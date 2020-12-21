using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using MySql;
using MySqlX.XDevAPI.Common;
using Cadastro.Model;
using System.Net.Http;
using Newtonsoft.Json;

namespace CadastroManager
{
    public partial class Form1 : Form
    {
        public string URI = "";
        public string URIBase = "https://localhost:5001/api/Cadastro/";
        public CadastroModel DadosCadastro;
        public string command = "";

        public Form1()
        {
            InitializeComponent();
            ClearFields();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void TbValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBLocal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBQtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnMinimize_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Consultar_Click_1(object sender, EventArgs e)
        {
            var cpf = TbQueryCpf.Text;
            GetCadastroByCpf(cpf);

            if (DadosCadastro != null)
            {
                BlockFieldEdition();
                PopulateFields(DadosCadastro);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AplicarMudanca_Click(object sender, EventArgs e)
        {
            switch (command)
            {
                case "add":
                    AddCadastro();
                    break;
                case "patch":
                    PatchCadastro(TbCPF.Text);
                    break;
                case "delete":
                    DeleteCadastro(TbCPF.Text);
                    break;
                default:

                    break;
            }
            command = "";

        }
        private void Editar_Click(object sender, EventArgs e)
        {
            AllowFieldEdition();
            command = "patch";
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            ClearFields();
            AllowFieldEdition();
            command = "add";
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            command = "delete";
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PopulateFields(CadastroModel cadastro)
        {
            TbNome.Text = cadastro.nome;
            TbCPF.Text = cadastro.CPF;
            TbEmail.Text = cadastro.email;
            TbTelef.Text = cadastro.telefone;
            TbLograd.Text = cadastro.logradouro;
            TbNumEnd.Text = Convert.ToString(cadastro.numero);
            TbTelefEnd.Text = cadastro.telefoneEndereco;
            TbBairro.Text = cadastro.bairro;
            TbCidade.Text = cadastro.cidade;
            TbEstado.Text = cadastro.estado;
        }

        private CadastroModel GetFields()
        {
            var cadastro = new CadastroModel();
            cadastro.nome = TbNome.Text;
            cadastro.CPF = TbCPF.Text;
            cadastro.email = TbEmail.Text;
            cadastro.telefone = TbTelef.Text;
            cadastro.logradouro = TbLograd.Text;
            cadastro.numero = Convert.ToInt32(TbNumEnd.Text);
            cadastro.telefoneEndereco = TbTelefEnd.Text;
            cadastro.bairro = TbBairro.Text;
            cadastro.cidade = TbCidade.Text;
            cadastro.estado = TbEstado.Text;
            return cadastro;
        }

        private void ClearFields()
        {
            TbNome.Text = "";
            TbCPF.Text = "";
            TbEmail.Text = "";
            TbTelef.Text = "";
            TbLograd.Text = "";
            TbNumEnd.Text = "";
            TbTelefEnd.Text = "";
            TbBairro.Text = "";
            TbCidade.Text = "";
            TbEstado.Text = "";
        }

        private void BlockFieldEdition()
        {
            var color = Color.LightGray;
            TbNome.ReadOnly = true; TbNome.BackColor = color;
            TbCPF.ReadOnly = true; TbCPF.BackColor = color;
            TbEmail.ReadOnly = true; TbEmail.BackColor = color;
            TbTelef.ReadOnly = true; TbTelef.BackColor = color;
            TbLograd.ReadOnly = true; TbLograd.BackColor = color;
            TbNumEnd.ReadOnly = true; TbNumEnd.BackColor = color;
            TbTelefEnd.ReadOnly = true; TbTelefEnd.BackColor = color;
            TbBairro.ReadOnly = true; TbBairro.BackColor = color;
            TbCidade.ReadOnly = true; TbCidade.BackColor = color;
            TbEstado.ReadOnly = true; TbEstado.BackColor = color;
        }

        private void AllowFieldEdition()
        {
            var color = Color.White;
            TbNome.ReadOnly = false; TbNome.BackColor = color;
            TbCPF.ReadOnly = false; TbCPF.BackColor = color;
            TbEmail.ReadOnly = false; TbEmail.BackColor = color;
            TbTelef.ReadOnly = false; TbTelef.BackColor = color;
            TbLograd.ReadOnly = false; TbLograd.BackColor = color;
            TbNumEnd.ReadOnly = false; TbNumEnd.BackColor = color;
            TbTelefEnd.ReadOnly = false; TbTelefEnd.BackColor = color;
            TbBairro.ReadOnly = false; TbBairro.BackColor = color;
            TbCidade.ReadOnly = false; TbCidade.BackColor = color;
            TbEstado.ReadOnly = false; TbEstado.BackColor = color;
        }




        public async void GetCadastroByCpf(string cpf)
        {
            if (cpf == "")
            {
                System.Windows.Forms.MessageBox.Show("Insira um CPF", "CPF em branco");
            }
            else
            {
                using (var client = new HttpClient())
                {
                    ClearFields();
                    BlockFieldEdition();
                    URI = URIBase + cpf;

                    HttpResponseMessage resposta = await client.GetAsync(URI);
                    if (resposta.IsSuccessStatusCode)
                    {
                        var CadastroJsonString = await resposta.Content.ReadAsStringAsync();
                        DadosCadastro = JsonConvert.DeserializeObject<CadastroModel>(CadastroJsonString);
                    }
                }
            }
        }

        public async void AddCadastro()
        {
            URI = URIBase;
            var cadastroAdd = GetFields();

            using (var client = new HttpClient())
            {
                var serializedCadastro = JsonConvert.SerializeObject(cadastroAdd);
                var conteudo = new StringContent(serializedCadastro, Encoding.UTF8, "Application/json");
                var resultado = await client.PostAsync(URI, conteudo);
            }
            GetCadastroByCpf(cadastroAdd.CPF);
        }

        private async void DeleteCadastro(string cpf)
        {
            URI = URI + cpf;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await client.DeleteAsync(string.Format("{0}/{1}", URI, cpf));

                if (responseMessage.IsSuccessStatusCode)
                {
                    System.Windows.Forms.MessageBox.Show("Produto excluído com sucesso");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Falha ao excluir o produto  : " + responseMessage.StatusCode);
                }
            }
        }

        private async void PatchCadastro(string cpf)
        {
            var cadastroPatch = GetFields();

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URIBase + cpf, cadastroPatch);
                if (responseMessage.IsSuccessStatusCode)
                {
                    System.Windows.Forms.MessageBox.Show("Produto atualizado");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Falha ao atualizar o produto : " + responseMessage.StatusCode);
                }
            }


        }


        private bool mouseDown;
        private System.Drawing.Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new System.Drawing.Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
      
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        
    }
}