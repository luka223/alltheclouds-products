using System.Text.Json.Serialization;

namespace Poducts_service.Domain
{
    public class Product
    {
        public string ProductId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double UnitPrice { get; set; }
        public double? MaximumQuantity { get; private set; }

        public Product(string productId, string name, string description, double unitPrice, double? maximumQuantity)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            UnitPrice = unitPrice;
            MaximumQuantity = maximumQuantity;
        }
    }
}
