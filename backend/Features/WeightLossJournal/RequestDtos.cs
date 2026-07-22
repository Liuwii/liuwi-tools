namespace LiuwiTools.Api.Features.WeightLossJournal
{
    public class WeightLossEntryPostRequestDto
    {
        public DateTime Timestamp { get; set; }
        public decimal Weight { get; set; }
        public string? Notes { get; set; }
    }
}