using FestivoAPI.Infraestructura.Persistencia;
using FestivosAPI.Core.Repositorio;
using FestivosAPI.dominio;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace FestivoAPI.Infraestructura.Repositorio
{
    public class PaisRepositorio : IPaisRepositorio
    {
        private FestivosAPIContext contexto;

        public async Task<IEnumerable<Pais>> ObtenerTodos()
        {
            return await contexto.Pais
                .OrderBy(Pais => Pais.Nombre)
                .ToArrayAsync();
        }

        public async Task<Pais> Obtener(int Id)
        {
            return await contexto.Pais.FindAsync(Id);
        }
        public Task<Pais> Agregar(Pais Pais)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Pais>> Buscar(int IndiceDato, string Texto)
        {
            return await contexto.Pais
                .Where(pais => pais.Nombre.Contains(Texto))
                .ToArrayAsync();
        }

        public Task<Pais> Modificar(Pais Pais)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
