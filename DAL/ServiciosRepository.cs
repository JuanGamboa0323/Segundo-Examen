using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class ServiciosRepository
    {
        string ruta = @"PAGOTERCERO.txt";
        List<Servicios> servicios = new List<Servicios>();
        public void guardar(Servicios servicio)
        {

            FileStream archivo = new FileStream(ruta, FileMode.Append);
            StreamWriter escribir = new StreamWriter(archivo);
            escribir.WriteLine(servicio.TipoServicio + ";" + servicio.Nit + ";" + servicio.Nombre + ";" + servicio.Fecha + ";" + servicio.Valor);
            escribir.Close();
            archivo.Close();
        }

        public List<Servicios> Consultar()
        {
            servicios.Clear();
            FileStream archivo = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(archivo);


            string linea = string.Empty;

            while ((linea = reader.ReadLine()) != null)
            {
                Servicios servicio = new Servicios();
                char Delimitar = ';';
                string[] ListaDatos = linea.Split(Delimitar);

                servicio.TipoServicio = ListaDatos[0];
                servicio.Nit = ListaDatos[1];
                servicio.Nombre = ListaDatos[2];
                servicio.Fecha = Convert.ToDateTime(ListaDatos[3]);
                servicio.Valor = double.Parse(ListaDatos[4]);
                servicios.Add(servicio);
            }
                reader.Close();
                archivo.Close();
                return servicios;
            }

        }
    
}
