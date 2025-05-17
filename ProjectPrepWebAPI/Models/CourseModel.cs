using System;
using System.Collections.Generic;

namespace ProjectPrepWebAPI.Models;

public partial class CourseModel
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public int UserId { get; set; }

    public virtual UserModel User { get; set; } = null!;
}
