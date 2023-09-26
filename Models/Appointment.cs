using System.ComponentModel.DataAnnotations;
namespace HilarysHairCare.Models;

public class Appointment
{
    public int Id {get;set;}
    [Required]
    public int StylistId {get;set;}
    [Required]
    public int CustomerId {get;set;}
    [Required]
    public DateTime AppointmentTime {get;set;}
    [Required]
    public bool isActive {get;set;}
    public Stylist Stylist {get;set;}
    public Customer Customer {get;set;}
    public List<Service> Services {get;set;}
    public decimal? TotalPrice 
    {
        get 
        {
            return Services.Sum(s => s.Price);
        }
    }
}