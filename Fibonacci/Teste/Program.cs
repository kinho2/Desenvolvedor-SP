namespace Fibonacci;
class Program
{
    static void Main(string[] args)
    {

        double Anterior = 0;
        double Atual = 1;
        double fibonacci;
        double valor = 0;

        List<double> fibonacciList = new List<double>();


        for (int i = 1; i < 100; i++)
        {
            fibonacci = Anterior + Atual;
            Anterior = Atual;
            Atual = fibonacci;
            valor = fibonacci;
            fibonacciList.Add(fibonacci);

        }
        double n = 34;

        double x = 0;


        foreach (double produto in fibonacciList.FindAll(x => x == n || x != n))
        {
            if (produto == n)
            {
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine(n + " - O número informado pertence a sequência");
                break;
            }
            else if (produto != n)
            {
                Console.WriteLine("Verificando");
            }
        }
       

    }
}