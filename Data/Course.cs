using System;
using System.Collections.Generic;

namespace SchoolManagementAppMVC.Data;

public partial class Course
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Code { get; set; }

    public string LastName { get; set; } = null!;
}
