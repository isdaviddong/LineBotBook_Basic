using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebHook_First.Controllers
{
  
    public class LineBotWebHookController : ApiController
    {
        [HttpPost]
        public IHttpActionResult POST()
        {
            string ChannelAccessToken = "Omj1rwtDh+eP0wb+KbcbLF0+tpdrlDz7G+cfXXvmrf4W8gBz7x9VNgyApN62ZY31muFeXll6qFCKrbsJyfYxgt6qqxoKZ7ygxdWIHFkIudhxrzj46W2tXjY+djMfTVI1RrYfNptLOjQA7ARXs2JRHAdB04t89/1O/w1cDnyilFU=";
    
            try
            {
                //取得 http Post RawData(should be JSON)
                string postData = Request.Content.ReadAsStringAsync().Result;
                //剖析JSON
                var ReceivedMessage = isRock.LineBot.Utility.Parsing(postData);
                //回覆訊息
                string Message;
                Message = "你說了:" + ReceivedMessage.events[0].message.text;
                //回覆用戶
                isRock.LineBot.Utility.ReplyMessage(
                    ReceivedMessage.events[0].replyToken, Message, ChannelAccessToken);
                //回覆API OK
                return Ok();
            }
            catch (Exception ex)
            {
                //請自行處理Exception
                return Ok();
            }
        }
    }
}
