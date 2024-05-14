using System;

namespace Desafio1Boher
{
    public class Usuario
    {
        protected int id;
        protected string nombre;
        protected string apellido;
        protected string nombreUsuario;
        protected string contrasenia;
        protected string mail;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Contrasenia = contrasenia;
            this.Mail = mail;
        }
    }
}