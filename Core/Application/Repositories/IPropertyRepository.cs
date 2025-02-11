using System.Linq.Expressions;
using Domain;

namespace Application.Repositories;

public interface IPropertyRepository
{
    #region Writable Methods
    Task<bool> AddAsync(Property property,
        CancellationToken cancellationToken = default);
    Task UpdateAsync(
        Property property, 
        CancellationToken cancellationToken = default
        );
    Task DeleteAsync(
        Property property, 
        CancellationToken cancellationToken = default
        );
    #endregion
    
    #region Reading Methods
    Task<IReadOnlyCollection<Property>> GetAllAsync(
        Expression<Func<Property, bool>>? filter = null,
        Func<IQueryable<Property>, IOrderedQueryable<Property>>? orderBy = null,
        bool includeProperties = false,
        CancellationToken cancellationToken = default
    );
    Task<Property> GetByIdAsync(
        Guid propertyId,
        bool includeProperties = false,
        CancellationToken cancellationToken = default);
    #endregion
}