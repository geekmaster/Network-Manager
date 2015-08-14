﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib.Sync
{
    public class ExceptionEventArgs : EventArgs
    {
        public Exception Exception;

        public ExceptionEventArgs(Exception e)
        {
            this.Exception = e;
        }
    }
}
