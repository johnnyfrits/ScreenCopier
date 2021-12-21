namespace ScreenCopier
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
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCopiar = new System.Windows.Forms.Button();
			this.btnLocalizarCopiar = new System.Windows.Forms.Button();
			this.txtCopiarPara = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTelas = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnLocalizarPcfCustom = new System.Windows.Forms.Button();
			this.txtPastaPcfCustom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.statusLabel = new System.Windows.Forms.Label();
			this.chkCompactar = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.chkCompactar);
			this.panel1.Controls.Add(this.statusLabel);
			this.panel1.Controls.Add(this.btnCopiar);
			this.panel1.Controls.Add(this.btnLocalizarCopiar);
			this.panel1.Controls.Add(this.txtCopiarPara);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtTelas);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnLocalizarPcfCustom);
			this.panel1.Controls.Add(this.txtPastaPcfCustom);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(928, 283);
			this.panel1.TabIndex = 0;
			// 
			// btnCopiar
			// 
			this.btnCopiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopiar.Location = new System.Drawing.Point(400, 192);
			this.btnCopiar.Name = "btnCopiar";
			this.btnCopiar.Size = new System.Drawing.Size(125, 50);
			this.btnCopiar.TabIndex = 10;
			this.btnCopiar.Text = "&Copiar";
			this.btnCopiar.UseVisualStyleBackColor = true;
			this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
			// 
			// btnLocalizarCopiar
			// 
			this.btnLocalizarCopiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLocalizarCopiar.Location = new System.Drawing.Point(878, 104);
			this.btnLocalizarCopiar.Name = "btnLocalizarCopiar";
			this.btnLocalizarCopiar.Size = new System.Drawing.Size(35, 30);
			this.btnLocalizarCopiar.TabIndex = 8;
			this.btnLocalizarCopiar.Text = "...";
			this.btnLocalizarCopiar.UseVisualStyleBackColor = true;
			this.btnLocalizarCopiar.Click += new System.EventHandler(this.btnLocalizarCopiar_Click);
			// 
			// txtCopiarPara
			// 
			this.txtCopiarPara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCopiarPara.Location = new System.Drawing.Point(218, 106);
			this.txtCopiarPara.Name = "txtCopiarPara";
			this.txtCopiarPara.Size = new System.Drawing.Size(654, 26);
			this.txtCopiarPara.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(120, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "C&opiar para:";
			// 
			// txtTelas
			// 
			this.txtTelas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTelas.Location = new System.Drawing.Point(219, 52);
			this.txtTelas.Name = "txtTelas";
			this.txtTelas.Size = new System.Drawing.Size(654, 26);
			this.txtTelas.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(154, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "&Tela(s):";
			// 
			// btnLocalizarPcfCustom
			// 
			this.btnLocalizarPcfCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLocalizarPcfCustom.Location = new System.Drawing.Point(879, 13);
			this.btnLocalizarPcfCustom.Name = "btnLocalizarPcfCustom";
			this.btnLocalizarPcfCustom.Size = new System.Drawing.Size(35, 30);
			this.btnLocalizarPcfCustom.TabIndex = 2;
			this.btnLocalizarPcfCustom.Text = "...";
			this.btnLocalizarPcfCustom.UseVisualStyleBackColor = true;
			this.btnLocalizarPcfCustom.Click += new System.EventHandler(this.btnLocalizar_Click);
			// 
			// txtPastaPcfCustom
			// 
			this.txtPastaPcfCustom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPastaPcfCustom.Location = new System.Drawing.Point(219, 15);
			this.txtPastaPcfCustom.Name = "txtPastaPcfCustom";
			this.txtPastaPcfCustom.Size = new System.Drawing.Size(654, 26);
			this.txtPastaPcfCustom.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Pasta PCFCustom280280:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(215, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "(Ex.: C0733;C0789)";
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Location = new System.Drawing.Point(17, 246);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(0, 20);
			this.statusLabel.TabIndex = 11;
			// 
			// chkCompactar
			// 
			this.chkCompactar.AutoSize = true;
			this.chkCompactar.Checked = true;
			this.chkCompactar.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCompactar.Location = new System.Drawing.Point(218, 143);
			this.chkCompactar.Name = "chkCompactar";
			this.chkCompactar.Size = new System.Drawing.Size(177, 24);
			this.chkCompactar.TabIndex = 9;
			this.chkCompactar.Text = "Compactar para .zip";
			this.chkCompactar.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(928, 283);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Copiador de Telas";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnLocalizarPcfCustom;
		private System.Windows.Forms.TextBox txtPastaPcfCustom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Button btnCopiar;
		private System.Windows.Forms.Button btnLocalizarCopiar;
		private System.Windows.Forms.TextBox txtCopiarPara;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTelas;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.CheckBox chkCompactar;
	}
}

