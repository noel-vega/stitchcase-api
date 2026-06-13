namespace api;


static class Database
{

  public static string ResolveDbConnectionStringAsync(WebApplicationBuilder builder)
  {
    if (builder.Environment.IsDevelopment())
    {
      string connString = builder.Configuration.GetConnectionString("DefaultConnection")
        ?? throw new InvalidOperationException("ConnectionString:DefaultConnection not set.");

      return connString;
    }

    return "";
  }
}
