using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace snt_task.Models
{

    public class Stock
    {
        public double open { get; set; }
        public double close { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public int amount { get; set; }
        public int volume { get; set; }
        public string date { get; set; }

    }
}
