using ImageHandling;
using ImageHandling.Controllers;
using ImageHandling.Plugin;
using System.Drawing;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

ImageProcessor imageProcessor = new ImageProcessor();
imageProcessor.AddPlugin(new ResizePlugin());

Bitmap image = new Bitmap("example");

var effects = new List<(IImagePlugin, object[])>
{
     (new ResizePlugin(), new object[] { 100 }),
};

imageProcessor.ProcessImages(new List<(Bitmap, List<(IImagePlugin, object[])>)>
{
    (image, effects)
});

app.Run();




