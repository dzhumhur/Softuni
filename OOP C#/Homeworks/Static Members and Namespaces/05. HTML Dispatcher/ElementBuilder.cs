namespace _05.HTML_Dispatcher
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ElementBuilder
    {
        private List<Attribute> attributes = new List<Attribute>();

        public ElementBuilder(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        private List<Attribute> Attributes
        {
            get { return this.attributes; }
            set
            {
                this.attributes = value;
            }
        }

        public string Content { get; private set; }

        public void AddAttribute(string name, string value)
        {
            var attribute = new Attribute(name, value);
            this.Attributes.Add(attribute);
        }

        public void AddContent(string content)
        {
            this.Content = content;
        }

        public static string operator *(ElementBuilder element, int number)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < number; i++)
            {
                result.AppendLine(element.ToString());
            }
            return result.ToString();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("<{0} ", this.Name);
            foreach (var attribute in this.Attributes)
            {
                result.AppendFormat("{0}=\"{1}\" ", attribute.Name, attribute.Value);
            }

            if (!this.Name.Equals("img") && !this.Name.Equals("input"))
            {
                result.AppendLine();
            }

            result.AppendFormat("   {0}",this.Content);

            if (this.Name.Equals("img") || this.Name.Equals("input"))
            {
                result.Append(">");
            }
            else
            {
                result.AppendLine();
                result.AppendFormat("</{0}>", this.Name);
            }
            
            return result.ToString();
        }
    }
}
