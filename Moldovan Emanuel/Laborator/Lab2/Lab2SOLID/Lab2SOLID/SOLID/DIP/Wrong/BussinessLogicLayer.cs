using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DIP
{
    public class BussinessLogicLayer
    {
        private Provider _provider;
        private ProviderType2 _providerType2;

        public BussinessLogicLayer()
        {
            _provider = new Provider();
            _providerType2 = new ProviderType2();
        }

        public void ComputeSomething()
        {
            // collect data from all providers
            var stuff = _provider.ProvideSomething();
            stuff += _providerType2.ProvideSomething();
            
            // ..... for 40 types of providers ?

            // bussiness logic
        }
    }
}
