using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaregister.model
{
    class Book : Media
    {
        private string _author;
        private int _nrOfPages;

        public Book(string title, string author, int pages)
        {
            Title = title;
            _author = author;
            _nrOfPages = pages;
        }

        public override string ToString()
        {
            return "BjdsfnsdjkfsdjfbsdkbfksdbfksdbfksdbfkjsbdfjkbskdfsjkfbsdbfjksdbfjksdbfksdbfkbsdkfbsdkbfksdOK";
        }
    }
}
