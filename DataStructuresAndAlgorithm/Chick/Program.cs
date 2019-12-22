using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chick
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("公鸡5元一只，母鸡3元一只，小鸡1元三只。");
            Console.WriteLine();
            int cock = 0; //公鸡数量   

            int hen = 0;  //母鸡数量 

            int chick = 0; //小鸡数量 

            int method = 1;

            for (cock = 0; cock <= 20; cock++)  //100块最多买20只公鸡

            {

                for (hen = 0; hen <= 33; hen++) //100块最多买33只母鸡

                {

                    chick = 100 - cock - hen;

                    if (3 * hen + 5 * cock + chick / 3 == 100 && chick % 3 == 0)

                    {

                        Console.WriteLine("在方法{0}中：", method++);

                        Console.WriteLine("公鸡数量为:" + cock);

                        Console.WriteLine("母鸡数量为:" + hen);

                        Console.WriteLine("小鸡数量为:" + chick);
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
        
