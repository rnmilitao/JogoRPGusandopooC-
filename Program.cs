using Aula_1.CLC.Entity;

namespace dotnet__poo
{
    class Program
    {
        static void Main(string[] args){
            Knight Arus = new Knight("Arus", 23, "Knight");
            Wizard Cratos = new Wizard("Jennica", 23, "White Wizard");
                      
            Console.Write(Cratos.Attack(1));
            Console.WriteLine();
            Console.Write(Cratos.Attack(7));
        }
    }
}