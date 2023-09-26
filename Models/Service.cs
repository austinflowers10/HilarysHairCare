using System.ComponentModel.DataAnnotations;

namespace HilarysHairCare.Models;

public class Service
{
    public int Id {get;set;}
    [Required]
    public string Name {get;set;}
    [Required]
    public decimal Price {get;set;}
}