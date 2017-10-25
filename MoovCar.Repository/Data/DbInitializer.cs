using System;
using System.Collections.Generic;
using System.Text;
using MoovCar.Domain;
using System.Linq;

namespace MoovCar.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MoovCarContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Usuarios.Any())
            {
                return;   // DB has been seeded
            }

            var usuarios = new Usuario[]
            {
            new Usuario{Nome="Rafael Pereira",Email="rpstos@gmail.com"},
            new Usuario{Nome="Rafael Pereira 2",Email="rpstos@gmail.com 2"},
            };
            foreach (Usuario s in usuarios)
            {
                context.Usuarios.Add(s);
            }
            context.SaveChanges();

            var clientes = new Cliente[]
            {
            new Cliente{Nome="Cliente 1",Email="cliente@gmail.com", CPF="434343434343"},
            new Cliente{Nome="Cliente 2",Email="cliente@gmail.com", CPF="434343434343"},
            };
            foreach (Cliente c in clientes)
            {
                context.Clientes.Add(c);
            }
            context.SaveChanges();
        }
    }
}
