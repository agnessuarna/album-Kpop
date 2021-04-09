using System;

namespace album_kpop
{
   public struct albumList
   {
      public string[] GBBBnama;
      public string[] albumJudul;
      public int[] albumID;
      public string[] albumVers;
      public int total;

      
      public void input()
      {
          total = 2;
          listGBBB();
          listJudul();
          listId();
          listVers();
      }

      public void listGBBB(){
          GBBBnama[0] = "EXO";
          GBBBnama[1] = "NCT";
          GBBBnama[2] = "SNSD";
      }
      public void listJudul(){
          albumJudul[0] = "Full Album";
          albumJudul[1] = "Mini Album";
          albumJudul[2] = "Short Album";
      }

      public void listId(){
          albumID[0] = 34246;
          albumID[1] = 12357;
          albumID[2] = 23568;
      }

      public void listVers(){
          albumVers[0] = "Black Version";
          albumVers[1] = "Dark Version";
          albumVers[2] = "Happy Version";
      }
   } 
}