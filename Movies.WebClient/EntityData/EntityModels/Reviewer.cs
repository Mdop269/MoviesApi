using System;
using System.Collections.Generic;

namespace Movies.WebClient.EntityData.EntityModels;

public partial class Reviewer
{
    public int RevId { get; set; }

    public string? RevName { get; set; }

    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();
}
