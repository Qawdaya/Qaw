using System;

namespace _6._3__多维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twodim = new int[3, 3];
            twodim[0, 0] = 1;
            twodim[0, 1] = 2;
            twodim[0, 2] = 3;
            twodim[1, 0] = 4;
            twodim[1, 1] = 5;
            twodim[1, 2] = 6;
            twodim[2, 0] = 7;
            twodim[2, 1] = 8;
            twodim[2, 2] = 9;
            int[,] twodim1 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            int[,,] twodim2 = { { { 1, 2 }, { 3,4} },
                              { { 5, 6 }, { 7,8} },{ { 9, 10 }, { 11,12} } };
            for(int a=0;a<3;a++)
            {
               for(int j=0;j<3;j++)
                {
                    Console.WriteLine(twodim[a, j]);
                } 
            }
            for(int c=0;c<twodim1.GetLength(0);c++)
            {
                for(int z=0;z<twodim1.GetLength(1);z++)
                {
                  
                        Console.WriteLine("twodiml1[{0},{1}]:{2}", c, z, twodim1[c, z]);
                 
                }
            }
            for(int h=0;h<twodim2.GetLength(0);h++)
            {
                for(int p=0;p<twodim2.GetLength(1);p++)
                {
                    for(int o=0;o<twodim2.GetLength(2);o++)
                    {
                        Console.WriteLine("twodiml2[{0},{1},{2}]:{3}", h, p,o, twodim2[h, p,o]);
                    }
                }
            }
                                
        }
    }
}
