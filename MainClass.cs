using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OOP_Lab_4_Gl_Vlad
{
    class MainClass
    {

        public static void Main()
        {
            string a = "Vlad";
            string b = "Hluzhin";

            MyConcat(a, b);
        }

        public static string MyConcat(string firstWord, string secondWord)
        {
            firstWord = firstWord.Replace(" ", "");
            Debug.WriteLine(firstWord);
            Debug.WriteLine(secondWord);

            return (firstWord + " " + secondWord);
        }
    }
}
