using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Net;
using System.Reflection;
using TechnicalServiceBusiness.Abstract;
using TechnicalServiceBusiness.Concrete;
//using TechnicalServiceCore.Security.Encyrption;

using TechnicalServiceDataAccess;
using TechnicalServiceDataAccess.Abstract;
using TechnicalServiceDataAccess.Concrete;
using TechnicalServiceDataAccess.Repository;
using TechnicalServiceEntity.Entity;
using TechnicalServiceEntity.Security.Encyrption;
using TechnicalServiceEntity.Security.JWT;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddDbContext<EfContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<EfContext>().AddDefaultTokenProviders();
builder.Services.AddScoped<IAuthService,AuthManager>();
var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOption>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidIssuer = tokenOptions.Issuer,
            ValidAudience = tokenOptions.Audience,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
        };
    });

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

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
