namespace MbmStore.Models
{
    
    public class Book : Product
    {
        // fields - I haven't declared any fields 
        
        // properties - just get and set creates private fields automatically
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }
        public string ISBN { get; set; }

        //Constructor. Creates a Book object
        public Book() { }

        public Book(string author, string title, decimal price, short published)
            : base(title, price)
        {
            this.Author = author;
            this.Published = published;
        }

    }
}