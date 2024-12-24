using System;
using System.Collections.Generic;

namespace Movies.DataServices.EntityData.EntityModels;

public partial class Director
{
    public int DirId { get; set; }

    public string? DirFname { get; set; }

    public string? DirLname { get; set; }

    public virtual ICollection<MovieDirection> MovieDirections { get; set; } = new List<MovieDirection>();
}
