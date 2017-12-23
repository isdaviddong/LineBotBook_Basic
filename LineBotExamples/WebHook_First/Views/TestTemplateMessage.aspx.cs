using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHook_First.Views
{
    public partial class TestTemplateMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //建立一個Buttons Template Message物件
            var ButtonsTemplateMsg = new isRock.LineBot.ButtonsTemplate();
            //設定thumbnailImageUrl
            ButtonsTemplateMsg.altText = "無法顯示時的替代文字";
            ButtonsTemplateMsg.thumbnailImageUrl = new Uri("https://arock.blob.core.windows.net/blogdata201709/14-143030-1cd8cf1e-8f77-4652-9afa-605d27f20933.png");
            ButtonsTemplateMsg.text = "請問您想購買哪一類的服飾?";
            ButtonsTemplateMsg.title = "詢問"; //標題
            //建立actions
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.PostbackAction()
            { label = "男裝", data = "product=clothes&type=man" });
            actions.Add(new isRock.LineBot.PostbackAction()
            { label = "女裝", data = "product=clothes&type=women" });
            actions.Add(new isRock.LineBot.PostbackAction()
            { label = "童裝", data = "product=clothes&type=children" });
            //將建立好的actions選項加入
            ButtonsTemplateMsg.actions = actions;
            //建立bot instance
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("換成你的Token");
            //send ButtonsTemplateMsg
            bot.PushMessage("換成你的UserId", ButtonsTemplateMsg);
        }
    }
}