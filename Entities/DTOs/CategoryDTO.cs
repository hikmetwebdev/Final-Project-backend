﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CategoryDTO
    {
        public string Name { get; set; }
        public string? IconUrl { get; set; }
        public int? ParentCategoryId { get; set; }

    }
}
