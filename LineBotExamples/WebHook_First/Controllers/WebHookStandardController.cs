using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebHook_First.Controllers
{
    public class WebHookStandardController : LineWebHookControllerBase
    {
        [HttpPost]
        public IHttpActionResult POST()
        {
            try
            {
                //設定ChannelAccessToken(或抓取Web.Config)
                this.ChannelAccessToken = "!!!!! 改成自己的ChannelAccessToken !!!!!";
                //取得Line Event
                var LineEvent = this.ReceivedMessage.events.FirstOrDefault();
                //回覆訊息
                this.ReplyMessage(
                    LineEvent.replyToken, "你說了:" + LineEvent.message.text);
                //response OK
                return Ok();
            }
            catch (Exception ex)
            {
                //回覆訊息
                this.PushMessage("AdminUserId", "發生錯誤:\n" + ex.Message);
                //response OK
                return Ok();
            }
        }
    }
}
