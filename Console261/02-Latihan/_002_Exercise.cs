using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console261._02_Latihan
{
    class _002_Exercise
    {
        public void exerciseLooping()
        {
            //Console.Write("Masukkan Berapa Nilai yang ingin ditampilkan :  ");

            //int inputlooping = Convert.ToInt16(Console.ReadLine());



            int hitungGanjil = 0, hitungGenap = 0, countb = 0;
            Console.Write("Inputkan Nilai N :  ");
            int N = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Ini adalah Soal No 1");

            for (int i = 1; true; i++)
            {
                // Console.Write("Masukkan Berapa Nilai yang ingin ditampilkan :  ");
                //int N = Convert.ToInt16(Console.ReadLine());
                //inputlooping = n ;
                //Console.WriteLine(inputlooping);
                if (hitungGanjil >= N)
                {
                    break;
                }

                if (i % 2 != 0) //(i % 2 !=0) // Ganjil
                {
                    Console.Write(i + " ");

                    hitungGanjil += 1;
                }

            }
            Console.WriteLine("\n");
            Console.Write("Inputkan Nilai N :  ");
            int K = Int16.Parse(Console.ReadLine());
            Console.WriteLine(" ini adalah Soal No 2");

            for (int j = 0; true; j++)
            {
                if (hitungGenap >= K)
                {

                    break;
                }

                if (j % 2 == 0) // (j % 2 == 0) //Genap --Soal no. 4//( j % 4 == 1)
                {

                    Console.Write(j + " ");
                    hitungGenap += 1;
                }

            }



            int counta = 0;
            Console.WriteLine("\n");
            Console.Write("Inputkan Nilai N :  ");
            int P = Int16.Parse(Console.ReadLine());
            Console.WriteLine("ini adalah Soal No 3 ");

            for (int z = 1; true; z++)
            {
                // Console.Write("Masukkan Berapa Nilai yang ingin ditampilkan :  ");
                //int N = Convert.ToInt16(Console.ReadLine());
                //inputlooping = n ;
                //Console.WriteLine(inputlooping);
                if (counta >= P)
                {
                    break;
                }

                if (z % 3 == 1) //(i % 2 !=0) // Ganjil
                {
                    Console.Write(z + " ");

                    counta += 1;
                }



            }

            Console.WriteLine("\n");
            Console.Write("Inputkan Nilai N :  ");
            int R = Int16.Parse(Console.ReadLine());
            Console.WriteLine("ini adalah Soal No 4");

            for (int r = 0; true; r++)
            {
                if (countb >= R)
                {

                    break;
                }

                if (r % 4 == 1) // (j % 2 == 0) //Genap --Soal no. 4//( j % 4 == 1)
                {

                    Console.Write(r + " ");
                    countb += 1;
                }

            }


            Console.WriteLine("\n");
            Console.Write("Inputkan Nilai N :  ");
            int c = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ini adalah Soal No 5");

            for (int b = 1; b <= c; b++)
            {
                int kali2 = Convert.ToInt16(Math.Pow(2, b));
                Console.Write($"{kali2}, ");

            }


        }

        //cara punya kak Ade di pembahasan Soal
        public void exerciselooping2()
        {

            Console.Write("\nSoal no.1 \nMasukkan panjang deret :  ");
            int m = Convert.ToInt16(Console.ReadLine());

            for (int l = 0; l < m * 2; l++)
            {
                if (l % 2 == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(l + " ");
                }

            }

            Console.Write("\nSoal no.1 \nMasukkan panjang deret :  ");
            int p = Convert.ToInt16(Console.ReadLine());

            for (int s = 0; s < p * 2; s++)
            {
                if (s % 2 == 1)
                {
                    continue;
                }
                else
                {
                    Console.Write(s + " ");
                }

            }


            Console.WriteLine();
            // n = panjang baring yang diminta
            // count = panjang baris yang sudah dicetak
            for (int x = 2, count = 0; count < m; x++)
            {
                //2 % 2 = 0   true | genap
                if (x % 2 == 1)
                {
                    continue;
                }
                else
                {
                    Console.Write(x + " ");
                    count++;
                }

            }
        }


    }



}

