﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Add(args[1]??"");
        }
    }
}
