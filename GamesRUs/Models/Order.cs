namespace GamingStore.Models
{
    public class Order
    {
        //admin sees customer order
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int AuthId { get; set; }
    }
}
