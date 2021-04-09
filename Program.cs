using System;

namespace album_kpop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat Datang di Program Peminjaman Album Kpop");

            Data_Peminjam dataPeminjam = new Data_Peminjam();
            dataPeminjam.input();

            Album_Kpop album = new Album_Kpop();
            album.list();
            album.tampil();

        }
    }
}
