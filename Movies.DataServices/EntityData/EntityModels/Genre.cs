using System;
using System.Collections.Generic;

namespace Movies.DataServices.EntityData.EntityModels;

public partial class Genre
{
    public int GenId { get; set; }

    public string? GenTitle { get; set; }

    public virtual ICollection<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();
}
