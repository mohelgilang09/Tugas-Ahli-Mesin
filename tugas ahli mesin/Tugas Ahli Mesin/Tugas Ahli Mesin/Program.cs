using System;

namespace TugasAhliMesin
{
    

    class Home
    {
       

        static void Main(string[] args)
        {
           
            bool ulang = true;

            while (ulang)
            {
                Console.Write("Berapa Nilai TKA MTK Kamu? :");
                int nilaiMtk = Convert.ToInt32(Console.ReadLine());

                if (nilaiMtk > 100)
                {
                    Console.Clear();
                    Console.WriteLine("Nilai salah");
                    return;
                }

                Console.Write("Berapa Nilai TKA B Inggris Kamu? :");
                int nilaiBIng = Convert.ToInt32(Console.ReadLine());

                if (nilaiBIng > 100)
                {
                    Console.Clear();
                    Console.WriteLine("Nilai salah");
                    return;
                }
             
                Console.Write("Berapa Nilai TKA Pilihan Kamu? :");
                int nilaiPilihan = Convert.ToInt32(Console.ReadLine());

                if (nilaiPilihan > 100)
                {
                    Console.Clear();
                    Console.WriteLine("Nilai salah");
                    return;
                }

                double jumlahNilaiTka = nilaiMtk + nilaiBIng + nilaiPilihan;
                Console.WriteLine("Jumlah nilai TKA Anda Adalah : " + jumlahNilaiTka);

                if (jumlahNilaiTka >= 280)
                {
                    Console.Clear();
                    Console.WriteLine("Anda Bisa Diterima Di ITS");
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Anda Tidak Bisa Diterima Melalui Jalur Prestasi");
                    Console.WriteLine("Mau Coba Jalur UTBK?");                 
                    Console.WriteLine("1. Iya");
                    Console.WriteLine("2. Tidak (keluar) ");
                    int pilih = Convert.ToInt32(Console.ReadLine());

                    if (pilih == 1)
                    {
                        Console.Clear();

                        Console.WriteLine("Masukan Nilai UTBK Anda : ");
                        int nilaiUTBK = Convert.ToInt32(Console.ReadLine());

                        double jumlahNilaiTka2 = 30.0 / 100.0 * jumlahNilaiTka;
                        Console.WriteLine("Jumlah 30% Nilai TKA Anda Adalah : " + jumlahNilaiTka2);

                        Console.WriteLine("nilai Gabungan Anda Adalah : " + (nilaiUTBK + jumlahNilaiTka2));

                        if (nilaiUTBK >= 600)
                        {
                            Console.WriteLine("Anda Bisa Diterima Di ITS");
                        }
                        else
                        {
                            Console.WriteLine("Anda Tidak Diterima Di ITS");
                        }
                       
                    }

                    else
                    {
                        return;
                    }
                }
            }

            
        }

    }
        
}
