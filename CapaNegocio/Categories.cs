using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDato;

namespace CapaNegocio
{
    public class Categories : Interface.ICategories
    {
        // Crear un objeto para utilizar capa dato
        private Datos datos = new DatosSQL();
        //Delcarar atributo y propiedad para el mensaje del procedimiento almacenado
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }
        // atributos de la clase
        private string customerid;
        private string companyname;
        private string contactname;
        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Agregar()
        {
            throw new NotImplementedException();
        }

        public DataSet Buscar(string texto, string criterio)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public DataSet Listar()
        {
            throw new NotImplementedException();
        }
        // atributos de la clase
    }
}
