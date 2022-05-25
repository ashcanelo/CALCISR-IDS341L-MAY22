namespace CalculadoraSueldo
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcularSueldo_Click(object sender, EventArgs e)
        {
            double vAFP, vIRS, vSFS, vSueldoNeto, vSueldoBruto;
            double vTaxAFP, vTaxIRS, vTaxSFS;

            vSueldoBruto = double.Parse(txtSueldoBruto.Text);

            vAFP = 0.0287;
            vIRS = 0.09;
            vSFS = 0.0304;

            vTaxAFP = vSueldoBruto * vAFP;
            vTaxIRS = vSueldoBruto * vIRS;
            vTaxSFS = vSueldoBruto * vSFS;

            vSueldoNeto = vSueldoBruto - (vTaxAFP + vTaxIRS + vTaxSFS);

            txtSueldoNeto.Text = vSueldoNeto.ToString();
            txtAFP.Text = vTaxAFP.ToString();
            txtIRS.Text = vTaxIRS.ToString();
            txtSFS.Text = vTaxSFS.ToString();

        }
    }
}