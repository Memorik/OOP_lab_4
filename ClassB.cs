using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace OOP_Lab_4_Gl_Vlad
{
    class ClassB
    {
        string w = "ddd";
        void Method1()
        {
            Debug.WriteLine("Method1");
        }         
    }


    class ClassP1 : ClassB
    {
        void Method2(string w)
        {
            Debug.WriteLine(w);
        }
    }
}
