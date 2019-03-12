namespace MbmStore.Models
{
    public class Movie : Product
    {
        //fields
        private string director;
        private string producer;

        //properties

        public string Director { get; }

        public string Producer { get; set; }

        //Constructor
        public Movie(string title, decimal price) : base(title, price)
        {
        }

        public Movie(string title, decimal price, string imageUrl, string director) : base(title, price)
        {
            this.ImageUrl = imageUrl;
            this.director = director;
        }
    }
}