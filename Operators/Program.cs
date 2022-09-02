namespace Operators
{
    class Program
    {
         static void Main(string[] args)
    {
        #region Sintaxe
        int a = 10; 
        int b = 2;

        // Aritmeticos

        //Add
        int add = a + b;

        //Subt
        int subt = a - b;

        //Mult
        int mult = a * b;

        //Divis
        int divis = a / b;

        //Rest
        //int rest = 5 % 2;

        //Primary

        //incremento - x++
        //decremento - x--

        //Comparativos

        if(a > b)
            //Console.WriteLine("a > b");

            if(a < b)
                //Console.WriteLine("a < b")

                // => - Lambda
                if(a >= b)
                    //Console.WriteLine("a >= b");

                    if(a <= b)
                        //Console.WriteLine("a <= b");

                        //Equals
                        if(a == b)
                            //Console.Writeline("a == b");

                            //Not
                            if(a !=b)
                                //Console.WriteLine("a != b");

                                //Logicos

                                //XOR - Lógico Excluiso - um ou outro
                                if(true ^ false)
                                    //Console.WriteLine("true");

                                    //Condicionais

                                    //AND
                                    if(true && true)
                                        //Console.WriteLine("true");

                                        //OR ---> if(a < b || b > c)
                                        if(false || true)
                                            //Console.WriteLine("true");

                                            #endregion

        Console.ReadLine();
        Console.WriteLine("Valor 1: ");
        int v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor 2: ");
        int v2 = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Soma: " + Convert.ToString(v1 + v2));
        Console.WriteLine("Subtração: " + Convert.ToString(v1 - v2));
        Console.WriteLine("Multiplicação: " + Convert.ToString(v1 * v2));
        Console.WriteLine("Divisão: " + Convert.ToString(v1 / v2));
        Console.WriteLine();

        if(v1 > 0 && v2 > 0)
            Console.WriteLine("Valores v1 e v2 Maiores que zero");

        if(v1 + v2 <= 0 || v1 - v2 <= 0 || v1 * v2 <= 0 || v1 / v2 <= 0)
            Console.WriteLine("Uma ou mais operações possui valor Menor ou Igual a zero");

        Console.ReadKey();
        }
    }
}
   