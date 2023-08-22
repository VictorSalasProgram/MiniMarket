using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoMiniMarket.Entidades;
using ProyectoMiniMarket.Negocio;

namespace ProyectoMiniMarket.Presentacion
{
    public partial class frm_Categorias : Form
    {
        public frm_Categorias()
        {
            InitializeComponent();
        }
        #region "Variables"
        int Codigo_ca = 0;
        int Estadoguarda = 0; //Sin ninguna accion

        #endregion
        #region "Mis metodos"
        private void Formato_ca()
        {
            dgv_principal.Columns[0].Width = 100;
            dgv_principal.Columns[0].HeaderText = "CODIGO_CA";
            dgv_principal.Columns[1].Width = 300;
            dgv_principal.Columns[1].HeaderText = "CATEGORIA";

        }
        private void Listado_ca(string cTexto)
        {
            try
            {
                dgv_principal.DataSource = N_Categorias.Listado_ca(cTexto);
                this.Formato_ca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message +ex.StackTrace);
            }
           
            
        }
        private void Estado_botonesprincipales(bool lEstado)
        {
            this.btn_nuevo.Enabled = lEstado;
            this.btn_actualizar.Enabled = lEstado;
            this.btn_eliminar.Enabled = lEstado;
            this.btn_reporte.Enabled = lEstado;
            this.btn_salir.Enabled = lEstado;   

        }
        private void Estado_botonesprocesos (bool lEstado)
        {
            this.btn_cancelar.Visible = lEstado;
            this.btn_guardar.Visible = lEstado;
            this.btn_retornar.Visible = !lEstado;
        }
        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_principal.CurrentRow.Cells["codigo_ca"].Value)))
            {
                MessageBox.Show("No tiene informacion para mostrar","AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_ca =Convert.ToInt32(dgv_principal.CurrentRow.Cells["codigo_ca"].Value);
                txt_descripcion_ca.Text = Convert.ToString(dgv_principal.CurrentRow.Cells["descripcion_ca"].Value);
            }
        }
        #endregion

        private void frm_Categorias_Load(object sender, EventArgs e)
        {
            this.Listado_ca("%");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1; //NUEVO REGISTRO
            this.Estado_botonesprincipales(false);
            this.Estado_botonesprocesos(true);
            txt_descripcion_ca.ReadOnly = false;
            txt_descripcion_ca.Text= "";
            tb_principal.SelectedIndex = 1;
            txt_descripcion_ca.Focus();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            //Reportes.frm_rpt_categoria oRpt1 = new Reportes.frm_rpt_categoria();
            //oRpt1.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_principal.CurrentRow.Cells["codigo_ca"].Value)))
            {
                MessageBox.Show("No tiene informacion para mostrar", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Seguro que deseas eliminar el registro?", "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if(Opcion == DialogResult.Yes)
                {
                    string Rpta = "";
                    this.Codigo_ca = Convert.ToInt32(dgv_principal.CurrentRow.Cells["codigo_ca"].Value);
                    Rpta = N_Categorias.Eliminar_ca(Codigo_ca);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_ca("%");
                        this.Codigo_ca = 0;
                        MessageBox.Show("Registro eliminado", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    //Enviar eliminar datos
                }
                
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar registro
            this.Estado_botonesprincipales(false);
            this.Estado_botonesprocesos(true);
            txt_descripcion_ca.ReadOnly = false;
            tb_principal.SelectedIndex = 1;
            this.Selecciona_item();
            txt_descripcion_ca.Focus();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_descripcion_ca.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos", "AVISO DEL SISTEMA",MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else //SE PROCEDE A REGISTRAR INFO
            {
                E_Categorias oCa = new E_Categorias();
                string Rpta = "";
                oCa.Codigo_ca = this.Codigo_ca;
                oCa.Descripcion_ca = txt_descripcion_ca.Text.Trim();
                Rpta = N_Categorias.Guardar_ca(Estadoguarda, oCa);
                if (Rpta =="OK")
                {
                    this.Listado_ca("%");
                    MessageBox.Show("Los datos han sido guardados con exito", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0;
                    this.Estado_botonesprincipales(true);
                    this.Estado_botonesprocesos(false);
                    txt_descripcion_ca.Text = "";
                    tb_principal.SelectedIndex = 0;
                    this.Codigo_ca = 0;

                    
                }
                else
                {
                    MessageBox.Show(Rpta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //SIN ACCION
            this.Codigo_ca = 0;
            txt_descripcion_ca.Text = "";
            txt_descripcion_ca.ReadOnly = true;
            this.Estado_botonesprincipales(true);
            this.Estado_botonesprocesos(false);
            tb_principal.SelectedIndex = 0;

        }

        private void btn_retornar_Click(object sender, EventArgs e)
        {
            this.Estado_botonesprocesos(false);
            this.Codigo_ca = 0;
            tb_principal.SelectedIndex = 0;
            txt_descripcion_ca.Text = "";
        }

        private void dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_botonesprocesos(false);
            tb_principal.SelectedIndex = 1;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_ca(txt_buscar.Text.Trim());
        }

        private void dgv_principal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
