namespace GamingStore.Models
{
    public class Review
    {
        //customer product review
        public int ReviewId { get; set; }
        public int GameId { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
    }
}
