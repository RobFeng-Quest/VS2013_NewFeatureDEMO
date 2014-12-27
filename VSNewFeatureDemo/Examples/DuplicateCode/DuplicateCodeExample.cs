using System;
using System.Collections.Generic;
using System.Text;

namespace VSNewFeatureDemo.Examples.DuplicateCode
{
    class DuplicateCodeExample : IExample
    {
        public void Show()
        {
            Method1();

            Method2();
        }

        static void Method1()
        {
            int a = 10;
            int a1 = 10;
            int a2 = 10;
            int a3 = 10;
            int a4 = 10;
            int a5 = 10;
            int a6 = 10;
            int a7 = 10;
            int a8 = 10;
            int a9 = 10;
        }

        static void Method2()
        {
            int a = 10;
            int a1 = 10;
            int a2 = 10;
            int a3 = 10;
            int a4 = 10;
            int a5 = 10;
            int a6 = 10;
            int a7 = 10;
            int a8 = 10;
            //int a9 = 10;
        }
    }
}
