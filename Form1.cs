using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCopier
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLocalizar_Click(object sender, EventArgs e)
		{
			if (this.folderBrowserDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			this.txtPastaPcfCustom.Text = this.folderBrowserDialog.SelectedPath;
		}

		private void btnLocalizarCopiar_Click(object sender, EventArgs e)
		{
			if (this.folderBrowserDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			this.txtCopiarPara.Text = this.folderBrowserDialog.SelectedPath;
		}

		private void btnCopiar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.txtPastaPcfCustom.Text))
			{
				MessageBox.Show("Informe o campo Pasta 'Pasta PCFCustom280280'.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (string.IsNullOrEmpty(this.txtTelas.Text))
			{
				MessageBox.Show("Informe o campo 'Telas'.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (string.IsNullOrEmpty(this.txtCopiarPara.Text))
			{
				MessageBox.Show("Informe o campo 'Copiar para'.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					string copiarParaPath = this.txtCopiarPara.Text + @"\";

					string[] telas = this.txtTelas.Text.Split(';');

					string bllSourcePath = this.txtPastaPcfCustom.Text + @"\PCF4CustomPM028280\BLL\";
					string htmlSourcePath = this.txtPastaPcfCustom.Text + @"\PCF4CustomPM028280\Content\pages\MWS\";
					string controllerSourcePath = this.txtPastaPcfCustom.Text + @"\PCF4CustomPM028280\Controllers\";
					string dtoSourcePath = this.txtPastaPcfCustom.Text + @"\PCF4CustomPM028280\DTO\";
					string repositorySourcePath = this.txtPastaPcfCustom.Text + @"\PCF4CustomPM028280\Repository\";
					string jsSourcePath = this.txtPastaPcfCustom.Text + @"\PCF4CustomPM028280\Scripts\pages\MWS\";

					//string bllDestPath        = this.txtCopiarPara + @"\PCF4CustomPM028280\BLL\";
					//string htmlDestPath       = this.txtCopiarPara + @"\PCF4CustomPM028280\Content\pages\MWS\";
					//string controllerDestPath = this.txtCopiarPara + @"\PCF4CustomPM028280\Controllers\";
					//string dtoDestPath        = this.txtCopiarPara + @"\PCF4CustomPM028280\DTO\";
					//string repositoryDestPath = this.txtCopiarPara + @"\PCF4CustomPM028280\Repository\";
					//string jsDestPath         = this.txtCopiarPara + @"\PCF4CustomPM028280\Scripts\pages\MWS\";

					foreach (string tela in telas)
					{
						string bllFile        = Path.Combine(bllSourcePath, tela + "BLL.cs");
						string htmlFile       = Path.Combine(htmlSourcePath, tela + ".html");
						string controllerFile = Path.Combine(controllerSourcePath, tela + "Controller.cs");
						string dtoFile        = Path.Combine(dtoSourcePath, tela + "DTO.cs");
						string repositoryFile = Path.Combine(repositorySourcePath, tela + "Repository.cs");
						string jsFile         = Path.Combine(jsSourcePath, tela + ".js");

						string targetPath = copiarParaPath + tela;

						if (!Directory.Exists(targetPath))
						{
							Directory.CreateDirectory(targetPath);
						}

						Copiar(bllFile, Path.Combine(targetPath, tela + "BLL.cs")); Thread.Sleep(1);
						Copiar(htmlFile, Path.Combine(targetPath, tela + ".html")); Thread.Sleep(1);
						Copiar(controllerFile, Path.Combine(targetPath, tela + "Controller.cs")); Thread.Sleep(1);
						Copiar(dtoFile, Path.Combine(targetPath, tela + "DTO.cs")); Thread.Sleep(1);
						Copiar(repositoryFile, Path.Combine(targetPath, tela + "Repository.cs")); Thread.Sleep(1);
						Copiar(jsFile, Path.Combine(targetPath, tela + ".js")); Thread.Sleep(1);

						Compactar(targetPath); Thread.Sleep(1);
					}

					this.statusLabel.Text = "Cópia concluída!";
				}
				catch (Exception ex)
				{
					MessageBox.Show("Ocorreu um erro ao tentar copiar!\n\n" + ex.Message);
				}
			}
		}

		private void Copiar(string sourceFile, string targetFile)
		{
			Status("Copiando arquivos... (" + sourceFile + ")");

			File.Copy(sourceFile, targetFile, true);
		}

		private void Compactar(string path)
		{
			Status("Compactando pasta(s)... (" + path + ")");

			if (File.Exists(path + ".zip"))
			{
				File.Delete(path + ".zip");
			}

			ZipFile.CreateFromDirectory(path, path + ".zip");

			Directory.Delete(path, true);
		}

		private void Status(string message)
		{
			this.statusLabel.Text = message;

			this.Update();
		}
	}
}
