using ConsoleApp2.Banh.@base;
using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp2.Banh.@base.Banhmacdinh;

namespace ConsoleApp2.Store.@base
{
    public abstract class banhstore
    {
        public void orderbanh(string type)
        {
            Banhmacdinh banhmacdinh;
            banhmacdinh=CreateBanh(type);
            banhmacdinh.prepage();
            banhmacdinh.banh();
            banhmacdinh.cut();
            banhmacdinh.boxing();
        }
        protected abstract Banhmacdinh CreateBanh(string type); 
    }
}
