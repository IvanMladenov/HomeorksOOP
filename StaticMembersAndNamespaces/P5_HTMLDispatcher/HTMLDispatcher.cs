using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_HTMLDispatcher
{
    static class HTMLDispatcher
    {
        public static ElementBuilder CreateImage(string source, string alt , string title)
        {
            ElementBuilder image = new ElementBuilder("image");
            image.AddAtribute("scr", source);
            image.AddAtribute("alt", alt);
            image.AddAtribute("title", title);

            return image;
        }

        public static ElementBuilder CreateURL(string url, string title, string text)
        {
            ElementBuilder link = new ElementBuilder("a");
            link.AddAtribute("hreff", url);
            link.AddAtribute("title", title);
            link.AddContent(text);

            return link;
        }

        public static ElementBuilder CreateInput(string type, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input");
            input.AddAtribute("type", type);
            input.AddAtribute("name", name);
            input.AddAtribute("value", value);

            return input;
        }
    }
}
