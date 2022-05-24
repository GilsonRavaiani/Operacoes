using System;

namespace Operacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;
            int num = 10;

            res =(5+7)*2;
            num++;
            //num += 1;
            //num = num + 1;
            //adicionar um else somando até chegar ao resultado 

            bool res2 = 10 != 10;
            bool res3 = (5 != 7) & (7 > 5);// AND/E(&) V=(Todos forem verdadeiros)
            bool res4 = (3 > 2) & (6 < 7);
            bool res5 = (3 < 2) & (3 > 2);// AND/E(&) F=(Quando existir um falso)

            bool res6 = (3 > 2) | (4 > 3);// OR/OU(|) V=(Quando existir um verdadeiro)
            bool res7 = (3 > 2) | (4 < 3);
            bool res8 = (3 < 2) | (4 < 3);// OR/OU(|) F=(Quando todos forem falso)




            Console.WriteLine(num);
            Console.WriteLine(res);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);
            Console.WriteLine(res5);
            Console.WriteLine(res6);
            Console.WriteLine(res7);
            Console.WriteLine(res8);

            Console.ReadLine();

            Console.WriteLine("Testando indices: {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", num, res, res2, res3, res4, res5, res6, res7, res8);

            Console.ReadLine();

        }
    }
}
