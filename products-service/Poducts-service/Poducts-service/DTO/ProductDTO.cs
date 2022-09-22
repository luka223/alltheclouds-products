namespace Poducts_service.DTO
{
    public class ProductDTO
    {
        public string ProductId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double UnitPrice { get; private set; }
        public double? MaximumQuantity { get; private set; }

        public ProductDTO(string productId, string name, string description, double unitPrice, double? maximumQuantity)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            UnitPrice = unitPrice;
            MaximumQuantity = maximumQuantity;
        }
    }
}
