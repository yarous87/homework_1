using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    internal class Book
    {
        private string title;
        private string author;
        private int productionYear;

        public Book ()
        {
            this.title = string.Empty;
            this.author = string.Empty;
            this.productionYear = DateTime.Now.Year;
        }

        public Book (string title, string author, int productionYear)
        {
            this.title = title;
            this.author = author;
            this.productionYear = productionYear;
        }
    }
}
