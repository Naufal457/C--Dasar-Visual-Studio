using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console261._01_Materi
{
    class _009_Math
    {
    
        
        public void math()
        {
            int x = 5, y = 10;
            //Math.MaX(x, y);
            Console.WriteLine(Math.Max(x, y));
            Console.WriteLine(Math.Min(x, y));

            String uang1 = "10000";
            int uang2 = 10000;

            int sum = Convert.ToInt32(uang1) + uang2;

            Math.Max(Convert.ToInt32(uang1), uang2);
            Console.WriteLine(Math.Max(Convert.ToInt32(uang1), uang2));


            float f1 = 10000f;
            float f2 = 10000.765f;
            Console.WriteLine("FLoat Max" + Math.Max(f1, f2));
            Console.WriteLine("Float Min" + Math.Min(f1, f2));

            decimal dec1 = 9.99m;
            decimal dec2 = Math.Round(dec1);
            Console.WriteLine("Decimal ROund dari ");


        }
    }
}
