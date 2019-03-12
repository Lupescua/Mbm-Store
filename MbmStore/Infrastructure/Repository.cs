using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MbmStore.Infrastructure
{

    // This class will handle access to the data needed for this website.
    // At the moment all data is stored in memory and not persisted. Data will be created on each call to the constructor.

    public class Repository
    {

        public List<Product> Products = new List<Product>();
        public List<Customer> Customers = new List<Customer>();
        public List<Invoice> Invoices = new List<Invoice>();

        // Constructor that will create all the data and store it in local lists. No data is persisted.

        public Repository()
        {
            // Books
            Book book = new Book("James C. Collins", "Good to Great: Why Some Companies Make the Leap... and Others Don't", 150m, 2001);
            book.Publisher = "HarperBusiness";
            book.ISBN = "9780066620992";
            book.ImageUrl = "goodtogreat.jpg";
            Products.Add(book);

            book = new Book("David Brooks", "The Social Animal: The Hidden Sources of Love, Character, and Achievement", 199m, 2011);
            book.Publisher = "Random House";
            book.ISBN = "9781400067602";
            book.ImageUrl = "socialanimal.jpg";
            Products.Add(book);

            // Music CDs
            MusicCD cd = new MusicCD("Beatles", "Abbey Road (Remastered)", 128m, 2009);
            cd.Label = "EMI";
            cd.ImageUrl = "AbbeyRoadAlbumCover.jpg";
            cd.AddTrack(new Track { Title = "Come Together", Composer = "Lennon/McCartney", Length = new TimeSpan(0, 4, 20) });
            cd.AddTrack(new Track { Title = "Something", Composer = "Harrison", Length = new TimeSpan(0, 3, 3) });
            cd.AddTrack(new Track { Title = "Maxwell's Silver Hammer", Composer = "Lennon/McCartney", Length = new TimeSpan(0, 3, 27) });
            cd.AddTrack(new Track { Title = "Oh! Darling", Composer = "Lennon/McCartney", Length = new TimeSpan(0, 3, 26) });
            cd.AddTrack(new Track { Title = "Octopus's Garden", Composer = "Starr", Length = new TimeSpan(0, 2, 51) });
            cd.AddTrack(new Track { Title = "I Want You (She's So Heavy)", Composer = "Lennon/McCartney", Length = new TimeSpan(0, 7, 47) });
            cd.AddTrack(new Track { Title = "Here Comes The Sun", Composer = "Harrison", Length = new TimeSpan(0, 3, 5) });
            cd.AddTrack(new Track { Title = "Because", Composer = "Lennon/McCartney", Length = new TimeSpan(0, 2, 45) });
            cd.AddTrack(new Track { Title = "You Never Give Me Your Money", Composer = "Lennon/McCartney", Length = new TimeSpan(0, 4, 2) });
            cd.AddTrack(new Track { Title = "Sun King", Composer = "Lennon/McCartney", Length = new TimeSpan(0, 2, 26) });
            cd.AddTrack(new Track { Title = "Mean Mr. Mustard", Composer = "Lennon/McCartney", Length = new TimeSpan(0, 1, 6) });
            cd.AddTrack(new Track { Title = "Polythene Pam", Composer = "Lennon/McCartney", Length = new TimeSpan(0, 1, 12) });
            cd.AddTrack(new Track { Title = "She Came In Through The Bathroom Window", Composer = "Lennon/McCartney", Length = new TimeSpan(0, 1, 57) });
            cd.AddTrack(new Track { Title = "Golden Slumbers", Composer = "Lennon/McCartney", Length = new TimeSpan(0, 1, 31) });
            cd.AddTrack(new Track { Title = "Carry The Weight", Composer = "Lennon/McCartney", Length = new TimeSpan(0, 1, 36) });
            cd.AddTrack(new Track { Title = "The End", Composer = "Lennon/McCartney", Length = new TimeSpan(0, 2, 5) });
            cd.AddTrack(new Track { Title = "Her Majesty", Composer = "Lennon/McCartney", Length = new TimeSpan(0, 0, 23) });
            Products.Add(cd);

            cd = new MusicCD("Fields of the Nepthilim", "Earth Inferno", 99m, 1991);
            cd.Label = "Beggars Banquet";
            cd.ImageUrl = "Earth_Inferno_Fields_of_the_Nephilim.jpeg";
            cd.AddTrack(new Track { Title = "Intro (Dead But Dreaming)", Composer = "Fields of the Nephilim", Length = new TimeSpan(0, 16, 8) });
            cd.AddTrack(new Track { Title = "Moonchild", Composer = "Fields of the Nephilim", Length = new TimeSpan(0, 5, 25) });
            cd.AddTrack(new Track { Title = "Submission", Composer = "Fields of the Nephilim", Length = new TimeSpan(0, 7, 34) });
            cd.AddTrack(new Track { Title = "Preacher Man", Composer = "Fields of the Nephilim", Length = new TimeSpan(0, 4, 51) });
            cd.AddTrack(new Track { Title = "Love Under Will", Composer = "Fields of the Nephilim", Length = new TimeSpan(0, 6, 17) });
            cd.AddTrack(new Track { Title = "Sumerland", Composer = "Fields of the Nephilim", Length = new TimeSpan(0, 8, 26) });
            cd.AddTrack(new Track { Title = "Last Exit for the Lost", Composer = "Fields of the Nephilim", Length = new TimeSpan(0, 10, 18) });
            cd.AddTrack(new Track { Title = "Psychonaut", Composer = "Fields of the Nephilim", Length = new TimeSpan(0, 9, 5) });
            cd.AddTrack(new Track { Title = "Dawnrazor", Composer = "Fields of the Nephilim", Length = new TimeSpan(0, 9, 9) });
            Products.Add(cd);

            // Movies
            Movie movie = new Movie("Captain Marvel", 124.50m, "captain_marvel.jpg", "Ryan Fleck");
            Products.Add(movie);
            movie = new Movie("Deadpool", 128.95m, "deadpool.jpg", "Tim Miller");
            Products.Add(movie);
            movie = new Movie("Avengers", 189.50m, "avengers.jpg", "David Leitch");
            Products.Add(movie);

            //Customers
            Customer AdrianLupescu = new Customer(10, "Adrian", "Lupescu", "Home", "1", "Place");
            AdrianLupescu.Birthdate = new DateTime(1989, 6, 19);
            AdrianLupescu.AddPhone("040-457342");
            Customers.Add(AdrianLupescu);
            Customer GuilermoManuel = new Customer(19, "Guilermo", "Manuel", "His Home", "27", "Baker Street");
            GuilermoManuel.Birthdate = new DateTime(1992, 7, 15);
            Customers.Add(GuilermoManuel);
            Customer ElenaOse = new Customer(2014, "Elena", "Ose", "Dr Fichs Vej", "21", "Kolding");
            ElenaOse.AddPhone("123-2134355");
            ElenaOse.Birthdate = new DateTime(1992, 4, 9);
            Customers.Add(ElenaOse);

            //Invoices & OrderItems
            Invoice invoice = new Invoice(190228, new DateTime(2019, 2, 28), AdrianLupescu);
            invoice.AddOrderItem(Products.Where(p => p.GetType() == typeof(Book) && p.Title.Contains("Good to Great")).Single(), 1);
            invoice.AddOrderItem(Products.Where(p => p.GetType() == typeof(Movie) && p.Title.Contains("Deadpool")).Single(), 1);
            Invoices.Add(invoice);

            invoice = new Invoice(12939, new DateTime(2015, 12, 21), GuilermoManuel);
            invoice.AddOrderItem(Products.Where(p => p.GetType() == typeof(Book) && p.Title.Contains("Good to Great")).Single(), 1);
            invoice.AddOrderItem(Products.Where(p => p.GetType() == typeof(MusicCD) && p.Title.Contains("Earth Inferno")).Single(), 2);
            invoice.AddOrderItem(Products.Where(p => p.GetType() == typeof(Movie) && p.Title.Contains("Avengers")).Single(), 1);
            invoice.AddOrderItem(Products.Where(p => p.GetType() == typeof(Book) && p.Title.Contains("The Social Animal")).Single(), 1);
            Invoices.Add(invoice);
        }
    }
}