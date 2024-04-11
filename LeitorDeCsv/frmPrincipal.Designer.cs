using System.Drawing;
using System.Windows.Forms;

namespace LeitorDeCsv
{
	partial class frmPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbId = new System.Windows.Forms.TextBox();
			this.tbNome = new System.Windows.Forms.TextBox();
			this.tbEndereco = new System.Windows.Forms.TextBox();
			this.tbBairro = new System.Windows.Forms.TextBox();
			this.tbMunicipio = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.tbEstado = new System.Windows.Forms.TextBox();
			this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
			this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
			this.mtbCep = new System.Windows.Forms.MaskedTextBox();
			this.cdSexo = new System.Windows.Forms.ComboBox();
			this.tsFerramentas = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnGerar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnPlanilha = new System.Windows.Forms.ToolStripButton();
			this.btnConfiguracoes = new System.Windows.Forms.ToolStripButton();
			this.tsFerramentas.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(218, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cadastro de Clientes";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(105, 165);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "ID:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(96, 199);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "CPF:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(82, 233);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "Nome:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(90, 267);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 17);
			this.label5.TabIndex = 1;
			this.label5.Text = "Sexo:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(63, 301);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "Endereço:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(82, 335);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 17);
			this.label7.TabIndex = 1;
			this.label7.Text = "Bairro:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(57, 369);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 17);
			this.label8.TabIndex = 1;
			this.label8.Text = "Município:";
			// 
			// tbId
			// 
			this.tbId.BackColor = System.Drawing.Color.LightSkyBlue;
			this.tbId.Location = new System.Drawing.Point(137, 162);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(100, 25);
			this.tbId.TabIndex = 0;
			this.tbId.TabStop = false;
			// 
			// tbNome
			// 
			this.tbNome.BackColor = System.Drawing.Color.LightSkyBlue;
			this.tbNome.Location = new System.Drawing.Point(137, 230);
			this.tbNome.Name = "tbNome";
			this.tbNome.Size = new System.Drawing.Size(517, 25);
			this.tbNome.TabIndex = 2;
			// 
			// tbEndereco
			// 
			this.tbEndereco.BackColor = System.Drawing.Color.LightSkyBlue;
			this.tbEndereco.Location = new System.Drawing.Point(137, 298);
			this.tbEndereco.Name = "tbEndereco";
			this.tbEndereco.Size = new System.Drawing.Size(324, 25);
			this.tbEndereco.TabIndex = 4;
			// 
			// tbBairro
			// 
			this.tbBairro.BackColor = System.Drawing.Color.LightSkyBlue;
			this.tbBairro.Location = new System.Drawing.Point(137, 332);
			this.tbBairro.Name = "tbBairro";
			this.tbBairro.Size = new System.Drawing.Size(324, 25);
			this.tbBairro.TabIndex = 5;
			// 
			// tbMunicipio
			// 
			this.tbMunicipio.BackColor = System.Drawing.Color.LightSkyBlue;
			this.tbMunicipio.Location = new System.Drawing.Point(137, 366);
			this.tbMunicipio.Name = "tbMunicipio";
			this.tbMunicipio.Size = new System.Drawing.Size(324, 25);
			this.tbMunicipio.TabIndex = 6;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(479, 301);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 17);
			this.label9.TabIndex = 1;
			this.label9.Text = "Número:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(506, 335);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 17);
			this.label10.TabIndex = 1;
			this.label10.Text = "CEP:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(488, 369);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 17);
			this.label11.TabIndex = 1;
			this.label11.Text = "Estado:";
			// 
			// tbEstado
			// 
			this.tbEstado.BackColor = System.Drawing.Color.LightSkyBlue;
			this.tbEstado.Location = new System.Drawing.Point(547, 366);
			this.tbEstado.Name = "tbEstado";
			this.tbEstado.Size = new System.Drawing.Size(107, 25);
			this.tbEstado.TabIndex = 9;
			// 
			// mtbCpf
			// 
			this.mtbCpf.BackColor = System.Drawing.Color.LightSkyBlue;
			this.mtbCpf.Location = new System.Drawing.Point(137, 196);
			this.mtbCpf.Mask = "999,999,999-99";
			this.mtbCpf.Name = "mtbCpf";
			this.mtbCpf.Size = new System.Drawing.Size(100, 25);
			this.mtbCpf.TabIndex = 1;
			// 
			// mtbNumero
			// 
			this.mtbNumero.BackColor = System.Drawing.Color.LightSkyBlue;
			this.mtbNumero.Location = new System.Drawing.Point(547, 298);
			this.mtbNumero.Mask = "(99) 99999-9999";
			this.mtbNumero.Name = "mtbNumero";
			this.mtbNumero.Size = new System.Drawing.Size(107, 25);
			this.mtbNumero.TabIndex = 7;
			// 
			// mtbCep
			// 
			this.mtbCep.BackColor = System.Drawing.Color.LightSkyBlue;
			this.mtbCep.Location = new System.Drawing.Point(547, 332);
			this.mtbCep.Mask = "99,999-999";
			this.mtbCep.Name = "mtbCep";
			this.mtbCep.Size = new System.Drawing.Size(107, 25);
			this.mtbCep.TabIndex = 8;
			// 
			// cdSexo
			// 
			this.cdSexo.BackColor = System.Drawing.Color.LightSkyBlue;
			this.cdSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cdSexo.FormattingEnabled = true;
			this.cdSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
			this.cdSexo.Location = new System.Drawing.Point(137, 264);
			this.cdSexo.Name = "cdSexo";
			this.cdSexo.Size = new System.Drawing.Size(194, 25);
			this.cdSexo.TabIndex = 3;
			// 
			// tsFerramentas
			// 
			this.tsFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPlanilha,
            this.toolStripSeparator1,
            this.toolStripSeparator3,
            this.btnConfiguracoes,
            this.toolStripSeparator2});
			this.tsFerramentas.Location = new System.Drawing.Point(0, 0);
			this.tsFerramentas.Name = "tsFerramentas";
			this.tsFerramentas.Size = new System.Drawing.Size(739, 54);
			this.tsFerramentas.TabIndex = 0;
			this.tsFerramentas.Text = "toolStrip1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
			// 
			// btnGerar
			// 
			this.btnGerar.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnGerar.Location = new System.Drawing.Point(547, 162);
			this.btnGerar.Name = "btnGerar";
			this.btnGerar.Size = new System.Drawing.Size(107, 36);
			this.btnGerar.TabIndex = 11;
			this.btnGerar.Text = "Gerar dados";
			this.btnGerar.UseVisualStyleBackColor = false;
			this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.Blue;
			this.btnSalvar.FlatAppearance.BorderSize = 2;
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.Location = new System.Drawing.Point(336, 447);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(96, 45);
			this.btnSalvar.TabIndex = 10;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnPlanilha
			// 
			this.btnPlanilha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnPlanilha.Image = global::LeitorDeCsv.Properties.Resources.csv_32px;
			this.btnPlanilha.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnPlanilha.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPlanilha.Name = "btnPlanilha";
			this.btnPlanilha.Size = new System.Drawing.Size(51, 51);
			this.btnPlanilha.Text = "Ler CSV";
			this.btnPlanilha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnPlanilha.ToolTipText = "Ler o CSV especificado e carregar na planilha especificada";
			this.btnPlanilha.Click += new System.EventHandler(this.btnPlanilha_Click);
			// 
			// btnConfiguracoes
			// 
			this.btnConfiguracoes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnConfiguracoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnConfiguracoes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnConfiguracoes.Image = global::LeitorDeCsv.Properties.Resources.configuracao;
			this.btnConfiguracoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnConfiguracoes.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnConfiguracoes.Name = "btnConfiguracoes";
			this.btnConfiguracoes.Size = new System.Drawing.Size(88, 51);
			this.btnConfiguracoes.Text = "Configurações";
			this.btnConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnConfiguracoes.ToolTipText = "Configure os diretórios da planilha e CSV onde deseja salvar os dados";
			this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
			// 
			// frmPrincipal
			// 
			this.AcceptButton = this.btnSalvar;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.DodgerBlue;
			this.ClientSize = new System.Drawing.Size(739, 517);
			this.Controls.Add(this.btnGerar);
			this.Controls.Add(this.tsFerramentas);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.cdSexo);
			this.Controls.Add(this.mtbCep);
			this.Controls.Add(this.mtbNumero);
			this.Controls.Add(this.mtbCpf);
			this.Controls.Add(this.tbNome);
			this.Controls.Add(this.tbMunicipio);
			this.Controls.Add(this.tbBairro);
			this.Controls.Add(this.tbEndereco);
			this.Controls.Add(this.tbEstado);
			this.Controls.Add(this.tbId);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.Control;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de dados";
			this.Load += new System.EventHandler(this.frmPrincipal_Load);
			this.tsFerramentas.ResumeLayout(false);
			this.tsFerramentas.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private TextBox tbId;
		private TextBox tbNome;
		private TextBox tbEndereco;
		private TextBox tbBairro;
		private TextBox tbMunicipio;
		private Label label9;
		private Label label10;
		private Label label11;
		private TextBox tbEstado;
		private MaskedTextBox mtbCpf;
		private MaskedTextBox mtbNumero;
		private MaskedTextBox mtbCep;
		private ComboBox cdSexo;
		private Button btnSalvar;
		private ToolStrip tsFerramentas;
		private ToolStripButton btnPlanilha;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton btnConfiguracoes;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripSeparator toolStripSeparator2;
		private Button btnGerar;
	}
}