
namespace ExamenSegundoParcial
{
    partial class MaestrosForm
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
            this.InformacionMaestrosLabel = new System.Windows.Forms.Label();
            this.CalificacionesMaestrosLabel = new System.Windows.Forms.Label();
            this.InformacionMaestrosRespuestaLabel = new System.Windows.Forms.Label();
            this.CalificacionesMestrosRespuestaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InformacionMaestrosLabel
            // 
            this.InformacionMaestrosLabel.AutoSize = true;
            this.InformacionMaestrosLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformacionMaestrosLabel.Location = new System.Drawing.Point(12, 9);
            this.InformacionMaestrosLabel.Name = "InformacionMaestrosLabel";
            this.InformacionMaestrosLabel.Size = new System.Drawing.Size(183, 23);
            this.InformacionMaestrosLabel.TabIndex = 0;
            this.InformacionMaestrosLabel.Text = "Información personal";
            // 
            // CalificacionesMaestrosLabel
            // 
            this.CalificacionesMaestrosLabel.AutoSize = true;
            this.CalificacionesMaestrosLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalificacionesMaestrosLabel.Location = new System.Drawing.Point(12, 259);
            this.CalificacionesMaestrosLabel.Name = "CalificacionesMaestrosLabel";
            this.CalificacionesMaestrosLabel.Size = new System.Drawing.Size(210, 23);
            this.CalificacionesMaestrosLabel.TabIndex = 1;
            this.CalificacionesMaestrosLabel.Text = "Calificaciones y alumnos";
            // 
            // InformacionMaestrosRespuestaLabel
            // 
            this.InformacionMaestrosRespuestaLabel.AutoSize = true;
            this.InformacionMaestrosRespuestaLabel.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformacionMaestrosRespuestaLabel.Location = new System.Drawing.Point(12, 54);
            this.InformacionMaestrosRespuestaLabel.Name = "InformacionMaestrosRespuestaLabel";
            this.InformacionMaestrosRespuestaLabel.Size = new System.Drawing.Size(50, 20);
            this.InformacionMaestrosRespuestaLabel.TabIndex = 2;
            this.InformacionMaestrosRespuestaLabel.Text = "label1";
            // 
            // CalificacionesMestrosRespuestaLabel
            // 
            this.CalificacionesMestrosRespuestaLabel.AutoSize = true;
            this.CalificacionesMestrosRespuestaLabel.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalificacionesMestrosRespuestaLabel.Location = new System.Drawing.Point(16, 306);
            this.CalificacionesMestrosRespuestaLabel.Name = "CalificacionesMestrosRespuestaLabel";
            this.CalificacionesMestrosRespuestaLabel.Size = new System.Drawing.Size(50, 20);
            this.CalificacionesMestrosRespuestaLabel.TabIndex = 3;
            this.CalificacionesMestrosRespuestaLabel.Text = "label1";
            // 
            // MaestrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalificacionesMestrosRespuestaLabel);
            this.Controls.Add(this.InformacionMaestrosRespuestaLabel);
            this.Controls.Add(this.CalificacionesMaestrosLabel);
            this.Controls.Add(this.InformacionMaestrosLabel);
            this.Name = "MaestrosForm";
            this.Text = "Maestros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InformacionMaestrosLabel;
        private System.Windows.Forms.Label CalificacionesMaestrosLabel;
        private System.Windows.Forms.Label InformacionMaestrosRespuestaLabel;
        private System.Windows.Forms.Label CalificacionesMestrosRespuestaLabel;
    }
}