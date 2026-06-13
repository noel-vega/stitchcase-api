var builder = WebApplication.CreateBuilder(args);


const string CorsPolicy = "spa";

builder.Services.AddCors(options =>
{
  options.AddPolicy(
      CorsPolicy,
      policy =>
          policy
              .WithOrigins("http://localhost:5173") // your React origin
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials()
  ); // needed if you send the refresh cookie
});

var app = builder.Build();

app.UseCors(CorsPolicy);


app.MapGet("/", () => "Hello World!");

app.MapPost("/auth/signup", () =>
{
  Console.WriteLine("");
}
);

app.Run();
