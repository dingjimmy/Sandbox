/// <summary>
/// To smooth out the developer experience, we are using asp.net core (i.e. Kestrel) to 
/// serve static files when debugging in visual studio. In production and QA environments, 
/// a dedicated web server such as IIS, Apache or NGNIX is used. 
/// </summary>

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();
