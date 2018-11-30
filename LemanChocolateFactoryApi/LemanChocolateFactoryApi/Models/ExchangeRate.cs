using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemanChocolateFactoryApi.Models
{
    public class ExchangeRate
    {
        public DateTime? date { get; set; }
        public string fromCcy { get; set; }
        public string toCcy { get; set; }
        public decimal change { get; set; }
    }
}
