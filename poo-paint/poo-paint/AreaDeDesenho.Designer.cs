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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // comboxFerramenta
            // 
            this.comboxFerramenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboxFerramenta.FormattingEnabled = true;
            this.comboxFerramenta.Location = new System.Drawing.Point(0, 0);
            this.comboxFerramenta.Margin = new System.Windows.Forms.Padding(2);
            this.comboxFerramenta.Name = "comboxFerramenta";
            this.comboxFerramenta.Size = new System.Drawing.Size(1055, 21);
            this.comboxFerramenta.TabIndex = 0;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 25);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(59, 26);
            this.btnAbrir.TabIndex = 2;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(75, 25);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(66, 26);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // AreaDeDesenho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 607);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.comboxFerramenta);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}