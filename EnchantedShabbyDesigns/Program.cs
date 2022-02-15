using Esd;

var builder = WebApplication.CreateBuilder();

// builder.Host.UseSerilog();

builder.Services.AddSecurity();
builder.Services.AddResponseCompression();
builder.Services.AddControllersWithViews();
// builder.Services.AddControllers().AddJsonOptions().AddAuthorizationPolicy();
// builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSpa();
// builder.Services.AddContext();
// builder.Services.AddServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// app.UseException();
// app.UseHttps();
app.UseRouting();
app.UseResponseCompression();
app.UseAuthentication();
app.UseAuthorization();
// app.UseEndpointsMapControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.UseSpa();

app.Run();
