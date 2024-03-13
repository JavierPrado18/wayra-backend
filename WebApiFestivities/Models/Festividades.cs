
namespace WebApiFestivities.Models
{
    public class Festividad
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Descripcion { get; set; }
        public required string ImgUrl { get; set; }
        public int? Dia { get; set; }
        public int? Mes { get; set; }
    }
}