namespace GastosDelMes
{
    partial class Gastos
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
            this.label2 = new System.Windows.Forms.Label();
            this.ingresoGasto = new System.Windows.Forms.TextBox();
            this.listaGasto = new System.Windows.Forms.ListBox();
            this.EntrarGasto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ImprimoTotal = new System.Windows.Forms.TextBox();
            this.VerGasto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DengXian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Los gastos:";
            // 
            // ingresoGasto
            // 
            this.ingresoGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ingresoGasto.Location = new System.Drawing.Point(127, 54);
            this.ingresoGasto.Name = "ingresoGasto";
            this.ingresoGasto.Size = new System.Drawing.Size(201, 20);
            this.ingresoGasto.TabIndex = 2;
            // 
            // listaGasto
            // 
            this.listaGasto.BackColor = System.Drawing.Color.Linen;
            this.listaGasto.Font = new System.Drawing.Font("DengXian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaGasto.FormattingEnabled = true;
            this.listaGasto.ItemHeight = 18;
            this.listaGasto.Location = new System.Drawing.Point(86, 191);
            this.listaGasto.Name = "listaGasto";
            this.listaGasto.Size = new System.Drawing.Size(324, 130);
            this.listaGasto.TabIndex = 3;
            // 
            // EntrarGasto
            // 
            this.EntrarGasto.BackColor = System.Drawing.Color.White;
            this.EntrarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntrarGasto.Location = new System.Drawing.Point(335, 52);
            this.EntrarGasto.Name = "EntrarGasto";
            this.EntrarGasto.Size = new System.Drawing.Size(75, 23);
            this.EntrarGasto.TabIndex = 4;
            this.EntrarGasto.Text = "Aceptar";
            this.EntrarGasto.UseVisualStyleBackColor = false;
            this.EntrarGasto.Click += new System.EventHandler(this.EntrarGasto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total de los Gastos:";
            // 
            // ImprimoTotal
            // 
            this.ImprimoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ImprimoTotal.Font = new System.Drawing.Font("DengXian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimoTotal.Location = new System.Drawing.Point(249, 113);
            this.ImprimoTotal.Name = "ImprimoTotal";
            this.ImprimoTotal.Size = new System.Drawing.Size(100, 22);
            this.ImprimoTotal.TabIndex = 6;
            // 
            // VerGasto
            // 
            this.VerGasto.BackColor = System.Drawing.Color.White;
            this.VerGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerGasto.Location = new System.Drawing.Point(159, 158);
            this.VerGasto.Name = "VerGasto";
            this.VerGasto.Size = new System.Drawing.Size(169, 27);
            this.VerGasto.TabIndex = 7;
            this.VerGasto.Text = "Ver Gastos";
            this.VerGasto.UseVisualStyleBackColor = false;
            this.VerGasto.Click += new System.EventHandler(this.VerGasto_Click);
            // 
            // Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(519, 323);
            this.Controls.Add(this.VerGasto);
            this.Controls.Add(this.ImprimoTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EntrarGasto);
            this.Controls.Add(this.listaGasto);
            this.Controls.Add(this.ingresoGasto);
            this.Controls.Add(this.label2);
            this.Name = "Gastos";
            this.Text = "Gastos del Mes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ingresoGasto;
        private System.Windows.Forms.ListBox listaGasto;
        private System.Windows.Forms.Button EntrarGasto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImprimoTotal;
        private System.Windows.Forms.Button VerGasto;
    }
}

