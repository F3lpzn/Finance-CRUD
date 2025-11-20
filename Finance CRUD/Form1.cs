using System.Data;
using System.Data.SqlClient;
namespace Finance_CRUD
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=FLZGAMER\SQLEXPRESS;Database=FinanceDB;Integrated Security=True;";

        int idSelecionado = 0;

        public Form1()
        {
            InitializeComponent();
            cboFiltroTipo.SelectedIndex = 0; 
            CarregarDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "" || txtValor.Text == "" || cboTipo.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    string sql = "";

                    if (idSelecionado == 0)
                    {
                        sql = "INSERT INTO Lancamentos (Descricao, Valor, DataLancamento, Tipo) VALUES (@desc, @valor, @data, @tipo)";
                    }
                    else
                    {
                        sql = "UPDATE Lancamentos SET Descricao=@desc, Valor=@valor, DataLancamento=@data, Tipo=@tipo WHERE Id=@id";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@desc", txtDescricao.Text);
                        cmd.Parameters.AddWithValue("@valor", Convert.ToDecimal(txtValor.Text));
                        cmd.Parameters.AddWithValue("@data", dtpData.Value);
                        cmd.Parameters.AddWithValue("@tipo", cboTipo.Text);

                        if (idSelecionado != 0)
                            cmd.Parameters.AddWithValue("@id", idSelecionado);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Salvo com sucesso!");

                // Limpeza
                txtDescricao.Text = "";
                txtValor.Text = "";
                idSelecionado = 0; 
                CarregarDados(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void CarregarDados()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    string sql = "SELECT * FROM Lancamentos WHERE 1=1";

                    if (txtFiltroDesc.Text != "")
                    {
                        sql += " AND Descricao LIKE @buscaDesc";
                    }

                    if (cboFiltroTipo.Text != "Todos" && cboFiltroTipo.Text != "")
                    {
                        sql += " AND Tipo = @buscaTipo";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        if (txtFiltroDesc.Text != "")
                            cmd.Parameters.AddWithValue("@buscaDesc", "%" + txtFiltroDesc.Text + "%"); 

                        if (cboFiltroTipo.Text != "Todos" && cboFiltroTipo.Text != "")
                            cmd.Parameters.AddWithValue("@buscaTipo", cboFiltroTipo.Text);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvLancamentos.DataSource = dt;

                            decimal saldo = 0;
                            foreach (DataRow row in dt.Rows)
                            {
                                decimal valor = Convert.ToDecimal(row["Valor"]);
                                if (row["Tipo"].ToString() == "Entrada")
                                    saldo += valor;
                                else
                                    saldo -= valor;
                            }
                            lblSaldo.Text = $"Saldo: {saldo:C2}";
                            lblSaldo.ForeColor = saldo >= 0 ? Color.Green : Color.Red;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvLancamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um lançamento para excluir.");
                return;
            }

            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dgvLancamentos.SelectedRows[0].Cells["Id"].Value);

                    using (SqlConnection cn = new SqlConnection(connectionString))
                    {
                        cn.Open();
                        string sql = "DELETE FROM Lancamentos WHERE Id = @id";

                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    CarregarDados(); 
                    MessageBox.Show("Excluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLancamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um lançamento para editar.");
                return;
            }

            var linha = dgvLancamentos.SelectedRows[0];

            txtDescricao.Text = linha.Cells["Descricao"].Value.ToString();
            txtValor.Text = linha.Cells["Valor"].Value.ToString();
            cboTipo.Text = linha.Cells["Tipo"].Value.ToString();
            dtpData.Value = Convert.ToDateTime(linha.Cells["DataLancamento"].Value);

            idSelecionado = Convert.ToInt32(linha.Cells["Id"].Value);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
            txtValor.Text = "";
            dtpData.Value = DateTime.Now;
            cboTipo.SelectedIndex = -1;

            idSelecionado = 0; 
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarDados(); 
        }
    }
}
