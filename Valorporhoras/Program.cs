namespace Valorporhoras
{
    class Program
    {             
       static void Main(string[] args)
       {
            Menu();
       } 
       static void Menu()
       {
           Console.Clear();

           Console.WriteLine("Digite seu salário mensal: ");
           float salarioMesTotal = float.Parse(Console.ReadLine());  
           Console.WriteLine("Digite sua carga horária mensal: ");
           float salarioHoraTotal = float.Parse(Console.ReadLine());
           float salarioHora = salarioMesTotal / salarioHoraTotal;
           Console.WriteLine(salarioHora);
           Console.ReadKey();
           
           Menu();
       }
    }
}