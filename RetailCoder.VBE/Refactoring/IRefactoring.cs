﻿using Microsoft.Vbe.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubberduck.Refactoring
{
    internal interface IRefactoring
    {
        void Refactor(CodeModule module);
    }
}