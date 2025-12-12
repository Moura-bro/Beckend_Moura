using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Crud.Models;

[Table("Aluno")]
public partial class Aluno
{
    [Key]
    [Column("Id_Aluno")]
    public int Id_Aluno { get; set; }

    [StringLength(255)]
    public string Nome { get; set; } = null!;

    public int Idade { get; set; }

    [StringLength(255)]
    public string Ra { get; set; } = null!;

    [Column("CPF")]
    [StringLength(14)]
    [Unicode(false)]
    public string CPF { get; set; } = null!;
}
