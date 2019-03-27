using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NoContact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables
        int line;
        string number;
        string message;
        string URL;
        ProcessStartInfo sInfo;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            number = richTextBoxNumbers.Lines[line];
            message = textBoxMessage.Text.Replace("\r\n","%0A");
    
            URL = "https://web.whatsapp.com/send?phone=" + number + "&text=" + message;

            line++;

            sInfo = new ProcessStartInfo(URL);
            Process.Start(sInfo);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            richTextBoxNumbers.Clear();
            textBoxMessage.Clear();
            line = 0;
        }
    }
}
