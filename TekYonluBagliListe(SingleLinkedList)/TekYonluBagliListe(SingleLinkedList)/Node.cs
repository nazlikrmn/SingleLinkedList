using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekYonluBagliListe_SingleLinkedList_
{
   public class Node
    {
       public bool Doluluk;
       public string AdSoyad;
       public int KoltukNumarasi;

       public Node nextNode;
        public Node(bool a)
        {
            Doluluk = a;
        }
    }
}
