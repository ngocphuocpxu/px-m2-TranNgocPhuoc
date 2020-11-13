using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookManager.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nhập tên sách!")]
        [DisplayName("Tên sách")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Nhập tên tác giả!")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Nhâp mô tả!")]
        [DisplayName("Mô tả")]
        
        public string Description { get; set; }

        [Required(ErrorMessage = "Nhập năm xuất bản!")]
        
        [DisplayName("Năm xuất bản")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Nhập số lượng sách!")]
        [DisplayName("Số lượng")]
        public int Count { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
