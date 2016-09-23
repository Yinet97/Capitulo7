namespace AtencionCliente
{
    partial class Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IngresoNombre = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.listadoCliente = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ImprimoCliente = new System.Windows.Forms.TextBox();
            this.VerTurno = new System.Windows.Forms.Button();
            this.Siguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicio Al Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del cliente:";
            // 
            // IngresoNombre
            // 
            this.IngresoNombre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresoNombre.Location = new System.Drawing.Point(235, 78);
            this.IngresoNombre.Name = "IngresoNombre";
            this.IngresoNombre.Size = new System.Drawing.Size(244, 22);
            this.IngresoNombre.TabIndex = 2;
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.Color.Gray;
            this.Aceptar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.Location = new System.Drawing.Point(485, 72);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(121, 32);
            this.Aceptar.TabIndex = 3;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // listadoCliente
            // 
            this.listadoCliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listadoCliente.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoCliente.FormattingEnabled = true;
            this.listadoCliente.ItemHeight = 16;
            this.listadoCliente.Location = new System.Drawing.Point(56, 149);
            this.listadoCliente.Name = "listadoCliente";
            this.listadoCliente.Size = new System.Drawing.Size(580, 116);
            this.listadoCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Turno del Cliente:";
            // 
            // ImprimoCliente
            // 
            this.ImprimoCliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimoCliente.Location = new System.Drawing.Point(212, 357);
            this.ImprimoCliente.Name = "ImprimoCliente";
            this.ImprimoCliente.Size = new System.Drawing.Size(371, 22);
            this.ImprimoCliente.TabIndex = 6;
            // 
            // VerTurno
            // 
            this.VerTurno.BackColor = System.Drawing.SystemColors.GrayText;
            this.VerTurno.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerTurno.Location = new System.Drawing.Point(258, 271);
            this.VerTurno.Name = "VerTurno";
            this.VerTurno.Size = new System.Drawing.Size(158, 34);
            this.VerTurno.TabIndex = 8;
            this.VerTurno.Text = "Ver Turno";
            this.VerTurno.UseVisualStyleBackColor = false;
            this.VerTurno.Click += new System.EventHandler(this.VerTurno_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.BackColor = System.Drawing.SystemColors.GrayText;
            this.Siguiente.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Siguiente.Location = new System.Drawing.Point(258, 398);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(158, 36);
            this.Siguiente.TabIndex = 9;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = false;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 446);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.VerTurno);
            this.Controls.Add(this.ImprimoCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listadoCliente);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.IngresoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cliente";
            this.Text = "Atencion A Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IngresoNombre;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.ListBox listadoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ImprimoCliente;
        private System.Windows.Forms.Button VerTurno;
        private System.Windows.Forms.Button Siguiente;
    }
}

