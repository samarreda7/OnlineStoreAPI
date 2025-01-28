namespace OnlineStoreAPI.DTO
{
    public class CartItemWithProductDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }   
        public int Price { get; set; }
    }
}
