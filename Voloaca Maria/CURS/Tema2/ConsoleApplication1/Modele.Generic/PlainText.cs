using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic.Exceptions;

namespace Modele.Generic
{
    public class PlainText
    {
        private string _text;
        public string Text { get { return _text; } }
        public PlainText(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException();
            }

            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentCannotBeEmptyStringException(text);
            }
        }

        public override string ToString()
        {
            return Text;
        }

        public override bool Equals(object obj)
        {
            var nume = (PlainText)obj;
            return Text.Equals(nume.Text);
        }

        public override int GetHashCode()
        {
            return Text.GetHashCode();
        }
    }
}
