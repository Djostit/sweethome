﻿using System;
using System.Collections.Generic;

namespace SweetHome.API.Data.Models;

public partial class User
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public byte[] Photo { get; set; } = null!;
}
