using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompaniaTest.Domain.Model;

[Table("Compania")]
public class CompaniaModel
{
    [Column("Id", TypeName = "int")]
    [Key]
    public int Id { get; set; }

    [Column("name", TypeName = "varchar(max)")]
    public string Name { get; set; } = null!;

    [Column("Detalles", TypeName = "varchar(max)")]
    public string Detalles { get; set; } = null!;

    [Column("Status", TypeName = "varchar(max)")]
    public string Status { get; set; } = null!;
}
