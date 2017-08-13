using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinebotFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var token = ""; //換成你的token
            var AdminUserId = ""; //換成你的UserId
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);

            bot.PushMessage(AdminUserId, "測試訊息");
        }
    }
}
