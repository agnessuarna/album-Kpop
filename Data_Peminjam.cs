using System;

namespace album_kpop
{
    public struct Data_Peminjam
    {
        public string namaPeminjam;
        public int idPeminjam;
        public string alamatPeminjam;

        public void input()
        {
            Data_Peminjam dataPeminjam;

            Console.WriteLine("Masukkan nama peminjam: ");
            dataPeminjam.namaPeminjam = Console.ReadLine();
            Console.WriteLine("Masukkan id peminjam : ");
            dataPeminjam.idPeminjam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan alamat rumah peminjam : ");
            dataPeminjam.alamatPeminjam = Console.ReadLine();
        }
    }
}