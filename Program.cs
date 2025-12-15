using AccordionData;
using AlertData;
using Analytics;
using ApexCharts;
using AreaData;
using AvatarData;
using BadgeData;
using BarData;
using BlogData;
using BorderData;
using BoxplotData;
using ButtonData;
using CandlestickData;
using CartData;
using ChatData;
using ColorsData;
using ColumnData;
using Courses;
using Crm;
using CrmData;
using Crypto;
using CryptoData;
using CurrieTechnologies.Razor.SweetAlert2;
using DataTablesData;
using DropdownData;
using Ecommerce;
using FaqsData;
using FilemanagerData;
using FunnelData;
using HeatmapData;
using Hrm;
using IconsData;
using Index1;
using InvoiceData;
using JobData;
using Jobs;
using JonoTest;
using LandingData;
using LineData;
using ListGroupData;
using MailData;
using Medical;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using MixedChartData;
using Nft;
using NftData;
using OffcanvasData;
using OrderdetailsData;
using OrdersData;
using PieChartData;
using PodCast;
using PolarChartData;
using PopoversData;
using POSSystem;
using PricingData;
using ProductsData;
using ProfileData;
using ProgressData;
using ProjectData;
using Projects;
using RadarChartData;
using RadialChartData;
using RangeChartData;
using ReviewsData;
using Sandbox.Data;
using Sandbox.Helpers;
using Sandbox.Services;
using ScatterData;
using School;
using SearchData;
using SlopeChartData;
using Social;
using Soenneker.Blazor.FilePond;
using Soenneker.Blazor.FilePond.Registrars;
using Soenneker.Blazor.TomSelect;
using Soenneker.Blazor.TomSelect.Registrars;
using Stocks;
using System.Diagnostics;
using TablesData;
using TasksData;
using TeamData;
using TimelineChartData;
using TimelineData;
using ToastData;
using TodoData;
using TooltipData;
using TreemapData;
using WidgetData;
using static Sandbox.Services.WindowpaneService;

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
builder.Services.AddScoped<PrismService>();
builder.Services.AddScoped<FDWHReportingService>();
builder.Services.AddScoped<ExceptionService>();
builder.Services.AddScoped<CookieManager>();
builder.Services.AddScoped<CytoraCheckingFilterState>();

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

//Apps Start  //
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

builder.Services.AddHttpClient();
builder.Services.AddHttpContextAccessor();

// Authentication
builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
    .AddNegotiate();

builder.Services.AddAuthorization();

// do app context
var connString = builder.Configuration.GetConnectionString("DaleSandboxConnection");
var parsed = new SqlConnectionStringBuilder(connString);

// Override database server if running on DUWPMLSW03
if (Environment.MachineName.Equals("DUWPMLSW03", StringComparison.OrdinalIgnoreCase))
{
	parsed.DataSource = "DUWPMND06";

	// Override the config directly
	builder.Configuration["ConnectionStrings:DaleSandboxConnection"] = parsed.ConnectionString;
	Console.WriteLine($"[Startup] Overriding DB server to DUWPMND06 for {Environment.MachineName}");
}

var sandboxContext = new SandboxContext
{
	WebServerName = Environment.MachineName,
	DatabaseServer = parsed.DataSource,
	DatabaseName = parsed.InitialCatalog
};

builder.Services.AddSingleton(sandboxContext);

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

// adding username to app context
app.Use(async (context, next) =>
{
	var info = context.RequestServices.GetRequiredService<SandboxContext>();
	info.UserName = context.User?.Identity?.Name ?? "Unknown";
	await next.Invoke();
});

app.UseRouting();

app.MapBlazorHub();
app.UseAuthentication();
app.UseAuthorization();

app.MapFallbackToPage("/_Host");

app.MapGet("Windowpane/DownloadDFProformaExcelFile", (string policyRef, WindowpaneService windowpaneService) =>
{
	var fileContent = windowpaneService.GenerateDFProformaExcelFile(policyRef);
	var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
	var fileName = "DFProformaExcelFile.xlsx";

	return Results.File(fileContent, contentType, fileName);
});

app.Run();
