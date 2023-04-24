using System.Drawing;
using System.Windows.Forms;

namespace Desafio
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
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_consulta_cpf = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.txt_valor_busca = new System.Windows.Forms.TextBox();
            this.cmb_buscar = new System.Windows.Forms.ComboBox();
            this.bnt_limpar = new System.Windows.Forms.Button();
            this.btn_deleta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_uf = new System.Windows.Forms.Label();
            this.txt_uf = new System.Windows.Forms.TextBox();
            this.lbl_complemento = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.Image")));
            this.btn_salvar.Location = new System.Drawing.Point(718, 307);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 46);
            this.btn_salvar.TabIndex = 46;
            this.btn_salvar.TabStop = false;
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_consulta_cpf
            // 
            this.btn_consulta_cpf.Image = ((System.Drawing.Image)(resources.GetObject("btn_consulta_cpf.Image")));
            this.btn_consulta_cpf.Location = new System.Drawing.Point(304, 19);
            this.btn_consulta_cpf.Name = "btn_consulta_cpf";
            this.btn_consulta_cpf.Size = new System.Drawing.Size(25, 25);
            this.btn_consulta_cpf.TabIndex = 47;
            this.btn_consulta_cpf.TabStop = false;
            this.btn_consulta_cpf.UseVisualStyleBackColor = true;
            this.btn_consulta_cpf.Click += new System.EventHandler(this.btn_consulta_Click_2);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.Location = new System.Drawing.Point(637, 307);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 46);
            this.btn_alterar.TabIndex = 50;
            this.btn_alterar.TabStop = false;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // txt_valor_busca
            // 
            this.txt_valor_busca.Location = new System.Drawing.Point(58, 21);
            this.txt_valor_busca.Name = "txt_valor_busca";
            this.txt_valor_busca.Size = new System.Drawing.Size(241, 23);
            this.txt_valor_busca.TabIndex = 13;
            // 
            // cmb_buscar
            // 
            this.cmb_buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_buscar.Items.AddRange(new object[] {
            "CPF",
            "ID"});
            this.cmb_buscar.Location = new System.Drawing.Point(6, 21);
            this.cmb_buscar.Name = "cmb_buscar";
            this.cmb_buscar.Size = new System.Drawing.Size(46, 23);
            this.cmb_buscar.TabIndex = 12;
            // 
            // bnt_limpar
            // 
            this.bnt_limpar.Image = ((System.Drawing.Image)(resources.GetObject("bnt_limpar.Image")));
            this.bnt_limpar.Location = new System.Drawing.Point(556, 307);
            this.bnt_limpar.Name = "bnt_limpar";
            this.bnt_limpar.Size = new System.Drawing.Size(75, 46);
            this.bnt_limpar.TabIndex = 53;
            this.bnt_limpar.TabStop = false;
            this.bnt_limpar.UseVisualStyleBackColor = true;
            this.bnt_limpar.Click += new System.EventHandler(this.bnt_limpar_Click);
            // 
            // btn_deleta
            // 
            this.btn_deleta.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleta.Image")));
            this.btn_deleta.Location = new System.Drawing.Point(475, 307);
            this.btn_deleta.Name = "btn_deleta";
            this.btn_deleta.Size = new System.Drawing.Size(75, 46);
            this.btn_deleta.TabIndex = 54;
            this.btn_deleta.TabStop = false;
            this.btn_deleta.UseVisualStyleBackColor = true;
            this.btn_deleta.Click += new System.EventHandler(this.btn_deleta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_buscar);
            this.groupBox1.Controls.Add(this.txt_valor_busca);
            this.groupBox1.Controls.Add(this.btn_consulta_cpf);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 58);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.lbl_id);
            this.groupBox2.Controls.Add(this.lbl_uf);
            this.groupBox2.Controls.Add(this.txt_uf);
            this.groupBox2.Controls.Add(this.lbl_complemento);
            this.groupBox2.Controls.Add(this.lbl_numero);
            this.groupBox2.Controls.Add(this.txt_numero);
            this.groupBox2.Controls.Add(this.txt_complemento);
            this.groupBox2.Controls.Add(this.txt_bairro);
            this.groupBox2.Controls.Add(this.lbl_cidade);
            this.groupBox2.Controls.Add(this.lbl_bairro);
            this.groupBox2.Controls.Add(this.lbl_rua);
            this.groupBox2.Controls.Add(this.lbl_cep);
            this.groupBox2.Controls.Add(this.lbl_celular);
            this.groupBox2.Controls.Add(this.lbl_idade);
            this.groupBox2.Controls.Add(this.lbl_cpf);
            this.groupBox2.Controls.Add(this.lbl_nome);
            this.groupBox2.Controls.Add(this.txt_idade);
            this.groupBox2.Controls.Add(this.txt_cpf);
            this.groupBox2.Controls.Add(this.txt_nome);
            this.groupBox2.Controls.Add(this.txt_celular);
            this.groupBox2.Controls.Add(this.txt_rua);
            this.groupBox2.Controls.Add(this.txt_cidade);
            this.groupBox2.Controls.Add(this.btn_consulta);
            this.groupBox2.Controls.Add(this.txt_cep);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 251);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CADASTRO";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(107, 15);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(40, 23);
            this.txt_id.TabIndex = 74;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(6, 23);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(22, 15);
            this.lbl_id.TabIndex = 73;
            this.lbl_id.Text = "ID:";
            this.lbl_id.Click += new System.EventHandler(this.lbl_id_Click);
            // 
            // lbl_uf
            // 
            this.lbl_uf.AutoSize = true;
            this.lbl_uf.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uf.Location = new System.Drawing.Point(596, 223);
            this.lbl_uf.Name = "lbl_uf";
            this.lbl_uf.Size = new System.Drawing.Size(24, 15);
            this.lbl_uf.TabIndex = 72;
            this.lbl_uf.Text = "UF:";
            // 
            // txt_uf
            // 
            this.txt_uf.Location = new System.Drawing.Point(626, 215);
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(35, 23);
            this.txt_uf.TabIndex = 11;
            // 
            // lbl_complemento
            // 
            this.lbl_complemento.AutoSize = true;
            this.lbl_complemento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_complemento.Location = new System.Drawing.Point(6, 223);
            this.lbl_complemento.Name = "lbl_complemento";
            this.lbl_complemento.Size = new System.Drawing.Size(95, 15);
            this.lbl_complemento.TabIndex = 70;
            this.lbl_complemento.Text = "COMPLEMENTO:";
            this.lbl_complemento.Click += new System.EventHandler(this.lbl_complemento_Click_1);
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(495, 183);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(59, 15);
            this.lbl_numero.TabIndex = 69;
            this.lbl_numero.Text = "NUMERO:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(559, 177);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(35, 23);
            this.txt_numero.TabIndex = 7;
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(107, 215);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(216, 23);
            this.txt_complemento.TabIndex = 9;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(666, 177);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(101, 23);
            this.txt_bairro.TabIndex = 8;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(411, 223);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(50, 15);
            this.lbl_cidade.TabIndex = 65;
            this.lbl_cidade.Text = "CIDADE:";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.Location = new System.Drawing.Point(611, 183);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(51, 15);
            this.lbl_bairro.TabIndex = 64;
            this.lbl_bairro.Text = "BAIRRO:";
            // 
            // lbl_rua
            // 
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rua.Location = new System.Drawing.Point(6, 183);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(32, 15);
            this.lbl_rua.TabIndex = 63;
            this.lbl_rua.Text = "RUA:";
            this.lbl_rua.Click += new System.EventHandler(this.lbl_rua_Click);
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(6, 143);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(30, 15);
            this.lbl_cep.TabIndex = 62;
            this.lbl_cep.Text = "CEP:";
            this.lbl_cep.Click += new System.EventHandler(this.lbl_cep_Click);
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_celular.Location = new System.Drawing.Point(261, 100);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(55, 15);
            this.lbl_celular.TabIndex = 61;
            this.lbl_celular.Text = "CELULAR:";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idade.Location = new System.Drawing.Point(585, 63);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(43, 15);
            this.lbl_idade.TabIndex = 60;
            this.lbl_idade.Text = "IDADE:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(6, 103);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(30, 15);
            this.lbl_cpf.TabIndex = 59;
            this.lbl_cpf.Text = "CPF:";
            this.lbl_cpf.Click += new System.EventHandler(this.lbl_cpf_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(6, 63);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(44, 15);
            this.lbl_nome.TabIndex = 58;
            this.lbl_nome.Text = "NOME:";
            this.lbl_nome.Click += new System.EventHandler(this.lbl_nome_Click);
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(644, 55);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(100, 23);
            this.txt_idade.TabIndex = 2;
            this.txt_idade.Tag = "";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(107, 95);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(100, 23);
            this.txt_cpf.TabIndex = 3;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(107, 55);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(472, 23);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.Tag = "";
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(326, 95);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(100, 23);
            this.txt_celular.TabIndex = 4;
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(107, 177);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(367, 23);
            this.txt_rua.TabIndex = 6;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(467, 215);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(100, 23);
            this.txt_cidade.TabIndex = 10;
            // 
            // btn_consulta
            // 
            this.btn_consulta.Image = ((System.Drawing.Image)(resources.GetObject("btn_consulta.Image")));
            this.btn_consulta.Location = new System.Drawing.Point(213, 140);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(25, 25);
            this.btn_consulta.TabIndex = 51;
            this.btn_consulta.TabStop = false;
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click_1);
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(107, 140);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(100, 23);
            this.txt_cep.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_deleta);
            this.Controls.Add(this.bnt_limpar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_salvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_consulta_cpf;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.TextBox txt_valor_busca;
        private System.Windows.Forms.ComboBox cmb_buscar;
        private Button bnt_limpar;
        private Button btn_deleta;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txt_id;
        private Label lbl_id;
        private Label lbl_uf;
        private TextBox txt_uf;
        private Label lbl_complemento;
        private Label lbl_numero;
        private TextBox txt_numero;
        private TextBox txt_complemento;
        private TextBox txt_bairro;
        private Label lbl_cidade;
        private Label lbl_bairro;
        private Label lbl_rua;
        private Label lbl_cep;
        private Label lbl_celular;
        private Label lbl_idade;
        private Label lbl_cpf;
        private Label lbl_nome;
        private TextBox txt_idade;
        private TextBox txt_cpf;
        private TextBox txt_nome;
        private TextBox txt_celular;
        private TextBox txt_rua;
        private TextBox txt_cidade;
        private Button btn_consulta;
        private TextBox txt_cep;
    }
}

