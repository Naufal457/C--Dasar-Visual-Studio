using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console261._01_Materi
{
    class _005_DataType
    {
        public void dataTypes()
        {

            string myStr = "Xsis Mitra Utama";
            char myChar = 'a';
            int myInt = 100;
            long myLong = 1000000;
            double myDouble = 90.70d;
            float myFloat = 150.5f;
            decimal myDecimal = 95.50M;
            bool myBool = true;

            Console.WriteLine("String   : " + myStr);
            Console.WriteLine("Char     : " + myChar);
            Console.WriteLine("Int      : " + myInt);
            Console.WriteLine("Long     : " + myLong);
            Console.WriteLine("Double   : " + myDouble);
            Console.WriteLine("Float    : " + myFloat);
            Console.WriteLine("Decimal  : " + myDecimal);
            Console.WriteLine("Boolean  : " + myBool);

            #region DateTime
            // tanggal dan waktu menggunakan DateTime

            // tanggal dan waktu saat ini juga
            DateTime dt = DateTime.Now;

            // tanggal dengan parameter tahun, bulan, tanggal
            DateTime dt2 = new DateTime(2021, 8, 12);

            // tanggal dengan parameter tahun, bulan, tanggal, jam, menit, detik
            DateTime dt3 = new DateTime(2021, 8, 12, 9, 05, 00);

            // tanggal dengan parameter tahun, bulan, tanggal, jam, menit, detik, UTC timezone
            DateTime dt4 = new DateTime(2021, 8, 12, 9, 05, 00, DateTimeKind.Utc);


            Console.WriteLine("DateTime : " + dt);
            Console.WriteLine("DateTime : " + dt2);
            Console.WriteLine("DateTime : " + dt3);
            Console.WriteLine("DateTime : " + dt4.ToString("MM/dd/yyyy hh:mm:ss tt"));
            Console.WriteLine("DateTime : " + dt.ToString("MM/dd/yyyy HH:mm:ss"));

            // format 12 jam pakai hh
            // format 24 jam pakai HH
            /* format datetime
                DateTime.Now.ToString("MM/dd/yyyy") 	                05/29/2015
                DateTime.Now.ToString("dddd, dd MMMM yyyy") 	        Friday, 29 May 2015
                DateTime.Now.ToString("dddd, dd MMMM yyyy") 	        Friday, 29 May 2015 05:50
                DateTime.Now.ToString("dddd, dd MMMM yyyy") 	        Friday, 29 May 2015 05:50 AM
                DateTime.Now.ToString("dddd, dd MMMM yyyy") 	        Friday, 29 May 2015 5:50
                DateTime.Now.ToString("dddd, dd MMMM yyyy") 	        Friday, 29 May 2015 5:50 AM
                DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") 	Friday, 29 May 2015 05:50:06
                DateTime.Now.ToString("MM/dd/yyyy HH:mm") 	            05/29/2015 05:50
                DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") 	        05/29/2015 05:50 AM
                DateTime.Now.ToString("MM/dd/yyyy H:mm") 	            05/29/2015 5:50
                DateTime.Now.ToString("MM/dd/yyyy h:mm tt") 	        05/29/2015 5:50 AM
                DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") 	        05/29/2015 05:50:06
                DateTime.Now.ToString("MMMM dd") 	                    May 29
                DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK") 	2015-05-16T05:50:06.7199222-04:00
                DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’") 	Fri, 16 May 2015 05:50:06 GMT
                DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss") 	        2015-05-16T05:50:06
                DateTime.Now.ToString("HH:mm") 	                                05:50
                DateTime.Now.ToString("hh:mm tt") 	                            05:50 AM
                DateTime.Now.ToString("H:mm") 	                                5:50
                DateTime.Now.ToString("h:mm tt") 	                            5:50 AM
                DateTime.Now.ToString("HH:mm:ss") 	                            05:50:06
                DateTime.Now.ToString("yyyy MMMM") 	                            2015 May
             
             */
            #endregion

            #region TimeSpan
            // variable Waktu - TimeSpan

            // new TimeSpan(Jam, menit, detik)
            TimeSpan ts = new TimeSpan(16, 42, 56);
            Console.WriteLine("TimeSpan : " + ts);
            Console.WriteLine("TimeSpan : " + ts.Hours + ":" + ts.Minutes);

            TimeSpan ts1 = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
            Console.WriteLine("TimeSpan : " + ts1);

            // case, parkir di mall dari jam 7.15 pagi sampai jam 10.00 siang
            // cari lama parkirnya

            TimeSpan jamMasuk = new TimeSpan(7, 15, 00);
            TimeSpan jamKeluar = new TimeSpan(10, 00, 00);
            TimeSpan jamDurasi = jamKeluar - jamMasuk;

            Console.WriteLine("{0} - {1} = {2}", jamKeluar, jamMasuk, jamDurasi);

            DateTime dtMasuk = new DateTime(2021, 8, 12, 7, 15, 00);
            DateTime dtKeluar = new DateTime(2021, 8, 12, 10, 00, 00);
            TimeSpan durasi = dtKeluar - dtMasuk;
            Console.WriteLine("case ke 2 \n{0} - {1} = {2}", dtKeluar.ToString("HH:mm:ss"),
            dtMasuk.ToString("HH:mm:ss"), durasi);

            #endregion

            #region String
            string namadepan = "Adenia";
            string namaBelakang = "Anjani";
            int umur = 25;
            string kota = "wonogiri";

            string identitas = "Nama\t\t: " + namadepan + " " + namaBelakang +
                "\nUmur\t\t :  " + umur +
                "\nKota\t\t :  " + kota;
            Console.WriteLine(identitas);

            string identitasUpper = identitas.ToUpper();
            Console.WriteLine(identitasUpper);

            string identitasLower = identitas.ToLower();
            Console.WriteLine(identitasLower);

            string namalengkap = string.Concat(namadepan, namaBelakang);
            Console.WriteLine("\n" + namalengkap);

            string identitas2 = $"\nNama\t\t : {namadepan} {namaBelakang}";
            Console.WriteLine("\n" + identitas2);

            /* Nama   : Adenia Anjani
             * Umur   : 25
             * Kota   : Wonogiri
             * */

            #endregion

        }
    }
}
