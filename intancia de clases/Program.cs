using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Instancia de clases 

namespace instancia_de_clases

{
    class Program  //Clase principal
    {
        static void Main(string[] args)
        {

            Perro tobi = new Perro(); //Nueva Instancia
            tobi.color = "Blanco";
            tobi.edad = 5;
            Console.WriteLine("Tobi tiene " + tobi.edad + " y su color es " + tobi.color);
            tobi.ladra();

            Perro lassie = new Perro(); //Nueva Instancia
            lassie.color = "Negro";
            lassie.edad = 3;
            Console.WriteLine("Tobi tiene " + lassie.edad + " y su color es " + lassie.color);
            lassie.duerme();


            Console.ReadKey();
        }

    }

    class Perro
    {
        //Propiedades de la clase Perro
        public string color;
        public byte edad;

        //metodo 1
        public void ladra()
        {
            Console.WriteLine("Guau");
        }

        //metodo 1
        public void duerme()
        {
            Console.WriteLine("Zzzzzzz.....");
        }

    }


}

