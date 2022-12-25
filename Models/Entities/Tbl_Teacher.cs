using System.ComponentModel.DataAnnotations;

public class Tbl_Teacher
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    
    public string Family { get; set; }
    public string Gender { get; set; }
    public DateTime Birthday { get; set; }

    public string Calss { get; set; }
    
    
    
    
    
    
}