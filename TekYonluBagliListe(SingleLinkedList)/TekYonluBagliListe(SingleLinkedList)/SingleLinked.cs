using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekYonluBagliListe_SingleLinkedList_
{
    public class SingleLinked : BagliListe
    {
        public override void DeletePos(int koltukNo)
        {
            Node n = new Node(false);
            Node tmpNode = Head;
            for (int i = 0; i < koltukNo - 2; i++)
            {
                tmpNode = tmpNode.nextNode;
            }
            Node tmp = tmpNode.nextNode.nextNode;
            tmpNode.nextNode = n;
            n.nextNode = tmp;
        }

        public override string GetElement(string kisi)
        {
            Node tmpNode = Head;
            
            for (int i = 0; i < 60; i++)
            {
                if(tmpNode.AdSoyad==kisi)
                {
                    return tmpNode.KoltukNumarasi.ToString();
                }
                tmpNode = tmpNode.nextNode;
            }
            return "Bu isme kayitli koltuk yok.";
           
        }

        public override void InsertPos(int koltukNo, string Kisi)
        {
            Node tmpNode = Head;
            for (int i = 0; i < koltukNo-2; i++)
            {
                tmpNode = tmpNode.nextNode;
            }
            Node tmp = tmpNode.nextNode.nextNode;
                DeletePos(koltukNo);
            Node n = new Node(true);
            n.AdSoyad = Kisi;
            n.KoltukNumarasi = koltukNo;
                tmpNode.nextNode = n;
                n.nextNode = tmp;

        }
        int sayac = 0;
        public override void InstertLast()
        {
            sayac++;
           if(Head==null)
            {
                Head = new Node(false);
                Head.KoltukNumarasi = sayac;
            }
            else
            {
                Node tmpNode = Head;
                while (tmpNode.nextNode != null)
                {
                    tmpNode = tmpNode.nextNode;
                }
                tmpNode.nextNode = new Node(false);
                tmpNode.nextNode.KoltukNumarasi = sayac;
            }
        }
    }
}
