using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console261._01_Materi
{
    class _003_WriteAndWriteLine
    {
        // method yg tidak mengeluarkan data
        public void WriteAndWriteLine()
        {
            // mencetak ke command prompt / terminal
            // dan menambahkan baris baru di akhir proses
            Console.WriteLine("Cetak dan kasih baris baru");

            // mencetak ke command prompt / terminal
            // tanpa menambahkan baris baru di akhir proses
            // dalam arti, program akan mencetak dalam 1 baris
            Console.Write("Cetak masih dalam satu baris! ");
            Console.Write("cetak Write ke 2! ");
        }

    }
}
