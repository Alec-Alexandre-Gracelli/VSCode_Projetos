namespace ValueTypes
{
    public class Program
    {
        enum Acessorio { Sapato, Bolsa, Cinto, Carteira, Colar };

        public static void Main(string[] args)
        {
            // int a = 10;
            // string b = "OK";
            //char ch = 'X';

            //float ff = 10.89F;
            //double dd = 90.9876;

            //decimal dec = 10.88M;

            //bool bl = true;

            int item = (int)Acessorio.Cinto;

            //Implicit Conversion
            //int i1 = 10;
            //long i2 = i1;

            //Explicit Conversion
            //double d1 = 10.9;
            //int d2 = (int)d1;

            //int.TryParse
            //int.Parse


            //Convert.

            Console.WriteLine(item);
            Console.ReadKey();
        }


    }
}