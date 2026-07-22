using LiuwiTools.Api.Entities;
using LiuwiTools.Api.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace LiuwiTools.Api.Features.WeightLossJournal
{
    public class WeightLossJournalHandler (AppDbContext db)
    {
        public async Task<List<WeightEntry>> GetAllEntries()
            => await db.WeightEntries.OrderByDescending(e => e.Timestamp).ToListAsync();

        public async Task InsertEntry(WeightLossEntryPostRequestDto request)
        {
            db.WeightEntries.Add(new WeightEntry
            {
                Id = Guid.NewGuid(),
                Timestamp = request.Timestamp,
                Weight = request.Weight,
                Notes = request.Notes,
            });
            await db.SaveChangesAsync();
        }
    }
}