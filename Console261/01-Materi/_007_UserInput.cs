using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console261._01_Materi
{
    class _007_UserInput
    {
        public void userInput()
        {
            /* Contoh
             *  Masukkan Nama : Adenia Cintya
             *  Nama anda adalah Adenia Cintya
             */
            //Text keterangan
            Console.Write("Masukkan Nama :  ");
            //penampung inputan dari console
            string name = Console.ReadLine();

            Console.WriteLine("Nama anda adalah " + name);

            /* Contoh
            *  Masukkan umur  : 10
            * Umur anda adalah 10 tahun
            */
            //text keterangan
            Console.Write("Masukkan umur: ");
            //Penampung Inputan
            int umur = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Umur anda adalah {0} Tahun", umur);

            Console.WriteLine("Umur anda adalah {0} Tahun", umur);

        }
    }
}
