
namespace ExamenSegundoParcial
{
    partial class MenuForm
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
            this.BienvenidoLabel = new System.Windows.Forms.Label();
            this.IngresaLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.EntrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BienvenidoLabel
            // 
            this.BienvenidoLabel.AutoSize = true;
            this.BienvenidoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BienvenidoLabel.Location = new System.Drawing.Point(12, 9);
            this.BienvenidoLabel.Name = "BienvenidoLabel";
            this.BienvenidoLabel.Size = new System.Drawing.Size(196, 24);
            this.BienvenidoLabel.TabIndex = 0;
            this.BienvenidoLabel.Text = "Bienvenido al sitio UP";
            // 
            // IngresaLabel
            // 
            this.IngresaLabel.AutoSize = true;
            this.IngresaLabel.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresaLabel.Location = new System.Drawing.Point(12, 62);
            this.IngresaLabel.Name = "IngresaLabel";
            this.IngresaLabel.Size = new System.Drawing.Size(313, 20);
            this.IngresaLabel.TabIndex = 1;
            this.IngresaLabel.Text = "Ingresa email y contraseña para iniciar sesión";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(16, 130);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(184, 25);
            this.emailBox.TabIndex = 2;
            this.emailBox.Text = "E-mail";
            this.emailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(16, 184);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(184, 25);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.Text = "Contraseña";
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EntrarButton
            // 
            this.EntrarButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntrarButton.Location = new System.Drawing.Point(16, 244);
            this.EntrarButton.Name = "EntrarButton";
            this.EntrarButton.Size = new System.Drawing.Size(75, 31);
            this.EntrarButton.TabIndex = 4;
            this.EntrarButton.Text = "Entrar";
            this.EntrarButton.UseVisualStyleBackColor = true;
            this.EntrarButton.Click += new System.EventHandler(this.EntrarButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EntrarButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.IngresaLabel);
            this.Controls.Add(this.BienvenidoLabel);
            this.Name = "MenuForm";
            this.Text = "Menú principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BienvenidoLabel;
        private System.Windows.Forms.Label IngresaLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button EntrarButton;
    }
}

