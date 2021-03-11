using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VlaknaFormCas.implementace
{
    public class Hodiny
    {
        private bool zobrazuje = true;


        public void Zobrazuj() {

            Console.WriteLine("--on");
            this.zobrazuje = true;
           // Smycka();
           // nespoustim, jen menim hodnotu prommene zobrazuje
        
        }
        public void Nezobrazuj() {
            Console.WriteLine("--off");
            this.zobrazuje = false;
        }
        public void  Smycka() {


            //do
            //{
            //    Console.WriteLine(DateTime.Now.ToLongTimeString());
            //    Thread.Sleep(1000);
            //} while (this.zobrazuje);
            // tahle smycka neni nekonecna kdyz zmeni hodnotu na zobrazuj, tak uz se znova nerozbehne
            //protoze se spousti ve vlakne, na zacatku je zobrazuje true, tak bezi, jakmile zmeni tlacitkem, zobrazuje na false, tak uz se to vlakno znova nespusti

            while (true)
            {
                if (this.zobrazuje)
                    Console.WriteLine(DateTime.Now.ToLongTimeString());
                Thread.Sleep(1000);  //jinak by thread vytížil procesor na 100 %
            }


        }


    }
}
