using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LineNotify
{
    public partial class SendNotify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //以Token發送訊息
            isRock.LineNotify.Utility.SendNotify(
                this.TextBoxToken.Text, this.TextBoxMsg.Text);
        }
    }
}