using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class SerieRepository : IRepositorio<Serie>
	{
        private List<Serie> listaSerie = new List<Serie>();
		public void Update(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Delete(int id)
		{
			listaSerie[id].Delete();
		}

		public void Create(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Serie> List()
		{
			return listaSerie;
		}

		public int NextId()
		{
			return listaSerie.Count;
		}

		public Serie ReturnByID(int id)
		{
			return listaSerie[id];
		}
	}
}