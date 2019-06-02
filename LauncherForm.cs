using System;
using System.Reflection;
using System.Windows.Forms;

namespace SharpMCL
{
    public partial class LauncherForm : Form
    {
        const string InstanceName = "";
        const string ClientPath = @"\Instances\" + InstanceName + @"\";
        private string clientdir = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + ClientPath;
        private string client = "DPT";
        private string user = "USSRNAME";
        private string uuid = Guid.NewGuid().ToString();
        private string session = "0";

        public LauncherForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Program.start(clientdir, client, user, uuid, session);
        }
    }
}
