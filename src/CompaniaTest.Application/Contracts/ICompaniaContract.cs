using System;
using CompaniaTest.Domain.Type;

namespace CompaniaTest.Application.Contracts;

public interface ICompaniaContract
{
    public Task<List<CompaniaType>>? GetCompanias();
}
