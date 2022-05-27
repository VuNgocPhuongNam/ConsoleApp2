using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Banh.@base
{

    public abstract class Banhmacdinh
    {
        protected string name;
        protected string vo;
        protected string nuocsot;
        protected List<string> topping = new List<string>();
        public void prepage()
        {
            Console.WriteLine("Prepage"+name);
            Console.WriteLine("Vo: "+vo);
            Console.WriteLine("nuocsoot: "+nuocsot);
            Console.WriteLine("addtoppinh");
            topping?.ForEach((topping) => Console.WriteLine("\t"+topping));
        }
        public void banh()
        {
            Console.WriteLine("banh "+name+" doi 15 phut");
        }
        public void cut()
        {
            Console.WriteLine("Cutting "+ name);
        }
        public virtual void boxing()
        {
            Console.WriteLine("boxing "+name);
        }
    }
}
