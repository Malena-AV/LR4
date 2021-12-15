using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Mas
    {
        public static int Number(int[] mas)
        {
            int c = 0;
            for (int a = 0; a < mas.Length; a++)
            {
                if (mas[a] % 2 != 0)
                {
                    c++;
                }
                else
                {
                    c--;
                }
            }
            return c;
        }

    }
}
