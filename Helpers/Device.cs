using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class Hardware
    {
        private static Hardware _Default;
        public static Hardware Default
        {
            get
            {
                return _Default ?? (_Default = new Hardware());
            }
        }
    }
}
