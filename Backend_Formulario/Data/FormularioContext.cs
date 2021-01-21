using Backend_Formulario.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Formulario.Data
{
    public class FormularioContext: DbContext
    {
        public FormularioContext(DbContextOptions<FormularioContext> options)
            :base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }


    }
}
