using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject
{
   public class CountryDetails
    {

        public string PostCode { get; set; }
        public string Country { get; set; }

        public string CountryAbbreviation { get; set; }

        public Place [] Places { get; set; }
    }
}
