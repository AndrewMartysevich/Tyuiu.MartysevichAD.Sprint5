using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MartysevichAD.Sprint5.Task6.V15.Lib
{
    public class DataService : ISprint5Task6V15
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string word = File.ReadAllText(path);
            string[] words = word.Split(' ');
            string russianLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            for (int i = 0; i <= words.Length - 1; i++)
            {
                foreach (char c in russianLetters)
                {
                    if(words[i].Contains(c))
                    {
                        
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
    }
}
