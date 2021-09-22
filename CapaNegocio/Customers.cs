using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDato;

namespace CapaNegocio
{
    public class Customers : Interface.ICustomers
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
        private string contacttitle;
        private string address;
        private string city;
        private string region;
        private string postalcode;
        private string country;
        private string phone;
        private string fax;
        
        public string CustomerID { get => customerid; set => customerid = value; }
        public string Companyname { get => companyname; set => companyname = value; }
        public string Contactname { get => contactname; set => contactname = value; }
        public string Contacttitle { get => contacttitle; set => contacttitle = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string Region { get => region; set => region = value; }
        public string Postalcode { get => postalcode; set => postalcode = value; }
        public string Country { get => country; set => country = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Fax { get => fax; set => fax = value; }

        public bool Actualizar()
        {
            //throw new NotImplementedException();
            DataRow fila = datos.TraerDataRow("spActualizarCustomers", CustomerID, Companyname, Contactname, Contacttitle, Address, City, Region, Postalcode, Country, Phone, Fax);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Agregar()
        {
            //throw new NotImplementedException();
            // Traer os datos de la conslta
            DataRow fila = datos.TraerDataRow("spAgregarCustomers", CustomerID,Companyname,Contactname,Contacttitle,Address,City,Region,Postalcode,Country,Phone,Fax);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarCustomers", texto, criterio);
        }

        public bool Eliminar()
        {
            //Eliminar
            //throw new NotImplementedException();
            DataRow fila = datos.TraerDataRow("spEliminarCustomers", CustomerID);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Listar()
        {
            //throw new NotImplementedException();
            return datos.TraerDataSet("spListarCustomers");
        }
    }
}
