namespace Ejercicio5Formularios
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
            this.mcCalendario1 = new System.Windows.Forms.MonthCalendar();
            this.txaFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCalendario2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // mcCalendario1
            // 
            this.mcCalendario1.Location = new System.Drawing.Point(110, 109);
            this.mcCalendario1.Name = "mcCalendario1";
            this.mcCalendario1.TabIndex = 0;
            this.mcCalendario1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcCalendario1_DateChanged);
            // 
            // txaFecha
            // 
            this.txaFecha.Location = new System.Drawing.Point(392, 35);
            this.txaFecha.Name = "txaFecha";
            this.txaFecha.Size = new System.Drawing.Size(177, 22);
            this.txaFecha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha elegida:";
            // 
            // dtpCalendario2
            // 
            this.dtpCalendario2.Location = new System.Drawing.Point(462, 109);
            this.dtpCalendario2.Name = "dtpCalendario2";
            this.dtpCalendario2.Size = new System.Drawing.Size(200, 22);
            this.dtpCalendario2.TabIndex = 4;
            this.dtpCalendario2.ValueChanged += new System.EventHandler(this.dtpCalendario2_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpCalendario2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txaFecha);
            this.Controls.Add(this.mcCalendario1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcCalendario1;
        private System.Windows.Forms.TextBox txaFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCalendario2;
    }
}

