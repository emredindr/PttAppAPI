﻿using PttAppAPI.Domain.Entity.Common;

namespace PttApp.Domain.Entities;

public class AccountPageItem : BaseEntity
{
    public string? Title { get; set; }       
    public string? Url { get; set; }
    
}
