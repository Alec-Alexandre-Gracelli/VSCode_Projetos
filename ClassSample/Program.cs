namespace ClassSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.Nome = "Pedro";
            a1.Idade = 30;

            Aluno a2 = new Aluno();
            a2.Nome = "Lauro";
            a2.Idade = 18;

            Console.ReadKey();


        }
    }
}