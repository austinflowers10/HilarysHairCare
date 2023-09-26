using System.ComponentModel.DataAnnotations;
namespace HilarysHairCare.Models;

public class Customer 
{
    public int Id {get;set;}
    [Required]
    public string Name {get;set;}
    // public List<Appointment> Appointments {get;set;}
}