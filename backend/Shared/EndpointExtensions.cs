using LiuwiTools.Api.Features.WeightLossJournal;

namespace LiuwiTools.Api.Shared
{
    public static class EndpointExtensions
    {
        public static void MapEndpoints(this WebApplication app)
        {
            var api = app.MapGroup("/api");
            var weightlossjournal = api.MapGroup("/weightlossjournal");
            WeightLossJournalEndpoints.Map(weightlossjournal);
        }
    }
}