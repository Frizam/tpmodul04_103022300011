using System;

namespace tpmodul4_103022300011
{
    class KodePos
    {
        // Enum untuk merepresentasikan kelurahan
        public enum Kelurahan
        {
            Batununggal,
            Kujangsari,
            Mengger,
            Wates,
            Cijaura,
            Jatisari,
            Margasari,
            Sekejati,
            Kebonwaru,
            Maleer,
            Samoja
        }

        //method yg berfungsi untuk mengembalikan kode pos dari tabel enum kelurahan
        public static string GetKodePos(Kelurahan kelurahan)
        {
            
            string[] kodePos = { "40266" , "40287" , "40267" , "40256" , "40287" 
                    , "40286" , "40286" , "40286" , "40272" , "40274" , "40273"};
            
            return kodePos[(int)kelurahan]; //mengembalikan kode pos menyesuaikan index dari kelurahan
        }
    }
}
