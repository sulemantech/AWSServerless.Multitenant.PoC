﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitenant.Infrastructure.Contexts
{
    public abstract class BaseEntity
    {
        public int Id { get; private set; }

    }
}
