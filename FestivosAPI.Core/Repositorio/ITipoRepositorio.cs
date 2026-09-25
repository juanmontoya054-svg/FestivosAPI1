using System;
using System.Collections.Generic;
using System.Text;
using FestivosAPI.dominio;

namespace FestivosAPI.Core.Repositorio
{
    public interface ITipoRepositorio
    {
        Task<IEnumerable<Tipo>> ObtenerTodos();

        Task<Tipo> Obtener(int Id);

        Task<IEnumerable<Tipo>> Buscar(int IndiceDato, string Texto);

        Task<Pais> Agregar(Tipo Tipo);

        Task<Pais> Modificar(Tipo Tipo);

        Task<bool> Eliminar(int Id);

    }
}

    }
}
