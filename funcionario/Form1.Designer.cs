namespace funcionario
{
    partial class Form1
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
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValorHora = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCPF.Location = new System.Drawing.Point(26, 36);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(54, 32);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF\r\n";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(26, 83);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(80, 32);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblValorHora
            // 
            this.lblValorHora.AutoSize = true;
            this.lblValorHora.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorHora.Location = new System.Drawing.Point(26, 140);
            this.lblValorHora.Name = "lblValorHora";
            this.lblValorHora.Size = new System.Drawing.Size(125, 32);
            this.lblValorHora.TabIndex = 2;
            this.lblValorHora.Text = "Valor Hora\r\n";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoras.Location = new System.Drawing.Point(26, 200);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(207, 32);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Horas Trabalhadas\r\n";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalario.Location = new System.Drawing.Point(26, 292);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(85, 32);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salário";
            this.lblSalario.Visible = false;
            this.lblSalario.Click += new System.EventHandler(this.lblSalario_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(119, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(349, 39);
            this.txtNome.TabIndex = 2;
            // 
            // txtValorHora
            // 
            this.txtValorHora.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorHora.Location = new System.Drawing.Point(170, 140);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(181, 39);
            this.txtValorHora.TabIndex = 3;
            // 
            // txtHoras
            // 
            this.txtHoras.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoras.Location = new System.Drawing.Point(260, 197);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 39);
            this.txtHoras.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalario.Location = new System.Drawing.Point(119, 289);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(169, 39);
            this.txtSalario.TabIndex = 6;
            this.txtSalario.Visible = false;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Orchid;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(340, 292);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(128, 40);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCPF.Location = new System.Drawing.Point(119, 29);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(207, 39);
            this.txtCPF.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(537, 371);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblValorHora);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCPF);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCPF;
        private Label lblNome;
        private Label lblValorHora;
        private Label lblHoras;
        private Label lblSalario;
        private TextBox txtNome;
        private TextBox txtValorHora;
        private TextBox txtHoras;
        private TextBox txtSalario;
        private Button btnCalcular;
        private MaskedTextBox txtCPF;
    }
}