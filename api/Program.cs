using api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//What is CORS
//CORS stans for Cross-Origin Resource Sharing
//you can think of "origin" as our protocal + port like http://127.0.0.1:5500
//Only browser check cors, postman ignores it
builder.Services.AddScoped<IAddingServices, AddingServices>();
builder.Services.AddScoped<IComparingServices, ComparingServices>();
builder.Services.AddScoped<IHelloServices, HelloServices>();
builder.Services.AddScoped<IMagicServices, MagicServices>();
builder.Services.AddScoped<IFoodServices, FoodServices>();
builder.Services.AddScoped<IMadLibServices, MadLibServices>();


builder.Services.AddCors(options =>
{
    //We must name our Policy so we can call it within our app
    options.AddPolicy("Frontend", policy =>
    {

        //Here we are going to let our app know which
        //Origins and request methods are allow
        policy.AllowAnyOrigin()
        //Allows any request header like Content-Type
        .AllowAnyHeader()
        //Allows any Http Method: GET, POST, PUT, DELETE
        .AllowAnyMethod();   
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("Frontend");

app.MapControllers();

app.Run();
