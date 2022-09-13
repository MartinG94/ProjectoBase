using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Entidades
{
    public class Usuario
    {
        private string NombreUsuario;
        private string Clave;

        public Usuario(string nombre, string pass)
        {
            this.NombreUsuario = nombre;
            this.Clave = pass;
        }

        public string NombreDeUsuario
        {
            get => this.NombreUsuario;
            set => this.NombreUsuario = value;
        }

        public string Password
        {
            get => this.Clave;
            set => this.Clave = value;
        }
    }
}
