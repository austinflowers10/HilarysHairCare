using Microsoft.EntityFrameworkCore;
namespace HilarysHairCare.Models;

public class HilarysHairCareDbContext : DbContext
{
    public DbSet<Stylist> Stylists {get;set;}
    public DbSet<Customer> Customers {get;set;}
    public DbSet<Service> Services {get;set;}
    public DbSet<Appointment> Appointments {get;set;}
    public DbSet<AppointmentService> AppointmentServices {get;set;}
    public HilarysHairCareDbContext(DbContextOptions<HilarysHairCareDbContext> context) : base(context)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Stylist>().HasData(new Stylist[]
        {
            new Stylist {Id = 1, Name = "Sheila Robinson", isActive = true},
            new Stylist {Id = 2, Name = "Martha Johnson", isActive = true},
            new Stylist {Id = 3, Name = "Lashonda Smith", isActive = true},
            new Stylist {Id = 4, Name = "Mary McLemore", isActive = false},
            new Stylist {Id = 5, Name = "Billy Martin", isActive = false}
        });
        modelBuilder.Entity<Customer>().HasData(new Customer[]
        {
            new Customer {Id = 1, Name = "Bradley Hasselhoff"},
            new Customer {Id = 2, Name = "Matthew Miller"},
            new Customer {Id = 3, Name = "Leslie Smith"},
            new Customer {Id = 4, Name = "Betty Mathis"},
            new Customer {Id = 5, Name = "James Jameson"}
        });
        modelBuilder.Entity<Service>().HasData(new Service[]
        {
            new Service {Id = 1, Name = "Haircut", Price = 15.00M},
            new Service {Id = 2, Name = "Hair Wash", Price = 5.00M},
            new Service {Id = 3, Name = "Hair Color", Price = 50.00M},
            new Service {Id = 4, Name = "Beard Trim", Price = 10.00M},
            new Service {Id = 5, Name = "Beard Wash", Price = 5.00M}
        });
        modelBuilder.Entity<Appointment>().HasData(new Appointment[]
        {
            new Appointment {Id = 1, StylistId = 1, CustomerId = 5, AppointmentTime = new DateTime(2023, 09, 27, 1, 0, 0), isActive = true},
            new Appointment {Id = 2, StylistId = 2, CustomerId = 4, AppointmentTime = new DateTime(2023, 09, 27, 2, 0, 0), isActive = true},
            new Appointment {Id = 3, StylistId = 3, CustomerId = 3, AppointmentTime = new DateTime(2023, 09, 27, 3, 0, 0), isActive = true},
            new Appointment {Id = 4, StylistId = 4, CustomerId = 2, AppointmentTime = new DateTime(2023, 09, 27, 4, 0, 0), isActive = true},
            new Appointment {Id = 5, StylistId = 5, CustomerId = 1, AppointmentTime = new DateTime(2023, 09, 27, 5, 0, 0), isActive = true},
            new Appointment {Id = 6, StylistId = 5, CustomerId = 1, AppointmentTime = new DateTime(2023, 09, 27, 6, 0, 0), isActive = false}
        });
        modelBuilder.Entity<AppointmentService>().HasData(new AppointmentService[]
        {
            new AppointmentService {Id = 1, AppointmentId = 1, ServiceId = 4},
            new AppointmentService {Id = 2, AppointmentId = 1, ServiceId = 5},
            new AppointmentService {Id = 3, AppointmentId = 2, ServiceId = 1},
            new AppointmentService {Id = 4, AppointmentId = 2, ServiceId = 2},
            new AppointmentService {Id = 5, AppointmentId = 3, ServiceId = 1},
            new AppointmentService {Id = 6, AppointmentId = 3, ServiceId = 2},
            new AppointmentService {Id = 7, AppointmentId = 3, ServiceId = 3},
            new AppointmentService {Id = 8, AppointmentId = 4, ServiceId = 1},
            new AppointmentService {Id = 9, AppointmentId = 4, ServiceId = 4},
            new AppointmentService {Id = 10, AppointmentId = 5, ServiceId = 1},
            new AppointmentService {Id = 11, AppointmentId = 6, ServiceId = 3}
        });
    }
}