using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Sandbox.Data;
using Soenneker.Blazor.FilePond;
using Soenneker.Blazor.FilePond.Registrars;
using Soenneker.Blazor.TomSelect;
using Soenneker.Blazor.TomSelect.Registrars;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using ApexCharts;
using Index1;
using Analytics;
using Ecommerce;
using Crm;
using Hrm;
using Nft;
using Crypto;
using Jobs;
using Projects;
using Courses;
using Stocks;
using Medical;
using POSSystem;
using PodCast;
using School;
using Social;
using JonoTest;

using CartData;
using OrderdetailsData;
using OrdersData;
using ProductsData;
using ProjectData;
using TasksData;
using JobData;
using NftData;
using CrmData;
using CryptoData;

using BlogData;
using ChatData;
using MailData;
using FaqsData;
using FilemanagerData;
using InvoiceData;
using PricingData;
using ProfileData;
using ReviewsData;
using SearchData;
using TeamData;
using TimelineData;
using TodoData;
using LandingData;

using ButtonData;
using AlertData;
using BadgeData;
using DropdownData;
using ListGroupData;
using PopoversData;
using TooltipData;
using ProgressData;
using ToastData;

using LineData;
using AreaData;
using ColumnData;
using BarData;
using MixedChartData;
using RangeChartData;
using TimelineChartData;
using FunnelData;
using CandlestickData;
using BoxplotData;
using ScatterData;
using HeatmapData;
using TreemapData;
using PieChartData;
using RadialChartData;
using RadarChartData;
using PolarChartData;
using SlopeChartData;

using TablesData;
using DataTablesData;

using WidgetData;
using IconsData;

using AvatarData;
using BorderData;
using ColorsData;

using OffcanvasData;
using AccordionData;
using Sandbox.Helpers;
using Sandbox.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<AppState>();
builder.Services.AddScoped<StateService>();
builder.Services.AddScoped<IActionService, ActionService>();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddWMBOS();
builder.Services.AddFilePond();
builder.Services.AddTomSelect();
builder.Services.AddWMBSC(); 
builder.Services.AddSweetAlert2();
builder.Services.AddScoped<MenuDataService>();
builder.Services.AddScoped<MenuDataServiceSandbox>();
builder.Services.AddScoped<LandingMenuDataService>();
builder.Services.AddScoped<NavScrollService>();
builder.Services.AddSession();
builder.Services.AddScoped<SessionService>();

builder.Services.AddScoped<RiskReviewService>();
builder.Services.AddScoped<WindowpaneService>();
builder.Services.AddScoped<Sandbox.Services.PricingService>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<ReservingService>();
builder.Services.AddScoped<ReportingService>();
builder.Services.AddScoped<ORIService>();
builder.Services.AddScoped<CookieManager>();

//Dashboards Start//
builder.Services.AddScoped<Index1Service>();
builder.Services.AddScoped<AnalyticsService>();
builder.Services.AddScoped<EcommerceService>();
builder.Services.AddScoped<CrmService>();
builder.Services.AddScoped<HrmService>();
builder.Services.AddScoped<NftService>();
builder.Services.AddScoped<CryptoService>();
builder.Services.AddScoped<JobsService>();
builder.Services.AddScoped<ProjectsService>();
builder.Services.AddScoped<CoursesService>();
builder.Services.AddScoped<StocksService>();
builder.Services.AddScoped<MedicalService>();
builder.Services.AddScoped<POSSystemService>();
builder.Services.AddScoped<PodCastService>();
builder.Services.AddScoped<SchoolService>();
builder.Services.AddScoped<SocialService>();
builder.Services.AddScoped<JonoTestService>();
//Dashboards End//

//Apps Start//
builder.Services.AddScoped<CartService>();
builder.Services.AddScoped<OrderdetailsService>();
builder.Services.AddScoped<OrdersService>();
builder.Services.AddScoped<ProductsService>();
builder.Services.AddScoped<ProjectService>();
builder.Services.AddScoped<TasksService>();
builder.Services.AddScoped<JobService>();
builder.Services.AddScoped<NftDataService>();
builder.Services.AddScoped<CrmDataService>();
builder.Services.AddScoped<CryptoDataService>();
//Apps End//

//Pages Start//
builder.Services.AddScoped<BlogService>();
builder.Services.AddScoped<ChatService>();
builder.Services.AddScoped<MailService>();
builder.Services.AddScoped<FaqsService>();
builder.Services.AddScoped<FilemanagerService>();
builder.Services.AddScoped<InvoiceService>();
builder.Services.AddScoped<PricingData.PricingService>();
builder.Services.AddScoped<ProfileService>();
builder.Services.AddScoped<ReviewsService>();
builder.Services.AddScoped<SearchService>();
builder.Services.AddScoped<TeamService>();
builder.Services.AddScoped<TimelineService>();
builder.Services.AddScoped<TodoService>();
builder.Services.AddScoped<LandingService>();
//Pages End//

//Charts Start//
builder.Services.AddScoped<LineService>();
builder.Services.AddScoped<AreaService>();
builder.Services.AddScoped<ColumnService>();
builder.Services.AddScoped<BarService>();
builder.Services.AddScoped<MixedChartService>();
builder.Services.AddScoped<RangeChartService>();
builder.Services.AddScoped<TimelineChartService>();
builder.Services.AddScoped<FunnelService>();
builder.Services.AddScoped<CandlestickService>();
builder.Services.AddScoped<BoxplotService>();
builder.Services.AddScoped<ScatterService>();
builder.Services.AddScoped<HeatmapService>();
builder.Services.AddScoped<TreemapService>();
builder.Services.AddScoped<PieChartService>();
builder.Services.AddScoped<RadialChartService>();
builder.Services.AddScoped<RadarChartService>();
builder.Services.AddScoped<PolarChartService>();
builder.Services.AddScoped<SlopeChartService>();
//Charts End//

builder.Services.AddScoped<TablesService>();
builder.Services.AddScoped<DataTablesService>();
builder.Services.AddScoped<WidgetService>();
builder.Services.AddScoped<IconsService>();

//Utilites Start//
builder.Services.AddScoped<AvatarService>();
builder.Services.AddScoped<BorderService>();
builder.Services.AddScoped<ColorsService>();
//Utilites End//

//Advanced Ui Start//
builder.Services.AddScoped<OffcanvasService>();
builder.Services.AddScoped<AccordionService>();
//Advanced Ui End//


//UI Elements Start//
builder.Services.AddScoped<ButtonsService>();
builder.Services.AddScoped<AlertService>();
builder.Services.AddScoped<BadgesService>();
builder.Services.AddScoped<DropdownsService>();
builder.Services.AddScoped<ListGroupService>();
builder.Services.AddScoped<PopoversService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ProgressService>();
builder.Services.AddScoped<ToastService>();
//UI Elements End//

// Add session services
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Adjust timeout as needed
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddHttpContextAccessor();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/login";
        options.AccessDeniedPath = "/accessdenied";
        options.Cookie.Name = "YourAppCookieName";
        options.Cookie.HttpOnly = true;
        options.Cookie.SameSite = SameSiteMode.Strict;
        options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseSession();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.UseAuthentication();
app.UseAuthorization();

app.MapFallbackToPage("/_Host");

app.Run();
