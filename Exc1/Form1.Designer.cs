namespace Exc1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCriptografia = new DevComponents.DotNetBar.ButtonX();
            this.txtCriptografia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPosicao = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPosicao = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnCriptografia
            // 
            this.btnCriptografia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCriptografia.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnCriptografia.Location = new System.Drawing.Point(12, 222);
            this.btnCriptografia.Name = "btnCriptografia";
            this.btnCriptografia.Size = new System.Drawing.Size(176, 41);
            this.btnCriptografia.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnCriptografia.Symbol = "";
            this.btnCriptografia.TabIndex = 0;
            this.btnCriptografia.Text = " Criptografia";
            this.btnCriptografia.Click += new System.EventHandler(this.btnCriptografia_Click);
            // 
            // txtCriptografia
            // 
            // 
            // 
            // 
            this.txtCriptografia.Border.Class = "TextBoxBorder";
            this.txtCriptografia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCriptografia.Location = new System.Drawing.Point(12, 12);
            this.txtCriptografia.Multiline = true;
            this.txtCriptografia.Name = "txtCriptografia";
            this.txtCriptografia.PreventEnterBeep = true;
            this.txtCriptografia.ReadOnly = true;
            this.txtCriptografia.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCriptografia.Size = new System.Drawing.Size(723, 204);
            this.txtCriptografia.TabIndex = 0;
            // 
            // txtPosicao
            // 
            // 
            // 
            // 
            this.txtPosicao.Border.Class = "TextBoxBorder";
            this.txtPosicao.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPosicao.Location = new System.Drawing.Point(583, 222);
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.PreventEnterBeep = true;
            this.txtPosicao.Size = new System.Drawing.Size(152, 30);
            this.txtPosicao.TabIndex = 1;
            // 
            // lblPosicao
            // 
            // 
            // 
            // 
            this.lblPosicao.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPosicao.ForeColor = System.Drawing.Color.White;
            this.lblPosicao.Location = new System.Drawing.Point(392, 222);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(185, 30);
            this.lblPosicao.Symbol = "";
            this.lblPosicao.TabIndex = 2;
            this.lblPosicao.Text = " Digite a Posição:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(747, 275);
            this.Controls.Add(this.lblPosicao);
            this.Controls.Add(this.txtPosicao);
            this.Controls.Add(this.txtCriptografia);
            this.Controls.Add(this.btnCriptografia);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnCriptografia;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCriptografia;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPosicao;
        private DevComponents.DotNetBar.LabelX lblPosicao;
    }
}

