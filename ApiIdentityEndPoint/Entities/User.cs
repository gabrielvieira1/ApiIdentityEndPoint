using Microsoft.AspNetCore.Identity;

namespace ApiIdentityEndPoint.Entities
{
  public class User : IdentityUser
  {
    public string Document { get; set; } = string.Empty;
  }
}
