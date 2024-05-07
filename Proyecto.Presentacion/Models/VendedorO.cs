using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace Proyecto.Presentacion.Models
{
    public class VendedorO
    {


        [DisplayName("CODIGO")]
        public int ide_ven { get; set; }
        [DisplayName("NOMBRES")]
        [Required(ErrorMessage="NOMBRE DE VENDEDOR")]

        public string nom_ven{ get;set; }
        [DisplayName("APELLIDOS")]
        [Required(ErrorMessage = "APELLIDO DE VENDEDOR")]
        public string ape_ven { get; set; }

        [Required(ErrorMessage = "SUELDO DE VENDEDOR")]
        [DisplayName("SUELDO")]
        public double sue_ven { get; set; }

        [Required(ErrorMessage = "FECHA INGRESO")]
        [DisplayName("FECHA DE INGRESO")]
        public DateTime fec_ing
        {
            get; set;
        }

        [DisplayName("DISTRITO")]
        [Required(ErrorMessage = "CODIGO DISTRITO")]

        public int ide_dis { get; set; }

    }
}
