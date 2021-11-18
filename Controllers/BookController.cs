using BookStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public List<Book> books = new List<Book>()
        {
            new Book
            {
                Id=001,Title="C#",Author="Anders Hejlsberg",PublicationYear=2000,IsAvailable=true,CallNumber="+919912345678"
            },new Book
            {
                Id=002,Title="Java",Author="James Gosling",PublicationYear=1996,IsAvailable=true,CallNumber="+919912345678"
            },new Book
            {
                Id=003,Title="C++",Author="Bjarne Stroustrup",PublicationYear=1985,IsAvailable=true,CallNumber="+919912345678"
            },new Book
            {
                Id=004,Title="Python",Author="Guido van Rossum",PublicationYear=1994,IsAvailable=true,CallNumber="+919912345678"
            },new Book
            {
                Id=005,Title="javascript",Author="Brendan Eich",PublicationYear=1995,IsAvailable=true,CallNumber="+919912345678"
            },new Book
            {
                Id=006,Title="PhP",Author="Rasmus Lerdorf",PublicationYear=1994,IsAvailable=true,CallNumber="+919912345678"
            }
        };


        [HttpGet]
        public ActionResult<IEnumerable<Book>>  GetAllBooks()
        {
            return books;
        }


    }
}
