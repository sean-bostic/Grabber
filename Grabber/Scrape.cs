using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grabber
{
    class Scrape
    {
        public string scrape()
        {
            string text = System.IO.File.ReadAllText(@"Z:\code\Miscellaneous Projects\Grabber\Grabber\Grabber\test.txt");
            return text;
        }
    }
}
