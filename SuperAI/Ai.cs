using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SuperAI
{
    public class Ai
    {
        #region Variables
        //Путь к файлу
        string filePath;
        //Текст файла
        string fileText;
        //Имя файла
        string fileName;
        //Объекты, связи и отношения
        String[,] objects;
        String[,] connections;
        String[,] relations;
        String objectsTextBlock;
        String connectionsTextBlock;
        String relationsTextBlock;
        //Запрос пользователя
        String[] req;
        //Генератор для фраз
        Random rnd;
        //Фразы приветсвия, отказа и подтверждения
        String[] hello = { "Мы готовы?", "Начнем.", "Начнем?", "Поехали.", "Я готов."};
        String[] yes = { "Да.", "Именно.", "Точно.", "Ага."};
        String[] donnow = { "Я не знаю.", "Не уверен." , "Откуда мне знать?", "Мне кажется, что я не знаю.", "Не хватает данных."};
        #endregion

        public String ObjectsTextBlock { get { return objectsTextBlock; } }
        public String ConnectionsTextBlock { get { return connectionsTextBlock; } }
        public String RelationsTextBlock { get { return relationsTextBlock; } }
        
        public String FileName { get { return fileName; } }
        public String FileText { get { return fileText; } }

        private void DefineAndFillArray(int currentBlock, ref String[,] array, int cellsCount)
        {
            int stIndex = fileText.IndexOf("#" + currentBlock.ToString()) + 2;
            int fnIndex;
            if (currentBlock < 3)
                fnIndex = fileText.IndexOf("#" + (currentBlock + 1).ToString());
            else
                fnIndex = fileText.Length;

            //ПОлучаем нужный участок текста
            string tempObjects = fileText.Substring(stIndex, fnIndex - stIndex);
            switch(currentBlock)
            {
                case 1: objectsTextBlock = tempObjects; break;
                case 2: connectionsTextBlock = tempObjects; break;
                case 3: relationsTextBlock = tempObjects; break;
            }
            //все строки участка текста
            string[] lines = tempObjects.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            array = new string[lines.Length, cellsCount];
            for (int i = 0; i < lines.Length; i++)
            {
                String[] splittedWords = lines[i].Split(':');
                if (splittedWords.Length < cellsCount)
                    continue;
                for (int j = 0; j < cellsCount; j++)
                {
                    array[i, j] = splittedWords[j];
                }
            }
        }

        public String ConvertToNormalLine(String line)
        {
            String[] el = line.Split(':');
            if (el.Length < 3)
                return "";
            List<String[]> list = new List<string[]>();
            list.Add(el);
            return ListToStringResults(list);
        }

        //Получить фразу приветствия
        public String Hello()
        {
            return hello[rnd.Next(hello.Length)];
        }

        private int GetConnectionType(String connIndex)
        {
            if (connIndex == "?")
                return 1;
            for(int i = 0; i < connections.GetLength(0); i ++)
            {
                if (connections[i, 0] == connIndex)
                {
                    return Int32.Parse(connections[i, 2]);
                }
            }
            return -1;
        }

        private List<String[]> Analyze(String[] req, bool inherConnectionType)
        {
            List<String[]> list = new List<string[]>();
            for (int i = 0; i < relations.GetLength(0); i ++)
            {           
                bool found = true;
                if (!inherConnectionType && GetConnectionType(relations[i, 1]) != 2)
                    continue;

                for (int j = 0; j < req.GetLength(0); j ++)
                {
                    //если ввели не ? или не совпадают - прерываемся
                    if (req[j] != "?" && req[j] != relations[i,j])
                    {
                        found = false;
                        break;
                    }
                }
                //если все совпало
                if (found)
                {
                    String[] toAdd = new string[3];
                    for (int k = 0; k < 3; k++)
                    {
                        toAdd[k] = relations[i, k];
                    }
                    list.Add(toAdd);
                }

                if ((relations[i, 0] == req[0] || req[0] == "?") && (GetConnectionType(relations[i, 1]) != 0) )//&& (GetConnectionType(relations[i, 1]) <= GetConnectionType(req[1])))
                {
                    List<String[]> toAdd = Analyze(new String[] { relations[i, 2], req[1], req[2] }, GetConnectionType(relations[i,1]) == 1);
                    for (int z = 0; z < toAdd.Count; z++)
                    {
                        toAdd[z][0] = relations[i, 0];
                        list.Add(toAdd[z]);
                    }
                }

                ////смотрим предков объекта на наличие нужного свойства
                //if ((req[0] == relations[i, 0] || req[0] == "?") && GetConnectionType(relations[i, 1]) == 1)
                //{
                //    List<String[]> toAdd = Analyze(new String[] { relations[i, 2], req[1], req[2] });
                //    for (int z = 0; z < toAdd.Count; z++)
                //    {
                //        if (GetConnectionType(toAdd[z][1]) >= 1)
                //        {
                //            toAdd[z][0] = relations[i, 0];
                //            //Predicate<string[]> pred = item => item == toAdd[z];
                //            //if (list.Find(pred) == null)
                //                list.Add(toAdd[z]);
                //        }
                //    }
                //}
                //if ((req[2] == relations[i, 0] || req[2] == "?") && (GetConnectionType(req[1]) == 2 || req[1] == "?") && GetConnectionType(relations[i, 1]) == 1)
                //{
                //    List<String[]> toAdd = Analyze(new String[] { req[0], req[1], relations[i, 2] });
                //    for (int z = 0; z < toAdd.Count; z++)
                //    {
                //        if (GetConnectionType(toAdd[z][1]) == 2)
                //        {
                //            toAdd[z][2] = relations[i, 0];
                //            if (list.FindIndex(l => Enumerable.SequenceEqual(toAdd[z], l)) == -1)
                //                list.Add(toAdd[z]);
                //        }
                //    }
                //}
            }
            return list;
        }

        public String Ask(String line)
        {
            req = new string[3];
            req = line.Split(':');

            //если у запроса нет ни одного знака "?", значит на него нужно ответить
            //"да" или "не знаю". Иначе - выдавать соответствия.
            List<String[]> list = Analyze(req, true);
            bool YorNQuestion = true;
            foreach (String r in req)
            {
                if (r == "?")
                    YorNQuestion = false;
            }
            if (list.Count > 0)
            {
                if (YorNQuestion)
                    return yes[rnd.Next(yes.Length)];
                else
                {
                    return ListToStringResults(list);
                }
            }
            else
            {
                return donnow[rnd.Next(donnow.Length)];
            }
        }

        private String ListToStringResults(List<String[]> list)
        {
            String result = "";
            foreach (String[] row in list)
            {
                for(int i = 0; i < row.GetLength(0); i ++)
                {
                    if (i == 0 || i == 2)
                    {
                        result += findInArray(objects, row[i]);
                    }
                    else
                    {
                        result += findInArray(connections, row[i]);
                    }
                    if (i < 2)
                        result += " ";
                }
                result += "\n";
            }
            result = result.Remove(result.Length - 1, 1);
            return result;
        }

        private String findInArray(String[,] array, String index)
        {
            if (index == "?")
                return "<что угодно>";
            for(int i = 0; i < array.GetLength(0); i++)
            {
                if (index == array[i, 0])
                {
                    return array[i, 1];
                }
            }
            return "NULL";
        }

        //Вычисляет имя файла по его пути (убираем символы \).
        private String GetFileNameByPath(String filePath)
        {
            string fn = filePath;
            while (fn.IndexOf('\\') != -1)
            {
                fn = fn.Remove(0, fn.IndexOf('\\') + 1);
            }
            return fn;
        }

        public Ai(string filePath)
        {
            rnd = new Random();
            this.filePath = filePath;
            fileName = GetFileNameByPath(filePath);
            StreamReader sr = new StreamReader(filePath, Encoding.Default, true, 128);
            fileText = sr.ReadToEnd();
            //fileText = RemoveAllx0D(fileText);
            fileText = fileText.Replace("\r", "");
            DefineAndFillArray(1, ref objects, 2);
            DefineAndFillArray(2, ref connections, 3);
            DefineAndFillArray(3, ref relations, 3);
            sr.Close();
        }
    }
}
