using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using Microsoft.EntityFrameworkCore;
using Plugins.DataAnimals.Sql.Repositories;
using Plugins.DataAnimals.Sql.Repositories.Repositories;
using UseCases.AnimalUseCase;
using UseCases.AnimalUseCasesInterfaces;
using UseCases.CategoriesUseCases;
using UseCases.DataAnimalsPluginInterfaces;
using UseCases.UseCasesInterfaces;
using Microsoft.AspNetCore.Identity;
using UseCases.ClientOrderUseCasesInterfaces;
using UseCases.ClientOrderUseCase;
using UseCases.SectionUseCasesInterfaces;
using UseCases.SectionUseCase;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContext<AnimalShelterDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
    
builder.Services
    .AddDefaultIdentity<IdentityUser>().AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AnimalShelterDbContext>(); 

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<AnimalsWebAppContext>();

// Dependency injection In memory data store
builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IClientOrderRepository, ClientRepository>();
builder.Services.AddScoped<ISectionRepository, SectionRepository>();

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

// ClientOrder UseCase
builder.Services.AddTransient<IAddClientOrderUseCase, AddClientOrderUseCase>();
builder.Services.AddTransient<IRemoveClientOrderUseCase, RemoveClientOrderUseCase>();
builder.Services.AddTransient<IGetClientOrderByIdUseCase, GetClientOrderByIdUseCase>();
builder.Services.AddTransient<IViewClientOrderUseCase, ViewClientOrderUseCase>();
builder.Services.AddTransient<IEditClientOrderUseCase, EditClientOrderUseCase>();
builder.Services.AddTransient<IGetClientOrderCountUseCase, GetClientOrderCountUseCase>();

// Section UseCase
builder.Services.AddTransient<IAddSectionUseCase, AddSectionUseCase>();
builder.Services.AddTransient<IDeleteSectionUseCase, DeleteSectionUseCase>();
builder.Services.AddTransient<IGetSectionByIdUseCase, GetSectionByIdUseCase>();
builder.Services.AddTransient<IViewSectionsUseCase, ViewSectionsUseCase>();
builder.Services.AddTransient<IEditSectionUseCase, EditSectionUseCase>();
builder.Services.AddTransient<IViewSectionUseCase, ViewSectionUseCase>();

// Register Blazorise.Bootstrap, fontawesome
builder.Services.AddBlazorise(options => { options.Immediate = true; })
    .AddBootstrap5Providers()
    .AddFontAwesomeIcons();

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization(); 

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
