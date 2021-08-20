using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console261._01_Materi
{
    class _008_Operators
    {
        public void operators()
        {
            #region Operator Aritmatika
            int mtk = 100, bahasa = 90, totalNilai, average;

            totalNilai = mtk + bahasa;
            Console.WriteLine("mtk\t\t :  " + mtk);
            Console.WriteLine("bahasa\t\t :  " + bahasa);
            Console.WriteLine("Total Nilai\t\t :  " + totalNilai);

            // (total nilai keseluruhan / jumlah data (pelajaran))
            average = totalNilai / 2; // hasil = 95
            //average = (mtk + bahasa) / 2 // hasil = 95
            average += 70;                 // 95 + 70 =
            average -= 20;                 // 95 - 20 =
            average++;                     // 95+1
            average--;                     // 95--
            Console.WriteLine("Rata - rata nilai\t: " + average);

            #endregion





        }
    }
}
