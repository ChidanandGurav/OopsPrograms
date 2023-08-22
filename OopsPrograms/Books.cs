using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Books
    {
        private int Book_id;
        private string BookName;
        private Double Price;

        // Constructor

        public Books()
        {
            Book_id= 0;
            BookName = "";
            Price= 0;
        }

        public Books(int Book_id, string BookName, double Price)
        {
            this.Book_id= Book_id;
            this.BookName= BookName;
            this.Price= Price;
        }
        public void AcceptBooks(int id , string name , Double rs )
        {
            Book_id = id;
            BookName = name;
            Price = rs;
        }

        public string PrintBooks()
        {
            return $" Book : {Book_id} / {BookName} / {Price}";
        }
    }
}
