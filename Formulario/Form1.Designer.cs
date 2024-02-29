namespace Formulario
{
    partial class Tesla
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tesla));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtDueño = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtKmActual = new System.Windows.Forms.TextBox();
            this.BoxTesla = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BoxModelo = new System.Windows.Forms.ComboBox();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.BotonRegistrar = new System.Windows.Forms.Button();
            this.BotonBorrarLista = new System.Windows.Forms.Button();
            this.BotonBorrarTodo = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Año";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dueño / Empresa  ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 341);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Km. Actual / Horas actuales";
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.Location = new System.Drawing.Point(373, 297);
            this.txtAño.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(275, 28);
            this.txtAño.TabIndex = 11;
            // 
            // txtDueño
            // 
            this.txtDueño.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueño.Location = new System.Drawing.Point(373, 210);
            this.txtDueño.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDueño.Name = "txtDueño";
            this.txtDueño.Size = new System.Drawing.Size(275, 28);
            this.txtDueño.TabIndex = 12;
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(373, 257);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(275, 28);
            this.txtColor.TabIndex = 13;
            // 
            // txtKmActual
            // 
            this.txtKmActual.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKmActual.Location = new System.Drawing.Point(373, 336);
            this.txtKmActual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKmActual.Name = "txtKmActual";
            this.txtKmActual.Size = new System.Drawing.Size(275, 28);
            this.txtKmActual.TabIndex = 14;
            // 
            // BoxTesla
            // 
            this.BoxTesla.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxTesla.FormattingEnabled = true;
            this.BoxTesla.Items.AddRange(new object[] {
            "",
            "Tesla",
            "SpaceX"});
            this.BoxTesla.Location = new System.Drawing.Point(373, 109);
            this.BoxTesla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BoxTesla.Name = "BoxTesla";
            this.BoxTesla.Size = new System.Drawing.Size(275, 31);
            this.BoxTesla.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Vehículo";
            // 
            // BoxModelo
            // 
            this.BoxModelo.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxModelo.FormattingEnabled = true;
            this.BoxModelo.Items.AddRange(new object[] {
            "",
            "X",
            "S",
            "CYBERTRUCK",
            "",
            "Starship",
            "Falcon9"});
            this.BoxModelo.Location = new System.Drawing.Point(373, 162);
            this.BoxModelo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BoxModelo.Name = "BoxModelo";
            this.BoxModelo.Size = new System.Drawing.Size(275, 31);
            this.BoxModelo.TabIndex = 19;
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // BotonRegistrar
            // 
            this.BotonRegistrar.Location = new System.Drawing.Point(373, 378);
            this.BotonRegistrar.Name = "BotonRegistrar";
            this.BotonRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BotonRegistrar.TabIndex = 21;
            this.BotonRegistrar.Text = "Registrar";
            this.BotonRegistrar.UseVisualStyleBackColor = true;
            this.BotonRegistrar.Click += new System.EventHandler(this.BotonRegistrar_Click);
            // 
            // BotonBorrarLista
            // 
            this.BotonBorrarLista.Location = new System.Drawing.Point(466, 378);
            this.BotonBorrarLista.Name = "BotonBorrarLista";
            this.BotonBorrarLista.Size = new System.Drawing.Size(63, 23);
            this.BotonBorrarLista.TabIndex = 22;
            this.BotonBorrarLista.Text = "Borrar";
            this.BotonBorrarLista.UseVisualStyleBackColor = true;
            this.BotonBorrarLista.Click += new System.EventHandler(this.BotonBorrarLista_Click);
            // 
            // BotonBorrarTodo
            // 
            this.BotonBorrarTodo.Location = new System.Drawing.Point(543, 378);
            this.BotonBorrarTodo.Name = "BotonBorrarTodo";
            this.BotonBorrarTodo.Size = new System.Drawing.Size(169, 23);
            this.BotonBorrarTodo.TabIndex = 23;
            this.BotonBorrarTodo.Text = "Borrar datos ingresados";
            this.BotonBorrarTodo.UseVisualStyleBackColor = true;
            this.BotonBorrarTodo.Click += new System.EventHandler(this.BotonBorrarTodo_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(49, 432);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(663, 150);
            this.dgvDatos.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(308, 50);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(373, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 84);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Tesla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 595);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.BotonBorrarTodo);
            this.Controls.Add(this.BotonBorrarLista);
            this.Controls.Add(this.BotonRegistrar);
            this.Controls.Add(this.BoxModelo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BoxTesla);
            this.Controls.Add(this.txtKmActual);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtDueño);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Tesla";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtDueño;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtKmActual;
        private System.Windows.Forms.ComboBox BoxTesla;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox BoxModelo;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.Button BotonRegistrar;
        private System.Windows.Forms.Button BotonBorrarLista;
        private System.Windows.Forms.Button BotonBorrarTodo;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

