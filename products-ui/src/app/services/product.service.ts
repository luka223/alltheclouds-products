import { Injectable } from '@angular/core';
import { catchError, Observable, of, throwError } from 'rxjs';
import { Product } from '../models/product';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private static API_ENDPOINT: string = '/api/Products';

  constructor(
    private http: HttpClient
  ) { }

  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(`${environment.backendUrl}${ProductService.API_ENDPOINT}`).pipe(catchError(err => {
      if (err.error.Message) {
        alert(err.error.Message);
      } else {
        alert('Failed getting products.')
      }

      return throwError(() => err);
    }));
  }
}
