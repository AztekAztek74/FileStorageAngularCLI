﻿using Ang.Models;
using Microsoft.EntityFrameworkCore;


namespace WebAPI.Models
{
    public class FileDetailContext : DbContext
    {
        public FileDetailContext(DbContextOptions<FileDetailContext> options) : base(options)
        {
        }
        public DbSet<FileDetail> FileDetails { get; set; }
        public DbSet<ShaPathDetail> ShaPathDetails { get; set; }
    }
}
