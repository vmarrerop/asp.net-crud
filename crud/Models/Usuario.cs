﻿using System;
using System.Collections.Generic;

namespace crud.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? Edad { get; set; }

    public DateTime? Fecha { get; set; }
}
