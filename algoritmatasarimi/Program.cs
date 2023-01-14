using algoritmaTasarimi.Banka;
using System.Collections;

namespace algoritmaTasarimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bankadan para yatır/çek ve bakiye göster

            //IBankaHesap mevduathesap = new mevduatHesabi();//new ile yapıcı sınıf oluşuyor. 
            //mevduathesap.Yatir(200);
            //mevduathesap.Cek(166);
            //Console.WriteLine(mevduathesap.ToString());

            #endregion

            #region Yatırım hesabı işlemleri

            //IBankaHesap yatirimhesap = new yatirimHesabi();
            //yatirimhesap.Yatir(100);
            //yatirimhesap.Cek(15);
            //Console.WriteLine(yatirimhesap.ToString());


            #endregion

            #region Hesaplar arası transfer

            //IBankaHesap mevduathesap= new mevduatHesabi(); //nesneyi mevduatHesabi'ndan ürettik.
            //ITransfer aktifhesap = new AktifHesap();
            //mevduathesap.Yatir(500);
            //Console.WriteLine(mevduathesap.ToString());
            //aktifhesap.Yatir(500);
            //Console.WriteLine(aktifhesap.ToString());
            //aktifhesap.transferYap(mevduathesap, 100);
            //Console.WriteLine(" ");
            //Console.WriteLine("Transfer işlemi gerçekleşiyorr...");
            //System.Threading.Thread.Sleep(2000);
            //Console.WriteLine("Transfer edilen miktar : 100...> ");
            //System.Threading.Thread.Sleep(2000);
            //Console.WriteLine(" ");
            //Console.WriteLine("Güncel "+ mevduathesap.ToString());
            //Console.WriteLine("Güncel "+aktifhesap.ToString());

            #endregion

            //*********************************************************************************************
        }       

    }
}