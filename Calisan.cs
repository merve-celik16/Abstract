using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Calisan
    {
        public string Ad{ get; set; }
        public string Soyadi { get; set; }
        public string Departman { get; set; }
        public abstract void Gorev();
       
        
    }
    public class MagazaYoneticisi :Calisan 
    {
       

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyadi} , Mağaza yöneticisi olarak görev yapmaktayım..");
        }
    }
    public class ProjeYoneticisi : Calisan
    {
        public override void Gorev()

        {
            Console.WriteLine($"{Ad} {Soyadi} , Proje yöneticisi olarak görev yapmaktayım..");
        }
    }

    public class SatisTemsilcisi : Calisan
    {
        public override void Gorev()

        {
            Console.WriteLine($"{Ad} {Soyadi} , Satış temsilcisi olarak görev yapmaktayım..");
        }
    }
}
