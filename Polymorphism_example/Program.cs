using System;

namespace Polymorphism_example
{
    class Program
    {
        public class News
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime Created { get; set; } = DateTime.Now;
            public string GetHappyNwes()
            {
                string happyNews = "Happy! " + Description;

                return happyNews;
            }
        }

        static void Main(string[] args)
        {
            News newsObject = new News();

            newsObject.Description = "First News";


            Console.WriteLine("Hello World!");

            Console.WriteLine(newsObject.Description);

            Console.WriteLine(newsObject.GetHappyNwes());
        }
    }
}
