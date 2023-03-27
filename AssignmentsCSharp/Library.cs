using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TeachMeHowToPrint
{
    internal static class Library
    {
        
        static string textToType;
        static String? PATH = "..\\..\\..\\Library\\";
        public static FileInfo[]? getTextList () {
            if (PATH == null) return null;
            DirectoryInfo library = new DirectoryInfo(PATH);
            return library.GetFiles();
        }

        public static string printRandomText()
        {
            Random random = new Random();
            var textList = getTextList();
            if (textList == null || textList.Length == 0)
            {
                throw new Exception("Библиотека не найдена!");
            }

            var textNumber = random.Next(0, textList.Length);
            string path = textList[textNumber].FullName;

            using (FileStream fs = File.OpenRead(path))
            {
                byte[] b = new byte[2048];
                UTF8Encoding temp = new UTF8Encoding(true);
                int readLen;
                while ((readLen = fs.Read(b, 0, b.Length)) > 0)
                {
                    textToType = temp.GetString(b, 0, readLen);
                }
                fs.Close();
            }

            return textToType;
            
        }

        public static string printText()
            {
                textToType = "C# (произносится си шарп) " +
                "— объектно-ориентированный язык программирования общего назначения. " +
                "Разработан в 1998—2001 годах группой инженеров компании Microsoft " +
                "под руководством Андерса Хейлсберга и Скотта Вильтаумота" +
                " как язык разработки приложений для платформы Microsoft .NET Framework" +
                " и .NET Core. Впоследствии был стандартизирован как ECMA-334 и ISO/IEC 23270." +
                "\nC# относится к семье языков с C-подобным синтаксисом, " +
                "из них его синтаксис наиболее близок к C++ и Java. " +
                "Язык имеет статическую типизацию, поддерживает полиморфизм, перегрузку операторов " +
                "(в том числе операторов явного и неявного приведения типа), " +
                "делегаты, атрибуты, события, переменные, свойства, обобщённые типы и методы, " +
                "итераторы, анонимные функции с поддержкой замыканий, LINQ, " +
                "исключения, комментарии в формате XML."
;
                return textToType;
            }

        }
}

