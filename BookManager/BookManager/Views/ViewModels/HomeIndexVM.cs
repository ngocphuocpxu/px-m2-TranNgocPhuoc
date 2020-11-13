using BookManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManager.Views.ViewModels
{
    public class HomeIndexVM
    {
        public List<Book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
