using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekYonluBagliListe_SingleLinkedList_
{
   public abstract class BagliListe
    {
        public Node Head;
        public abstract void InsertPos(int koltukNo,string Kisi);
        public abstract void DeletePos(int koltukNo);
        public abstract string GetElement(string kisi);
        public abstract void InstertLast();
    }
}
