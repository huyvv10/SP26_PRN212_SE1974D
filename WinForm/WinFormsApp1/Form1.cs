namespace WinFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtNum1.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int.TryParse(txtNum1.Text, out int a);
            int.TryParse(txtNum2.Text, out int b);
            int rs = a + b;
            txtResult.Text = rs.ToString();
            //txtResult.Text = rs + "";
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            int.TryParse(txtNum1.Text, out int a);
            int.TryParse(txtNum2.Text, out int b);
            int rs = a - b;
            txtResult.Text = rs.ToString();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            int.TryParse(txtNum1.Text, out int a);
            int.TryParse(txtNum2.Text, out int b);
            int rs = a * b;
            txtResult.Text = rs.ToString();
        }

        private void btnQuotien_Click(object sender, EventArgs e)
        {
            int.TryParse(txtNum1.Text, out int a);
            int.TryParse(txtNum2.Text, out int b);
            if (b == 0)
            {
                MessageBox.Show("Number 2 must not be zero.","Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                double rs = Convert.ToDouble(a) / b;
                txtResult.Text = rs.ToString();
            }
            
        }
    }
}
