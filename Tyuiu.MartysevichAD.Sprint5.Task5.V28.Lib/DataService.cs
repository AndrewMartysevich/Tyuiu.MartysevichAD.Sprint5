using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MartysevichAD.Sprint5.Task5.V28.Lib
{
    public class DataService : ISprint5Task5V28
    {
        public double LoadFromDataFile(string path)
        {
            int count = 0;
            int z = 1;
            int[] mas;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    
                   char[] y= line.ToCharArray();
                    for (int i = 0; i < y.Length; i++)
                    {
                        mas = new int[y.Length];
                        mas[i] = Convert.ToInt32(y[i]);
                        if ((mas[i]>0) && (mas[i] % 1 == 0)&&(mas[i]%5==0))
                        {
                            count++;
                            int[] arr = new int[count];
                            arr[i] = mas[i];

                            foreach (int element in arr)
                            {
                                Array.Sort(arr);
                            }
                            z= arr[0];
                        } 
                    }
                }
                return z;
            }
            int res = 1;
            for (int j = 1; j <= z; j++)
            {
                res = res * j;
            }

            return res;
        }

        
    }
}
