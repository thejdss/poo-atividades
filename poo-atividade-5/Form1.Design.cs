namespace poo_forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblVagas = new System.Windows.Forms.Label();
            this.mtxPlaca = new System.Windows.Forms.MaskedTextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCalcularValores = new System.Windows.Forms.Button();
            this.lbCarros = new System.Windows.Forms.ListBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.checkBoxG = new System.Windows.Forms.CheckBox();
            this.checkBoxP = new System.Windows.Forms.CheckBox();
            this.checkBoxM = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(8, 43);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(57, 22);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa";
            // 
            // lblVagas
            // 
            this.lblVagas.AutoSize = true;
            this.lblVagas.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVagas.Location = new System.Drawing.Point(8, 9);
            this.lblVagas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVagas.Name = "lblVagas";
            this.lblVagas.Size = new System.Drawing.Size(197, 22);
            this.lblVagas.TabIndex = 1;
            this.lblVagas.Text = "Carros Estacionados: ";
            // 
            // mtxPlaca
            // 
            this.mtxPlaca.Location = new System.Drawing.Point(79, 47);
            this.mtxPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.mtxPlaca.Mask = ">LLL-0000";
            this.mtxPlaca.Name = "mtxPlaca";
            this.mtxPlaca.Size = new System.Drawing.Size(76, 20);
            this.mtxPlaca.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Orange;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(402, 43);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(165, 30);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar Veiculo";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnCarroAdicionar_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Lime;
            this.btnListar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(411, 84);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(157, 38);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar Veiculos";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnCalcularValores
            // 
            this.btnCalcularValores.BackColor = System.Drawing.Color.LightCyan;
            this.btnCalcularValores.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularValores.Location = new System.Drawing.Point(411, 126);
            this.btnCalcularValores.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcularValores.Name = "btnCalcularValores";
            this.btnCalcularValores.Size = new System.Drawing.Size(157, 35);
            this.btnCalcularValores.TabIndex = 7;
            this.btnCalcularValores.Text = "Verificar Valores";
            this.btnCalcularValores.UseVisualStyleBackColor = false;
            this.btnCalcularValores.Click += new System.EventHandler(this.btnCalcularValores_Click);
            // 
            // lbCarros
            // 
            this.lbCarros.FormattingEnabled = true;
            this.lbCarros.Location = new System.Drawing.Point(12, 87);
            this.lbCarros.Margin = new System.Windows.Forms.Padding(2);
            this.lbCarros.Name = "lbCarros";
            this.lbCarros.Size = new System.Drawing.Size(373, 108);
            this.lbCarros.TabIndex = 8;
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.Red;
            this.btnRetirar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.Location = new System.Drawing.Point(411, 165);
            this.btnRetirar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(157, 30);
            this.btnRetirar.TabIndex = 9;
            this.btnRetirar.Text = "Retirar Veiculo";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // checkBoxG
            // 
            this.checkBoxG.AutoSize = true;
            this.checkBoxG.Location = new System.Drawing.Point(175, 43);
            this.checkBoxG.Name = "checkBoxG";
            this.checkBoxG.Size = new System.Drawing.Size(99, 17);
            this.checkBoxG.TabIndex = 12;
            this.checkBoxG.Text = "Veiculo Grande";
            this.checkBoxG.UseVisualStyleBackColor = true;
            this.checkBoxG.Click += new System.EventHandler(this.checkBoxG_CheckedChanged);
            // 
            // checkBoxP
            // 
            this.checkBoxP.AutoSize = true;
            this.checkBoxP.Location = new System.Drawing.Point(280, 43);
            this.checkBoxP.Name = "checkBoxP";
            this.checkBoxP.Size = new System.Drawing.Size(107, 17);
            this.checkBoxP.TabIndex = 13;
            this.checkBoxP.Text = "Veiculo Pequeno";
            this.checkBoxP.UseVisualStyleBackColor = true;
            this.checkBoxP.Click += new System.EventHandler(this.checkBoxP_CheckedChanged);
            // 
            // checkBoxM
            // 
            this.checkBoxM.AutoSize = true;
            this.checkBoxM.Checked = true;
            this.checkBoxM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxM.Location = new System.Drawing.Point(175, 66);
            this.checkBoxM.Name = "checkBoxM";
            this.checkBoxM.Size = new System.Drawing.Size(50, 17);
            this.checkBoxM.TabIndex = 14;
            this.checkBoxM.Text = "Moto";
            this.checkBoxM.UseVisualStyleBackColor = true;
            this.checkBoxM.Click += new System.EventHandler(this.checkBoxM_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 204);
            this.Controls.Add(this.checkBoxM);
            this.Controls.Add(this.checkBoxP);
            this.Controls.Add(this.checkBoxG);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.lbCarros);
            this.Controls.Add(this.btnCalcularValores);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mtxPlaca);
            this.Controls.Add(this.lblVagas);
            this.Controls.Add(this.lblPlaca);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Estacionamento do Jaja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblVagas;
        private System.Windows.Forms.MaskedTextBox mtxPlaca;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCalcularValores;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.CheckBox checkBoxG;
        private System.Windows.Forms.CheckBox checkBoxP;
        private System.Windows.Forms.CheckBox checkBoxM;
        private System.Windows.Forms.ListBox lbCarros;
    }
}

