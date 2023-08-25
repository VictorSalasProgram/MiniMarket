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
    public partial class frm_marcas : Form
    {
        public frm_marcas()
        {
            InitializeComponent();
        }
        #region "Variables"
        int Codigo_ma = 0;
        int Estadoguarda = 0; //Sin ninguna accion

        #endregion
        #region "Mis metodos"
        private void Formato_ma()
        {
            dgv_principal.Columns[0].Width = 100;
            dgv_principal.Columns[0].HeaderText = "CODIGO_MA";
            dgv_principal.Columns[1].Width = 300;
            dgv_principal.Columns[1].HeaderText = "MARCA";

        }
        private void Listado_ma(string cTexto)
        {
            try
            {
                dgv_principal.DataSource = N_Marcas.Listado_ma(cTexto);
                this.Formato_ma();
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
            if (string.IsNullOrEmpty(Convert.ToString(dgv_principal.CurrentRow.Cells["codigo_ma"].Value)))
            {
                MessageBox.Show("No tiene informacion para mostrar","AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_ma =Convert.ToInt32(dgv_principal.CurrentRow.Cells["codigo_ma"].Value);
                txt_descripcion_ma.Text = Convert.ToString(dgv_principal.CurrentRow.Cells["descripcion_ma"].Value);
            }
        }
        #endregion

        private void frm_marcas_Load(object sender, EventArgs e)
        {
            this.Listado_ma("%");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1; //NUEVO REGISTRO
            this.Estado_botonesprincipales(false);
            this.Estado_botonesprocesos(true);
            txt_descripcion_ma.ReadOnly = false;
            txt_descripcion_ma.Text= "";
            tb_principal.SelectedIndex = 1;
            txt_descripcion_ma.Focus();

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
            if (string.IsNullOrEmpty(Convert.ToString(dgv_principal.CurrentRow.Cells["codigo_ma"].Value)))
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
                    this.Codigo_ma = Convert.ToInt32(dgv_principal.CurrentRow.Cells["codigo_ma"].Value);
                    Rpta = N_Marcas.Eliminar_ma(Codigo_ma);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_ma("%");
                        this.Codigo_ma = 0;
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
            txt_descripcion_ma.ReadOnly = false;
            tb_principal.SelectedIndex = 1;
            this.Selecciona_item();
            txt_descripcion_ma.Focus();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_descripcion_ma.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos", "AVISO DEL SISTEMA",MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else //SE PROCEDE A REGISTRAR INFO
            {
                E_Marcas oMa = new E_Marcas();
                string Rpta = "";
                oMa.Codigo_ma = this.Codigo_ma;
                oMa.Descripcion_ma = txt_descripcion_ma.Text.Trim();
                Rpta = N_Marcas.Guardar_ma(Estadoguarda, oMa);
                if (Rpta =="OK")
                {
                    this.Listado_ma("%");
                    MessageBox.Show("Los datos han sido guardados con exito", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0;
                    this.Estado_botonesprincipales(true);
                    this.Estado_botonesprocesos(false);
                    txt_descripcion_ma.Text = "";
                    tb_principal.SelectedIndex = 0;
                    this.Codigo_ma = 0;

                    
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
            this.Codigo_ma = 0;
            txt_descripcion_ma.Text = "";
            txt_descripcion_ma.ReadOnly = true;
            this.Estado_botonesprincipales(true);
            this.Estado_botonesprocesos(false);
            tb_principal.SelectedIndex = 0;

        }

        private void btn_retornar_Click(object sender, EventArgs e)
        {
            this.Estado_botonesprocesos(false);
            this.Codigo_ma = 0;
            tb_principal.SelectedIndex = 0;
            txt_descripcion_ma.Text = "";
        }

        private void dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_botonesprocesos(false);
            tb_principal.SelectedIndex = 1;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_ma(txt_buscar.Text.Trim());
        }

        private void dgv_principal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
