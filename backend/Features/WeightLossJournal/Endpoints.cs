using Microsoft.AspNetCore.Http.HttpResults;

namespace LiuwiTools.Api.Features.WeightLossJournal
{
    public static class WeightLossJournalEndpoints
    {
        public static void Map(RouteGroupBuilder group)
        {
            group.MapGet("/", GetWeightLossJournal);
            group.MapPut("/", PostNewWeightEntry);
        }

        private static async Task<Ok<List<WeightLossEntryResponseDto>>> GetWeightLossJournal(WeightLossJournalHandler handler)
        {
            var entries = await handler.GetAllEntries();

            var response = entries.Select(x => new WeightLossEntryResponseDto
            {
                Id = x.Id,
                Timestamp = x.Timestamp, 
                Weight = x.Weight, 
                Notes = x.Notes,
            }).ToList();

            return TypedResults.Ok(response);
        }

        private static async Task<Ok> PostNewWeightEntry(WeightLossEntryPostRequestDto request, WeightLossJournalHandler handler)
        {
            await handler.InsertEntry(request);
            return TypedResults.Ok();
        }
    }
}