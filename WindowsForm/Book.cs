using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    class Book:IComparable<Book>
    {
        public string ISBN { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
        public string PublishingHouse { get; set; }
        public string Name { get; set; }

        List<Book> books = new List<Book>();

        public int CompareTo(Book other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Book book = (Book)obj;
            return (this.Name == book.Name);
        }
    }
}
