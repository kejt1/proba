using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYBKI
{
    public class Program
    {
        public static int [] zjadanie (int[] A, int[] B, int N)
        {
            for(int p = 0; p < N; p++)    
            {
                if((B[p] == 1) && (B[p+1] == 0))    //szukam ktora plynie z pradem
                {
                    for(int j = p; j < N; j++)
                    {
                        if ((A[j] > A[j+1]) && (B[j] > B[j+1]))
                        {
                            for(int i = j+1; i < N - 1; j++)
                            {
                                A[i] = A[i + 1];
                                B[i] = B[i + 1];
                            }
                            N = N - 1;
                        }

                        if ((A[j + 1] > A[j])&& (B[j] > B[j+1]))
                        {
                            for (int i = j; i < (N - 1); i++)
                            {
                                A[i] = A[i + 1];
                                B[i] = B[i + 1];
                            }
                            N = N - 1;
                        }
                    }
                }     
            }   
            return A;
        }

        public static int zlicz(int[] A, int[] B, int N)
        {
            int k = 1;
            int [] tabl = zjadanie(A, B, N);
            for (int i = 0; i < N-1; i++)
            {
                if (tabl[i+1] == tabl[i])
                    continue;
                else
                    k = k + 1;
            }
            return k;
        }

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 5, 4, 6 };
            int[] b = { 0, 0, 1, 0, 1, 0 };

            Console.WriteLine(zlicz(a,b,6));

            Console.ReadKey();
        }
    }
}
