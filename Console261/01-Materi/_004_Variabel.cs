using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console261._01_Materi
{

    
    class _004_Variabel
    {

        public void Variabel()
        {
            /* Variabel C# 

                Cara ke 1
                Type variableName assigment;

                Cara ke 2
                Type variableName;

                Cara ke 3
                Type variableName;
                variableName = Convert ke Type yg sama

                Cara ke 4 - banyak variabel
                    cara ke 4.1
                    Type variableName1 = 90, variableName2 = 80, variableName2 = 70;

                    cara ke 4.2
                    Type variableName1, variableName2, variableName2;
                

                Tidak semua tipe data bisa pakai cara ke 2.
             */

            #region Tipe Data Integer
            //cara ke 1 untuk tipe data int
            int myNum1 = 0;
            Console.WriteLine("Cara 1, Nilai Awal : " + myNum1);

            //penugasan ulang / ubah nilai
            myNum1 = 15;
            Console.WriteLine("Cara 1, Nilai baru : " + myNum1);


            //................................................

            //cara ke 1  untuk tipe data char
            char myChar1 = 'A';
            Console.WriteLine("Cara 1, Nilai Awal Char 1 : " + myChar1);

            //penugasan ulang untuk char / ubah nilai untuk char
            myChar1 = 'B';
            Console.WriteLine("Cara 1, Nilai baru Char 1 : " + myChar1);

            //.........................................................
            //cara ke 2 untuk Integer
            int myNum2;
            myNum2 = 20;
            Console.WriteLine("Cara 2, Nilai awal : " + myNum2);


            myNum2 = 90;
            Console.WriteLine("Cara 2, Nilai baru : " + myNum2);
            //...........................................................

            //cara ke 2 untuk Char
            char myChar2;
            myChar2 = 'C';
            Console.WriteLine("Cara 2, Nilai awal : " + myChar2);

            //Penulisan ulang char cara ke 2 ajasi
            myChar2 = 'D';
            Console.WriteLine("Cara 2, Nilai baru : " + myChar2);
            //...........................................................

            //Cara ke 3
            int myNum3;
            myNum3 = 80;
            Console.WriteLine("Cara 3, Nilai awal : " + myNum3);

            //.........................................................
            //cara ke 4
            //data barunya adalah string "95"
            string myStr1 = "95";

            myNum3 = Convert.ToInt16(myStr1); // "95" -> 95
            Console.WriteLine("Cara 4, Nilai baru : " + myNum3);

            //.........................................................

            //data barunya adalah char "E"
            char myChar3 = 'E';
            myNum3 = Convert.ToInt16(myChar3); // "95" -> 95
            Console.WriteLine("Cara 5, Nilai baru : " + myNum3);

            //.........................................................

            // cara ke 4.1
            int myNum4 = 70, myNym5 = 80, myNum6 = 90;
            Console.WriteLine("Cara 4.1, Nilai baru : " + myNum4 + " & " + myNym5 + " & " + myNum6);

            // cara ke 4.2
            int myNum7, myNum8; // declarasi
            myNum7 = 80; // assigment myNum7
            myNum8 = 85; // assigment myNum8
            Console.WriteLine("Cara 4.2, Nilai baru : " + myNum7 + " & " + myNum8);
            // indexing                                         {0}     {1}
            Console.WriteLine("Cara 4.2, Nilai baru : {0} & {1}", myNum7, myNum8);
            #endregion

            Console.ReadKey();

    }
  }
}