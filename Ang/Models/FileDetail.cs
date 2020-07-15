using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ang.Models
{
    public class FileDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string FileSha256 { get; set; }
        public ShaPathDetail ShaPathDetail { get; set; }
    }
}
