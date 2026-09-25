using FestivosAPI.dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace FestivosAPI.Core.Servicio
{
    public interface IPaisServicio
    {
        Task<IEnumerable<Pais>> ObtenerTodos();
        Task<IEnumerable<Pais>> ObtenerPaiss(int IdPais);

        Task<Festivo> Obtener(int Id);

        Task<Festivo> Agregar(Pais Pais);

        Task<Festivo> Modificar(Pais Pais);

        Task<bool> Eliminar(int Id);

    }
}
