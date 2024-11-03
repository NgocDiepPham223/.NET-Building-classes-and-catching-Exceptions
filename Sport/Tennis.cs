using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Exception.Bai_2
{
    public class Tennis : Sport
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Tennis ìnformation:");
            base.DisplayInfo();
        }
    }
}

