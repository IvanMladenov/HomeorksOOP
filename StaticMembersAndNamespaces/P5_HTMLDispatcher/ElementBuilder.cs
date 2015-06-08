using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_HTMLDispatcher
{
    class ElementBuilder
    {
        public ElementBuilder(string name)
        {
            this.ElelmentName = name;
            this.DataBank = new Dictionary<string, string>();
            this.Content = string.Empty;
        }

        public string ElelmentName { get; set; }

        public Dictionary<string,string> DataBank { get; set; }

        public string Content { get; set; }

        public void AddAtribute(string atribute, string value)
        {
            this.DataBank.Add(atribute, value);
        }

        public void AddContent(string content)
        {
            this.Content += content;
        }

        public override string ToString()
        {
            StringBuilder attributes = new StringBuilder(string.Format("<{0} ",this.ElelmentName));
            foreach (var item in this.DataBank)
            {
                attributes.Append(string.Format("{0}=\"{1}\" ", item.Key, item.Value));
            }
            attributes.Remove(attributes.Length - 1, 1);
            attributes.Append(string.Format(">{0}</div>", this.Content));

            return attributes.ToString();
        }

        public static string operator *(ElementBuilder element, int multiplier)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < multiplier; i++)
            {
                sb.Append(element);
            }
            return sb.ToString();
        }
    }
}
