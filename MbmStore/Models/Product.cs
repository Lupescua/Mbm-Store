using System;
using System.Text;

namespace MbmStore.Models
{
    public class Product
    {
        //variables
        private int productId;
        private string title;
        private decimal price;
        private string imageUrl;

        //properties
        public int ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
            }
        }
        public string Title
        {
            get
            {
                return title ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    title = value;
                }
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public string ImageUrl
        {
            get
            {
                return imageUrl ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    imageUrl = value;
                }
            }
        }

        //Construtor
        public Product(){}
        
        public Product(string title, decimal price)
        {
            Random rnd = new Random();
            this.productId = rnd.Next(1000, 50000);
            this.Title = title;
            this.Price = price;
        }

        public virtual string Details()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("ID: {0}", productId));
            sb.AppendLine(string.Format("Title: {0}", title));
            sb.AppendLine(string.Format("Price: {0:0.00}", price));
            sb.AppendLine(string.Format("ImageUrl: {0}", imageUrl));
            return sb.ToString();
        }
    }
}