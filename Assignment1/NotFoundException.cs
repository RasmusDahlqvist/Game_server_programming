﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class NotFoundException: Exception
    {
        public NotFoundException(string message): base(message)
        {
        }
    }
}
