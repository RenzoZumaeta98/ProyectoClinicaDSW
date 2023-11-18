using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolClinicaHealth.DataAccess.Entities
{
    [Table("MotivoCitaAplazada")]
    public class MotivoCitaAplazadaEntity
    {
        [Key]
        public int IdMotivoAplazo { get; set; }
        public string NombreMotivoAplazo { get; set; }
    }
}
