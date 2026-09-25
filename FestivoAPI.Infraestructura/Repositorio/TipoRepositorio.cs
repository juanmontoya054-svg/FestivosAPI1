using FestivoAPI.Infraestructura.Persistencia;
using FestivosAPI.Core.Repositorio;
using FestivosAPI.dominio;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace FestivoAPI.Infraestructura.Repositorio
{
    public class TipoRepositorio : ITipoRepositorio
    {
        private FestivosAPIContext contexto;

        public async Task<IEnumerable<Tipo>> ObtenerTodos()
        {
            return await contexto.Tipo
                .OrderBy(Tipo => Tipo.Tiposnombre)
                .ToArrayAsync();
        }

        public async Task<Tipo> Obtener(int Id)
        {
            return await contexto.Tipo.FindAsync(Id);
        }
        public Task<Tipo> Agregar(Tipo Tipo)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tipo>> Buscar(int IndiceDato, string Texto)
        {
            return await contexto.Tipo
                .Where(Tipo => Tipo.Tiposnombre.Contains(Texto))
                .ToArrayAsync();
        }

        public Task<Tipo> Modificar(Tipo Tipo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int Id)
        {
            throw new NotImplementedException();
        }

        Task<Pais> ITipoRepositorio.Agregar(Tipo Tipo)
        {
            throw new NotImplementedException();
        }

        Task<Pais> ITipoRepositorio.Modificar(Tipo Tipo)
        {
            throw new NotImplementedException();
        }
    }
}
