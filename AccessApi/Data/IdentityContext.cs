using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AccessApi.Data;

public class IdentityContext(DbContextOptions options) : IdentityDbContext(options)
{
}