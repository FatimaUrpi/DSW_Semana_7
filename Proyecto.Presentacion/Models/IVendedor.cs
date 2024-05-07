namespace Proyecto.Presentacion.Models
{
    public interface IVendedor
    {
        /*definir metodos de manteniemiento de vendor
         */
        IEnumerable<Vendedor> listadoVendedores();
        IEnumerable<VendedorO> listadoVendedorO();
        IEnumerable<Distrito> listadoDistrito();

        string nuevoVendedor(VendedorO objV);
        string modificaVendedor(VendedorO objV);





    }
}
