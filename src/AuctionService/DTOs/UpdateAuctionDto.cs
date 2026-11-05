namespace AuctionService.DTOs;

public class UpdateAuctionDto
{
    public string? Make { get; set; }
    public string? Model { get; set; }
    public string? Description { get; set; }
    public int? Year { get; set; }
    public string? Color { get; set; }
    public string? Mileage { get; set; }
}