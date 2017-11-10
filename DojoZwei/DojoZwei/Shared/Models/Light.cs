﻿using Shared.BaseModels;
using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Light : BaseActuator
    {
        public Light(string name, string description, string room, int id) : base(name, description, id, room, typeof(bool))
        {

        }
    }
}
