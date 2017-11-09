using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic.Exceptions;

namespace Modele.Generic
{
    public class Adresa
    {
        private string _oras;
        public string Oras { get { return _oras; } }

        private string _strada;
        public string Strada { get { return _strada; } }

        private string _nr;
        public string Nr { get { return _nr; } }

        public Adresa(string oras,string strada,string nr)
        {
            if (string.IsNullOrEmpty(oras) || string.IsNullOrEmpty(strada) || string.IsNullOrEmpty(nr))
                throw new ArgumentCannotBeEmptyStringException("text");
            _oras = oras;
            _strada = strada;
            _nr = nr;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}",this.Oras, this.Strada, this.Nr);
        }

        public override bool Equals(object obj)
        {
            var v = (Adresa)obj;
            return this.Oras.Equals(v.Oras) && this.Strada.Equals(v.Strada) && this.Nr.Equals(v.Nr);
        }

        public override int GetHashCode()
        {
            return Oras.GetHashCode()+Strada.GetHashCode()+Nr.GetHashCode();
        }
    }
}
