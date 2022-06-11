using PttAppAPI.Domain.Entity.Common;

namespace PttApp.Domain.Entities;

public class AccountPageItemLogined : BaseEntity
{
    public string? Title { get; set; }
    public string? ImageSource { get; set; }
}
