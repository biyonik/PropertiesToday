using System.Linq.Expressions;
using Application.Repositories;
using Domain;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories;

public class PropertyRepository: IPropertyRepository
{
    private readonly ApplicationDbContext _context;

    public PropertyRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> AddAsync(Property property, CancellationToken cancellationToken = default)
    {
        await _context.Properties.AddAsync(property, cancellationToken);
        var result = await _context.SaveChangesAsync(cancellationToken);
        
        return result > 0;
    }

    public async Task UpdateAsync(Property property, CancellationToken cancellationToken = default)
    {
        _context.Update(property);
        
    }

    public Task DeleteAsync(Property property, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<Property>> GetAllAsync(Expression<Func<Property, bool>>? filter = null, Func<IQueryable<Property>, IOrderedQueryable<Property>>? orderBy = null, bool includeProperties = false,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Property> GetByIdAsync(Guid propertyId, bool includeProperties = false, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}