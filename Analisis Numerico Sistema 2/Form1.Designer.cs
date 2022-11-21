namespace Analisis_Numerico_Sistema_2
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.px_info = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ecuacion = new System.Windows.Forms.TextBox();
            this.dgv_solucion = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.num_XI = new System.Windows.Forms.NumericUpDown();
            this.num_XU = new System.Windows.Forms.NumericUpDown();
            this.rtb_proceso = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.num_error = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.pbx_Ecuacion = new System.Windows.Forms.PictureBox();
            this.btn_restart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.px_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_solucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_XI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_XU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Ecuacion)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(982, 116);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 45);
            this.button2.TabIndex = 25;
            this.button2.Text = "Obtener Raices";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 630);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(528, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "NOTA: Para el correcto funcionamiento se debe trabajar en función de x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "f(x)=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ingresar Función:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.px_info);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 58);
            this.panel1.TabIndex = 21;
            // 
            // px_info
            // 
            this.px_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.px_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.px_info.Image = global::Analisis_Numerico_Sistema_2.Properties.Resources.info_120px;
            this.px_info.Location = new System.Drawing.Point(1150, 15);
            this.px_info.Margin = new System.Windows.Forms.Padding(6);
            this.px_info.Name = "px_info";
            this.px_info.Size = new System.Drawing.Size(35, 33);
            this.px_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.px_info.TabIndex = 12;
            this.px_info.TabStop = false;
            this.px_info.Click += new System.EventHandler(this.px_info_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(576, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Análisis Numérico Sistema 2 - Método de la Regla Falsa";
            // 
            // txt_Ecuacion
            // 
            this.txt_Ecuacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Ecuacion.Location = new System.Drawing.Point(90, 124);
            this.txt_Ecuacion.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Ecuacion.Name = "txt_Ecuacion";
            this.txt_Ecuacion.Size = new System.Drawing.Size(439, 27);
            this.txt_Ecuacion.TabIndex = 19;
            // 
            // dgv_solucion
            // 
            this.dgv_solucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_solucion.BackgroundColor = System.Drawing.Color.White;
            this.dgv_solucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_solucion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_solucion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_solucion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_solucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_solucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.XI,
            this.XR,
            this.XU,
            this.error});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_solucion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_solucion.Location = new System.Drawing.Point(46, 318);
            this.dgv_solucion.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_solucion.Name = "dgv_solucion";
            this.dgv_solucion.ReadOnly = true;
            this.dgv_solucion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_solucion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_solucion.RowHeadersVisible = false;
            this.dgv_solucion.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgv_solucion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_solucion.RowTemplate.Height = 28;
            this.dgv_solucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_solucion.Size = new System.Drawing.Size(608, 279);
            this.dgv_solucion.TabIndex = 26;
            // 
            // iteracion
            // 
            this.iteracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iteracion.HeaderText = "Iteración";
            this.iteracion.MinimumWidth = 8;
            this.iteracion.Name = "iteracion";
            this.iteracion.ReadOnly = true;
            this.iteracion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iteracion.Width = 98;
            // 
            // XI
            // 
            this.XI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.XI.HeaderText = "XI";
            this.XI.MinimumWidth = 8;
            this.XI.Name = "XI";
            this.XI.ReadOnly = true;
            // 
            // XR
            // 
            this.XR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.XR.HeaderText = "XR";
            this.XR.Name = "XR";
            this.XR.ReadOnly = true;
            // 
            // XU
            // 
            this.XU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.XU.HeaderText = "XU";
            this.XU.Name = "XU";
            this.XU.ReadOnly = true;
            // 
            // error
            // 
            this.error.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.error.HeaderText = "Error(%)";
            this.error.Name = "error";
            this.error.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(533, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ingresar extremos del Intervalo:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(533, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "XI:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(663, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "XU:";
            // 
            // num_XI
            // 
            this.num_XI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_XI.DecimalPlaces = 2;
            this.num_XI.Location = new System.Drawing.Point(568, 124);
            this.num_XI.Name = "num_XI";
            this.num_XI.Size = new System.Drawing.Size(86, 27);
            this.num_XI.TabIndex = 30;
            // 
            // num_XU
            // 
            this.num_XU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_XU.DecimalPlaces = 2;
            this.num_XU.Location = new System.Drawing.Point(704, 124);
            this.num_XU.Name = "num_XU";
            this.num_XU.Size = new System.Drawing.Size(86, 27);
            this.num_XU.TabIndex = 31;
            this.num_XU.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rtb_proceso
            // 
            this.rtb_proceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_proceso.Location = new System.Drawing.Point(667, 212);
            this.rtb_proceso.Name = "rtb_proceso";
            this.rtb_proceso.ReadOnly = true;
            this.rtb_proceso.Size = new System.Drawing.Size(521, 385);
            this.rtb_proceso.TabIndex = 32;
            this.rtb_proceso.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(42, 169);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Obtención de raices:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(821, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Porcentaje de Error:";
            // 
            // num_error
            // 
            this.num_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_error.DecimalPlaces = 4;
            this.num_error.Location = new System.Drawing.Point(825, 124);
            this.num_error.Name = "num_error";
            this.num_error.Size = new System.Drawing.Size(86, 27);
            this.num_error.TabIndex = 35;
            this.num_error.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(920, 129);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 19);
            this.label10.TabIndex = 36;
            this.label10.Text = "%";
            // 
            // pbx_Ecuacion
            // 
            this.pbx_Ecuacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_Ecuacion.BackColor = System.Drawing.Color.White;
            this.pbx_Ecuacion.Location = new System.Drawing.Point(46, 212);
            this.pbx_Ecuacion.Margin = new System.Windows.Forms.Padding(6);
            this.pbx_Ecuacion.Name = "pbx_Ecuacion";
            this.pbx_Ecuacion.Size = new System.Drawing.Size(608, 98);
            this.pbx_Ecuacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Ecuacion.TabIndex = 20;
            this.pbx_Ecuacion.TabStop = false;
            // 
            // btn_restart
            // 
            this.btn_restart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_restart.FlatAppearance.BorderSize = 0;
            this.btn_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restart.ForeColor = System.Drawing.Color.White;
            this.btn_restart.Location = new System.Drawing.Point(985, 604);
            this.btn_restart.Margin = new System.Windows.Forms.Padding(4);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(203, 45);
            this.btn_restart.TabIndex = 37;
            this.btn_restart.Text = "Borrar ecuación";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.num_error);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtb_proceso);
            this.Controls.Add(this.num_XU);
            this.Controls.Add(this.num_XI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_solucion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbx_Ecuacion);
            this.Controls.Add(this.txt_Ecuacion);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1216, 697);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ramírez García, Pérez Garza, Sánchez Carrillo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.px_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_solucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_XI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_XU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Ecuacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox px_info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbx_Ecuacion;
        private System.Windows.Forms.TextBox txt_Ecuacion;
        private System.Windows.Forms.DataGridView dgv_solucion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num_XI;
        private System.Windows.Forms.NumericUpDown num_XU;
        private System.Windows.Forms.RichTextBox rtb_proceso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown num_error;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn XI;
        private System.Windows.Forms.DataGridViewTextBoxColumn XR;
        private System.Windows.Forms.DataGridViewTextBoxColumn XU;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
        private System.Windows.Forms.Button btn_restart;
    }
}

