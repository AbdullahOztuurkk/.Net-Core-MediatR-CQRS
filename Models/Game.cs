using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMediatRExample.Models
{
    public class Game : IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate => DateTime.Now;
        public GenreType Genre { get; set; }
    }

    public enum GenreType
    {
        Action = 0,
        Indie,
        Horror,
        Adventure,
        Survival,
        Puzzle,
        FPS
    }
}
