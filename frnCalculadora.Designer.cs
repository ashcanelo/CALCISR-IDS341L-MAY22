namespace CalculadoraSueldo;

partial class frmCalculadora
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.lblTitulo = new System.Windows.Forms.Label();
        this.lblAFP = new System.Windows.Forms.Label();
        this.lblIRS = new System.Windows.Forms.Label();
        this.lblSFS = new System.Windows.Forms.Label();
        this.txtSueldoBruto = new System.Windows.Forms.TextBox();
        this.lblSueldoBruto = new System.Windows.Forms.Label();
        this.txtAFP = new System.Windows.Forms.TextBox();
        this.txtSFS = new System.Windows.Forms.TextBox();
        this.txtIRS = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.txtSueldoNeto = new System.Windows.Forms.TextBox();
        this.btnCalcularSueldo = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // lblTitulo
        // 
        this.lblTitulo.AutoSize = true;
        this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTitulo.Location = new System.Drawing.Point(180, 28);
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.Size = new System.Drawing.Size(239, 19);
        this.lblTitulo.TabIndex = 0;
        this.lblTitulo.Text = "Calculadora de Impuestos ISR";
        // 
        // lblAFP
        // 
        this.lblAFP.AutoSize = true;
        this.lblAFP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblAFP.Location = new System.Drawing.Point(43, 159);
        this.lblAFP.Name = "lblAFP";
        this.lblAFP.Size = new System.Drawing.Size(29, 16);
        this.lblAFP.TabIndex = 1;
        this.lblAFP.Text = "AFP";
        // 
        // lblIRS
        // 
        this.lblIRS.AutoSize = true;
        this.lblIRS.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblIRS.Location = new System.Drawing.Point(224, 159);
        this.lblIRS.Name = "lblIRS";
        this.lblIRS.Size = new System.Drawing.Size(24, 16);
        this.lblIRS.TabIndex = 2;
        this.lblIRS.Text = "IRS";
        // 
        // lblSFS
        // 
        this.lblSFS.AutoSize = true;
        this.lblSFS.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblSFS.Location = new System.Drawing.Point(418, 159);
        this.lblSFS.Name = "lblSFS";
        this.lblSFS.Size = new System.Drawing.Size(25, 16);
        this.lblSFS.TabIndex = 3;
        this.lblSFS.Text = "SFS";
        // 
        // txtSueldoBruto
        // 
        this.txtSueldoBruto.Location = new System.Drawing.Point(128, 98);
        this.txtSueldoBruto.Name = "txtSueldoBruto";
        this.txtSueldoBruto.Size = new System.Drawing.Size(145, 23);
        this.txtSueldoBruto.TabIndex = 4;
        // 
        // lblSueldoBruto
        // 
        this.lblSueldoBruto.AutoSize = true;
        this.lblSueldoBruto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblSueldoBruto.Location = new System.Drawing.Point(41, 101);
        this.lblSueldoBruto.Name = "lblSueldoBruto";
        this.lblSueldoBruto.Size = new System.Drawing.Size(85, 16);
        this.lblSueldoBruto.TabIndex = 5;
        this.lblSueldoBruto.Text = "Sueldo Bruto: ";
        // 
        // txtAFP
        // 
        this.txtAFP.Enabled = false;
        this.txtAFP.Location = new System.Drawing.Point(43, 190);
        this.txtAFP.Name = "txtAFP";
        this.txtAFP.Size = new System.Drawing.Size(145, 23);
        this.txtAFP.TabIndex = 6;
        // 
        // txtSFS
        // 
        this.txtSFS.Enabled = false;
        this.txtSFS.Location = new System.Drawing.Point(418, 190);
        this.txtSFS.Name = "txtSFS";
        this.txtSFS.Size = new System.Drawing.Size(145, 23);
        this.txtSFS.TabIndex = 7;
        // 
        // txtIRS
        // 
        this.txtIRS.Enabled = false;
        this.txtIRS.Location = new System.Drawing.Point(224, 190);
        this.txtIRS.Name = "txtIRS";
        this.txtIRS.Size = new System.Drawing.Size(145, 23);
        this.txtIRS.TabIndex = 8;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.label1.Location = new System.Drawing.Point(331, 101);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(81, 16);
        this.label1.TabIndex = 9;
        this.label1.Text = "Sueldo Neto:";
        // 
        // txtSueldoNeto
        // 
        this.txtSueldoNeto.Enabled = false;
        this.txtSueldoNeto.Location = new System.Drawing.Point(418, 98);
        this.txtSueldoNeto.Name = "txtSueldoNeto";
        this.txtSueldoNeto.Size = new System.Drawing.Size(145, 23);
        this.txtSueldoNeto.TabIndex = 10;
        // 
        // btnCalcularSueldo
        // 
        this.btnCalcularSueldo.BackColor = System.Drawing.Color.Indigo;
        this.btnCalcularSueldo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnCalcularSueldo.ForeColor = System.Drawing.Color.Azure;
        this.btnCalcularSueldo.Location = new System.Drawing.Point(41, 249);
        this.btnCalcularSueldo.Name = "btnCalcularSueldo";
        this.btnCalcularSueldo.Size = new System.Drawing.Size(520, 23);
        this.btnCalcularSueldo.TabIndex = 11;
        this.btnCalcularSueldo.Text = "Calcular Sueldo Neto";
        this.btnCalcularSueldo.UseVisualStyleBackColor = false;
        this.btnCalcularSueldo.Click += new System.EventHandler(this.btnCalcularSueldo_Click);
        // 
        // frmCalculadora
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(587, 292);
        this.Controls.Add(this.btnCalcularSueldo);
        this.Controls.Add(this.txtSueldoNeto);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.txtIRS);
        this.Controls.Add(this.txtSFS);
        this.Controls.Add(this.txtAFP);
        this.Controls.Add(this.lblSueldoBruto);
        this.Controls.Add(this.txtSueldoBruto);
        this.Controls.Add(this.lblSFS);
        this.Controls.Add(this.lblIRS);
        this.Controls.Add(this.lblAFP);
        this.Controls.Add(this.lblTitulo);
        this.Name = "frmCalculadora";
        this.Text = "Calculadora de Sueldo";
        this.TopMost = true;
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private Label lblTitulo;
    private Label lblAFP;
    private Label lblIRS;
    private Label lblSFS;
    private TextBox txtSueldoBruto;
    private Label lblSueldoBruto;
    private TextBox txtAFP;
    private TextBox txtSFS;
    private TextBox txtIRS;
    private Label label1;
    private TextBox txtSueldoNeto;
    private Button btnCalcularSueldo;
}