namespace AgendaTelefonica
{
    partial class Agenda
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
            this.label3 = new System.Windows.Forms.Label();
            this.IngresoNombre = new System.Windows.Forms.TextBox();
            this.IngresoNumero = new System.Windows.Forms.TextBox();
            this.AgendaTel = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guarde en la Agenda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero:";
            // 
            // IngresoNombre
            // 
            this.IngresoNombre.Location = new System.Drawing.Point(184, 67);
            this.IngresoNombre.Name = "IngresoNombre";
            this.IngresoNombre.Size = new System.Drawing.Size(100, 20);
            this.IngresoNombre.TabIndex = 3;
            // 
            // IngresoNumero
            // 
            this.IngresoNumero.Location = new System.Drawing.Point(184, 93);
            this.IngresoNumero.Name = "IngresoNumero";
            this.IngresoNumero.Size = new System.Drawing.Size(100, 20);
            this.IngresoNumero.TabIndex = 4;
            // 
            // AgendaTel
            // 
            this.AgendaTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AgendaTel.Font = new System.Drawing.Font("DengXian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgendaTel.FormattingEnabled = true;
            this.AgendaTel.ItemHeight = 15;
            this.AgendaTel.Location = new System.Drawing.Point(21, 211);
            this.AgendaTel.Name = "AgendaTel";
            this.AgendaTel.Size = new System.Drawing.Size(382, 109);
            this.AgendaTel.TabIndex = 5;
            this.AgendaTel.SelectedIndexChanged += new System.EventHandler(this.AgendaTel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Agenda Telefonica";
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Guardar.Location = new System.Drawing.Point(148, 131);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(109, 36);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(415, 342);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AgendaTel);
            this.Controls.Add(this.IngresoNumero);
            this.Controls.Add(this.IngresoNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Agenda";
            this.Text = "Directorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IngresoNombre;
        private System.Windows.Forms.TextBox IngresoNumero;
        private System.Windows.Forms.ListBox AgendaTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Guardar;
    }
}

