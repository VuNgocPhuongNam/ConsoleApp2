using ConsoleApp2.Store;
using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* var banhmacdinh = new Banhmacdinh("banh 1", "thin dough", "chilli sauce", new List<string>(){ " back oliver" });
           banhmacdinh.Prepage();
           banhmacdinh.banh();
           banhmacdinh.cut();
           banhmacdinh.boxing();*/
            var banhstore = new cuahang1store();
            banhstore.orderbanh("banhmy1");
          
            var banhstore1 = new cuahang2strore();
            banhstore1.orderbanh("banhmy1");
        
         
            var banhstore2 = new cuahang3store();
            banhstore2.orderbanh("banhmy1");
         
        }
    }
}
