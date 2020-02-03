using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Modelo;

namespace BackEnd.DAOS
{
    public class MúsicoDAO
    {
        public List<Músico> GetAll()
        {
            List<Músico> lista;
            lista = new List<Músico>();
            lista.Add(new Músico()
            {
                Id = 1,
                Nombre = "Juan",
                Instrumento = "Guitarra"
            });
            return lista;
        }
    }
}
