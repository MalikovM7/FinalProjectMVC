﻿using FinalProjectMVC.Areas.Identity.Data;
using FinalProjectMVC.Configurations;
using FinalProjectMVC.Data.Configurations;
using FinalProjectMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Org.BouncyCastle.Asn1.Ess;
using System.Reflection.Emit;

namespace FinalProjectMVC.Areas.Identity.Data;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {

    }

    public DbSet<AppUser> Users { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<Payment> Payments { get; set; }

    public DbSet<FAQ> FAQS { get; set; }

    public DbSet<Feature> Features { get; set; }

    public DbSet<Statistic> Statistics { get; set; }

    public DbSet<DriverLicense> DriverLicenses { get; set; }

    public DbSet<HomePreview> HomePreviews { get; set; }

    public DbSet<AboutUsViewModel> AboutUsViewModels { get; set; }



    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new UserConfiguration());
        builder.ApplyConfiguration(new CarConfiguration());
        builder.ApplyConfiguration(new BlogPostConfiguration());
        builder.ApplyConfiguration(new ContactFormConfiguration());
        builder.ApplyConfiguration(new FAQConfiguration());
        builder.ApplyConfiguration(new FeatureConfiguration());
        builder.ApplyConfiguration(new DriverLicenseConfiguration());
        builder.ApplyConfiguration(new ReservationConfiguration());
        builder.ApplyConfiguration(new StatisticConfiguration());
        

    }
}


