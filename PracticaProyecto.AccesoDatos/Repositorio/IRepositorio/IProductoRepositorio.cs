using Microsoft.AspNetCore.Mvc.Rendering;
using PracticaProyecto.Modelos;

namespace PracticaProyecto.AccesoDatos.Repositorio.IRepositorio
{
    public interface IProductoRepositorio : IRepositorio<Producto>
    {
        void Actualizar(Producto producto);
        IEnumerable<SelectListItem> ObtenerTodosDropDownList(string obj);
    }
}