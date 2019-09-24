using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;using System.Data.Entity;

namespace BooksShopOnline.Models
{
    public class BookDatabaseInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetBooks().ForEach(p => context.Books.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "SamSung"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Huawei"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Oppo"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Xiaomi"
                },
                 new Category
                {
                    CategoryID = 5,
                    CategoryName = "Nokia"
                },
                  new Category
                {
                    CategoryID = 6,
                    CategoryName = "Iphone"
                },
            };
            return categories;
        }
        private static List<Book> GetBooks()
        {
            var books = new List<Book> {
                new Book
                {
                    BookID = 1,
                    BookName = "SamSung A50s",
                    Description = "Bức phá mới trong thiết kế từ mặt lưng đến màu sắc vượt trội).",
                    ImagePath ="Pic1.png",
                    UnitPrice = 7790000,
                    CategoryID = 1
                    },
                new Book
                {
                    BookID = 2,
                    BookName = "SamSung Galaxy Note 10+ ",
                    Description = "Chữ viết tay sang chữ viết văn bản nhanh chóng).",
                    ImagePath ="Pic9.jn",
                    UnitPrice = 26990000,
                    CategoryID = 1
                    },
                new Book
                {
                    BookID = 3,
                    BookName = "SamSung Galaxy S10 ",
                    Description = "Siêu phẩm năm 2018).",
                    ImagePath ="Pic10.png",
                    UnitPrice = 22990000,
                    CategoryID = 1
                    },
                new Book
                {
                    BookID = 2,
                    BookName = "Huawei P30 Lite",
                    Description = "Thiết kế hoàn toàn mới . Viền mỏng hơn . Đem lại trải nghiệm xem thoải mái hơn",
                    ImagePath ="Pic2.png",
                    UnitPrice = 6699000,
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 3,
                    BookName = "Huawei Mate 20 Pro",
                    Description = "Siêu phẩm thuộc hãng Huawei",
                    ImagePath ="Pic3.png",
                    UnitPrice = 15999000,
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 4,
                    BookName = "Oppo K3",
                    Description = "Thiết kế đẹp , chip mạnh , pin trâu ",
                    ImagePath ="Pic4.png",
                    UnitPrice = 7690000,
                    CategoryID = 3
                },
                new Book
                {
                    BookID = 5,
                    BookName = "Xiaomi MI9T",
                    Description = "Nổi bật với mặt lưng thiết kế sợi cacbon, cùng đường cong 3D tinh xảo ",
                    ImagePath ="Pic5.png",
                    UnitPrice = 7990000,
                    CategoryID = 4
                },
                 new Book
                {
                    BookID = 6,
                    BookName = "NOKIA 8.1",
                    Description = " Thiết kế sang trọng và mạnh mẽ ",
                    ImagePath ="Pic6.png",
                    UnitPrice = 7990000,
                    CategoryID = 5
                },
                 new Book
                {
                    BookID = 7,
                    BookName = "Ihone X",
                    Description = " Siêu phẩm năm 2017 ",
                    ImagePath ="Pic7.png",
                    UnitPrice =24000000,
                    CategoryID = 6
                },
                  new Book
                {
                    BookID = 8,
                    BookName = "Ihone XS MAX",
                    Description = " Siêu phẩm năm 2018 ",
                    ImagePath ="Pic8.png",
                    UnitPrice =26000000,
                    CategoryID = 6
                },
            };
            return books;
        }
    }
}