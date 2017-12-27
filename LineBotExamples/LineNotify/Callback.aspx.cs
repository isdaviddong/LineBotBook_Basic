using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LineNotify
{
    public partial class Callback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //取得返回的code
            var code = Request.QueryString["code"];
            if (code == null)
            {
                Response.Write("沒有正確回應code");
                Response.End();
            }
            //顯示，測試用
            Response.Write("<br/> code : " + code);
            //從Code取回toke
            var token = isRock.LineNotify.Utility.GetTokenFromCode(code,
                "FkAzcte6WjGR1s2PhqEP8b",  //TODO:請更正為你自己的 client_id
                "Y1dRkTf8LIKfbNZlcH6Op6lQLZovz2daEoa1Rd0zfdx", //TODO:請更正為你自己的 client_secret
                "http://localhost:49100/Callback.aspx");
            //顯示，測試用
            //(注意這是範例，token不該用明碼傳遞，也不該出現在用戶端，你應該自行記錄在資料庫或ServerSite session中)
            Response.Write("<br/> token : " + token.access_token);
            //利用token順手發個測試訊息
            isRock.LineNotify.Utility.SendNotify(token.access_token, "msg test - " + System.DateTime.Now.ToString());
        }
    }
}