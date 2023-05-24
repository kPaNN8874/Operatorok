using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Kifejezesek
    {
        int elsoOperandus;
        string oper;
        int masodikOperandus;

         public Kifejezesek(string csvSor)
        {
            var mezok = csvSor.Split(';');
            this.elsoOperandus = mezok[0];
            this.oper = mezok[1];
            this.masodikOperandus = mezok[2];
        }
         public Kolcsonzes(string nev, char jazon, int eOra, int ePerc, int vOra, int vPerc)
        {
            this.elsoOperandus = elsoOperandus;
            this.oper = oper;
            this.masodikOperandus=masodikOperandus;
        }
        
        public int elsoOperandus { get => elsoOperandus; }
        public string oper { get => oper; }
        public int masodikOperandus { get => masodikOperandus; }
          
    }
}
