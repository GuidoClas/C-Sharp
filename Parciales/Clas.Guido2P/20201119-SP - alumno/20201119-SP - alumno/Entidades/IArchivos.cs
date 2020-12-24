﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IArchivos<X>
    {
        void Guardar(X info);

        X Leer();
    }
}
