import { Component, AfterViewInit, ViewChild, OnInit } from '@angular/core';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { Product } from 'src/app/models/product';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements AfterViewInit {
  displayedColumns: string[] = ['name', 'description', 'unitPrice', 'maximumQuantity'];
  pageSizeOptions: number[] = [5, 10, 20];

  totalRows: number = 0;
  pageSize: number = 5;
  currentPage: number = 0;

  products: MatTableDataSource<Product> = new MatTableDataSource<Product>();
  @ViewChild(MatPaginator) paginator!: MatPaginator;

  constructor(
    private productService: ProductService
  ) { }

  ngAfterViewInit() {
    this.loadData();
  }

  loadData(): void {
    this.productService.getProducts().subscribe(result => {
      this.products = new MatTableDataSource<Product>(result);
      this.products.paginator = this.paginator;
    });
  }
}
