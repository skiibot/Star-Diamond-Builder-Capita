using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(StarBuilder(3));
            Console.WriteLine(DiamondBuilder(2));
            Console.ReadLine();
        }

        static StringBuilder StarBuilder(int layers)
        {
            StringBuilder starGenerated = new StringBuilder("");
            for(int i = 1; i<=layers; i++)
            {
                for(int j = 0; j<layers-i; j++)
                {
                    starGenerated.Append(" ");
                }
                for(int j = 0; j<2*i-1; j++)
                {
                    starGenerated.Append("*");
                }
                starGenerated.Append("\n");
            }

            return starGenerated;
        }


       
        static StringBuilder DiamondBuilder(int layers)
        {
            StringBuilder bottom = new StringBuilder("");
            StringBuilder totDiamond = new StringBuilder("");
            if(layers == 1)
            {
                totDiamond.Append("*");
            }
            else
            {
                StringBuilder topDiamond = StarBuilder(layers);
                for(int i = 1; i< layers; i++)
                {
                    for(int j = 0; j<i; j++)
                    {
                        bottom.Append(" ");
                    }
                    for(int j =0; j < 2*(layers-1)-1 - 2 * (i - 1); j++)
                    {
                        bottom.Append("*");
                    }
                    bottom.Append("\n");
                }

                totDiamond = totDiamond.Append(topDiamond).Append(bottom);
            }
            return totDiamond;

        }
        /*
    static StringBuilder StarBuilder2(int layers)
        {
            StringBuilder starGenerated = new StringBuilder("");
            for (int i = 1; i <= layers; i++)
            {
                for (int j = 0; j < layers +i -1; j++)
                {
                    if (j < 2 * i - 1)
                    {
                        starGenerated.Append(" ");
                    }
                    else
                    {
                        starGenerated.Append("*");
                    }
                }
                starGenerated.Append("\n");
            }

            return starGenerated;
        }



        static StringBuilder DiamondBuilder(int layers)
        {
            ArrayList starGenerated = new ArrayList();
            for (int i = 1; i <= layers; i++)
            {
                for (int j = 0; j < layers - i; j++)
                {
                    starGenerated.Add(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    starGenerated.Add("*");
                }
                starGenerated.Add("\n");
            }
            starGenerated = starGenerated.Reverse

            return starGenerated;
        }

        */
    }
}
