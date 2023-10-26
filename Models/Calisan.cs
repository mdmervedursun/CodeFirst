public class Calisan
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public int DepartmanId { get; set; }
    public Departman Departman { get; set; }
    
    
    public CalisanAdresi CalisanAdresi{get;set;}
}