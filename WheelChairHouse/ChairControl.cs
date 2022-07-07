using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelChairHouse
{
    public partial class ChairControl : Form
    {
        public ChairControl()
        {
            InitializeComponent();
        }

        ConexãoBD bd = new ConexãoBD();
        string foto, sql;
        

        ///Metodo para limpar os campos do forms
        public void Limpar()
        {
            txt_nome.Clear();
            txt_codigo.Clear();
            cbx_tipo.SelectedIndex = -1;
            txt_qtd.Clear();
            txt_valor.Clear();
            img_foto.Load("C:/Users/Marco Cunha/Desktop/CRUD/WheelChairHouse/SemFoto.png");
            txt_nome.Focus();
        }

        ///Metodo para listar o banco de dados no DataGridView
        public void Listar()
        {
            sql = "SELECT * FROM PRODUTOS";
            dgv_bd.DataSource = bd.ConsultarTabelas(sql);
        }

        ///Configurando o botao "Novo", utilizado adicionar uma nova serie de componentes dentro do banco de dados
        private void btn_novo_Click(object sender, EventArgs e)
        {
            foto = foto.Replace(@"\", @"\\"); ///C# so reconhece com duas barras
            sql = string.Format("INSERT INTO PRODUTOS VALUES(null,'{0}','{1}','{2}','{3}','{4}')",
                                txt_nome.Text,cbx_tipo.Text,txt_qtd.Text,txt_valor.Text,foto);

            bd.AlterarTabelas(sql);
            MessageBox.Show("Adicionado com sucesso!!", "Controle", MessageBoxButtons.OK, MessageBoxIcon.Information); ///Mesagem de Informação para o usuario na conclusão da ação 

            Limpar();
            Listar();

        }


        ///Configuracao do botao "Alterar", utilizado para modificar qualquer componente do banco de dados
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            foto = foto.Replace(@"\", @"\\");
            sql = string.Format("UPDATE PRODUTOS SET NOME = '{0}', TIPO_PRODUTO = '{1}', QUANTIDADE = '{2}', VALOR = '{3}', FOTO = '{4}' WHERE CODIGO ='{5}'",txt_nome.Text,cbx_tipo.Text,txt_qtd.Text,txt_valor.Text,foto,txt_codigo.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Alterado com sucesso!!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            Listar();
        }

        private void ChairControl_Load(object sender, EventArgs e)
        {
            Listar();
            Limpar();
        }

        ///Configurando botao "Buscar" facilitando o usuario encontrar as configurações
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();
            sql = string.Format("SELECT * FROM PRODUTOS WHERE CODIGO = '{0}' OR NOME = '{1}'",txt_codigo.Text, txt_nome.Text);
            buscar = bd.ConsultarTabelas(sql);
            if(buscar.Rows.Count > 0)
            {

                txt_codigo.Text = buscar.Rows[0]["CODIGO"].ToString();
                txt_nome.Text = buscar.Rows[0]["NOME"].ToString();
                cbx_tipo.Text = buscar.Rows[0]["TIPO_PRODUTO"].ToString();
                txt_qtd.Text = buscar.Rows[0]["QUANTIDADE"].ToString();
                txt_valor.Text = buscar.Rows[0]["VALOR"].ToString();
                img_foto.Load(buscar.Rows[0]["foto"].ToString());
                foto = buscar.Rows[0]["foto"].ToString();

            }
            else
            {
                MessageBox.Show("Nenhum resultado encontrado!!", "Busca não encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar();
            }
        }

        ///Configurando o DataGridView, ao clicar em qualquer linha retornará os valores de cada componente do forms
        private void dgv_bd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dgv_bd.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dgv_bd.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbx_tipo.Text = dgv_bd.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_qtd.Text = dgv_bd.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_valor.Text = dgv_bd.Rows[e.RowIndex].Cells[4].Value.ToString();
            img_foto.Load(dgv_bd.Rows[e.RowIndex].Cells[5].Value.ToString());
            foto = dgv_bd.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        ///Configuração do botao "Excluir", utilizado para remover algum componente do banco de dados
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("DELETE FROM PRODUTOS WHERE CODIGO = '{0}'",txt_codigo.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Removido com sucesso!!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            Listar();
        }

        ///Configuração do botao "Excluir", usado para o usuario retorna a pagina inicial
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        ///Configurando botao da foto permitindo extrair uma foto do computador
        private void btn_foto_Click(object sender, EventArgs e)
        {
            foto = "";

            if(ofd_foto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ///FileName permiti extrair a foto dentro do seu computador
                img_foto.Load(ofd_foto.FileName);
                foto = ofd_foto.FileName;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_L_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void img_foto_Click(object sender, EventArgs e)
        {

        }
    }
}
