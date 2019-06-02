using System;
using System.Reflection;
using System.Windows.Forms;

namespace SharpMCL
{
    public partial class LauncherForm : Form
    {
        public LauncherForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String InstanceName = "";
            InstanceName = textBox1.Text;
            String ClientPath = @"\Instances\" + InstanceName + @"\";
            String clientdir = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + ClientPath;
            String client = "DPT";
            String user = "USSRNAME";
            String uuid = Guid.NewGuid().ToString();
            String session = "0";
            Program.start(clientdir, client, user, uuid, session);
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
