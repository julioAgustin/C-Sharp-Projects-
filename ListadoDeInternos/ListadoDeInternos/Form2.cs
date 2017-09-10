using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ListadoDeInternos
{
    public partial class frmListadoDeInterno : Form
    {
        NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();
        String consulta;
        Boolean estado;
        //SelectCommand.Connection = null;
        public frmListadoDeInterno()
        {
            InitializeComponent();
            consulta = "";
            estado = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            validarCbo();

           if (estado == true) {

                if (cboSucursales.SelectedItem.Equals("Casa Matriz"))
                {
                    consultaMatriz();
                }
                
                if (cboSucursales.SelectedItem.Equals("San Lorenzo"))
                {
                    consultaSanLorenzo();
                }

                if (cboSucursales.SelectedItem.Equals("Mariano Roque Alonso"))
                {
                    consultaMariano();
                }

                if (cboSucursales.SelectedItem.Equals("Todos"))
                {
                    consultaTodos();
                }

            }
            else
            {
                MessageBox.Show("No has precionado en el botón conectar.");
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void frmListadoDeInterno_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            desconectarBaseDeDatos();
            Close();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBaseDeDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al conectar. A continuación se detalla el error: " + ex);
            }

        }

        private void conectarBaseDeDatos()
        {
            try
            {
                NpgsqlConnection conexion = new NpgsqlConnection(
                      "Server = localhost;" 
                    + "Port = 5432;" 
                    + "User Id = postgres;" 
                    + "Password = postgres;"
                    + "Database = repuestos;");
                conexion.Open();
                MessageBox.Show("Conectado.");
                estado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar. A continuación se detalla el error: " + ex);
            }

           
        }

        private void desconectarBaseDeDatos()
        {
            
            NpgsqlConnection conexion = new NpgsqlConnection(builder.ToString());
            MessageBox.Show("Desconectado.");
            conexion.Close();
            estado = false;
        }   

        private void consultaMatriz()
        {
            try
            {
                consulta = "SELECT * FROM personas;";
                NpgsqlCommand con = new NpgsqlCommand();
                con.CommandText = consulta;
                NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(con);
                DataSet dset = new DataSet();
                adapt.Fill(dset, "personas");
                dgvRegListado.DataSource = dset.Tables["personas"];

            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }
        private void consultaSanLorenzo()
        {

        }
        private void consultaMariano()
        {

        }
        private void consultaTodos()
        {
            
        }
        private void validarCbo()
        {
            if (cboSucursales.SelectedIndex == -1)
            {
                MessageBox.Show("¡Debe seleccionar una opción!");
                cboSucursales.Focus();
            }
        }

        private void dgvRegListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
