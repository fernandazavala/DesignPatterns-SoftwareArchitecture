
namespace ExamenSegundoParcial
{
    partial class AlumnosForm
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
            this.InformacionAlumnosLabel = new System.Windows.Forms.Label();
            this.CalificacionesAlumnosLabel = new System.Windows.Forms.Label();
            this.DescargarButton = new System.Windows.Forms.Button();
            this.InformacionAlumnosRespuestaLabel = new System.Windows.Forms.Label();
            this.CalificacionesAlumnosRespuestaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InformacionAlumnosLabel
            // 
            this.InformacionAlumnosLabel.AutoSize = true;
            this.InformacionAlumnosLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformacionAlumnosLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InformacionAlumnosLabel.Location = new System.Drawing.Point(12, 9);
            this.InformacionAlumnosLabel.Name = "InformacionAlumnosLabel";
            this.InformacionAlumnosLabel.Size = new System.Drawing.Size(183, 23);
            this.InformacionAlumnosLabel.TabIndex = 0;
            this.InformacionAlumnosLabel.Text = "Información personal";
            // 
            // CalificacionesAlumnosLabel
            // 
            this.CalificacionesAlumnosLabel.AutoSize = true;
            this.CalificacionesAlumnosLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalificacionesAlumnosLabel.Location = new System.Drawing.Point(12, 245);
            this.CalificacionesAlumnosLabel.Name = "CalificacionesAlumnosLabel";
            this.CalificacionesAlumnosLabel.Size = new System.Drawing.Size(122, 23);
            this.CalificacionesAlumnosLabel.TabIndex = 1;
            this.CalificacionesAlumnosLabel.Text = "Calificaciones";
            // 
            // DescargarButton
            // 
            this.DescargarButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescargarButton.Location = new System.Drawing.Point(578, 403);
            this.DescargarButton.Name = "DescargarButton";
            this.DescargarButton.Size = new System.Drawing.Size(210, 35);
            this.DescargarButton.TabIndex = 2;
            this.DescargarButton.Text = "Descargar calificaciones";
            this.DescargarButton.UseVisualStyleBackColor = true;
            this.DescargarButton.Click += new System.EventHandler(this.DescargarButton_Click);
            // 
            // InformacionAlumnosRespuestaLabel
            // 
            this.InformacionAlumnosRespuestaLabel.AutoSize = true;
            this.InformacionAlumnosRespuestaLabel.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformacionAlumnosRespuestaLabel.Location = new System.Drawing.Point(12, 52);
            this.InformacionAlumnosRespuestaLabel.Name = "InformacionAlumnosRespuestaLabel";
            this.InformacionAlumnosRespuestaLabel.Size = new System.Drawing.Size(21, 20);
            this.InformacionAlumnosRespuestaLabel.TabIndex = 3;
            this.InformacionAlumnosRespuestaLabel.Text = "   ";
            //this.InformacionAlumnosRespuestaLabel.Click += new System.EventHandler(this.InformacionAlumnosRespuestaLabel_Click);
            // 
            // CalificacionesAlumnosRespuestaLabel
            // 
            this.CalificacionesAlumnosRespuestaLabel.AutoSize = true;
            this.CalificacionesAlumnosRespuestaLabel.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalificacionesAlumnosRespuestaLabel.Location = new System.Drawing.Point(12, 287);
            this.CalificacionesAlumnosRespuestaLabel.Name = "CalificacionesAlumnosRespuestaLabel";
            this.CalificacionesAlumnosRespuestaLabel.Size = new System.Drawing.Size(21, 20);
            this.CalificacionesAlumnosRespuestaLabel.TabIndex = 4;
            this.CalificacionesAlumnosRespuestaLabel.Text = "   ";
            //this.CalificacionesAlumnosRespuestaLabel.Click += new System.EventHandler(this.CalificacionesAlumnosRespuestaLabel_Click);
            // 
            // AlumnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalificacionesAlumnosRespuestaLabel);
            this.Controls.Add(this.InformacionAlumnosRespuestaLabel);
            this.Controls.Add(this.DescargarButton);
            this.Controls.Add(this.CalificacionesAlumnosLabel);
            this.Controls.Add(this.InformacionAlumnosLabel);
            this.Name = "AlumnosForm";
            this.Text = "Alumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InformacionAlumnosLabel;
        private System.Windows.Forms.Label CalificacionesAlumnosLabel;
        private System.Windows.Forms.Button DescargarButton;
        private System.Windows.Forms.Label InformacionAlumnosRespuestaLabel;
        private System.Windows.Forms.Label CalificacionesAlumnosRespuestaLabel;
    }
}