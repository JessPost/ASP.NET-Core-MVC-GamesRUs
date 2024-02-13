namespace GamingStore.Models
{
    public class Cart
    {
        //customers cart
        public int Id { get; set; }
        public int GameId { get; set; }
        public int Quantity { get; set; }

        //many to many relationships - join table 
    }
}
