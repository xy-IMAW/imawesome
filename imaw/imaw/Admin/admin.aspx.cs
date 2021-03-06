﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using IMAW.Model;
using IMAW.BLL;
using COMMON;

namespace imaw.Admin
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IMAW.Model.user_ider ider = new IMAW.Model.user_ider();
            IMAW.BLL.user_iderBLL iderbll = new IMAW.BLL.user_iderBLL();
            IMAW.Model.user_info user_info = new IMAW.Model.user_info();
            IMAW.BLL.user_infoBLL user_infobll = new IMAW.BLL.user_infoBLL();

            IMAW.Model.admin admin = (IMAW.Model.admin)SessionHelper.GetSession("imaw_admin");
            user_info = user_infobll.GetModel(iderbll.GetModel(admin.admin_id).user_id);
            ad_id.Text = user_info.user_realname + admin.admin_class.ToString();
        }

        public void login_out(object sender, EventArgs e)
        {
            SessionHelper.Del("imaw_admin");
            Alert.ShowInTop("您已退出该系统");
        }
    }
}