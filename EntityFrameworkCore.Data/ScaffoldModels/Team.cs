﻿using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Data.ScaffoldModels;

public partial class Team
{
    public int TeamId { get; set; }

    public string? Name { get; set; }

    public DateTime CreateDate { get; set; }
}
