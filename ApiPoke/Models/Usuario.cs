using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiPoke.Models;

public partial class Usuario
{
    [Key]
    public int ID { get; set; }
    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Correo { get; set; }

    public byte[] Contraseña { get; set; }
}
