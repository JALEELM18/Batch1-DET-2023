﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2023
{
    public class InvalidEmpIdException:Exception
    {
        public InvalidEmpIdException(string msg):base(msg)
        { 

        }
    }
}
