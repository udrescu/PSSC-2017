using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic.Exceptions;

namespace Modele.Generic
{
    public class CUI
    {
        private string _cui;
        public string Cui { get { return _cui; } }

        public CUI(string cui)
        {
            if (cui == null)
                throw new ArgumentNullException("lipsa CUI");
            if (string.IsNullOrEmpty(cui))
                throw new ArgumentCannotBeEmptyStringException("text");
            if (cui.Length > 9 || cui.Length < 6)
                throw new ArgumentException("CUI trebuie sa contina intre 6 si 9 cifre");
            _cui = cui;
        }

        public override string ToString()
        {
            return Cui;
        }
        public override bool Equals(object obj)
        {
            var nume = (CUI)obj;
            return nume.Cui.Equals(this.Cui);
        }
    }
}
