using System;
using System.Collections.Generic;

namespace Movies.WebClient.EntityData.EntityModels;

public partial class MovieCast
{
    public int? MovId { get; set; }

    public int? ActId { get; set; }

    public string? Role { get; set; }

    public int CastId { get; set; }

    public virtual Actor? Act { get; set; }

    public virtual Movie? Mov { get; set; }
}
