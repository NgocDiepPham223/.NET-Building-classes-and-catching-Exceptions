using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Exception.Bai_2
{
    public class Football : Sport
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Football information:");
            base.DisplayInfo();
        }
    }
}

