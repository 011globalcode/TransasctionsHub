﻿using System;
using System.Collections.Generic;

namespace _011Global.Shared.JobsServiceDBContext.Entities;

public partial class GlobalJob
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsRunning { get; set; }

    public string Assembly { get; set; } = null!;

    public string TypeName { get; set; } = null!;

    public DateTime? LastStartDate { get; set; }

    public DateTime? LastStopDate { get; set; }

    public string? MachineNameList { get; set; }
}
