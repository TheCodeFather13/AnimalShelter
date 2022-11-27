using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Plugins.DataAnimals.Sql.Repositories;
using Plugins.DataAnimals.Sql.Repositories.Repositories;
using UseCases.AnimalUseCase;
using UseCases.AnimalUseCasesInterfaces;
using UseCases.CategoriesUseCases;
using UseCases.DataAnimalsPluginInterfaces;
using UseCases.UseCasesInterfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContext<AnimalShelterDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Dependency injection In memory data store
builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

// Category UseCase
builder.Services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCase>();
builder.Services.AddTransient<IAddCategoryUseCase, AddCategoryUseCase>();
builder.Services.AddTransient<IEditCategoryUseCase, EditCategoryUseCase>();
builder.Services.AddTransient<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();
builder.Services.AddTransient<IDeleteCategoryUseCase, DeleteCategoryUseCase>();

// Animal UseCase
builder.Services.AddTransient<IAddAnimalUseCase, AddAnimalUseCase>();
builder.Services.AddTransient<IViewAnimalsUseCase, ViewAnimalsUseCase>();
builder.Services.AddTransient<IDeleteAnimalUseCase, DeleteAnimalUseCase>();
builder.Services.AddTransient<IEditAnimalUseCase, EditAnimalUseCase>();
builder.Services.AddTransient<IGetAnimalByIdUseCase, GetAnimalByIdUseCase>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
