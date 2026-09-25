using System;
using System.Collections.Generic;
using System.Text;
using FestivosAPI.dominio;
namespace FestivosAPI.Core.Servicio
{
    public interface IFestivoServicio
    {
        Task<IEnumerable<Festivo>> ObtenerTodos();
        Task<IEnumerable<Festivo>> ObtenerFestivo(int IdFestivos);

        Task<Festivo> Obtener(int Id);

        Task<Festivo> Agregar(Festivo Festivo);

        Task<Festivo> Modificar(Festivo Festivo);

        Task<bool> Eliminar(int Id);





    }
}
