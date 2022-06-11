using PttAppAPI.Domain.Entity.Common;

namespace PttApp.Domain.Entities;

public class MainCategory : BaseEntity
{
    public string? Title { get; set; }
    public string? IconSource { get; set; }
}
