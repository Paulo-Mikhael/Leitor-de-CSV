using System.Drawing;
using System.Windows.Forms;

namespace LeitorDeCsv
{
	partial class frmPlanilha
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanilha));
			this.cdSexo = new System.Windows.Forms.ComboBox();
			this.mtbCep = new System.Windows.Forms.MaskedTextBox();
			this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
			this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
			this.tbNome = new System.Windows.Forms.TextBox();
			this.tbMunicipio = new System.Windows.Forms.TextBox();
			this.tbBairro = new System.Windows.Forms.TextBox();
			this.tbEndereco = new System.Windows.Forms.TextBox();
			this.tbEstado = new System.Windows.Forms.TextBox();
			this.tbId = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnProximo = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnUltimo = new System.Windows.Forms.Button();
			this.btnPrimeiro = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.tbLinha = new System.Windows.Forms.TextBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnAbrir = new System.Windows.Forms.Button();
			this.lblExcluirCarregando = new System.Windows.Forms.Label();
			this.tbPlanilha = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.btnConfig = new System.Windows.Forms.Button();
			this.btnAviso = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cdSexo
			// 
			this.cdSexo.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.cdSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cdSexo.FormattingEnabled = true;
			this.cdSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
			this.cdSexo.Location = new System.Drawing.Point(112, 191);
			this.cdSexo.Name = "cdSexo";
			this.cdSexo.Size = new System.Drawing.Size(194, 25);
			this.cdSexo.TabIndex = 3;
			// 
			// mtbCep
			// 
			this.mtbCep.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.mtbCep.Location = new System.Drawing.Point(522, 259);
			this.mtbCep.Mask = "99,999-999";
			this.mtbCep.Name = "mtbCep";
			this.mtbCep.Size = new System.Drawing.Size(107, 25);
			this.mtbCep.TabIndex = 8;
			// 
			// mtbNumero
			// 
			this.mtbNumero.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.mtbNumero.Location = new System.Drawing.Point(522, 225);
			this.mtbNumero.Mask = "(99) 99999-9999";
			this.mtbNumero.Name = "mtbNumero";
			this.mtbNumero.Size = new System.Drawing.Size(107, 25);
			this.mtbNumero.TabIndex = 7;
			// 
			// mtbCpf
			// 
			this.mtbCpf.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.mtbCpf.Location = new System.Drawing.Point(112, 123);
			this.mtbCpf.Mask = "999,999,999-99";
			this.mtbCpf.Name = "mtbCpf";
			this.mtbCpf.Size = new System.Drawing.Size(100, 25);
			this.mtbCpf.TabIndex = 1;
			// 
			// tbNome
			// 
			this.tbNome.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.tbNome.Location = new System.Drawing.Point(112, 157);
			this.tbNome.Name = "tbNome";
			this.tbNome.Size = new System.Drawing.Size(517, 25);
			this.tbNome.TabIndex = 2;
			// 
			// tbMunicipio
			// 
			this.tbMunicipio.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.tbMunicipio.Location = new System.Drawing.Point(112, 293);
			this.tbMunicipio.Name = "tbMunicipio";
			this.tbMunicipio.Size = new System.Drawing.Size(324, 25);
			this.tbMunicipio.TabIndex = 6;
			// 
			// tbBairro
			// 
			this.tbBairro.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.tbBairro.Location = new System.Drawing.Point(112, 259);
			this.tbBairro.Name = "tbBairro";
			this.tbBairro.Size = new System.Drawing.Size(324, 25);
			this.tbBairro.TabIndex = 5;
			// 
			// tbEndereco
			// 
			this.tbEndereco.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.tbEndereco.Location = new System.Drawing.Point(112, 225);
			this.tbEndereco.Name = "tbEndereco";
			this.tbEndereco.Size = new System.Drawing.Size(324, 25);
			this.tbEndereco.TabIndex = 4;
			// 
			// tbEstado
			// 
			this.tbEstado.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.tbEstado.Location = new System.Drawing.Point(522, 293);
			this.tbEstado.Name = "tbEstado";
			this.tbEstado.Size = new System.Drawing.Size(107, 25);
			this.tbEstado.TabIndex = 9;
			// 
			// tbId
			// 
			this.tbId.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.tbId.Enabled = false;
			this.tbId.Location = new System.Drawing.Point(112, 89);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(100, 25);
			this.tbId.TabIndex = 0;
			this.tbId.TabStop = false;
			this.tbId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(32, 296);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 17);
			this.label8.TabIndex = 13;
			this.label8.Text = "Município:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(57, 262);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 17);
			this.label7.TabIndex = 12;
			this.label7.Text = "Bairro:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(463, 296);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 17);
			this.label11.TabIndex = 11;
			this.label11.Text = "Estado:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(481, 262);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 17);
			this.label10.TabIndex = 10;
			this.label10.Text = "CEP:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(454, 228);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 17);
			this.label9.TabIndex = 9;
			this.label9.Text = "Número:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(38, 228);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "Endereço:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(65, 194);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "Sexo:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(57, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Nome:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(71, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 17);
			this.label3.TabIndex = 14;
			this.label3.Text = "CPF:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(80, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "ID:";
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.DarkOrchid;
			this.btnSalvar.FlatAppearance.BorderSize = 2;
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.Location = new System.Drawing.Point(38, 449);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(108, 37);
			this.btnSalvar.TabIndex = 0;
			this.btnSalvar.TabStop = false;
			this.btnSalvar.Text = "Salvar dados";
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(38, 414);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(50, 17);
			this.lblStatus.TabIndex = 5;
			this.lblStatus.Text = "Status:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(16, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 17);
			this.label1.TabIndex = 0;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAnterior
			// 
			this.btnAnterior.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnAnterior.FlatAppearance.BorderSize = 2;
			this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAnterior.Location = new System.Drawing.Point(431, 449);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(96, 37);
			this.btnAnterior.TabIndex = 0;
			this.btnAnterior.TabStop = false;
			this.btnAnterior.Text = "Anterior";
			this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAnterior.UseVisualStyleBackColor = false;
			this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
			// 
			// btnProximo
			// 
			this.btnProximo.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnProximo.FlatAppearance.BorderSize = 2;
			this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProximo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnProximo.Location = new System.Drawing.Point(533, 449);
			this.btnProximo.Name = "btnProximo";
			this.btnProximo.Size = new System.Drawing.Size(96, 37);
			this.btnProximo.TabIndex = 0;
			this.btnProximo.TabStop = false;
			this.btnProximo.Text = "Proximo";
			this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnProximo.UseVisualStyleBackColor = false;
			this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.DarkRed;
			this.btnExcluir.FlatAppearance.BorderSize = 2;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcluir.Location = new System.Drawing.Point(292, 449);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(96, 37);
			this.btnExcluir.TabIndex = 0;
			this.btnExcluir.TabStop = false;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnUltimo
			// 
			this.btnUltimo.BackColor = System.Drawing.Color.Orange;
			this.btnUltimo.FlatAppearance.BorderSize = 2;
			this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUltimo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUltimo.Location = new System.Drawing.Point(533, 394);
			this.btnUltimo.Name = "btnUltimo";
			this.btnUltimo.Size = new System.Drawing.Size(96, 37);
			this.btnUltimo.TabIndex = 0;
			this.btnUltimo.TabStop = false;
			this.btnUltimo.Text = "Ultimo";
			this.btnUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUltimo.UseVisualStyleBackColor = false;
			this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
			// 
			// btnPrimeiro
			// 
			this.btnPrimeiro.BackColor = System.Drawing.Color.Orange;
			this.btnPrimeiro.FlatAppearance.BorderSize = 2;
			this.btnPrimeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrimeiro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPrimeiro.Location = new System.Drawing.Point(431, 394);
			this.btnPrimeiro.Name = "btnPrimeiro";
			this.btnPrimeiro.Size = new System.Drawing.Size(96, 37);
			this.btnPrimeiro.TabIndex = 0;
			this.btnPrimeiro.TabStop = false;
			this.btnPrimeiro.Text = "Primeiro";
			this.btnPrimeiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrimeiro.UseVisualStyleBackColor = false;
			this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(38, 362);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(46, 17);
			this.label12.TabIndex = 5;
			this.label12.Text = "Linha:";
			// 
			// tbLinha
			// 
			this.tbLinha.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.tbLinha.Location = new System.Drawing.Point(90, 359);
			this.tbLinha.Name = "tbLinha";
			this.tbLinha.Size = new System.Drawing.Size(45, 25);
			this.tbLinha.TabIndex = 0;
			this.tbLinha.TabStop = false;
			this.tbLinha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbLinha.Leave += new System.EventHandler(this.tbLinha_Leave);
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblTotal.Location = new System.Drawing.Point(141, 362);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(25, 17);
			this.lblTotal.TabIndex = 5;
			this.lblTotal.Text = "/ 7";
			// 
			// btnAbrir
			// 
			this.btnAbrir.BackColor = System.Drawing.Color.DarkOrchid;
			this.btnAbrir.FlatAppearance.BorderSize = 2;
			this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAbrir.Location = new System.Drawing.Point(152, 449);
			this.btnAbrir.Name = "btnAbrir";
			this.btnAbrir.Size = new System.Drawing.Size(96, 37);
			this.btnAbrir.TabIndex = 0;
			this.btnAbrir.TabStop = false;
			this.btnAbrir.Text = "Atualizar";
			this.btnAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAbrir.UseVisualStyleBackColor = false;
			this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
			// 
			// lblExcluirCarregando
			// 
			this.lblExcluirCarregando.AutoSize = true;
			this.lblExcluirCarregando.Location = new System.Drawing.Point(296, 460);
			this.lblExcluirCarregando.Name = "lblExcluirCarregando";
			this.lblExcluirCarregando.Size = new System.Drawing.Size(91, 17);
			this.lblExcluirCarregando.TabIndex = 5;
			this.lblExcluirCarregando.Text = "Carregando...";
			// 
			// tbPlanilha
			// 
			this.tbPlanilha.BackColor = System.Drawing.SystemColors.Control;
			this.tbPlanilha.Enabled = false;
			this.tbPlanilha.ForeColor = System.Drawing.Color.DarkGreen;
			this.tbPlanilha.Location = new System.Drawing.Point(500, 89);
			this.tbPlanilha.Name = "tbPlanilha";
			this.tbPlanilha.Size = new System.Drawing.Size(100, 25);
			this.tbPlanilha.TabIndex = 0;
			this.tbPlanilha.TabStop = false;
			this.tbPlanilha.Text = "Planilha1";
			this.tbPlanilha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(153, 459);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(94, 17);
			this.label13.TabIndex = 5;
			this.label13.Text = "Atualizando...";
			// 
			// btnConfig
			// 
			this.btnConfig.BackgroundImage = global::LeitorDeCsv.Properties.Resources.configuracao;
			this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConfig.FlatAppearance.BorderSize = 0;
			this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
			this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna;
			this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfig.ForeColor = System.Drawing.Color.Transparent;
			this.btnConfig.Location = new System.Drawing.Point(605, 89);
			this.btnConfig.Name = "btnConfig";
			this.btnConfig.Size = new System.Drawing.Size(24, 25);
			this.btnConfig.TabIndex = 15;
			this.btnConfig.UseVisualStyleBackColor = true;
			this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
			this.btnConfig.MouseHover += new System.EventHandler(this.btnAviso_MouseHover);
			// 
			// btnAviso
			// 
			this.btnAviso.BackColor = System.Drawing.Color.Sienna;
			this.btnAviso.BackgroundImage = global::LeitorDeCsv.Properties.Resources.aviso_hover;
			this.btnAviso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAviso.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAviso.FlatAppearance.BorderSize = 0;
			this.btnAviso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
			this.btnAviso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna;
			this.btnAviso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAviso.ForeColor = System.Drawing.Color.Violet;
			this.btnAviso.Location = new System.Drawing.Point(619, 23);
			this.btnAviso.Name = "btnAviso";
			this.btnAviso.Size = new System.Drawing.Size(37, 37);
			this.btnAviso.TabIndex = 0;
			this.btnAviso.TabStop = false;
			this.btnAviso.UseVisualStyleBackColor = false;
			this.btnAviso.Click += new System.EventHandler(this.btnAviso_Click);
			this.btnAviso.MouseEnter += new System.EventHandler(this.btnAviso_MouseEnter);
			this.btnAviso.MouseLeave += new System.EventHandler(this.btnAviso_MouseLeave);
			this.btnAviso.MouseHover += new System.EventHandler(this.btnAviso_MouseHover);
			// 
			// frmPlanilha
			// 
			this.AcceptButton = this.btnSalvar;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Sienna;
			this.ClientSize = new System.Drawing.Size(668, 502);
			this.Controls.Add(this.btnConfig);
			this.Controls.Add(this.btnAviso);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnProximo);
			this.Controls.Add(this.btnPrimeiro);
			this.Controls.Add(this.btnUltimo);
			this.Controls.Add(this.btnAnterior);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnAbrir);
			this.Controls.Add(this.cdSexo);
			this.Controls.Add(this.mtbCep);
			this.Controls.Add(this.mtbNumero);
			this.Controls.Add(this.mtbCpf);
			this.Controls.Add(this.tbNome);
			this.Controls.Add(this.tbMunicipio);
			this.Controls.Add(this.tbBairro);
			this.Controls.Add(this.tbEndereco);
			this.Controls.Add(this.tbEstado);
			this.Controls.Add(this.tbLinha);
			this.Controls.Add(this.tbPlanilha);
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
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.lblExcluirCarregando);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmPlanilha";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lendo dados da planilha EXCEL";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPlanilha_FormClosing);
			this.Load += new System.EventHandler(this.frmPlanilha_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ComboBox cdSexo;
		private MaskedTextBox mtbCep;
		private MaskedTextBox mtbNumero;
		private MaskedTextBox mtbCpf;
		private TextBox tbNome;
		private TextBox tbMunicipio;
		private TextBox tbBairro;
		private TextBox tbEndereco;
		private TextBox tbEstado;
		private TextBox tbId;
		private Label label8;
		private Label label7;
		private Label label11;
		private Label label10;
		private Label label9;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Button btnSalvar;
		private Label lblStatus;
		private Label label1;
		private Button btnAnterior;
		private Button btnProximo;
		private Button btnExcluir;
		private Button btnUltimo;
		private Button btnPrimeiro;
		private Label label12;
		private TextBox tbLinha;
		private Label lblTotal;
		private Button btnAviso;
		private Button btnAbrir;
		private Label lblExcluirCarregando;
		private TextBox tbPlanilha;
		private Label label13;
		private Button btnConfig;
	}
}