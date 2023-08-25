namespace ProyectoMiniMarket.Presentacion
{
    partial class frm_unidades_medidas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_unidades_medidas));
            this.tb_principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_principal = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_abreviatura_um = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_retornar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_descripcion_um = new System.Windows.Forms.TextBox();
            this.lbl_unidades = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tb_principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_principal
            // 
            this.tb_principal.Controls.Add(this.tabPage1);
            this.tb_principal.Controls.Add(this.tabPage2);
            this.tb_principal.Location = new System.Drawing.Point(12, 12);
            this.tb_principal.Name = "tb_principal";
            this.tb_principal.SelectedIndex = 0;
            this.tb_principal.Size = new System.Drawing.Size(758, 329);
            this.tb_principal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_buscar);
            this.tabPage1.Controls.Add(this.lbl_buscar);
            this.tabPage1.Controls.Add(this.btn_buscar);
            this.tabPage1.Controls.Add(this.dgv_principal);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(750, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(142, 42);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(333, 27);
            this.txt_buscar.TabIndex = 3;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(61, 45);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(68, 20);
            this.lbl_buscar.TabIndex = 2;
            this.lbl_buscar.Text = "Buscar:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.ImageKey = "buscar.png";
            this.btn_buscar.Location = new System.Drawing.Point(492, 36);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(128, 38);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgv_principal
            // 
            this.dgv_principal.AllowUserToAddRows = false;
            this.dgv_principal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.dgv_principal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_principal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_principal.ColumnHeadersHeight = 35;
            this.dgv_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_principal.EnableHeadersVisualStyles = false;
            this.dgv_principal.Location = new System.Drawing.Point(51, 82);
            this.dgv_principal.Name = "dgv_principal";
            this.dgv_principal.ReadOnly = true;
            this.dgv_principal.RowHeadersWidth = 51;
            this.dgv_principal.RowTemplate.Height = 24;
            this.dgv_principal.Size = new System.Drawing.Size(601, 189);
            this.dgv_principal.TabIndex = 0;
            this.dgv_principal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_principal_CellContentClick);
            this.dgv_principal.DoubleClick += new System.EventHandler(this.dgv_principal_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_abreviatura_um);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_retornar);
            this.tabPage2.Controls.Add(this.btn_guardar);
            this.tabPage2.Controls.Add(this.btn_cancelar);
            this.tabPage2.Controls.Add(this.txt_descripcion_um);
            this.tabPage2.Controls.Add(this.lbl_unidades);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_abreviatura_um
            // 
            this.txt_abreviatura_um.Location = new System.Drawing.Point(238, 129);
            this.txt_abreviatura_um.MaxLength = 3;
            this.txt_abreviatura_um.Name = "txt_abreviatura_um";
            this.txt_abreviatura_um.ReadOnly = true;
            this.txt_abreviatura_um.Size = new System.Drawing.Size(70, 22);
            this.txt_abreviatura_um.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Abreviatura(*):";
            // 
            // btn_retornar
            // 
            this.btn_retornar.Location = new System.Drawing.Point(401, 196);
            this.btn_retornar.Name = "btn_retornar";
            this.btn_retornar.Size = new System.Drawing.Size(81, 23);
            this.btn_retornar.TabIndex = 5;
            this.btn_retornar.Text = "Retornar";
            this.btn_retornar.UseVisualStyleBackColor = true;
            this.btn_retornar.Visible = false;
            this.btn_retornar.Click += new System.EventHandler(this.btn_retornar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_guardar.Location = new System.Drawing.Point(315, 196);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(80, 23);
            this.btn_guardar.TabIndex = 4;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Visible = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancelar.Location = new System.Drawing.Point(225, 196);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(82, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_descripcion_um
            // 
            this.txt_descripcion_um.Location = new System.Drawing.Point(238, 157);
            this.txt_descripcion_um.MaxLength = 30;
            this.txt_descripcion_um.Name = "txt_descripcion_um";
            this.txt_descripcion_um.ReadOnly = true;
            this.txt_descripcion_um.Size = new System.Drawing.Size(283, 22);
            this.txt_descripcion_um.TabIndex = 2;
            // 
            // lbl_unidades
            // 
            this.lbl_unidades.AutoSize = true;
            this.lbl_unidades.Location = new System.Drawing.Point(116, 163);
            this.lbl_unidades.Name = "lbl_unidades";
            this.lbl_unidades.Size = new System.Drawing.Size(116, 16);
            this.lbl_unidades.TabIndex = 0;
            this.lbl_unidades.Text = "Unidad medida(*):";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nuevo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ImageKey = "nuevo.png";
            this.btn_nuevo.ImageList = this.imageList1;
            this.btn_nuevo.Location = new System.Drawing.Point(81, 347);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(116, 97);
            this.btn_nuevo.TabIndex = 1;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "acualizar.png");
            this.imageList1.Images.SetKeyName(1, "eliminar.png");
            this.imageList1.Images.SetKeyName(2, "nuevo.png");
            this.imageList1.Images.SetKeyName(3, "reporte.png");
            this.imageList1.Images.SetKeyName(4, "salir.png");
            this.imageList1.Images.SetKeyName(5, "buscar.png");
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_actualizar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ImageKey = "acualizar.png";
            this.btn_actualizar.ImageList = this.imageList1;
            this.btn_actualizar.Location = new System.Drawing.Point(208, 347);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(116, 97);
            this.btn_actualizar.TabIndex = 2;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ImageKey = "eliminar.png";
            this.btn_eliminar.ImageList = this.imageList1;
            this.btn_eliminar.Location = new System.Drawing.Point(335, 347);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(116, 97);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_reporte.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reporte.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte.ImageKey = "reporte.png";
            this.btn_reporte.ImageList = this.imageList1;
            this.btn_reporte.Location = new System.Drawing.Point(462, 347);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(116, 97);
            this.btn_reporte.TabIndex = 4;
            this.btn_reporte.Text = "Reporte";
            this.btn_reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_reporte.UseVisualStyleBackColor = false;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ImageKey = "salir.png";
            this.btn_salir.ImageList = this.imageList1;
            this.btn_salir.Location = new System.Drawing.Point(589, 347);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(116, 97);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "buscar.png");
            // 
            // frm_unidades_medidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1012, 500);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.tb_principal);
            this.Name = "frm_unidades_medidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidades de Medidas";
            this.Load += new System.EventHandler(this.frm_unidades_medidas_Load);
            this.tb_principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_principal;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_descripcion_um;
        private System.Windows.Forms.Label lbl_unidades;
        private System.Windows.Forms.Button btn_retornar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox txt_abreviatura_um;
        private System.Windows.Forms.Label label1;
    }
}