using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebHook_First.Controllers
{
    public class ContentProcessController : LineWebHookControllerBase
    {
        [HttpPost]
        public IHttpActionResult POST()
        {
            string ChannelAccessToken  = "!!!!! 改成自己的ChannelAccessToken !!!!!";
            string path = System.Web.HttpContext.Current.Request.MapPath("/temp/");
            string filename, fileURL;
            byte[] fileBody;
            var LineEvent = this.ReceivedMessage.events.FirstOrDefault();

            try
            {
                //如果不是訊息
                if (LineEvent.type != "message") return Ok();

                //依照訊息類型處理
                switch (LineEvent.message.type.ToLower())
                {
                    case "text":
                        //回覆文字訊息
                        Utility.ReplyMessage(LineEvent.replyToken,
                            $"我只收到訊息:{LineEvent.message.text}", ChannelAccessToken);
                        break;
                    case "image":
                        filename = Guid.NewGuid().ToString() + ".png";
                        fileBody = Utility.GetUserUploadedContent(LineEvent.message.id, ChannelAccessToken);
                        System.IO.File.WriteAllBytes(path + filename, fileBody);
                        fileURL = $"http://{System.Web.HttpContext.Current.Request.Url.Host}/temp/{filename}";
                        Utility.ReplyMessage(LineEvent.replyToken,
                         $"收到一個圖檔，位於:\n {fileURL}", ChannelAccessToken);
                        break;
                    case "audio":
                        filename = Guid.NewGuid().ToString() + ".mp3";
                        fileBody = Utility.GetUserUploadedContent(LineEvent.message.id, ChannelAccessToken);
                        System.IO.File.WriteAllBytes(path + filename, fileBody);
                        fileURL = $"http://{System.Web.HttpContext.Current.Request.Url.Host}/temp/{filename}";
                        Utility.ReplyMessage(LineEvent.replyToken,
                         $"收到一個聲音檔，位於:\n {fileURL}", ChannelAccessToken);
                        break;
                    default:
                        Utility.ReplyMessage(LineEvent.replyToken,
                    $"其他的我看不懂...", ChannelAccessToken);
                        break;
                }
                return Ok();
            }
            catch (Exception ex)
            {
                //請自行處理Exception
                isRock.LineBot.Utility.ReplyMessage(
                LineEvent.replyToken, "ERROR:" + ex.Message, ChannelAccessToken);

                return Ok();
        }

         
        }
    }
}
