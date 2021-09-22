using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using System.Data;


namespace CapaNegocio
{
    public class CustomerDemographics : Interface.ICustomerDemographics

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
        private int id;
        private string customerdesc;

        public int Id { get => id; set => id = value; }
        public string Customerdesc { get => customerdesc; set => customerdesc = value; }

        public bool Actualizar()
        {
            //throw new NotImplementedException();
            DataRow fila = datos.TraerDataRow("spActualizarCustomerDemographics", Id, Customerdesc);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Agregar()
        {
            //throw new NotImplementedException();
            // Traer os datos de la conslta
            DataRow fila = datos.TraerDataRow("spAgregarCustomerDemographics", Id, Customerdesc);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            //throw new NotImplementedException();
            return datos.TraerDataSet("spBuscarCustomerDemographics", texto, criterio);
        }

        public bool Eliminar()
        {
            //Eliminar
            //throw new NotImplementedException();
            DataRow fila = datos.TraerDataRow("spEliminarCustomerDemographics", Id);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Listar()
        {
            //throw new NotImplementedException();
            return datos.TraerDataSet("spListarCustomerDemographics");
        }
    }
}
