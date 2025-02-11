namespace Domain;

public sealed record Image
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Path { get; set; }
    public bool IsUploaded { get; set; }

    public Guid PropertyId { get; set; }
    public required Property Property { get; set; }
}