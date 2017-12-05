using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebHook_First.Controllers
{
    public class MsgTypeWebHookController : ApiController
    {
        [HttpPost]
        public IHttpActionResult POST()
        {
            string ChannelAccessToken = ""; 
            //TODO: 上面請改成自己的token;

            //取得 http Post RawData(should be JSON)
            string postData = Request.Content.ReadAsStringAsync().Result;
            //剖析JSON
            var ReceivedMessage = isRock.LineBot.Utility.Parsing(postData);

            try
            {
                //回覆訊息
                string Message;
                Message = "收到 event 類型為 :  " + ReceivedMessage.events[0].type;
                if (ReceivedMessage.events[0].type == "message")
                {
                    Message += "\n 你傳來的訊息類型為: " + ReceivedMessage.events[0].message.type;
                }
                //回覆用戶
                isRock.LineBot.Utility.ReplyMessage(
                    ReceivedMessage.events[0].replyToken, Message, ChannelAccessToken);
                //回覆API OK
                return Ok();
            }
            catch (Exception ex)
            {
                //請自行處理Exception
                isRock.LineBot.Utility.ReplyMessage(
                ReceivedMessage.events[0].replyToken, "ERROR:" + ex.Message, ChannelAccessToken);

                return Ok();
            }
        }
    }
}
