﻿using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tag:IEntity
    {
        public int Id { get; set; } 
        public string Name  { get; set; }
        public bool IsDeleted { get; set; }
    }
}
