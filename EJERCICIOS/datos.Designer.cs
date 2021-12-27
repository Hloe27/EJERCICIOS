
namespace EJERCICIOS
{
    partial class frmDatos
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
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtCurso2 = new System.Windows.Forms.TextBox();
            this.txtPromedio3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCondicion4 = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Promedio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Curso";
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(69, 28);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(100, 20);
            this.txtNombre2.TabIndex = 3;
            // 
            // txtCurso2
            // 
            this.txtCurso2.Location = new System.Drawing.Point(69, 60);
            this.txtCurso2.Name = "txtCurso2";
            this.txtCurso2.Size = new System.Drawing.Size(100, 20);
            this.txtCurso2.TabIndex = 4;
            // 
            // txtPromedio3
            // 
            this.txtPromedio3.Location = new System.Drawing.Point(69, 94);
            this.txtPromedio3.Name = "txtPromedio3";
            this.txtPromedio3.Size = new System.Drawing.Size(100, 20);
            this.txtPromedio3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Condición";
            // 
            // txtCondicion4
            // 
            this.txtCondicion4.Location = new System.Drawing.Point(69, 130);
            this.txtCondicion4.Name = "txtCondicion4";
            this.txtCondicion4.Size = new System.Drawing.Size(100, 20);
            this.txtCondicion4.TabIndex = 7;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(166, 159);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 184);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtCondicion4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPromedio3);
            this.Controls.Add(this.txtCurso2);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDatos";
            this.Text = "Información";
            this.Load += new System.EventHandler(this.frmDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.TextBox txtCurso2;
        private System.Windows.Forms.TextBox txtPromedio3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCondicion4;
        private System.Windows.Forms.Button btnRegresar;
    }
}