﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class NumGenerator2:INumGenerator2
    {
        private readonly INumGenerator numGenerator;

        public int RandomValue { get; }
        public NumGenerator2(INumGenerator NumGenerator)
        {
            RandomValue = new Random().Next(1000);//NumGenerator 2 oluşturulduğunda tetiklenen özellik
            numGenerator = NumGenerator;
        }

        public int GetNumGeneratorRandomNumber()
        {
            return numGenerator.RandomValue;
        }
    }

    public interface INumGenerator2
    {
        public int RandomValue { get; }

        public int GetNumGeneratorRandomNumber();
    }
}
