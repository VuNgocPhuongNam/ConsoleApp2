using ConsoleApp2.Banh.@base;
using ConsoleApp2.Banh.Cuahang3;
using ConsoleApp2.Store.@base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Store
{
    internal class cuahang3store:banhstore
    {
        protected override Banhmacdinh CreateBanh(string type)
        {
            switch (type)
            {
                case "banhmy1":
                    return new Cuahang3Banhngot1();
                case "banhmy2":
                    return new Cuahang3Banhngot2();
                case "banhmy3":
                    return new Cuahang3Banhngot3();
                default:
                    return null;
            }
        }
}
}
