namespace Final_project_assignmentt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbitem.SelectedItem.ToString() == "ข้าวเหนียวมะม่วง")
            {
                txtPrice.Text = "200";
            }
            else if (cmbitem.SelectedItem.ToString() == "กล้วยบวชชี")
            {
                txtPrice.Text = "150";
            }
            else if (cmbitem.SelectedItem.ToString() == "ลูกชุบ")
            {
                txtPrice.Text = "120";
            }
            else if (cmbitem.SelectedItem.ToString() == "คัพเค้ก")
            {
                txtPrice.Text = "170";
            }
            else
            {
                txtPrice.Text = "0";
            }

            txtTotal.Text = "";
            txtQty.Text = "";
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text.Length > 0)
            {
                txtTotal.Text = (Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQty.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[0].Value = cmbitem.Text;
            dataGridView1.Rows[i].Cells[1].Value = txtPrice.Text;
            dataGridView1.Rows[i].Cells[2].Value = txtQty.Text;
            dataGridView1.Rows[i].Cells[3].Value = txtTotal.Text;

            txtQty.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text.Length > 0)
            {
                txtTotal.Text = (Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtDiscount.Text)).ToString();
            }
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            if(txtPaid.Text.Length > 0)
            {
                txtBalance.Text = (Convert.ToDouble(txtPaid.Text) - Convert.ToDouble(txtTotal.Text)).ToString();
            }
        }

        private void BtOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                string reaaAllText = File.ReadAllText(openFileDialog.FileName);

                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string dessertRAW = readAllLine[i];
                    string[] dessertSplited = dessertRAW.Split(',');
                    Dessert dessert = new Dessert(dessertSplited[0], dessertSplited[1], dessertSplited[2], dessertSplited[3]);
                    addDataToGridView(dessertSplited[0], dessertSplited[1], dessertSplited[2], dessertSplited[3]);
                }

            }

            void addDataToGridView(string menu, string price, string qty, string total)
            {
                this.dataGridView1.Rows.Add(new string[] { menu, price, qty, total });
            }
        }

        private void txtSub_TextChanged(object sender, EventArgs e)
        {

        }
    }
}