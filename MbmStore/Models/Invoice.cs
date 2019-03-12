using System;
using System.Collections.Generic;
using System.Linq;

namespace MbmStore.Models
{
    public class Invoice
    {
        //variables
        private int invoiceId;
        private DateTime orderDate;
        private Customer customer;
        private List<OrderItem> orderItems;

        //properties
        public int InvoiceId
        {
            get
            {
                return invoiceId;
            }
            set
            {
                invoiceId = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return orderItems.Sum(item => item.TotalPrice);
            }
        }

        public Customer Customer
        {
            get
            {
                return customer;
            }
            set
            {
                if (value != null)
                {
                    customer = value;
                }
            }
        }

        public List<OrderItem> OrderItems
        {
            get
            {
                return orderItems;
            }
        }

        //Constructor
        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            this.InvoiceId = invoiceId;
            this.OrderDate = orderDate;
            this.Customer = customer;
            orderItems = new List<OrderItem>();
        }

        
        public void AddOrderItem(Product product, int quantity)
        {
            OrderItem oi = orderItems.SingleOrDefault(item => item.Product.Title == product.Title);
            if (oi == null)
            {
                oi = new OrderItem(product, quantity);
                orderItems.Add(oi);
            }
            else
            {
                oi.Quantity += quantity;
            }
        }

    }
}