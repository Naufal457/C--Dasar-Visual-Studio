using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console261._01_Materi
{
    class _006_Casting
    {
        public void casting()
        {
            #region Implicit Casting

            //int -> double

            int myInt = 9;
            double myDouble = myInt; //auto casting

            Console.WriteLine("Implicit - int to double : {0} to {1}", myInt, myDouble);
            #endregion

            #region Explicit Casting
            double myDouble2 = 9.78; // data yang dikirim double
                int myInt2 = (int)myDouble2; // data yang ditampung int

            Console.WriteLine("Implicit - int to double : {0} to {1}", myDouble2, myInt2);
            #endregion

            #region Type Conversion Methods

            // case adalah int ke double
            int myInt3 = 100;
            double myDouble3 = 9.52;
            bool myBool = true;

            //casting int to string
            Console.WriteLine("int to string : " + Convert.ToString(myInt3));
            Console.WriteLine("int to string : " + myInt3);

            //casting - double to int
            // jika nilai koma adalah => 50 maka akan dibulatkan ke atas
            // jika nilai koma adalah < 50 maka tidak dibulatkan ke atas
            Console.WriteLine("casting double to int : {0} -> {1}", myDouble3, Convert.ToInt16(myDouble3));
            Console.WriteLine("casting double to int : [0] -> {1}", myDouble3, (int)myDouble3);

            //casting - boolean to string
            Console.WriteLine("casting boolean to string : " + myBool); //true ke cetak jadi True
            #endregion

            #region Casting Parse
            string myInt4 = "170";
            Console.WriteLine("Parse - string to int16 : {0} to {1}", myInt4, Int16.Parse(myInt4));

            #endregion

        }
    }
}
