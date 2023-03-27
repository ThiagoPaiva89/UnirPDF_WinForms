using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Windows.Forms;

namespace Solucao_Unir_PDF
{
    public partial class Unir_PDF : Form
    {
        public Unir_PDF()
        {
            InitializeComponent();
        }

        private void btn_Origem_Click(object sender, EventArgs e)
        {
            Carregar_PDF_Origem();
        }

        private void Carregar_PDF_Origem()
        {
            var Abrir_Arquivo = new OpenFileDialog();
            Abrir_Arquivo.Filter = "Arquivos de Imagens pdf|*.pdf";
            Abrir_Arquivo.Multiselect = true;

            if (Abrir_Arquivo.ShowDialog() == DialogResult.OK)
                foreach (var arquivo in Abrir_Arquivo.FileNames)
                    lsb_Aquivo_Origem.Items.Add(arquivo);
        }

        private void btn_Destino_Click(object sender, EventArgs e)
        {
            Informar_Pasta_Destino();
        }

        private void Informar_Pasta_Destino()
        {
            var Abrir_Pasta = new FolderBrowserDialog();

            if (Abrir_Pasta.ShowDialog() == DialogResult.OK)
                lbl_Pasta_Destino.Text = Abrir_Pasta.SelectedPath;
            else
                lbl_Pasta_Destino.Text = "";
        }

        private void btn_Unir_Click(object sender, EventArgs e)
        {
            Unir_PDF_Dinamicamente();
            MessageBox.Show("Arquivos Unidos Com Sucesso!");
        }

        private void Unir_PDF_Dinamicamente()
        {
            try
            {
                PdfDocument oDestino = new PdfDocument();

                foreach (var Arquivo_Origem in lsb_Aquivo_Origem.Items)
                {
                    using (PdfDocument oOrigem = PdfReader.Open(Arquivo_Origem.ToString(), PdfDocumentOpenMode.Import))
                    {
                        int Contador = oOrigem.PageCount;
                        for (int i = 0; i < Contador; i++)
                        {
                            PdfPage Pagina = oOrigem.Pages[i];
                            oDestino.AddPage(Pagina);
                        }
                        oDestino.Save(lbl_Pasta_Destino.Text + "\\" + txt_Nome_Arquivo.Text + ".pdf");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }

        }

    }
}
