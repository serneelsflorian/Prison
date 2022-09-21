﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stoelendans.Contracts.Commands
{
    public class CommandBase<T> : IRequest<T> where T : class
    {

    }
}
