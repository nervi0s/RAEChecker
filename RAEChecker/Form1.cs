using HtmlAgilityPack;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RAEChecker
{
    public partial class FormRAE : Form
    {
        public FormRAE()
        {
            InitializeComponent();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox_input.Text))
            {
                MessageBox.Show("Inserte algo en el campo de texto", "Alerta");
            }
            else
            {
                string word = this.textBox_input.Text;

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                label_result.Text = existeEnLaRAE(word) ? "EXISTE" : "NO EXISTE";

                stopwatch.Stop();
                this.label_info.Text = "Consulta realizada en: " + stopwatch.ElapsedMilliseconds + " ms.";
            }
        }

        public bool existeEnLaRAE(string word)
        {
            string url = "https://dle.rae.es/" + word;

            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument htmlDoc = web.Load(url);
            HtmlNode htmlNode = htmlDoc.GetElementbyId("resultados");
            string text = htmlNode.InnerText;

            return !text.StartsWith("Aviso:");
        }
    }
}
