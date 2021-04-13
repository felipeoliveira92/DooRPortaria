using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Portaria
{
    public partial class Form_moradores : Form
    {
        public Form_moradores()
        {
            InitializeComponent();
            autoComplete();
        }

        private void autoComplete()
        {/*
            AutoCompleteStringCollection dadosModelo = new AutoCompleteStringCollection();
            AutoCompleteStringCollection dadosCor = new AutoCompleteStringCollection();

            string conexao = DoorPortaria.Properties.Settings.Default.BDPortaria;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "SELECT Nome, Rua, Unidade FROM moradores";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            try
            {
                while (sqlDataReader.Read())
                {
                    string modelo = sqlDataReader["Nome"].ToString();
                    string cor = sqlDataReader["Rua"].ToString();
                    //string cor = sqlDataReader["Unidade"].ToString();
                    dadosModelo.Add(modelo);
                    dadosCor.Add(cor);
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }

            textBoxModelo.AutoCompleteCustomSource = dadosModelo;
            textBoxCor.AutoCompleteCustomSource = dadosCor;

            sqlConnection.Close();
            */
        }
        private void Form_moradores_Load(object sender, EventArgs e)
        {
            buttonAddFoto.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBoxNomeMorador.Enabled = true;
            textBoxCpf.Enabled = true;
            textBoxRuaBloco.Enabled = true;
            textBoxUnidade.Enabled = true;
            textBoxRamal.Enabled = true;
            maskedTextBoxFixo.Enabled = true;
            maskedTextBoxCelular.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxModelo.Enabled = true;
            maskedTextBoxPlaca.Enabled = true;
            textBoxCor.Enabled = true;
            textBoxObservacoes.Enabled = true;
            buttonAddFoto.Visible = true;

            buttonAlterar.Visible = false;
            buttonDeletar.Visible = true;
        }       

        public void atualizardatagrid()
        {

            string conexao = DoorPortaria.Properties.Settings.Default.BDPortaria;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT IdMorador,nome,Cpf,rua,unidade,ramal,fixo,celular,email,observacoes,modelo,cor,placa,foto from moradores ";
            cmd.CommandText += "where nome LIKE '" + "%" + textBoxPesqNomeMorador.Text + "%" + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewMoradores.DataSource = dt;

            dataGridViewMoradores.Columns[0].Visible = false;
            dataGridViewMoradores.Columns[2].Visible = false;
            dataGridViewMoradores.Columns[8].Visible = false;
            dataGridViewMoradores.Columns[9].Visible = false;
            dataGridViewMoradores.Columns[11].Visible = false;
            dataGridViewMoradores.Columns[12].Visible = false;
            dataGridViewMoradores.Columns[13].Visible = false;
            dataGridViewMoradores.Columns[3].HeaderText = "Rua/Bloco";
            dataGridViewMoradores.AutoResizeColumns();

        }
        
        private void PictureBox_Foto_Morador_Click(object sender, EventArgs e)
        {
            /*string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select foto from moradores where nome = '" + dataGridView1.CurrentCell.Value + "'";
            cmd.ExecuteNonQuery();
            */
        }

        private void Form_moradores_MouseHover(object sender, EventArgs e)
        {

        }

        private void MaskedTextBox_fixo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
                              
        private void Form_moradores_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
                
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button_pesquisar_Click_1(object sender, EventArgs e)
        {
            if (textBoxPesqUnidadeMorador.Text == "")
            {
                dataGridViewMoradores.Visible = true;

                string conexao = DoorPortaria.Properties.Settings.Default.BDPortaria;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT IdMorador,nome,Cpf,rua,unidade,ramal,fixo,celular,email,observacoes,modelo,cor,placa,foto ";
                cmd.CommandText += "FROM moradores WHERE nome LIKE '" + "%" + textBoxPesqNomeMorador.Text + "%" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewMoradores.DataSource = dt;

                sqlConnection.Close();
                dataGridViewMoradores.Columns[0].Visible = false;
                dataGridViewMoradores.Columns[2].Visible = false;
                dataGridViewMoradores.Columns[8].Visible = false;
                dataGridViewMoradores.Columns[9].Visible = false;
                dataGridViewMoradores.Columns[11].Visible = false;
                dataGridViewMoradores.Columns[12].Visible = false;
                dataGridViewMoradores.Columns[13].Visible = false;
                dataGridViewMoradores.Columns[3].HeaderText = "Rua/Bloco";
                dataGridViewMoradores.AutoResizeColumns();
            }
            else if (textBoxPesqNomeMorador.Text == "")
            {
                dataGridViewMoradores.Visible = true;

                string conexao = DoorPortaria.Properties.Settings.Default.BDPortaria;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT IdMorador,Nome,Cpf,Rua,Unidade,Ramal,Fixo,Celular,Email,Observacoes,Modelo,Cor,Placa,Foto FROM moradores WHERE Unidade = '" + textBoxPesqUnidadeMorador.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewMoradores.DataSource = dt;

                sqlConnection.Close();
                dataGridViewMoradores.Columns[0].Visible = false;
                dataGridViewMoradores.Columns[2].Visible = false;
                dataGridViewMoradores.Columns[8].Visible = false;
                dataGridViewMoradores.Columns[9].Visible = false;
                dataGridViewMoradores.Columns[11].Visible = false;
                dataGridViewMoradores.Columns[12].Visible = false;
                dataGridViewMoradores.Columns[13].Visible = false;
                dataGridViewMoradores.Columns[3].HeaderText = "Rua/Bloco";
                dataGridViewMoradores.AutoResizeColumns();

            }
        }

        private void buttonAddMorador_Click_1(object sender, EventArgs e)
        {
            string conexao = DoorPortaria.Properties.Settings.Default.BDPortaria;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "SELECT Cpf FROM moradores WHERE Cpf = " + textBoxCpf.Text + "";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);

            if(sqlCommand.ExecuteScalar() == null)
            {
                if (textBoxNomeMorador.Text != "" && textBoxCpf.Text != "" && textBoxUnidade.Text != "")
                {

                    try
                    {   
                        comando = "INSERT INTO moradores(Nome,Cpf,Rua,Unidade,Ramal,Fixo,Celular,Email,Observacoes,Foto,Modelo,Cor,Placa) ";
                        comando += "VALUES(@nome,@CPF,@rua,@unidade,@ramal,@fixo,@celular,@email,@observacoes,@foto,@modelo,@cor,@placa)";
                        SqlCommand sqlCommand2 = new SqlCommand(comando, sqlConnection);
                        sqlCommand2.Parameters.AddWithValue("@nome", textBoxNomeMorador.Text);
                        sqlCommand2.Parameters.AddWithValue("@CPF", textBoxCpf.Text);
                        sqlCommand2.Parameters.AddWithValue("@rua", textBoxRuaBloco.Text);
                        sqlCommand2.Parameters.AddWithValue("@unidade", textBoxUnidade.Text);
                        sqlCommand2.Parameters.AddWithValue("@ramal", textBoxRamal.Text);
                        sqlCommand2.Parameters.AddWithValue("@fixo", maskedTextBoxFixo.Text);
                        sqlCommand2.Parameters.AddWithValue("@celular", maskedTextBoxCelular.Text);
                        sqlCommand2.Parameters.AddWithValue("@email", textBoxEmail.Text);
                        sqlCommand2.Parameters.AddWithValue("@observacoes", textBoxObservacoes.Text);
                        sqlCommand2.Parameters.AddWithValue("@foto", openFileDialog1.FileName);
                        sqlCommand2.Parameters.AddWithValue("@modelo", textBoxModelo.Text);
                        sqlCommand2.Parameters.AddWithValue("@cor", textBoxCor.Text);
                        sqlCommand2.Parameters.AddWithValue("@placa", maskedTextBoxPlaca.Text);

                        sqlCommand2.ExecuteNonQuery();

                        sqlConnection.Close();
                        MessageBox.Show("Morador cadastrado com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Dados Invalidos!!");
                }
            }
            else
            {
                MessageBox.Show("Já existe um morador com este CPF");
                sqlConnection.Close();
            }
            

            
        }

        private void textBoxPesqNomeMorador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dataGridViewMoradores.Visible = true;

                string conexao = DoorPortaria.Properties.Settings.Default.BDPortaria;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT IdMorador,nome,CPF,rua,unidade,ramal,fixo,celular,email,observacoes,modelo,cor,placa,foto FROM moradores WHERE nome LIKE '" + "%" + textBoxPesqNomeMorador.Text + "%" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewMoradores.DataSource = dt;

                sqlConnection.Close();
                dataGridViewMoradores.Columns[0].Visible = false;
                dataGridViewMoradores.Columns[2].Visible = false;
                dataGridViewMoradores.Columns[8].Visible = false;
                dataGridViewMoradores.Columns[9].Visible = false;
                dataGridViewMoradores.Columns[11].Visible = false;
                dataGridViewMoradores.Columns[12].Visible = false;
                dataGridViewMoradores.Columns[13].Visible = false;
                dataGridViewMoradores.Columns[3].HeaderText = "Rua/Bloco";
                dataGridViewMoradores.AutoResizeColumns();
            }            
        }

        private void buttonAddFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Selecione uma foto";
            openFileDialog1.Filter = "JPEG|*.JPG|PNG|*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFotoMorador.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void textBoxPesqUnidadeMorador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dataGridViewMoradores.Visible = true;

                string conexao = DoorPortaria.Properties.Settings.Default.BDPortaria;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT IdMorador,nome,CPF,rua,unidade,ramal,fixo,celular,email,observacoes,modelo,cor,placa,foto FROM moradores WHERE unidade = '" + textBoxPesqUnidadeMorador.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewMoradores.DataSource = dt;

                sqlConnection.Close();
                dataGridViewMoradores.Columns[0].Visible = false;
                dataGridViewMoradores.Columns[2].Visible = false;
                dataGridViewMoradores.Columns[8].Visible = false;
                dataGridViewMoradores.Columns[9].Visible = false;
                dataGridViewMoradores.Columns[11].Visible = false;
                dataGridViewMoradores.Columns[12].Visible = false;
                dataGridViewMoradores.Columns[13].Visible = false;
                dataGridViewMoradores.Columns[3].HeaderText = "Rua/Bloco";
                dataGridViewMoradores.AutoResizeColumns();
            }
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = DoorPortaria.Properties.Settings.Default.BDPortaria;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM moradores WHERE IdMorador = '" + textBoxId.Text + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Morador excluido\ncom sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                sqlConnection.Close();
                atualizardatagrid();

                textBoxId.Text = "";
                textBoxNomeMorador.Text = "";
                textBoxCpf.Text = "";
                textBoxRuaBloco.Text = "";
                textBoxUnidade.Text = "";
                textBoxRamal.Text = "";
                maskedTextBoxFixo.Text = "";
                maskedTextBoxCelular.Text = "";
                textBoxEmail.Text = "";
                textBoxModelo.Text = "";
                maskedTextBoxPlaca.Text = "";
                textBoxCor.Text = "";
                textBoxObservacoes.Text = "";
                buttonAddFoto.Text = "";
                pictureBoxFotoMorador.ImageLocation = "";

                buttonAlterar.Visible = false;
                buttonDeletar.Visible = false;
                buttonAddFoto.Visible = false;
                buttonCancelar.Visible = false;

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            string conexao = DoorPortaria.Properties.Settings.Default.BDPortaria;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            //string comando = "UPDATE moradores SET ramal = '" + textBox_Ramal.Text + "' WHERE nome = '"+textBox_Nome.Text+"'";
            string comando = "UPDATE moradores SET nome = @nome, CPF = @CPF, rua = @rua , unidade = @unidade, ramal = @ramal, fixo = @fixo, celular = @celular, ";
            comando += "email = @email, observacoes = @observacoes, modelo = @modelo, cor = @cor, placa = @placa,foto = @foto WHERE IdMorador = '" + textBoxId.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@nome", textBoxNomeMorador.Text);
            sqlCommand.Parameters.AddWithValue("@CPF", textBoxCpf.Text);
            sqlCommand.Parameters.AddWithValue("@rua", textBoxRuaBloco.Text);
            sqlCommand.Parameters.AddWithValue("@unidade", textBoxUnidade.Text);
            sqlCommand.Parameters.AddWithValue("@ramal", textBoxRamal.Text);
            sqlCommand.Parameters.AddWithValue("@fixo", maskedTextBoxFixo.Text);
            sqlCommand.Parameters.AddWithValue("@celular", maskedTextBoxCelular.Text);
            sqlCommand.Parameters.AddWithValue("@email", textBoxEmail.Text);
            sqlCommand.Parameters.AddWithValue("@observacoes", textBoxObservacoes.Text);
            sqlCommand.Parameters.AddWithValue("@foto", pictureBoxFotoMorador.ImageLocation);
            sqlCommand.Parameters.AddWithValue("@modelo", textBoxModelo.Text);
            sqlCommand.Parameters.AddWithValue("@cor", textBoxCor.Text);
            sqlCommand.Parameters.AddWithValue("@placa", maskedTextBoxPlaca.Text);
            sqlCommand.ExecuteNonQuery();

            atualizardatagrid();
            /*
            textBoxNomeMorador.Enabled = false;
            textBoxCpf.Enabled = false;
            textBoxRuaBloco.Enabled = false;
            textBoxUnidade.Enabled = false;
            textBoxRamal.Enabled = false;
            maskedTextBoxFixo.Enabled = false;
            maskedTextBoxCelular.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxModelo.Enabled = false;
            maskedTextBoxPlaca.Enabled = false;
            textBoxCor.Enabled = false;
            textBoxObservacoes.Enabled = false;
            */
            textBoxNomeMorador.Text = "";
            textBoxCpf.Text = "";
            textBoxRuaBloco.Text = "";
            textBoxUnidade.Text = "";
            textBoxRamal.Text = "";
            maskedTextBoxFixo.Text = "";
            maskedTextBoxCelular.Text = "";
            textBoxEmail.Text = "";
            textBoxModelo.Text = "";
            maskedTextBoxPlaca.Text = "";
            textBoxCor.Text = "";
            textBoxObservacoes.Text = "";
            buttonAddFoto.Text = "";
            pictureBoxFotoMorador.ImageLocation = "";

            buttonAlterar.Visible = false;
            buttonDeletar.Visible = false;
            buttonAddFoto.Visible = false;
            buttonCancelar.Visible = false;

            textBoxPesqUnidadeMorador.Focus();

            sqlConnection.Close();
        }

        private void dataGridViewMoradores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewMoradores.CurrentRow.Cells[0].Value.ToString();
            textBoxNomeMorador.Text = dataGridViewMoradores.CurrentRow.Cells[1].Value.ToString();
            textBoxCpf.Text = dataGridViewMoradores.CurrentRow.Cells[2].Value.ToString();
            textBoxRuaBloco.Text = dataGridViewMoradores.CurrentRow.Cells[3].Value.ToString();
            textBoxUnidade.Text = dataGridViewMoradores.CurrentRow.Cells[4].Value.ToString();
            textBoxRamal.Text = dataGridViewMoradores.CurrentRow.Cells[5].Value.ToString();
            maskedTextBoxFixo.Text = dataGridViewMoradores.CurrentRow.Cells[6].Value.ToString();
            maskedTextBoxCelular.Text = dataGridViewMoradores.CurrentRow.Cells[7].Value.ToString();
            textBoxEmail.Text = dataGridViewMoradores.CurrentRow.Cells[8].Value.ToString();
            textBoxModelo.Text = dataGridViewMoradores.CurrentRow.Cells[10].Value.ToString();
            maskedTextBoxPlaca.Text = dataGridViewMoradores.CurrentRow.Cells[12].Value.ToString();
            textBoxCor.Text = dataGridViewMoradores.CurrentRow.Cells[11].Value.ToString();
            textBoxObservacoes.Text = dataGridViewMoradores.CurrentRow.Cells[9].Value.ToString();
            pictureBoxFotoMorador.ImageLocation = dataGridViewMoradores.CurrentRow.Cells[13].Value.ToString();

            buttonAlterar.Visible = true;
            buttonDeletar.Visible = true;
            buttonAddFoto.Visible = true;
            buttonCancelar.Visible = true;
            buttonAddMorador.Visible = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxNomeMorador.Text = "";
            textBoxCpf.Text = "";
            textBoxRuaBloco.Text = "";
            textBoxUnidade.Text = "";
            textBoxRamal.Text = "";
            maskedTextBoxFixo.Text = "";
            maskedTextBoxCelular.Text = "";
            textBoxEmail.Text = "";
            textBoxModelo.Text = "";
            maskedTextBoxPlaca.Text = "";
            textBoxCor.Text = "";
            textBoxObservacoes.Text = "";
            buttonAddFoto.Text = "";
            pictureBoxFotoMorador.ImageLocation = "";

            buttonCancelar.Visible = false;
        }

        private void button_Registrar_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
    }
