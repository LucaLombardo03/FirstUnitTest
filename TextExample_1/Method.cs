﻿using System;

namespace TextExample_1
{
    public class Method
    {
       public static bool Calcolo1( )
        {
            double a = 1.0 / 10.0;
            double s = a + a + a + a + a + a + a + a + a + a;
            if (s == 1)
                return true;
            else
            return false;
        }
        public static bool Calcolo2()
        {
            double a = 1.0 / 10.0;
            double s = a + a + a + a + a + a + a + a + a + a;
            if (s == 1)
                return false;
            else
                return true;
        }
    }
}
