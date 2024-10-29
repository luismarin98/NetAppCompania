using System;

namespace CompaniaTest.Domain.Type;

public class CompaniaType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Detalles { get; set; } = null!;

    public string Status { get; set; } = null!;
}
