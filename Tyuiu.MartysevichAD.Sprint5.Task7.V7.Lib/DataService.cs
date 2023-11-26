using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MartysevichAD.Sprint5.Task7.V7.Lib
{
    public class DataService : ISprint5Task7V7
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = @"C:\DataSprint5\OutPutDataFileTask7V7.txt";
            FileInfo fileInfo = new FileInfo(pathSave);
            bool fileExist = fileInfo.Exists;

            if(fileExist)
            {
                File.Delete(pathSave);
            }

            var oldText = File.ReadAllText(path);
            var newText = oldText.Replace("А", "").Replace("Б", "").Replace("В", "").Replace("Г", "").Replace("Д", "").Replace("Е", "").Replace("Ё", "").Replace("Ж", "").Replace("З", "").Replace("И", "").Replace("Й", "").Replace("К", "").Replace("Л", "").Replace("М", "").Replace("Н", "").Replace("О", "").Replace("П", "").Replace("Р", "").Replace("С", "").Replace("Т", "").Replace("Ф", "").Replace("Х", "").Replace("Ц", "").Replace("Ч", "").Replace("Ш", "").Replace("Щ", "").Replace("Ъ", "").Replace("Ы", "").Replace("Б", "").Replace("Э", "").Replace("Ю", "").Replace("Я", "");
            string res = Convert.ToString(newText);
            File.AppendAllText(pathSave, res );
            return pathSave;
        }
    }
}
