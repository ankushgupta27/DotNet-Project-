﻿using System;
using System.Collections.Generic;

namespace BlogMgmt.Data.Entities;

public partial class City
{
    public int Id { get; set; }

    public int StateId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public virtual State State { get; set; } = null!;

    public virtual ICollection<User> Users { get; } = new List<User>();
}
