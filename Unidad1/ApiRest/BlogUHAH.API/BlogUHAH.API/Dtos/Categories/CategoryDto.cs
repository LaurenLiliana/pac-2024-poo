using System.ComponentModel.DataAnnotations;

namespace BlogUHAH.API.Dtos.Categories
{
    public class CategoryDto
    {
        public Guid Id { get; set; }

        //Data Annotations
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre de la categoria es requerido")]

        public string Name { get; set; }

        [Display(Name = "Descripcion")]
        [MinLength(10, ErrorMessage = "La {0} debe tener ral menos {1} caracteres")]
        public string Description { get; set; }

    
    }
}
