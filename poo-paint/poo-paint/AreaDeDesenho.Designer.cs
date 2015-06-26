namespace poo_paint
{
    partial class AreaDeDesenho
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
            this.comboxFerramenta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboxFerramenta
            // 
            this.comboxFerramenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboxFerramenta.FormattingEnabled = true;
            this.comboxFerramenta.Location = new System.Drawing.Point(0, 0);
            this.comboxFerramenta.Name = "comboxFerramenta";
            this.comboxFerramenta.Size = new System.Drawing.Size(530, 24);
            this.comboxFerramenta.TabIndex = 0;
            // 
            // AreaDeDesenho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 451);
            this.Controls.Add(this.comboxFerramenta);
            this.Name = "AreaDeDesenho";
            this.Text = "AreaDeDesenho";
            this.Load += new System.EventHandler(this.AreaDeDesenho_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Desenha);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DesenhaCliqueInicial);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DesenhaArrasta);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DesenhaCliqueFinal);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxFerramenta;
    }
}