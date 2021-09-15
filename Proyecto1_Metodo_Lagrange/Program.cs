using System;

namespace Proyecto1_Metodo_Lagrange{
    class Program{
        static void Main(string[] args){
            //Console.WriteLine("Hello World!");
            /* float x[101], y[101], res = 0, evaluar = 0;
             float prodnumerador = 0, prodenominador = 0;
             int pares = 0, i = 0, j = 0;*/
            float[] x = new float[101];
            float[] y = new float[101];
            float res = 0, evaluar = 0, prodnumerador = 0, prodenominador = 0;
            int pares = 0, i = 0, j = 0;

            /*printf("\t----------METODO DE LAGRANGE-----------\n\n");
            printf("\n\t%cCuantos pares ordenados desea ingresar? : ", 168);
            scanf("%i", &pares);*/
            Console.WriteLine("¿Cuantos pares ordenados desea ingresar?");
            pares = int.Parse(Console.ReadLine());

            /*for (i = 0; i < pares; i++){
                printf("\n\tIngrese el par %i,%i: \n\t", i, i);
                scanf("%f,%f", &x[i], &y[i]);
            }*/
            for (i = 0; i < pares; i++){
                Console.WriteLine($"Ingrese el par {i},{i}");
                Console.WriteLine("Ingrese x");
                x[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese y");
                y[i] = float.Parse(Console.ReadLine());
            }

            /*printf("\n\t%cPara que valor de x desea evaluar? : ", 168);
            scanf("%f", &evaluar);*/
            Console.WriteLine("¿Para que valor de x desea evaluar?");
            evaluar= float.Parse(Console.ReadLine());

            for (i = 0; i < pares; i++){
                prodnumerador = 1;
                prodenominador = 1;
                for (j = 0; j < pares; j++){
                    if (i != j){
                        prodnumerador = prodnumerador * (evaluar - x[j]);
                        prodenominador = prodenominador * (x[i] - x[j]);
                    }
                }
                res = res + y[i] * (prodnumerador / prodenominador);
            }

            //printf("\n\t y(%.3f) = %f", evaluar, res);
            Console.WriteLine($"y({evaluar})={res}");
        }
    }
}
