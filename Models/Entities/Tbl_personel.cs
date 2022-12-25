using System.ComponentModel.DataAnnotations;

public class Tbl_Personel
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    
    public string Family { get; set; }
    public string Gender { get; set; }
    public DateTime Birthday { get; set; }

   
    
    
    
    
    
    
}