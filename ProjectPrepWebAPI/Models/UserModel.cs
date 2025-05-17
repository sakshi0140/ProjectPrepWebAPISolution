using System;
using System.Collections.Generic;

namespace ProjectPrepWebAPI.Models;

public partial class UserModel
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public virtual ICollection<CourseModel> CourseModels { get; set; } = new List<CourseModel>();
}
