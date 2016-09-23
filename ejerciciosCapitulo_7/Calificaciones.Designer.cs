namespace ejerciciosCapitulo_7
{
    partial class Calificaciones
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
            this.ingresoCal = new System.Windows.Forms.TextBox();
            this.ImprimoMayor = new System.Windows.Forms.TextBox();
            this.ImprimoMenor = new System.Windows.Forms.TextBox();
            this.ImprimoPromedio = new System.Windows.Forms.TextBox();
            this.listaCal = new System.Windows.Forms.ListBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calificaciones :";
            // 
            // ingresoCal
            // 
            this.ingresoCal.Location = new System.Drawing.Point(217, 12);
            this.ingresoCal.Name = "ingresoCal";
            this.ingresoCal.Size = new System.Drawing.Size(100, 20);
            this.ingresoCal.TabIndex = 1;
            // 
            // ImprimoMayor
            // 
            this.ImprimoMayor.Location = new System.Drawing.Point(138, 108);
            this.ImprimoMayor.Name = "ImprimoMayor";
            this.ImprimoMayor.Size = new System.Drawing.Size(100, 20);
            this.ImprimoMayor.TabIndex = 2;
            // 
            // ImprimoMenor
            // 
            this.ImprimoMenor.Location = new System.Drawing.Point(138, 147);
            this.ImprimoMenor.Name = "ImprimoMenor";
            this.ImprimoMenor.Size = new System.Drawing.Size(100, 20);
            this.ImprimoMenor.TabIndex = 3;
            // 
            // ImprimoPromedio
            // 
            this.ImprimoPromedio.Location = new System.Drawing.Point(138, 183);
            this.ImprimoPromedio.Name = "ImprimoPromedio";
            this.ImprimoPromedio.Size = new System.Drawing.Size(100, 20);
            this.ImprimoPromedio.TabIndex = 4;
            // 
            // listaCal
            // 
            this.listaCal.FormattingEnabled = true;
            this.listaCal.Location = new System.Drawing.Point(282, 108);
            this.listaCal.Name = "listaCal";
            this.listaCal.Size = new System.Drawing.Size(120, 95);
            this.listaCal.TabIndex = 5;
            this.listaCal.SelectedIndexChanged += new System.EventHandler(this.listaCal_SelectedIndexChanged);
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.Chocolate;
            this.Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calcular.Location = new System.Drawing.Point(174, 52);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(100, 31);
            this.Calcular.TabIndex = 6;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Calificacion  Mayor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Calificacion  Menor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Promedio:";
            // 
            // Calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(434, 226);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.listaCal);
            this.Controls.Add(this.ImprimoPromedio);
            this.Controls.Add(this.ImprimoMenor);
            this.Controls.Add(this.ImprimoMayor);
            this.Controls.Add(this.ingresoCal);
            this.Controls.Add(this.label1);
            this.Name = "Calificaciones";
            this.Text = "Calificaciones estudiantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ingresoCal;
        private System.Windows.Forms.TextBox ImprimoMayor;
        private System.Windows.Forms.TextBox ImprimoMenor;
        private System.Windows.Forms.TextBox ImprimoPromedio;
        private System.Windows.Forms.ListBox listaCal;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

