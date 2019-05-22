using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class AtomicCalculator
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Func<int> GetNumberFromUser { get; set; }
        public Action MenuPrinter { get; set; }
        public Func<int> GetUserChoice { get; set; }
        public Func<int,int,double> Calculate { get; set; }
        public Action<double> ResultPrinter { get; set; }


    }
}
