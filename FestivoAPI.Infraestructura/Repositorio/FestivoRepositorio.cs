using System;
using System.Collections.Generic;
using System.Text;
using FestivoAPI.Infraestructura.Persistencia;
using FestivosAPI.Core.Repositorio;
using FestivosAPI.dominio;
using FestivosAPI.Infraestructura.Persistencias;
using Microsoft.EntityFrameworkCore;

namespace FestivoAPI.Infraestructura.Repositorio
{
    public class FestivoRepositorio : IFestivoRepositorio
    {
        private FestivosAPIContext contexto;

            public async Task<IEnumerable<Festivo>> ObtenerTodos()
            {
                return await contexto.Festivo
                    .OrderBy(Pais => Pais.Nombre)
                    .ToArrayAsync();
            }

            public async Task<Festivo> Obtener(int Id)
            {
                return await contexto.Festivo.FindAsync(Id);
            }
            public Task<Festivo> Agregar(Festivo Festivo)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<Festivo>> Buscar(int IndiceDato, string Texto)
            {
                return await contexto.Festivo
                    .Where(Festivo => Festivo.Nombre.Contains(Texto))
                    .ToArrayAsync();
            }

            public Task<Festivo> Modificar(Festivo Festivo)
            {
                throw new NotImplementedException();
            }

            public Task<bool> Eliminar(int Id)
            {
                throw new NotImplementedException();
            }
        }

    }
}
