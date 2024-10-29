using System;
using System.Security.Cryptography.X509Certificates;
using CompaniaTest.Application.Contracts;
using CompaniaTest.Domain.Model;
using CompaniaTest.Domain.Type;
using CompaniaTest.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CompaniaTest.Infraestructure.Repository;

public class CompaniaRepository : ICompaniaContract
{
    private readonly ILogger<CompaniaRepository> _logger;
    private readonly CompaniaContext _context;

    public CompaniaRepository(ILogger<CompaniaRepository> logger, CompaniaContext context) {
        _logger = logger;
        _context = context;
    }

    public async Task<List<CompaniaType>?> GetCompanias()
    {
        try
        {
            List<CompaniaModel>? model = await _context.Models.Where(x => x.Status == "A").ToListAsync();
            if(model is null ) throw new ArgumentException("No hay companias registradas");
            List<CompaniaType>? ListaCompanias = model.Select(x => new CompaniaType() { Name = x.Name, Detalles = x.Detalles, Id = x.Id, Status = x.Status}).ToList();
            return ListaCompanias;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            throw new Exception("Error: " + ex.Message);
        }
    }
}
