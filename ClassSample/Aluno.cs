namespace ClassSample
{
    public class Aluno
    {
        public Aluno()
        {
            Console.WriteLine("Aluno Constructor");
        }

        //Fields
        private string nome;
        private int idade;

        //Properties
        public string Nome
        {
            get {return nome;}
            set {nome = value;}
        }
        public int Idade
        {
            get {return idade;}

            set {
                if(value >= 18)
                idade = value;}
        }
        ~Aluno()
        {
            Console.WriteLine("Aluno Destructor");
        }
    }
}