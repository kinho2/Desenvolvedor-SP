namespace SOMA;
class Program
{
    static void Main(string[] args)
    {


        int INDICE = 13;
        int SOMA = 0, K = 0;

        for (int i1 = 0; K < INDICE; i1++)
        {
            K = K + 1;
            SOMA = SOMA + K;
            Console.WriteLine(SOMA);
        }
        Console.WriteLine("Valor final é = " + SOMA);
    }
}
