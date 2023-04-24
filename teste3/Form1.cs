using Newtonsoft.Json;
using Npgsql;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Desafio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            

        }  
        private void btn_consulta_Click_1(object sender, EventArgs e)
        {
            string cep = txt_cep.Text;
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";

            try
            {
                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();

                Endereco endereco = JsonConvert.DeserializeObject<Endereco>(responseFromServer);

                txt_rua.Text = endereco.Logradouro;
                txt_bairro.Text = endereco.Bairro;
                txt_cidade.Text = endereco.Localidade;
                txt_uf.Text = endereco.Uf;
            }
            catch (WebException ex)
            {
                MessageBox.Show("Erro ao buscar CEP: " + ex.Message);
            }

        }
        

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=Desafio;User Id=postgres;Password=5110;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
           
            string sql = "INSERT INTO cadastro (nome, cpf, idade, celular, cep, rua, numero, complemento, bairro, cidade, uf) VALUES (@nome, @cpf, @idade, @celular, @cep, @rua, @numero, @complemento, @bairro, @cidade, @uf);";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);

            command.Parameters.AddWithValue("@nome", txt_nome.Text.ToUpper());
            command.Parameters.AddWithValue("@cpf", txt_cpf.Text.ToUpper());
            command.Parameters.AddWithValue("@idade", int.Parse(txt_idade.Text));
            command.Parameters.AddWithValue("@celular", txt_celular.Text.ToUpper());
            command.Parameters.AddWithValue("@cep", txt_cep.Text.ToUpper());
            command.Parameters.AddWithValue("@rua", txt_rua.Text.ToUpper());
            command.Parameters.AddWithValue("@numero", int.Parse(txt_numero.Text));
            command.Parameters.AddWithValue("@complemento", txt_complemento.Text.ToUpper());
            command.Parameters.AddWithValue("@bairro", txt_bairro.Text.ToUpper());
            command.Parameters.AddWithValue("@cidade", txt_cidade.Text.ToUpper());
            command.Parameters.AddWithValue("@uf", txt_uf.Text.ToUpper());

            command.ExecuteNonQuery();
            connection.Close();

            txt_id.Clear();
            txt_nome.Clear();
            txt_cpf.Clear();
            txt_idade.Clear();
            txt_celular.Clear();
            txt_cep.Clear();
            txt_rua.Clear();
            txt_numero.Clear();
            txt_complemento.Clear();
            txt_bairro.Clear();
            txt_cidade.Clear();
            txt_uf.Clear();

            MessageBox.Show("Registro inserido com sucesso.");
        }


        private void btn_consulta_Click_2(object sender, EventArgs e)
        {
            string valorBusca = txt_valor_busca.Text.Trim();
            string opcaoBusca = cmb_buscar.SelectedItem.ToString();
            string sql = "";

            switch (opcaoBusca)
            {
                case "CPF":
                    sql = $"SELECT * FROM cadastro WHERE cpf = '{valorBusca}'";
                    break;
                case "ID":
                    sql = $"SELECT * FROM cadastro WHERE id = '{valorBusca}'";
                    break;
                default:
                    MessageBox.Show("Selecione uma opção ao lado.");
                    return;
            }

            string connectionString = "Server=localhost;Database=Desafio;User Id=postgres;Password=5110;";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_id.Text = reader["id"].ToString();
                            txt_nome.Text = reader["nome"].ToString();
                            txt_cpf.Text = reader["cpf"].ToString();
                            txt_idade.Text = reader["idade"].ToString();
                            txt_celular.Text = reader["celular"].ToString();
                            txt_cep.Text = reader["cep"].ToString();
                            txt_rua.Text = reader["rua"].ToString();
                            txt_numero.Text = reader["numero"].ToString();
                            txt_complemento.Text = reader["complemento"].ToString();
                            txt_bairro.Text = reader["bairro"].ToString();
                            txt_cidade.Text = reader["cidade"].ToString();
                            txt_uf.Text = reader["uf"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Registro não encontrado.");
                        }
                    }
                }
            }
        }


        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=Desafio;User Id=postgres;Password=5110;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string sql = "UPDATE cadastro SET nome = @nome, cpf = @cpf, idade = @idade, celular = @celular, cep = @cep, rua = @rua, numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, uf = @uf WHERE id = @id;";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);

            command.Parameters.AddWithValue("@id", int.Parse(txt_id.Text));
            command.Parameters.AddWithValue("@nome", txt_nome.Text.ToUpper());
            command.Parameters.AddWithValue("@cpf", txt_cpf.Text.ToUpper());
            command.Parameters.AddWithValue("@idade", int.Parse(txt_idade.Text));
            command.Parameters.AddWithValue("@celular", txt_celular.Text);
            command.Parameters.AddWithValue("@cep", txt_cep.Text);
            command.Parameters.AddWithValue("@rua", txt_rua.Text.ToUpper());
            command.Parameters.AddWithValue("@numero", int.Parse(txt_numero.Text));
            command.Parameters.AddWithValue("@complemento", txt_complemento.Text.ToUpper());
            command.Parameters.AddWithValue("@bairro", txt_bairro.Text.ToUpper());
            command.Parameters.AddWithValue("@cidade", txt_cidade.Text.ToUpper());
            command.Parameters.AddWithValue("@uf", txt_uf.Text.ToUpper());

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Registro atualizado com sucesso.");
        }


        private void bnt_limpar_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_nome.Clear();
            txt_cpf.Clear();
            txt_idade.Clear();
            txt_celular.Clear();
            txt_cep.Clear();
            txt_rua.Clear();
            txt_numero.Clear();
            txt_complemento.Clear();
            txt_bairro.Clear();
            txt_cidade.Clear();
            txt_uf.Clear();
            MessageBox.Show("Limpeza feita com sucesso.");
        }

        private void btn_deleta_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=Desafio;User Id=postgres;Password=5110;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string sql = "DELETE FROM cadastro WHERE id = @id;";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", int.Parse(txt_id.Text));

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Registro deletado com sucesso.");

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_rua_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void lbl_complemento_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_cep_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cpf_Click(object sender, EventArgs e)
        {

        }        

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
