using Microsoft.AspNetCore.Identity;

namespace StoreApi.Models;

public class ApplicationUser : IdentityUser
{
    // Additional profile data can be added here
    public string? PhotoUrl { get; set; }
}
