﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Programming_Example {
    internal class clsMyClass {

        private int m_intHeight;

        public long AddTwoNumbers(int intNumber1, int intNumber2)
        {
            return intNumber1 + intNumber2;
        }

        public int Height {
            get
            {
                return m_intHeight;
            }
            set
            {
                if (value >= 10)
                    m_intHeight = value;
            }
        }
    }
}
