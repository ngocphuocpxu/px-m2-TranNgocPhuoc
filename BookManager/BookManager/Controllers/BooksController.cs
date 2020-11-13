using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManager.Models;
using BookManager.Views.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BookManager.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public BooksController(AppDbContext appDbContext)
        {

            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var books = _appDbContext.Books.Include(p => p.Category).ToList();

            return View(books);
        }
        public IActionResult Create()
        {
            BookCreateVM booksVM = new BookCreateVM()
            {
                Book = new Book(),
                CategorySelectList = _appDbContext.Categories.Select(item => new SelectListItem
                {
                    Text = item.CategoryName,
                    Value = item.Id.ToString()
                })
            };

            return View(booksVM);
        }

        [HttpPost]
        public IActionResult Create(BookCreateVM booksCreateVM)
        {


            _appDbContext.Books.Add(booksCreateVM.Book);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            BookCreateVM booksVM = new BookCreateVM()
            {
                Book = _appDbContext.Books.Find(id),
                CategorySelectList = _appDbContext.Categories.Select(item => new SelectListItem
                {
                    Text = item.CategoryName,
                    Value = item.Id.ToString()
                })
            };

            return View(booksVM);
        }

        [HttpPost]
        public IActionResult Edit(BookCreateVM booksCreateVM)
        {

            if (ModelState.IsValid)
            {
                _appDbContext.Books.Update(booksCreateVM.Book);
                _appDbContext.SaveChanges();

                // return RedirectToAction("Index");
            }




            return RedirectToAction("booksCreateVM");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var books = _appDbContext.Books.Find(id);
            if (books == null) return NotFound();

            return View(books);
        }

        [HttpPost]
        public IActionResult DeleteProduct(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var books = _appDbContext.Books.Find(id);
            if (books == null) return NotFound();

            _appDbContext.Books.Remove(books);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
