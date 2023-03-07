internal class Program
{
    private static void Main(string[] args)
    {
        int[] A = new int[5];
        int[] B = new int[5];
        int[] C = new int[10];

        void Entrada(int[] vetor, int tamanho)
        {
            for(int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("DIGITE O " + (i + 1) + " º ELEMENTO: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
        void InserirVetorC()
        {
             // vetor c
            int i = 0; // vetor a, b
            for(int j = 0; j < 10; j++)
            {

                if(j < 5)
                {
                    C[j] = A[i];
                }
                else
                {
                    if(j == 5)
                    {
                        i = 0;
                    }

                    C[j] = B[i];
                }
                i++;
            }
        }

        void ExibirDados(int[] vetor, int tamanho)
        {
            Console.WriteLine("EXIBIÇÃO DOS VALORES DO VETOR: ");
            for(int i = 0; i < tamanho;i++) 
            {
                Console.Write(vetor[i] + " ");
            }

            Console.WriteLine();
        }

        Entrada(A, 5);
        Entrada(B, 5);
        InserirVetorC();
        ExibirDados(A, 5);
        ExibirDados(B, 5);
        ExibirDados(C, 10);
    }
}