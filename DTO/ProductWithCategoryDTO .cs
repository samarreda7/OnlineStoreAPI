namespace OnlineStoreAPI.DTO
{
    public class ProductWithCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public String CategoryName { get; set; }

    }
}
