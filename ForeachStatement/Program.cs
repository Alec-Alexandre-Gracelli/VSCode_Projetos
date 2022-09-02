namespace ForeachStatement
{
    public class Program
    {
        private const string V = "Livro Código:";

        public struct Livro
        {
            public string titulo;
            public string autor;
            public int codigo;
            public int anoPublicacao;
        }

        public static void Main(string[] args)
        {
            //Livro l1 = new Livro();
            Livro l1;
            l1.codigo = 1;
            l1.autor = "Machado de Assim";
            l1.titulo = "Dom Casmurro";
            l1.anoPublicacao = 1899;

            Livro l2;
            l2.codigo = 2;
            l2.autor = "Jorge Amado";
            l2.titulo = "Gabriela";
            l2.anoPublicacao = 1958;

            List <Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);

            foreach (Livro item in livros)
            {
                Console.WriteLine("Livro Código:" + item.codigo.ToString());
                Console.WriteLine("Título:" + item.titulo);
                Console.WriteLine("Autor:" + item.autor);
                Console.WriteLine("Ano Publicação:" + item.anoPublicacao.ToString());
                Console.WriteLine("---------------------------");
            }

            for (int i = 0; i < livros.Count; i++)
            {
                _ = livros.ElementAt(i).autor;
            }

            Console.ReadKey();
        }
    }
}