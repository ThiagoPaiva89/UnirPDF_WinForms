namespace Solucao_Unir_PDF
{
    partial class Unir_PDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unir_PDF));
            this.lbl_Origem = new DevExpress.XtraEditors.LabelControl();
            this.btn_Origem = new System.Windows.Forms.Button();
            this.btn_Destino = new System.Windows.Forms.Button();
            this.lsb_Aquivo_Origem = new System.Windows.Forms.ListBox();
            this.lbl_Pasta_Destino = new DevExpress.XtraEditors.LabelControl();
            this.txt_Nome_Arquivo = new System.Windows.Forms.TextBox();
            this.btn_Unir = new System.Windows.Forms.Button();
            this.lbl_Nome_Arquivo_Destino = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lbl_Origem
            // 
            this.lbl_Origem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_Origem.Appearance.Options.UseFont = true;
            this.lbl_Origem.Location = new System.Drawing.Point(28, 12);
            this.lbl_Origem.Name = "lbl_Origem";
            this.lbl_Origem.Size = new System.Drawing.Size(118, 16);
            this.lbl_Origem.TabIndex = 1;
            this.lbl_Origem.Text = "Arquivos de Origem:";
            // 
            // btn_Origem
            // 
            this.btn_Origem.FlatAppearance.BorderSize = 0;
            this.btn_Origem.Image = ((System.Drawing.Image)(resources.GetObject("btn_Origem.Image")));
            this.btn_Origem.Location = new System.Drawing.Point(373, 12);
            this.btn_Origem.Name = "btn_Origem";
            this.btn_Origem.Size = new System.Drawing.Size(30, 30);
            this.btn_Origem.TabIndex = 3;
            this.btn_Origem.UseVisualStyleBackColor = true;
            this.btn_Origem.Click += new System.EventHandler(this.btn_Origem_Click);
            // 
            // btn_Destino
            // 
            this.btn_Destino.FlatAppearance.BorderSize = 0;
            this.btn_Destino.Image = ((System.Drawing.Image)(resources.GetObject("btn_Destino.Image")));
            this.btn_Destino.Location = new System.Drawing.Point(373, 114);
            this.btn_Destino.Name = "btn_Destino";
            this.btn_Destino.Size = new System.Drawing.Size(30, 30);
            this.btn_Destino.TabIndex = 4;
            this.btn_Destino.UseVisualStyleBackColor = true;
            this.btn_Destino.Click += new System.EventHandler(this.btn_Destino_Click);
            // 
            // lsb_Aquivo_Origem
            // 
            this.lsb_Aquivo_Origem.FormattingEnabled = true;
            this.lsb_Aquivo_Origem.Location = new System.Drawing.Point(152, 12);
            this.lsb_Aquivo_Origem.Name = "lsb_Aquivo_Origem";
            this.lsb_Aquivo_Origem.Size = new System.Drawing.Size(215, 95);
            this.lsb_Aquivo_Origem.TabIndex = 5;
            // 
            // lbl_Pasta_Destino
            // 
            this.lbl_Pasta_Destino.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_Pasta_Destino.Appearance.Options.UseFont = true;
            this.lbl_Pasta_Destino.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_Pasta_Destino.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lbl_Pasta_Destino.Location = new System.Drawing.Point(152, 118);
            this.lbl_Pasta_Destino.Name = "lbl_Pasta_Destino";
            this.lbl_Pasta_Destino.Size = new System.Drawing.Size(215, 22);
            this.lbl_Pasta_Destino.TabIndex = 6;
            // 
            // txt_Nome_Arquivo
            // 
            this.txt_Nome_Arquivo.Location = new System.Drawing.Point(152, 146);
            this.txt_Nome_Arquivo.Name = "txt_Nome_Arquivo";
            this.txt_Nome_Arquivo.Size = new System.Drawing.Size(215, 20);
            this.txt_Nome_Arquivo.TabIndex = 7;
            // 
            // btn_Unir
            // 
            this.btn_Unir.Location = new System.Drawing.Point(152, 172);
            this.btn_Unir.Name = "btn_Unir";
            this.btn_Unir.Size = new System.Drawing.Size(115, 35);
            this.btn_Unir.TabIndex = 8;
            this.btn_Unir.Text = "Unir Arquivos";
            this.btn_Unir.UseVisualStyleBackColor = true;
            this.btn_Unir.Click += new System.EventHandler(this.btn_Unir_Click);
            // 
            // lbl_Nome_Arquivo_Destino
            // 
            this.lbl_Nome_Arquivo_Destino.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_Nome_Arquivo_Destino.Appearance.Options.UseFont = true;
            this.lbl_Nome_Arquivo_Destino.Location = new System.Drawing.Point(11, 146);
            this.lbl_Nome_Arquivo_Destino.Name = "lbl_Nome_Arquivo_Destino";
            this.lbl_Nome_Arquivo_Destino.Size = new System.Drawing.Size(135, 16);
            this.lbl_Nome_Arquivo_Destino.TabIndex = 9;
            this.lbl_Nome_Arquivo_Destino.Text = "Nome do Novo Arquivo:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(46, 121);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 16);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Diretório Destino:";
            // 
            // Unir_PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 232);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbl_Nome_Arquivo_Destino);
            this.Controls.Add(this.btn_Unir);
            this.Controls.Add(this.txt_Nome_Arquivo);
            this.Controls.Add(this.lbl_Pasta_Destino);
            this.Controls.Add(this.lsb_Aquivo_Origem);
            this.Controls.Add(this.btn_Destino);
            this.Controls.Add(this.btn_Origem);
            this.Controls.Add(this.lbl_Origem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Unir_PDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unir PDFs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lbl_Origem;
        private System.Windows.Forms.Button btn_Origem;
        private System.Windows.Forms.Button btn_Destino;
        private System.Windows.Forms.ListBox lsb_Aquivo_Origem;
        private DevExpress.XtraEditors.LabelControl lbl_Pasta_Destino;
        private System.Windows.Forms.TextBox txt_Nome_Arquivo;
        private System.Windows.Forms.Button btn_Unir;
        private DevExpress.XtraEditors.LabelControl lbl_Nome_Arquivo_Destino;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

