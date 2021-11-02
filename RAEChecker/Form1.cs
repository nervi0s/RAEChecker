using HtmlAgilityPack;
using System;
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
            string word = this.textBox_input.Text;
            label_result.Text = existeEnLaRAE(word) ? "EXISTE" : "NO EXISTE";
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
