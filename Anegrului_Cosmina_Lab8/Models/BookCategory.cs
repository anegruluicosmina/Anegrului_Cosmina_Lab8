using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anegrului_Cosmina_Lab8.Models
{
    public class BookCategory
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
