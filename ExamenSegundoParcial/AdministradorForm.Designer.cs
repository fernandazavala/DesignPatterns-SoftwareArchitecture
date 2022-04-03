
namespace ExamenSegundoParcial
{
    partial class AdministradorForm
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
            this.InformacionAdministradorLabel = new System.Windows.Forms.Label();
            this.InformacionAdministradorRespuestaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InformacionAdministradorLabel
            // 
            this.InformacionAdministradorLabel.AutoSize = true;
            this.InformacionAdministradorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformacionAdministradorLabel.Location = new System.Drawing.Point(12, 9);
            this.InformacionAdministradorLabel.Name = "InformacionAdministradorLabel";
            this.InformacionAdministradorLabel.Size = new System.Drawing.Size(183, 23);
            this.InformacionAdministradorLabel.TabIndex = 0;
            this.InformacionAdministradorLabel.Text = "Información personal";
            // 
            // InformacionAdministradorRespuestaLabel
            // 
            this.InformacionAdministradorRespuestaLabel.AutoSize = true;
            this.InformacionAdministradorRespuestaLabel.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformacionAdministradorRespuestaLabel.Location = new System.Drawing.Point(12, 57);
            this.InformacionAdministradorRespuestaLabel.Name = "InformacionAdministradorRespuestaLabel";
            this.InformacionAdministradorRespuestaLabel.Size = new System.Drawing.Size(50, 20);
            this.InformacionAdministradorRespuestaLabel.TabIndex = 1;
            this.InformacionAdministradorRespuestaLabel.Text = "label1";
            // 
            // AdministradorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InformacionAdministradorRespuestaLabel);
            this.Controls.Add(this.InformacionAdministradorLabel);
            this.Name = "AdministradorForm";
            this.Text = "Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InformacionAdministradorLabel;
        private System.Windows.Forms.Label InformacionAdministradorRespuestaLabel;
    }
}