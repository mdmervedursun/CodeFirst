using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CalisanAdresi
{
    [Key, ForeignKey(nameof(Calisan))]
    public int Id { get; set; }
    public string Adres { get; set; }
    public Calisan Calisan { get; set; }
}