using System;
using System.Collections.Generic;

namespace Movies.WebClient.EntityData.EntityModels;

public partial class Actor
{
    public int ActId { get; set; }

    public string? ActFname { get; set; }

    public string? ActLname { get; set; }

    public string? ActGender { get; set; }

    public virtual ICollection<MovieCast> MovieCasts { get; set; } = new List<MovieCast>();
}
