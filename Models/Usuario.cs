﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_exe7.Models
{
    public class Usuario
    {
        
        [Key]
        public int id { get; set; }
        public string Nome { get; set; }
    }
}
