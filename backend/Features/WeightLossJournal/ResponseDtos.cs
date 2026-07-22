namespace LiuwiTools.Api.Features.WeightLossJournal
{
    public class WeightLossEntryResponseDto
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal Weight { get; set; }
        public string? Notes { get; set; }
    }
}