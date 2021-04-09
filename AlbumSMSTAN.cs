using System;

namespace album_kpop
{
    public struct Album_Kpop
    {
        public string[] namaGBBB;
        public string[] judulalbum;
        public int[] IDalbum;
        public string[] versialbum;
        public int[] pilihannya;
       public void list()
        {
           albumList ListAlbum = new albumList();
           int i;
           for(i=0; i < ListAlbum.total; i++){
               namaGBBB[i] = ListAlbum.GBBBnama[i];
           } 

           for(i=0; i < ListAlbum.total; i++){
               judulalbum[i]= ListAlbum.albumJudul[i];
           }

           for(i=0; i < ListAlbum.total; i++){
               IDalbum[i] = ListAlbum.albumID[i];
           }

           for(i=0; i < ListAlbum.total; i++){
               versialbum[i] = ListAlbum.albumVers[i];
           }
        }

        public void tampil()
        {
            albumList albumList = new albumList();
            for(int i=0; i < albumList.total; i++){
                Console.WriteLine("{0} Group, Judul Album {1}, Vers Album {2} ",namaGBBB[i], judulalbum[i], versialbum[i] );
            }
        }


    }
}