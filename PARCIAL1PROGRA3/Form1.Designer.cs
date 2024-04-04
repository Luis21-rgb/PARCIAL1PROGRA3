
namespace PARCIAL1PROGRA3
{
    partial class Form1
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
            this.listBoxAlumnos = new System.Windows.Forms.ListBox();
            this.listBoxTalleres = new System.Windows.Forms.ListBox();
            this.textBoxReporte = new System.Windows.Forms.TextBox();
            this.buttonInscribir = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.buttonTotalInscritos = new System.Windows.Forms.Button();
            this.labelAlumnos = new System.Windows.Forms.Label();
            this.labelTalleres = new System.Windows.Forms.Label();
            this.labelReporte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxAlumnos
            // 
            this.listBoxAlumnos.FormattingEnabled = true;
            this.listBoxAlumnos.Location = new System.Drawing.Point(208, 76);
            this.listBoxAlumnos.Name = "listBoxAlumnos";
            this.listBoxAlumnos.Size = new System.Drawing.Size(120, 95);
            this.listBoxAlumnos.TabIndex = 0;
            // 
            // listBoxTalleres
            // 
            this.listBoxTalleres.FormattingEnabled = true;
            this.listBoxTalleres.Location = new System.Drawing.Point(421, 76);
            this.listBoxTalleres.Name = "listBoxTalleres";
            this.listBoxTalleres.Size = new System.Drawing.Size(120, 95);
            this.listBoxTalleres.TabIndex = 1;
            // 
            // textBoxReporte
            // 
            this.textBoxReporte.Location = new System.Drawing.Point(63, 112);
            this.textBoxReporte.Name = "textBoxReporte";
            this.textBoxReporte.Size = new System.Drawing.Size(100, 20);
            this.textBoxReporte.TabIndex = 2;
            // 
            // buttonInscribir
            // 
            this.buttonInscribir.Location = new System.Drawing.Point(221, 195);
            this.buttonInscribir.Name = "buttonInscribir";
            this.buttonInscribir.Size = new System.Drawing.Size(94, 33);
            this.buttonInscribir.TabIndex = 3;
            this.buttonInscribir.Text = "Inscribir";
            this.buttonInscribir.UseVisualStyleBackColor = true;
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Location = new System.Drawing.Point(433, 195);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(95, 33);
            this.buttonOrdenar.TabIndex = 4;
            this.buttonOrdenar.Text = "Ordenar";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            // 
            // buttonTotalInscritos
            // 
            this.buttonTotalInscritos.Location = new System.Drawing.Point(584, 115);
            this.buttonTotalInscritos.Name = "buttonTotalInscritos";
            this.buttonTotalInscritos.Size = new System.Drawing.Size(142, 20);
            this.buttonTotalInscritos.TabIndex = 5;
            this.buttonTotalInscritos.Text = "Total Inscritos";
            this.buttonTotalInscritos.UseVisualStyleBackColor = true;
            // 
            // labelAlumnos
            // 
            this.labelAlumnos.AutoSize = true;
            this.labelAlumnos.Location = new System.Drawing.Point(205, 48);
            this.labelAlumnos.Name = "labelAlumnos";
            this.labelAlumnos.Size = new System.Drawing.Size(47, 13);
            this.labelAlumnos.TabIndex = 6;
            this.labelAlumnos.Text = "Alumnos";
            // 
            // labelTalleres
            // 
            this.labelTalleres.AutoSize = true;
            this.labelTalleres.Location = new System.Drawing.Point(430, 48);
            this.labelTalleres.Name = "labelTalleres";
            this.labelTalleres.Size = new System.Drawing.Size(44, 13);
            this.labelTalleres.TabIndex = 7;
            this.labelTalleres.Text = "Talleres";
            // 
            // labelReporte
            // 
            this.labelReporte.AutoSize = true;
            this.labelReporte.Location = new System.Drawing.Point(12, 119);
            this.labelReporte.Name = "labelReporte";
            this.labelReporte.Size = new System.Drawing.Size(45, 13);
            this.labelReporte.TabIndex = 8;
            this.labelReporte.Text = "Reporte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelReporte);
            this.Controls.Add(this.labelTalleres);
            this.Controls.Add(this.labelAlumnos);
            this.Controls.Add(this.buttonTotalInscritos);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.buttonInscribir);
            this.Controls.Add(this.textBoxReporte);
            this.Controls.Add(this.listBoxTalleres);
            this.Controls.Add(this.listBoxAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlumnos;
        private System.Windows.Forms.ListBox listBoxTalleres;
        private System.Windows.Forms.TextBox textBoxReporte;
        private System.Windows.Forms.Button buttonInscribir;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Button buttonTotalInscritos;
        private System.Windows.Forms.Label labelAlumnos;
        private System.Windows.Forms.Label labelTalleres;
        private System.Windows.Forms.Label labelReporte;
    }
}

