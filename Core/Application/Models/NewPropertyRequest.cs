namespace Application.Models;

public class NewPropertyRequest
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required string Type { get; set; }
    public required string ErfSize { get; set; }
    public required string FloorSize { get; set; }
    public decimal Price { get; set; }
    public decimal Levies { get; set; }
    public decimal Rates { get; set; }
    public string? Address { get; set; }
    public bool PetsAllowed { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int Kitchens { get; set; }
    public int Louge { get; set; }
    public int Dining { get; set; }
    public DateTime ListDate { get; set; }
}