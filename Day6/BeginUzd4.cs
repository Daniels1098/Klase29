﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class BeginUzd4
    {
        public static int Factorial(int n)
        {
            return n > 0 ? n * Factorial(n - 1) : 1;
        }
    }
}
