﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.Response
{
    public class TareaResponse
    {
        public int IdTarea { get; set; }
        public string NameTarea { get; set; }
        public string DescriptionTarea { get; set; }
        public bool IsCompleted { get; set; }
    }
}
