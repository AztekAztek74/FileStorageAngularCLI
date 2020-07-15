﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ang.Models
{
    public class ShaPathDetail
    {
        [Key]
        public string FileSha256 { get; set; }
        public string FilePath { get; set; }

        public ICollection<FileDetail> FileDetails { get; set; }
    }
}
