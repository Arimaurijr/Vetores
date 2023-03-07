//Primeiro exercicio de vetor
internal class Program
{
    private static void Main(string[] args)
    {
        int[] A = new int[5];
        int[] B = new int[5];
        int[] C = new int[10];

        void Entrada(int[] vetor, string nome)
        {
            Console.WriteLine();
            Console.WriteLine("ENTRADA DOS VALORES DO VETOR " + nome);
            for(int i = 0; i < vetor.Length; i++)
            {
                //Console.WriteLine(Vetor[{0}] = ",i)
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

        void OrdenarVetorCrescente()
        {
            Console.WriteLine();
            Console.WriteLine("ORDENAÇÃO DO VETOR C:");
            int aux = 0;
            for(int i = 0;i< C.Length;i++)
            {
                for(int j = i+1; j < C.Length;j++) 
                {
                    if (C[i] > C[j])
                    {
                        aux = C[i];
                        C[i] = C[j];
                        C[j] = aux;
                    }
                }
            }
        }

        void OrdenarVetor(int[] v)
        {
            int i, j;
            for(i =0; i< v.Length - 1;i++)
            {
                for(j = i+1; j < v.Length;j++)
                {
                    if (v[i] > v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
        }

        void ExibirDados(int[] vetor, string nome)
        {
            Console.WriteLine();
            Console.WriteLine("ENTRADA DOS VALORES DO VETOR " + nome);
            for (int i = 0; i < vetor.Length;i++) 
            {
                Console.Write(vetor[i] + " ");
            }

            Console.WriteLine();
        }
        /*
         * int[] Concatenar_Vetor(int[] A, int[] B)
         * {
         *      int[] aux = = new int[10];
         *      for(int i = 0; i < A.Lenght; i++)
         *      {
         *          aux[i] = A[i];
         *      }
         *      for(int i = 0;i < B.Lenght; i++)
         *      {
         *          aux[i+5] = B[i]
         *      }
         *      
         *      return aux
         * }
         */

        Entrada(A, "A");
        Entrada(B, "B");
        InserirVetorC();
        ExibirDados(A, "A");
        ExibirDados(B, "B");
        ExibirDados(C, "C");
        OrdenarVetorCrescente();
        ExibirDados(C, "C");
    }
}