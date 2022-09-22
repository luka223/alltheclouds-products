namespace Poducts_service.DTO
{
    public class ProductDTO
    {
        /// <summary>
        /// Internal product ID
        /// </summary>
        public string ProductId { get; private set; }
        /// <summary>
        /// Name of the product
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Description of the product
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// Price of the single unit
        /// </summary>
        public double UnitPrice { get; private set; }
        /// <summary>
        /// Maximum quantity possible to order
        /// </summary>
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
