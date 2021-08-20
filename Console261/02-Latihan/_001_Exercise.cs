using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console261._02_Latihan
{
    class _001_Exercise
    {
        public void exerciseInput()

        {
            Console.WriteLine("_________Biodata_________");
            Console.Write("Nama : ");

            string nama = Console.ReadLine();

            //Console.WriteLine("Nama : " + nama);

            //------------------------------------------
            //ini di ganti jadi tipe data date

            Console.Write("Tgl. Lahir : ");

            String tanggal = Console.ReadLine();

            //Console.WriteLine("Tgl. Lahir : " + tanggal);

            //------------------------------------------


            Console.Write("Kota Lahir : ");

            string kotalahir = Console.ReadLine();

          //  Console.WriteLine("Tgl. Lahir : " + kotalahir);

            //------------------------------------------

            Console.Write("Universitas : ");

            string universitas = Console.ReadLine();

           // Console.WriteLine("Universitas : " + universitas);

            //------------------------------------------
            Console.Write("Jurusan : ");

            string jurusan = Console.ReadLine();

           // Console.WriteLine("Jurusan : " + jurusan);

            //------------------------------------------

            Console.Write("Tahun Lulus : ");

            int thnlulus = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine(" Soal Ke 2");
            //------------------------Soal Ke 2------------------

            Console.WriteLine("----------Bootcamp Xsis Academy--------");

            Console.Write("Batch : ");

            int batch = Convert.ToInt16(Console.ReadLine());


            Console.Write("Teknologi : ");

            string teknologi = Console.ReadLine();

            Console.Write("Trainer : ");

            string trainer = Console.ReadLine();

            Console.Write("Jml.Perserta : ");

            int jmlperserta = Convert.ToInt16(Console.ReadLine());

            Console.Write("Lokasi : ");

            string lokasi = Console.ReadLine();

            Console.Write("Ruangan : ");

            string ruangan = Console.ReadLine();

            //diganti jadi tipe data time span

            Console.Write("Jam Mulai : ");

            double jammulai = Convert.ToDouble(Console.ReadLine());

            //diganti jadi tipe data time span

            Console.Write("Jam Selesai : ");

            double jamselesai = Convert.ToDouble(Console.ReadLine());

            //diganti jadi tipe data time span dan dikelola dengan rumusnya

            Console.Write("Durasi : ");

            string durasi = Console.ReadLine();




        }
    }
}
