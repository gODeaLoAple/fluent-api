﻿using System;

namespace ObjectPrinting.PrintingConfig
{
    public class BasePrintingConfig
    {
        protected static readonly Type[] FinalTypes =
        {
            typeof(int),
            typeof(double),
            typeof(float),
            typeof(string),
            typeof(DateTime),
            typeof(TimeSpan)
        };

        protected static readonly string NewLine = Environment.NewLine;
    }
}