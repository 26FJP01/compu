using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //variables
        int pesoMan, pesoTt, TotalMan;
        //inicio
        pesoMan = 0;
        pesoTt = 0;
        TotalMan = 0;
        while (TotalMan < 1000) ;
        { 
        Console.WriteLine("ingrese el peso de la manzana:");
        pesoMan = Convert.ToInt32(Console.ReadLine());
            if (pesoMan > 180)
            {
                pesoTt += pesoMan;//Abreviada de un acumulador
                //pesoTt=pesoTt+pesoMan
                Console.WriteLine("llevo el total de peso" + pesoTt + "Gramos");

                TotalMan++;
            }
            else
            {
                Console.WriteLine("ya alcanzo o supero 1 kilo de manzanas");
                Console.WriteLine("Cantidad de total de manzana :" + TotalMan);
            }
        }
    }
}