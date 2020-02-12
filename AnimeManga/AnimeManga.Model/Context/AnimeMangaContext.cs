using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeManga.Model.Context
{
    public class AnimeMangaContext : DbContext
    {
        public AnimeMangaContext(DbContextOptions<AnimeMangaContext> connString) : base(connString)
        {

        }
    }
}
