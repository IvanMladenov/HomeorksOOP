using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_HTMLDispatcher
{
    class P5_HTMLDispatcherTest
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAtribute("id", "page");
            div.AddAtribute("class", "big");
            div.AddContent("<p>Hello</p>");

            Console.WriteLine(div * 4);
            Console.WriteLine();

            //Test HTMLDispatcher class method CreateImage
            ElementBuilder image = HTMLDispatcher.CreateImage(@"http://www.dir.bg", "hey", "girl");
            Console.WriteLine(image);
            Console.WriteLine();
            //Test HTMLDispatcher class method CreateURL
            ElementBuilder link = HTMLDispatcher.CreateURL(@"http://www.dir.bg", "News", "Latest!");
            Console.WriteLine(link);
            Console.WriteLine();
            //Test HTMLDispatcher class method CreateInput
            ElementBuilder input = HTMLDispatcher.CreateInput("stream", "internet", "0");
            Console.WriteLine(input);
        }
    }
}
