using System;
using System.Collections.Generic;
using CadastroSeries.Interfaces;

namespace CadastroSeries.Classes
{
    public class SeriesRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSeries = new List<Series>();

        public void Atualizar(int id, Series objeto)
        {
            listaSeries[id] = objeto;
        }

        public void Excluir(int id)
        {
            listaSeries[id].Exclui();
        }

        public void Insere(Series objeto)
        {
            listaSeries.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listaSeries;
        }

        public int ProximoId()
        {
            return listaSeries.Count;
        }

        public Series RetornaPorId(int id)
        {
            return listaSeries[id];
        }
    }
}