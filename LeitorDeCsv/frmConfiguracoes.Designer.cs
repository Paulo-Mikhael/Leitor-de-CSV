using System.Drawing;
using System.Windows.Forms;

namespace LeitorDeCsv
{
	partial class frmConfiguracoes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracoes));
			this.btnMudarXlsx = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblXlsxDirectory = new System.Windows.Forms.Label();
			this.btnMudarCsv = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblCsvDirectory = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tbCelula = new System.Windows.Forms.TextBox();
			this.tbPlanilha = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnMudarXlsx
			// 
			this.btnMudarXlsx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnMudarXlsx.Location = new System.Drawing.Point(609, 24);
			this.btnMudarXlsx.Name = "btnMudarXlsx";
			this.btnMudarXlsx.Size = new System.Drawing.Size(76, 28);
			this.btnMudarXlsx.TabIndex = 0;
			this.btnMudarXlsx.Text = "Mudar";
			this.btnMudarXlsx.UseVisualStyleBackColor = true;
			this.btnMudarXlsx.Click += new System.EventHandler(this.btnMudarXlsx_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(12, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Arquivo xlsx atual:";
			// 
			// lblXlsxDirectory
			// 
			this.lblXlsxDirectory.AutoSize = true;
			this.lblXlsxDirectory.ForeColor = System.Drawing.Color.Coral;
			this.lblXlsxDirectory.Location = new System.Drawing.Point(12, 73);
			this.lblXlsxDirectory.Name = "lblXlsxDirectory";
			this.lblXlsxDirectory.Size = new System.Drawing.Size(267, 17);
			this.lblXlsxDirectory.TabIndex = 1;
			this.lblXlsxDirectory.Text = "C:\\Documents\\Programação\\Planilha.xlsx";
			// 
			// btnMudarCsv
			// 
			this.btnMudarCsv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnMudarCsv.Location = new System.Drawing.Point(609, 118);
			this.btnMudarCsv.Name = "btnMudarCsv";
			this.btnMudarCsv.Size = new System.Drawing.Size(76, 28);
			this.btnMudarCsv.TabIndex = 0;
			this.btnMudarCsv.Text = "Mudar";
			this.btnMudarCsv.UseVisualStyleBackColor = true;
			this.btnMudarCsv.Click += new System.EventHandler(this.btnMudarCsv_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(12, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Arquivo CSV atual:";
			// 
			// lblCsvDirectory
			// 
			this.lblCsvDirectory.AutoSize = true;
			this.lblCsvDirectory.ForeColor = System.Drawing.Color.Coral;
			this.lblCsvDirectory.Location = new System.Drawing.Point(12, 154);
			this.lblCsvDirectory.Name = "lblCsvDirectory";
			this.lblCsvDirectory.Size = new System.Drawing.Size(251, 17);
			this.lblCsvDirectory.TabIndex = 1;
			this.lblCsvDirectory.Text = "C:\\Documents\\Programação\\Dados.csv";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(12, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Planilha";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.SystemColors.Control;
			this.label6.Location = new System.Drawing.Point(12, 107);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(165, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Arquivo separado por vírgulas";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(23, 220);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(248, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Configurações da planilha:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(23, 289);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "Célula inicial:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.SystemColors.Control;
			this.label7.Location = new System.Drawing.Point(23, 272);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "De A a Z";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label10.ForeColor = System.Drawing.SystemColors.Control;
			this.label10.Location = new System.Drawing.Point(23, 327);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(136, 20);
			this.label10.TabIndex = 1;
			this.label10.Text = "Nome da planilha:";
			// 
			// tbCelula
			// 
			this.tbCelula.Location = new System.Drawing.Point(120, 281);
			this.tbCelula.Name = "tbCelula";
			this.tbCelula.Size = new System.Drawing.Size(51, 25);
			this.tbCelula.TabIndex = 3;
			// 
			// tbPlanilha
			// 
			this.tbPlanilha.Location = new System.Drawing.Point(165, 326);
			this.tbPlanilha.Name = "tbPlanilha";
			this.tbPlanilha.Size = new System.Drawing.Size(187, 25);
			this.tbPlanilha.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.label11.ForeColor = System.Drawing.Color.Gold;
			this.label11.Location = new System.Drawing.Point(396, 219);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(68, 25);
			this.label11.TabIndex = 1;
			this.label11.Text = "Avisos";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.label12.ForeColor = System.Drawing.Color.Gold;
			this.label12.Location = new System.Drawing.Point(396, 259);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(327, 95);
			this.label12.TabIndex = 1;
			this.label12.Text = "Ficar com a planilha aberta no Excel, \r\nimpossibilitará o software modificar a pl" +
    "anilha;\r\n\r\nO arquivo CSV deve conter um cabeçalho, pois \r\no software ignorará a " +
    "primeira linha;\r\n";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblCsvDirectory);
			this.groupBox1.Controls.Add(this.lblXlsxDirectory);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnMudarCsv);
			this.groupBox1.Controls.Add(this.btnMudarXlsx);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Location = new System.Drawing.Point(19, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(704, 188);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Diretórios";
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(277, 220);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 29);
			this.btnSalvar.TabIndex = 5;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// frmConfiguracoes
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Blue;
			this.ClientSize = new System.Drawing.Size(750, 376);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tbPlanilha);
			this.Controls.Add(this.tbCelula);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label7);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmConfiguracoes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Configurações";
			this.Load += new System.EventHandler(this.frmConfiguracoes_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnMudarXlsx;
		private Label label1;
		private Label lblXlsxDirectory;
		private Button btnMudarCsv;
		private Label label3;
		private Label lblCsvDirectory;
		private Label label5;
		private Label label6;
		private Label label2;
		private Label label4;
		private Label label7;
		private Label label10;
		private TextBox tbCelula;
		private TextBox tbPlanilha;
		private Label label11;
		private Label label12;
		private GroupBox groupBox1;
		private Button btnSalvar;
	}
}