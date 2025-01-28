namespace OnlineStoreAPI.DTO
{
    public class OrderWithOrderItemDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalAmount { get; set; }
        public string Status { get; set; }
        public List<String> OrderItems { get; set; }
    }
}
