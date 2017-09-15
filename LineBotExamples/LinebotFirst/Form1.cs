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
        const string token = ""; //換成你的token
        const string AdminUserId = ""; //換成你的UserId

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

        //發送貼圖鈕
        private void button2_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);
            //發送貼圖
            bot.PushMessage(AdminUserId, 1,2);
        }

        //發送圖片鈕
        private void button3_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);

            //指定圖片位置
            Uri imgURL = new Uri("https://arock.blob.core.windows.net/blogdata201706/22-124357-ad3c87d6-b9cc-488a-8150-1c2fe642d237.png");
            //發送圖片
            bot.PushMessage(AdminUserId,imgURL);
        }

        private void buttonSendButtonTemplate_Click(object sender, EventArgs e)
        {
            //建立一個Buttons Template Message物件
            var ButtonsTemplateMsg = new isRock.LineBot.ButtonsTemplate();
            //設定thumbnailImageUrl
            ButtonsTemplateMsg.altText = "無法顯示時的替代文字";
            ButtonsTemplateMsg.thumbnailImageUrl=new Uri("https://arock.blob.core.windows.net/blogdata201709/14-143030-1cd8cf1e-8f77-4652-9afa-605d27f20933.png");
            ButtonsTemplateMsg.text = "請問您想購買哪一類的服飾?";
            ButtonsTemplateMsg.title = "詢問"; //標題
            //建立actions
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageAction() { label = "男裝", text = "man" });
            actions.Add(new isRock.LineBot.MessageAction() { label = "女裝", text = "women" });
            actions.Add(new isRock.LineBot.MessageAction() { label = "童裝", text = "children" });
            //將建立好的actions選項加入
            ButtonsTemplateMsg.actions = actions;
            //建立bot instance
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);
            //send ButtonsTemplateMsg
            bot.PushMessage(AdminUserId, ButtonsTemplateMsg);
        }

        private void buttonSendConfirmTemplate_Click(object sender, EventArgs e)
        {
            //建立一個Buttons Template Message物件
            var ConfirmTemplateMsg = new isRock.LineBot.ConfirmTemplate();
            //設定thumbnailImageUrl
            ConfirmTemplateMsg.altText = "無法顯示時的替代文字";
            ConfirmTemplateMsg.text = "請問您想選擇的是?";
            //建立actions
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageAction() { label = "同意", text = "yes" });
            actions.Add(new isRock.LineBot.MessageAction() { label = "拒絕", text = "no" });
            //將建立好的actions選項加入
            ConfirmTemplateMsg.actions = actions;
            //建立bot instance
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);
            //send ConfirmTemplateMsg
            bot.PushMessage(AdminUserId, ConfirmTemplateMsg);
        }

        private void buttonSendCarouselTemplate_Click(object sender, EventArgs e)
        {
            //建立actions，作為ButtonTemplate的用戶回覆行為
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageAction() { label = "標題-文字回覆", text = "回覆文字" });
            actions.Add(new isRock.LineBot.UriAction() { label = "標題-Google", uri = new Uri("http://www.google.com") });
            actions.Add(new isRock.LineBot.PostbackAction() { label = "標題-發生postack", data = "abc=aaa&def=111" });

            //單一Column 
            var Column = new isRock.LineBot.Column
            {
                text = "ButtonsTemplate文字訊息",
                title = "ButtonsTemplate標題",
                //設定圖片
                thumbnailImageUrl = new Uri("https://arock.blob.core.windows.net/blogdata201709/14-143030-1cd8cf1e-8f77-4652-9afa-605d27f20933.png"),
                actions = actions //設定回覆動作
            };

            //建立CarouselTemplate
            var CarouselTemplate = new isRock.LineBot.CarouselTemplate();

            //這是範例，所以用一組樣板建立三個
            CarouselTemplate.columns.Add(Column);
            CarouselTemplate.columns.Add(Column);
            CarouselTemplate.columns.Add(Column);

            //建立bot instance
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);

            //發送 CarouselTemplate
            bot.PushMessage(AdminUserId, CarouselTemplate);
        }
    }
}
