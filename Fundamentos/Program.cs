using System;

namespace Fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tipo de datos
            //------------------------------------------------ Enteros --------------------------------
            byte num = 255; //permite solo del 0 - 255
            sbyte nums = -127; //perite negativos del - 128 al positivo 127  
            int numint = 132; //-132; //permite enteros negativos y positivos de 32 bytes
            uint number = 22; //permite enteros positivos
            long number_largo = 1231231231231231321; //permite enteros positivos y negativos, son numeros muy grandes
            ulong number_lago2 = 132323233233132323; //represenga solo enteros positivos.

            //---------------------------------------------- Decimales -------------------------------
            float f = 189.1f; //4 bytes
            double d = 189.1d; //8bytes
            decimal de = 189.1m; //16 bytes

            //-------------------------------------- Cadenas------------------------
            char letra = 'A'; //2 byte, syntaxis correcta con '' , si es "" dara un error
            string nombr = "wilson"; //representado por comillas dobles ""

            //------------------------------------ Fecha ------------------------------------
            //para las fechas se utiliza la clase DateTime
            DateTime date1 = DateTime.Now;
            Console.WriteLine(date1);


            //---------------------------------------------------- Booleanos ------------------------------
            bool v = true;
            bool fa = false;
            // ---------------------------------------------------------------------------------------------


            //NOTA : En c# los datos ya tienen un dato por defecto

            //EJEMPLO : 

            int numero = new int(); //como vemos el numero no tiene ningun dato solo le decimo que es un objeto de entero

            Console.WriteLine(numero); // valor nos dara 0 

            //¿QUE PDEMOS HACER PARA QUE LA VARIABLE NO TENGA NINGUN VALOR, SEA "NULL" ?

            int? numb = null; //el "?" a lado de la variable te de la opcion de hacer null a la variable
                              //si no se coloca dara un error de sintaxis 

            Console.WriteLine(numb); // no aparace valor




            //-------------------------------------------- VAR -------------------------------------------------

            //"var" : palabra reservada para definir una variable que cuando se le asigna el valor, deduce el tipo de dato
            //ejemplo

            var nom = "wilson"; //esto deduce que es un tipo string
            //nom = 1; //esto es un error ya que ya se inicializo con un string



            //----------------------------------- OBJECT ---------------------------

            //object : es la base de todas los elementos de c# .net

            object persona = new { nombre = "wilson", apellidos = "Coronado" };
            //aqui no se puede acceder a sus atributos ya que este objecto deberia existar en una clase
            Console.WriteLine(persona);

            //objecto tipo anonimo
            var personas = new { nombre = "wilson", apellidos = "Coronado" };
            Console.WriteLine(personas.nombre);






        }
    }
}
