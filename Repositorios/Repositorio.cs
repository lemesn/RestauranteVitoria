using Raven.Client;
using Raven.Client.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitoriaRestaurante.Models;

namespace VitoriaRestaurante.Repositorios
{
    public class Repositorio
    {
        public DocumentStore store { get; set; }
        public Repositorio()
        {
            store = new DocumentStore
            {
                Url = "http://localhost:8080",
                DefaultDatabase = "BD_RESTAURANTE"
            };
            store.Initialize();
        }

        public string Cadastre(Cliente cliente)
        {
            using (IDocumentSession session = store.OpenSession())
            {
                session.Store(cliente);
                session.SaveChanges();
            }
            return cliente.Id;
        }


        public List<Cliente> Liste()
        {
            using (IDocumentSession session = store.OpenSession())
            {
                return session.Query<Cliente>().ToList();
            }
        }
    }
}
