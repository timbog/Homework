﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    public interface IStack
    {
        void Push(int number);

        int Pop();
    }
}
