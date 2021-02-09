using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaregister.model
{
    class Film : Media
    {
        private string _director;
        private int _length;

        public Film(string title, string director, int length)
        {
            Title = title;
            _director = director;
            _length = length;
        }

        public override string ToString()
        {
            return Title + $" ({_director}, {_length} minuter)";
        }
    }
}
