﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Transportadora.Models
{
    public class TransportadoraDB : DbContext
    {
        //construtor por defeito que estará ligada a uma ConnectionString
        public TransportadoraDB() : base("TransportadoraDBConnectionString") { }

        //definir as tabelas
        public DbSet<Encomendas> Encomendas { get; set; }
        public DbSet<Envios> Envios { get; set; }
        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<Clientes> Clientes { get; set; }



    }
}