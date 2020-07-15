﻿using System.Collections.Generic;

namespace MosesApi77.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Description { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}