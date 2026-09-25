using FestivosAPI.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FestivosAPI.Core.Servicio
{
    public interface ITipoServicio
    {
        Task<IEnumerable<Tipo>> ObtenerTodos();
        Task<IEnumerable<Tipo>> ObtenerTipo(int IdTipo);
        Task<IEnumerable<Festivo>> Buscar(int IndiceDato, string Texto);
        Task<Festivo> Obtener(int Id);
        Task<Festivo> Agregar(Tipo Tipo);
        Task<Festivo> Modificar(Tipo Tipo);
        Task<bool> Eliminar(int Id);
        Task<bool> ValidarFechaFestiva(int IdPais, DateTime Fecha);
        Task<IEnumerable<Festivo>> ObtenerFestivosPorAño(int IdPais, int Año);

    }
}
