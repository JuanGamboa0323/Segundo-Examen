using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace FrmPrincipal
{
    public partial class FrmInicio : Form
    {

        public FrmInicio()
        {
            InitializeComponent();
        }
        ServicioService servicioService = new ServicioService();
        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            cmbTipoServicio.Text = "";
            txtNit.Text = "";
            txtNombre.Text = "";
            txtValor.Text = "";
            lblTotal.Text = "";
            lblTotalServicios.Text = "";
            lblTotalPagos.Text = "";
            lblTotalCompras.Text = "";

        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {


                Servicios servicio = new Servicios();
                servicio.TipoServicio = cmbTipoServicio.Text;
                servicio.Nit = txtNit.Text;
                servicio.Nombre = txtNombre.Text;
                servicio.Fecha = dtpFecha.Value;
                servicio.Valor = Convert.ToDouble(txtValor.Text);

                string mensaje = servicioService.Guardar(servicio);
                MessageBox.Show(mensaje, $"Confirmacion de guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("No se permiten campos vacíos, por favor llene todos los campos e intentelo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void LlenarTabla()
        {
            dtgDatos.DataSource = null;
            dtgDatos.DataSource = servicioService.Consultar();
        }
        private void CmbConsultaFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbConsultaFiltro.SelectedIndex;
            if (cmbConsultaFiltro.Text.Equals("Todos"))
            {
                Limpiar();
                dtgDatos.DataSource = null;
                dtgDatos.DataSource = servicioService.Consultar();
                lblTotal.Text = "" + servicioService.CalcularTotal();
                lblRegistros.Text = "" + servicioService.NumeroPagos();
               
            }
            else if (cmbConsultaFiltro.Text.Equals("Servicios Publicos"))
            {
                Limpiar();
                dtgDatos.DataSource = null;
                dtgDatos.DataSource = servicioService.FiltroTipoServicioPublico();
                lblTotalServicios.Text = "" + servicioService.CalcularTotalServicioPublico();
                lblRegistros.Text = "" + servicioService.NumeroPagosServicios();
                ;

            }
            else if (cmbConsultaFiltro.Text.Equals("Compras a Provedores"))
            {
                Limpiar();
                dtgDatos.DataSource = null;
                dtgDatos.DataSource = servicioService.FiltroTipoComprasProvedores();
                lblTotalCompras.Text = "" + servicioService.CalcularTotalComprasProvedores();
                lblRegistros.Text = "" + servicioService.NumeroPagosCompras();
                

            }
            else if (cmbConsultaFiltro.Text.Equals("Pagos a Contratistas"))
            {
                Limpiar();
                dtgDatos.DataSource = null;
                dtgDatos.DataSource = servicioService.FiltroTipoPagosContratistas();
                lblTotalPagos.Text = "" + servicioService.CalcularTotalPagosContratistas();
                lblRegistros.Text = "" + servicioService.NumeroPagosContratistas();
                
            }
        }

        private void CmbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DtpConsultaFecha_ValueChanged(object sender, EventArgs e)
        {
            
            DateTime fecha = dtpFecha.Value;
            dtgDatos.DataSource = servicioService.FiltroFecha(fecha.Month, fecha.Year,cmbConsultaFiltro.Text);
        }

        private void DtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
