using Demo.Data;
using Demo.Entittes;
using System;
using System.Linq;

namespace Demo
{
    //realationFiexedUp
    //Tracking SnapShot
    class Program
    {
        static void Main(string[] args)
        {
            DemoContext ctx = new DemoContext();
            //ctx.Database.EnsureDeleted();
            //ctx.Database.EnsureCreated();
            //AddSample01(ctx);

            // GetAllTest(ctx);

            //var result=ctx.Students.Where(a => a.Name.Contains("a")).ToList();
            //result= ctx.Students.Where(a=>a.StudentId==1).ToList(); //list
            //var result1 = ctx.Students.Single(a => a.Name.Contains("a"));
            // var result2 = ctx.Students.First(a => a.Name.Contains("a"));
            //var result1 = ctx.Students.SingleOrDefault(a => a.StudentId == 8);
            //var result2 = ctx.Students.FirstOrDefault(a => a.StudentId == 8);
            var result0 = ctx.Students.Find(1);
            var result1 = ctx.Students.SingleOrDefault(a => a.StudentId==1);
            var result2 = ctx.Students.FirstOrDefault(a => a.StudentId == 1); 
            
            Console.ReadKey();
            
            
            //Take Skip  FindIndex  OrderBy Any All
        }

        private static void GetAllTest(DemoContext ctx)
        {
            var books = ctx.Books.Where(a => a.BookId < 4).ToList();
            foreach (var item in books)
            {
                Console.WriteLine(item.Title);
            }
        }

        private static void AddSample01(DemoContext ctx)
        {
           
            Book book = new Book() { Title = "Book1" };
            ctx.Books.Add(book);
        }
    }
}
