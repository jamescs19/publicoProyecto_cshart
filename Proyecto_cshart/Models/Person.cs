using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_cshart.Models
{
#nullable disable

    public abstract class Person : IPerson
    {
        private string id;
        private string name;
        private string email;

        public string Id
        {
            get => id;
            set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < 4 || value.Length > 15)
                {
                    throw new ArgumentException("Error: El id no puede tener menos de 4 caracteres" +
                    " ni mas de 15 caracteres");
                }
                if (!value.All(char.IsDigit))
                    throw new ArgumentException("El ID solo puede contener números");

                else
                {
                    id = value;
                }
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Error: El nombre debe tener al menos 1 caracter");
                }
                else
                {
                    name = value;
                }
            }
        }

        public string Email
        {
            get => email;
            set
            {
                if (String.IsNullOrWhiteSpace(value) || !value.EndsWith("@amigo.edu.co"))
                {
                    throw new ArgumentException("Error: El email debe tener al menos un caracter y @amigo.edu.co");
                }
                else
                {
                    email = value;
                }
            }
        }

        protected Person(string id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }


        public virtual string GetInfo()
        {
            return $"Id: {Id}\n" +
                    $"Nombre: {Name}\n" +
                    $"Email: {Email}";
        }
    }
}

