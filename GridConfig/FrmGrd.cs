using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridConfig
{
    public partial class FrmGrd : Form
    {
        public class GrdItem
        {
            public string Nome { get; set; }
            public string Fone { get; set; }
            public string Depto { get; set; }
            public DateTime Periodo { get; set; }
            public double Salario { get; set; }

            public GrdItem(string nome, string fone, string depto, string periodo, double salario)
            {
                Nome = nome;
                Fone = fone;
                Depto = depto;
                Periodo = DateTime.Parse(periodo);
                Salario = salario;
            }
        };

        private readonly List<GrdItem> grdItems = new List<GrdItem>()
        {
            new GrdItem( "Joao",    "4323 2123",    "Fisica", "01/09/16", 1500.46),
            new GrdItem( "Maria",   "4323 2123",    "Quimica", "01/09/16", 1500.21),
            new GrdItem( "Joao",    "4323 2123",    "Calculo", "01/09/16", 2300.92),
            new GrdItem( "Fonseca", "4323 2123",    "Historia", "01/09/16", 1500.2),
            new GrdItem( "Joao",    "4323 2123",    "Fisica", "01/09/16", 1500.2),
            new GrdItem( "Manoela", "4323 2123",    "Idiomas", "01/09/16", 1500.2),
            new GrdItem( "Joao",    "4323 2123",    "Fisica", "01/09/16", 1500.2),
            new GrdItem( "Gabriel", "4323 2123",    "Calculo", "01/09/16", 1500.2),
            new GrdItem( "Jonas",   "4323 2123",    "Fisica", "01/09/16", 1500.2),
            new GrdItem( "Venceslau", "4323 2123",  "Economia", "01/09/16", 1500.2),
            new GrdItem( "Sabrina", "4323 2123",    "Fisica", "01/09/16", 1500.2),
            new GrdItem( "Joao",    "4323 2123",    "calculo", "01/09/16", 1500.2),
            new GrdItem( "Cristiano", "4323 2123",  "Biologia", "01/09/16", 1500.2),
            new GrdItem( "Riberto",  "4323 2123",   "Fisica", "01/09/16", 1500.2),
            new GrdItem( "Luiz",    "4323 2123",    "Mecanica", "01/09/16", 1500.2),
            new GrdItem( "Joao",    "4323 2123",    "Fisica", "01/09/16", 3215.2)
        };

        public FrmGrd() => InitializeComponent();

        private void FrmGrd_Load(object sender, EventArgs e) { }

        private void BtnDados_Click(object sender, EventArgs e)
        {
            dgvGrd.DataSource = grdItems;
        }

        private void BtnHeader_Click(object sender, EventArgs e)
        {
            //  -----------------------------------------------------------------
            //  Dimensionamento do grid
            //  Pode ser automatico qdo tem datasource ( como é o caso) ou manual
            //      dgvGrd.AutoGenerateColumns = false;
            //  Quando tem datasource o comando anaixo é invalido
            //      dgvGrd.ColumnCount = 4;
            //  -----------------------------------------------------------------

            //  A property abaixo tem que ser false caso contrario 
            //  os comandos de estilo são ignorados.         
            dgvGrd.EnableHeadersVisualStyles = false;          

            //  Header colors e fontes          
            dgvGrd.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvGrd.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //  O fonte default vem do componente pai do grid, no caso o form
            dgvGrd.ColumnHeadersDefaultCellStyle.Font = new Font(dgvGrd.Font.Name, dgvGrd.Font.Size + 1, FontStyle.Regular);

            //  Altura da linha de cabeçalho. Primeiro habilita resize e depois altera. 
            dgvGrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvGrd.ColumnHeadersHeight = Convert.ToInt16(2.4 * dgvGrd.ColumnHeadersDefaultCellStyle.Font.Height); ;

            //  Define o estilo da linha divisoria entre os headers
            dgvGrd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
        }

        private void BtnRows_Click(object sender, EventArgs e)
        {
            //  Cor de fundo, fonte e cor da fonte
            dgvGrd.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvGrd.DefaultCellStyle.Font = new Font(dgvGrd.Font.Name, dgvGrd.Font.Size - 2, FontStyle.Regular);
            dgvGrd.DefaultCellStyle.ForeColor = Color.DarkSlateGray;
            //  Linhas alternadas de cores diferentes para facilitar a leitura
            dgvGrd.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            //  Altura das linhas de texto
            dgvGrd.RowTemplate.Height = Convert.ToInt16(1.8 * dgvGrd.DefaultCellStyle.Font.Height);

            //  Row Headers são celulas vazias a esquerda de cada linha. Como no excel onde fica a numeracao
            dgvGrd.RowHeadersVisible = true;
            dgvGrd.RowHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            //  Fazendo altura = largura por estética apenas. Nao é necessário.
            dgvGrd.RowHeadersWidth = dgvGrd.RowTemplate.Height;

            //  Zera o grid e carrega os dados de novo para alterar a altura das linhas.
            dgvGrd.DataSource = null;
            dgvGrd.DataSource = grdItems;
        }

        private void BtnCols_Click(object sender, EventArgs e)
        {
            //  -----------------------------------------------------------------------------------
            //  Estes dois comandos sao necessarios quando a data cource ven de um banco de dados
            //  Tipo dataset, datatable etc
            //      dgvGrd.Columns[0].Name = "Asset";
            //      dgvGrd.Columns[0].DataPropertyName = "IdAsset";
            //  -----------------------------------------------------------------------------------

            //  O texto no header de cada coluna pode vir do datasource mas pode ser modificado aqui
            dgvGrd.Columns[0].HeaderText = "Name";
            dgvGrd.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //  O posicionamento do texto = vertical (bottom, middle top) e horizontal(left, center, right)
            dgvGrd.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvGrd.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGrd.Columns[1].HeaderText = "Phone";
            dgvGrd.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGrd.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrd.Columns[2].HeaderText = "Depmto";
            dgvGrd.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGrd.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrd.Columns[3].HeaderText = "Period";
            dgvGrd.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGrd.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvGrd.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGrd.Columns[3].DefaultCellStyle.Format = "ddd, dd/MM/yyyy";
            
            dgvGrd.Columns[4].HeaderText = "Action";
            dgvGrd.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGrd.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvGrd.Columns[4].DefaultCellStyle.Format = "N2";   // 9.999,99

            //  Bordas das celulas do grid. No caso selecionamos apenas linhas horizontais
            dgvGrd.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGrd.GridColor = Color.BurlyWood;     // Cor das linhas

            //  Cor da parte do grid nao preenchida pela lista
            dgvGrd.BackgroundColor = dgvGrd.DefaultCellStyle.BackColor;

            //  Seleção de linhas            
            dgvGrd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrd.MultiSelect = true;
            dgvGrd.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvGrd.ClearSelection();
        }

        private void BtnBehavior_Click(object sender, EventArgs e)
        {
            //  Tira o rowheader
            dgvGrd.RowHeadersVisible = false;

            //  Muda seleção de linhas para apenas uma de cada vez
            dgvGrd.MultiSelect = false;
            dgvGrd.ClearSelection();

            //  Protege o grid de modificações
            //  Protege o grid todo
            //      dgvGrd.ReadOnly = true;
            //  Protege apenas uma coluna
            dgvGrd.Columns[0].ReadOnly = true;
            //  Protege apenas uma celula.
            //      dgvGrd.Rows[0].Cells[0].ReadOnly = true;

            //  Impede que o usuario mude (com o mouse) a altura de linha
            dgvGrd.AllowUserToResizeRows = false;
            //  Impede que o usuario mude a largura de uma coluna
            dgvGrd.AllowUserToResizeColumns = false;

            //  Permite que o usuario mude as colunas de lugar
            dgvGrd.AllowUserToOrderColumns = true;
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            //  Configure Context Menu associated to dgvGrd Grid
            ContextMenuStrip cmsDgvTrade = new ContextMenuStrip();
            dgvGrd.ContextMenuStrip = cmsDgvTrade;

            //#region ContextMenu
            cmsDgvTrade.Items.Clear();
            ////  Load menu strip options
            cmsDgvTrade.Items.Add(new ToolStripMenuItem
            {
                Font = new System.Drawing.Font("Segoe UI", 12F),
                BackColor = Color.DarkGray,
                ForeColor = Color.Snow,
                Text = "    Grid Options",
                Alignment = ToolStripItemAlignment.Right,
                Height = 2 * Height,
            }) ;
            cmsDgvTrade.Items.Add(new ToolStripSeparator
            {
                BackColor = Color.Bisque,
                Height = 3
            });
            cmsDgvTrade.Items.Add(new ToolStripMenuItem
            {
                Font = new System.Drawing.Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                Text = "Add New Row",
                Image = Properties.Resources.page
            });
            cmsDgvTrade.Items.Add(new ToolStripMenuItem
            {
                Font = new System.Drawing.Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                Text = "Edit Selected Row",
                Image = Properties.Resources.New
            });
            cmsDgvTrade.Items.Add(new ToolStripMenuItem
            {
                Font = new System.Drawing.Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                Text = "Delete Selected Row",
                Image = Properties.Resources.Delete4
            });
            cmsDgvTrade.Items.Add(new ToolStripSeparator
            {
                BackColor = Color.Bisque,
                Height = 3
            });
            cmsDgvTrade.Items.Add(new ToolStripMenuItem
            {
                Name = "tspUpdMktData",
                Font = new System.Drawing.Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                Text = "Update Rows",
                Image = Properties.Resources.SaveDisk
            });
        }

        private void dgvGrd_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvGrd.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
