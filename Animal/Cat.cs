using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab01_Exception.Bai_1;


namespace Lab01_Exception.Bai_1
{
    public class Cat : Animal
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Cat information:");
            base.DisplayInfo();
        }
    }
}

