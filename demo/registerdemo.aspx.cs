﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GeetestSDK;
namespace demo
{
    public partial class registerdemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected String getGTFront()
        {
            String private_key = "0f1a37e33c9ed10dd2e133fe2ae9c459";
            String captcha_id = "a40fd3b0d712165c5d13e6f747e948d4";
            GeetestLib geetest = new GeetestLib(private_key, captcha_id);
            if (geetest.register())
            {
                return geetest.getGTApiUrl();
            }
            else
            {
                //TODO
                return "";
            }
            
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            String privateKey = "0f1a37e33c9ed10dd2e133fe2ae9c459";
            GeetestLib geetest = new GeetestLib(privateKey);
            Boolean result = geetest.validate(Request);
            if (result)
            {
                //验证正确后的操作
                Response.Write("ok");

            }
            else
            {
                //验证错误后的操作
                Response.Write("error");

            }
        }
    }
}