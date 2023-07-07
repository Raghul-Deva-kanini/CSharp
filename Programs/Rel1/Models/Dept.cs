﻿using System;
using System.Collections.Generic;

namespace Rel1.Models;

public partial class Dept
{
    public int Deptno { get; set; }

    public string? Deptname { get; set; }

    public virtual ICollection<Emp> Emps { get; set; } = new List<Emp>();
}
