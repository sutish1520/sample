using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NoteService.Models;

namespace NoteService.Context
{
    public class NoteDbContext : DbContext
    {
        public NoteDbContext(DbContextOptions<NoteDbContext> options)
            : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }

}
