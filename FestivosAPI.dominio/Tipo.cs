using System.ComponentModel.DataAnnotations.Schema;

namespace FestivosAPI.dominio
{
    [Table("Tipo")]
    public class Tipo
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Tipo")]
        public required string Tiposnombre { get; set; }
    }
}
