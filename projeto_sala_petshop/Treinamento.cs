using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projeto_sala_petshop
{

    public partial class Treinamento : Form
    {
        private Image imagemOriginalG;
        private Image imagemOriginalL;
        private Image imagemOriginalN;
        private Image imagemOriginalS;
        private bool contornoAtivo = false; // Controla se o contorno está ativo
        private PictureBox pictureBoxSelecionada = null;
        private Color corContorno = Color.SkyBlue;
        public bool clickGui { get; set; }
        public bool clickLu { get; set; }
        public bool clickNic { get; set; }
        public bool clickSte { get; set; }
        public string nr_pet_pass { get; set; }
        public string tipo_caminhada { get; set; }
        public string data_pass { get; set; }
        public decimal valor_pass { get; set; }
        public string passeadorEscolhido { get; set; }

        public Treinamento()
        {
            InitializeComponent();

            pictureBoxGuilherme.Image = Image.FromFile(@"C:\Users\Lucas\source\repos\final\projeto_ATUALIZADO_petsty\projeto_sala_petshop\projeto_sala_petshop\imagens\guilherme.jpg");
            pictureBoxLucas.Image = Image.FromFile(@"C:\Users\Lucas\source\repos\final\projeto_ATUALIZADO_petsty\projeto_sala_petshop\projeto_sala_petshop\imagens\lucas.jpg");
            pictureBoxNicollas.Image = Image.FromFile(@"C:\Users\Lucas\source\repos\final\projeto_ATUALIZADO_petsty\projeto_sala_petshop\projeto_sala_petshop\imagens\nicollas.jpg");
            pictureBoxSte.Image = Image.FromFile(@"C:\Users\Lucas\source\repos\final\projeto_ATUALIZADO_petsty\projeto_sala_petshop\projeto_sala_petshop\imagens\stephanie.jpg");
            imagemOriginalG = pictureBoxGuilherme.Image;
            imagemOriginalL = pictureBoxLucas.Image;
            imagemOriginalN = pictureBoxNicollas.Image;
            imagemOriginalS = pictureBoxSte.Image;

        }

        private Image AjustarTransparencia(Image imagem, float opacidade)
        {
            Bitmap bmp = new Bitmap(imagem.Width, imagem.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacidade; // Define a opacidade (0 = totalmente transparente, 1 = totalmente opaco)

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(imagem, new Rectangle(0, 0, bmp.Width, bmp.Height),
                            0, 0, imagem.Width, imagem.Height, GraphicsUnit.Pixel, attributes);
            }

            return bmp;
        }

        private void bt_voltar_passeio_caes_Click(object sender, EventArgs e)
        {
            panel_passeio_caes.Controls.Clear();
            Servicos servicos = new Servicos() { TopLevel = false, TopMost = true };
            servicos.FormBorderStyle = FormBorderStyle.None;
            panel_passeio_caes.Controls.Add(servicos);
            servicos.Show();
        }

        private void pictureBoxGuilherme_MouseEnter(object sender, EventArgs e)
        {
            //contornoAtivo = false;
            pictureBoxGuilherme.Image = AjustarTransparencia(imagemOriginalG, 0.5f);
            lb_guilherme.Visible = true;
            desc_guilherme.Visible = true;
        }

        private void pictureBoxGuilherme_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxGuilherme.Image = imagemOriginalG;
            lb_guilherme.Visible = false;
            desc_guilherme.Visible = false;
        }

        private void pictureBoxGuilherme_Click(object sender, EventArgs e)
        {

            // Obtém o PictureBox clicado
            PictureBox pictureBoxClicada = sender as PictureBox;


            // Se já houver uma PictureBox selecionada, remove o contorno dela

            if (pictureBoxSelecionada != null && pictureBoxSelecionada != pictureBoxClicada)
            {
                pictureBoxSelecionada.Invalidate(); 
            }

            pictureBoxClicada.Invalidate();

            // Define a PictureBox clicada como a selecionada
            pictureBoxSelecionada = pictureBoxClicada;

            clickGui = true;

        }

        private void pictureBoxGuilherme_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            if (pictureBox == pictureBoxSelecionada)
            {
                // Desenha o contorno ao redor do PictureBox
                using (Pen pen = new Pen(corContorno, 7)) // Espessura da borda
                {
                    e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, pictureBoxGuilherme.Width - 1, pictureBoxGuilherme.Height - 1));
                }
            }
        }

        private void pictureBoxLucas_MouseEnter(object sender, EventArgs e)
        {
            //contornoAtivo = false;
            pictureBoxLucas.Image = AjustarTransparencia(imagemOriginalL, 0.5f);
            lb_lucas.Visible = true;
            desc_lucas.Visible = true;
        }

        private void pictureBoxLucas_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxLucas.Image = imagemOriginalL;
            lb_lucas.Visible = false;
            desc_lucas.Visible = false;
        }
        private void pictureBoxLucas_Click(object sender, EventArgs e)
        {
            PictureBox pictureBoxClicada = sender as PictureBox;

            if (pictureBoxSelecionada != null && pictureBoxSelecionada != pictureBoxClicada)
            {
                pictureBoxSelecionada.Invalidate();
            }

            pictureBoxClicada.Invalidate();

            pictureBoxSelecionada = pictureBoxClicada;

            clickLu = true;
        }

        private void pictureBoxLucas_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            if (pictureBox == pictureBoxSelecionada)
            {
                using (Pen pen = new Pen(corContorno, 7))
                {
                    e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, pictureBoxLucas.Width - 1, pictureBoxLucas.Height - 1));
                }
            }
        }

        private void pictureBoxNicollas_MouseEnter(object sender, EventArgs e)
        {
            //contornoAtivo = false;
            pictureBoxNicollas.Image = AjustarTransparencia(imagemOriginalN, 0.5f);
            lb_nicollas.Visible = true;
            desc_nicollas.Visible = true;
        }

        private void pictureBoxNicollas_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxNicollas.Image = imagemOriginalN;
            lb_nicollas.Visible = false;
            desc_nicollas.Visible = false;
        }

        private void pictureBoxNicollas_Click(object sender, EventArgs e)
        {
            PictureBox pictureBoxClicada = sender as PictureBox;

            if (pictureBoxSelecionada != null && pictureBoxSelecionada != pictureBoxClicada)
            {
                pictureBoxSelecionada.Invalidate();
            }

            pictureBoxClicada.Invalidate();

            pictureBoxSelecionada = pictureBoxClicada;

            clickNic = true;

        }

        private void pictureBoxNicollas_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            if (pictureBox == pictureBoxSelecionada)
            {
                using (Pen pen = new Pen(corContorno, 7))
                {
                    e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, pictureBoxLucas.Width - 1, pictureBoxLucas.Height - 1));
                }
            }
        }

        private void pictureBoxSte_MouseEnter(object sender, EventArgs e)
        {
            //contornoAtivo = false;
            pictureBoxSte.Image = AjustarTransparencia(imagemOriginalS, 0.5f);
            lb_ste.Visible = true;
            desc_ste.Visible = true;
        }

        private void pictureBoxSte_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSte.Image = imagemOriginalS;
            lb_ste.Visible = false;
            desc_ste.Visible = false;
        }

        private void pictureBoxSte_Click(object sender, EventArgs e)
        {
            PictureBox pictureBoxClicada = sender as PictureBox;

            if (pictureBoxSelecionada != null && pictureBoxSelecionada != pictureBoxClicada)
            {
                pictureBoxSelecionada.Invalidate();
            }

            pictureBoxClicada.Invalidate();

            pictureBoxSelecionada = pictureBoxClicada;
            clickSte = true;

        }

        private void pictureBoxSte_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            if (pictureBox == pictureBoxSelecionada)
            {
                using (Pen pen = new Pen(corContorno, 7))
                {
                    e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, pictureBoxLucas.Width - 1, pictureBoxLucas.Height - 1));
                }
            }
        }

        private void tb_tipo_caminhada_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo_caminhada = tb_tipo_caminhada.Text;

            switch (tipo_caminhada)
            {
                case "Leve":
                    valor_pass = 25.00m;
                    break;
                case "Moderada":
                    valor_pass = 40.00m;
                    break;
                case "Trote":
                    valor_pass = 50.00m;
                    break;
                default:
                    valor_pass = 0.00m;
                    break;
            }

            tb_valor_pass.Text = valor_pass.ToString("N2");
        }

        private void bt_selecionar_pass_Click(object sender, EventArgs e)
        {
            nr_pet_pass = tb_nr_pet.Text;
            data_pass = dt_agendamento_pass.Text;
            tipo_caminhada = tb_tipo_caminhada.Text;
            DateTime dataSelecionada = dt_agendamento_pass.Value;


            var passeioGuilherme = clickGui;
            var passeioLucas = clickLu;
            var passeioNicolas = clickNic;
            var passeioStephanie = clickSte;


            if (passeioGuilherme)
            {
                passeadorEscolhido = "Guilherme";
                clickLu = false;
                clickNic = false;
                clickSte = false;
            }
            if (passeioLucas)
            {
                passeadorEscolhido = "Lucas";
                clickGui = false;
                clickNic = false;
                clickSte = false;
            }
            if (passeioNicolas)
            {
                passeadorEscolhido = "Nicollas";
                clickGui = false;
                clickLu = false;
                clickSte = false;
            }
            if (passeioStephanie)
            {
                passeadorEscolhido = "Stephanie";
                clickGui = false;
                clickLu = false;
                clickNic = false;
            }

            if (string.IsNullOrWhiteSpace(nr_pet_pass) || string.IsNullOrWhiteSpace(data_pass) || string.IsNullOrWhiteSpace(tipo_caminhada) ||
                string.IsNullOrWhiteSpace(passeadorEscolhido))
            {
                MessageBox.Show("Por favor, preencha todos os campos e selecione os dados.", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(dataSelecionada < DateTime.Today)
            {
                MessageBox.Show("A data selecionada não pode ser menor que a data atual.", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt_agendamento_pass.Value = DateTime.Today;
            }
            else
            {
                rtb_confirmacao_pass.Text = $"Número de Registro do pet: {nr_pet_pass}\r\nTipo de Caminhada: {tipo_caminhada}\r\n" +
                $"Data de agendamento: {data_pass}\r\nPasseador(a) Responsável: {tb_nome_passeador.Text}\r\nValor do passeio: {tb_valor_pass.Text}";
                tb_nome_passeador.Text = passeadorEscolhido;
            }

        }

        private void bt_limpar_pass_Click(object sender, EventArgs e)
        {
            rtb_confirmacao_pass.Clear();
            tb_valor_pass.Clear();
            tb_nome_passeador.Clear();
            dt_agendamento_pass.Text = "";
            tb_nr_pet.Text = "";
            tb_tipo_caminhada.SelectedIndex = 0;

            PictureBox pictureBoxClicada = sender as PictureBox;

            foreach (Control control in this.Controls)
            {
                //Verifica se o controle é um PictureBox
                if (control is PictureBox)
                {
                    PictureBox pictureBox = control as PictureBox;

                    // Força a redesenhar o PictureBox para remover o contorno
                    pictureBox.Invalidate();
                }
            }
            // Limpa a PictureBox selecionada
            pictureBoxSelecionada = null;
        }

        private void bt_agendamento_pass_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja confirmar o passeio?", "Confirmação", MessageBoxButtons.YesNo);

            try
            {
                if (resultado == DialogResult.Yes)
                {
                    CultureInfo cultura = new CultureInfo("pt-BR");
                    nr_pet_pass = tb_nr_pet.Text;
                    int identityServ = 4;
                    tipo_caminhada = tb_tipo_caminhada.Text;
                    passeadorEscolhido = tb_nome_passeador.Text; //tb_nome_passeador.Text = passeadorEscolhido;
                    DateTime data_passeio = DateTime.Parse(dt_agendamento_pass.Text, cultura);
                    decimal valor_passeio = decimal.Parse(tb_valor_pass.Text, cultura);

                    if (string.IsNullOrWhiteSpace(nr_pet_pass) || string.IsNullOrWhiteSpace(tipo_caminhada) ||
                        valor_passeio == 0 ||string.IsNullOrWhiteSpace(dt_agendamento_pass.Text))
                    {
                        MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    Connection cn = new Connection();
                    cn.conn.Open();

                    //Verifica se já existe algum passeio agendado
                    string selectQuery = "select count(1) from agendamentos where id_usuario = @id_usuario and id_servico = @id_servico";

                    SqlCommand checkCmd = new SqlCommand(selectQuery, cn.conn);
                    checkCmd.Parameters.AddWithValue("@id_usuario", nr_pet_pass);
                    checkCmd.Parameters.AddWithValue("@id_servico", identityServ);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Já existe passeio marcado nessa data para esse número de registro.", "Passeio Existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        //Cadastro de passeio caso não haja nenhum agendamento para o número de registro específico
                        string insertQuery = "insert into agendamentos (id_usuario,id_servico,motivo,profissional_responsavel,data_hora,preco_agend)" +
                            "values (@id_usuario,@id_servico,@motivo,@profissional_responsavel,@data_hora,@preco_agend)";


                        SqlCommand cmd = new SqlCommand(insertQuery, cn.conn);

                        cmd.Parameters.AddWithValue("@id_usuario", nr_pet_pass);
                        cmd.Parameters.AddWithValue("@motivo", tipo_caminhada);
                        cmd.Parameters.AddWithValue("@profissional_responsavel", tb_nome_passeador.Text);
                        cmd.Parameters.AddWithValue("@data_hora", data_passeio);
                        cmd.Parameters.AddWithValue("@preco_agend", valor_pass);
                        cmd.Parameters.AddWithValue("@id_servico", identityServ);

                        int newRegis = (int)cmd.ExecuteNonQuery();
                        if (newRegis > 0)
                        {
                            MessageBox.Show("Passeio agendado com sucesso!", "Passeio Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rtb_confirmacao_pass.Clear();
                            tb_valor_pass.Clear();
                            tb_nome_passeador.Clear();
                            dt_agendamento_pass.Text = "";
                            tb_nr_pet.Text = "";
                            tb_tipo_caminhada.SelectedIndex = 0;
                        }

                        cn.conn.Close();

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("O Número de Registro informado não existe!", "ID não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_nr_pet.Focus();
            }
        }

        private void tb_nr_pet_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia o caractere
            }
            if (tb_nr_pet.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Impede digitar mais de 5 caracteres
            }
        }
    }
}
