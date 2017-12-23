using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebHook_First.Controllers
{
    public class TestPostbackController : LineWebHookControllerBase
    {
        [HttpPost]
        public IHttpActionResult POST()
        {
            try
            {
                //設定ChannelAccessToken(或抓取Web.Config)
                //this.ChannelAccessToken = "!!!!! 改成自己的ChannelAccessToken !!!!!";

                //取得Line Event
                var LineEvent = this.ReceivedMessage.events.FirstOrDefault();
                //如果event是postback
                if (LineEvent.type.ToLower() == "postback")
                {
                    //抓取postback的data
                    var postdata = LineEvent.postback.data;
                    //剖析postbact data
                    var data = System.Web.HttpUtility.ParseQueryString(postdata);
                    //準備顯示訊息
                    var msg = "收到 postback\n";
                    foreach (var item in data.AllKeys)
                    {
                        msg += $" key: {item}  value: {data[item]}";
                    }
                    //回覆訊息
                    this.ReplyMessage(LineEvent.replyToken, msg);
                }
                else
                {
                    //回覆訊息
                    this.ReplyMessage(
                        LineEvent.replyToken, $"user:{LineEvent.source.userId}  沒有postback:");
                }

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
