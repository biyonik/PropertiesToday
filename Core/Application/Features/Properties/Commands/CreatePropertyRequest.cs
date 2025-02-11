using Application.Models;
using Application.Repositories;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.Properties.Commands;

public abstract record CreatePropertyRequest(NewPropertyRequest PropertyRequest) : IRequest<bool>
{ }

public class CreatePropertyRequestHandler : IRequestHandler<CreatePropertyRequest, bool>
{
    private readonly IPropertyRepository _propertyRepository;
    private readonly IMapper _mapper;

    public CreatePropertyRequestHandler(IPropertyRepository propertyRepository, IMapper mapper)
    {
        _propertyRepository = propertyRepository;
        _mapper = mapper;
    }

    public async Task<bool> Handle(CreatePropertyRequest request, CancellationToken cancellationToken)
    {
        var property = _mapper.Map<Property>(request.PropertyRequest);
        await _propertyRepository.AddAsync(property, cancellationToken);
        return true;
    }
}