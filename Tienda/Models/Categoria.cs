using System.ComponentModel.DataAnnotations;

namespace Tienda.Models
{
    public class Categoria
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la categoria es obligatorio")]
        public string NombreCategoria { get; set; }


        [Required(ErrorMessage ="Mostrar el numero de orden es Requerido")]
        [Range(1,int.MaxValue, ErrorMessage ="Ingrese el valor mayor a 0")]
        public int MostrarOrden { get; set; }
    }
}
