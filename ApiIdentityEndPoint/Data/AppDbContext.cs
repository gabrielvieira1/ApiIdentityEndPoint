using ApiIdentityEndPoint.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiIdentityEndPoint.Data
{
  public class AppDbContext(DbContextOptions options) : IdentityDbContext<User>(options);
}
