using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using COMMON;
using IMAW.Model;
using System.Text.RegularExpressions;

namespace imaw.Admin
{
    public partial class newsadd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                //查找文章;
                IMAW.Model.admin admin = (IMAW.Model.admin) SessionHelper.GetSession("imaw_admin");
                LoadData( admin);
            }

        }

        private void LoadData(IMAW.Model.admin admin)
        {
            IMAW.BLL.adminBLL adminbll = new IMAW.BLL.adminBLL();
            IMAW.Model.user_info user_info = new IMAW.Model.user_info();

            user_info = adminbll.GetAdminInfo(admin.admin_id);
            string format = "yyyy-MM-dd";
            //数据绑定到表格
            news_createtime.Text = DateTime.Now.ToString(format);
            news_posterid.Text = admin.admin_id.ToString();
            news_postername.Text = user_info.user_realname;

            news_title.Text = "";
            btnClose.OnClientClick = ActiveWindow.GetHideReference();
        }


        protected void btnSaveContinue_Click(object sender, EventArgs e)
        {
            IMAW.BLL.newsBLL bll = new IMAW.BLL.newsBLL();
            IMAW.Model.news model = new IMAW.Model.news();

            string news_content = Request.Form["Editor1"];
            string news_abstract = Request.Form["Editor2"];

            // 1. 这里放置保存窗体中数据的逻辑
            model.news_createtime = Convert.ToDateTime(news_createtime.Text);
            model.news_class = "官网新闻";
            model.news_posterid = news_posterid.Text;
            model.news_postername = news_postername.Text;
            model.news_title = news_title.Text;

            
            model.news_abstract = news_abstract;
            model.news_content = news_content;
            model.news_state = news_state.SelectedIndex;

            if (bll.Add(model) > 0)
            {
                //关闭本窗体，然后回发父窗体
                PageContext.RegisterStartupScript(ActiveWindow.GetHidePostBackReference());
                Alert.ShowInTop("修改信息成功");
            }
            else
            {
                Alert.ShowInTop("修改信息失败，请联系超级管理员");
            }
        }

        protected void btnSaveRefresh_Click(object sender, EventArgs e)
        {
            // 1. 这里放置保存窗体中数据的逻辑



            // 2. 关闭本窗体，然后刷新父窗体
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            string content = Request.Form["Editor1"].ToString();
            Regex regex = new Regex(@"<[^>]+>|</[^>]+>");
            content = regex.Replace(content, "");
            if (content.Length > 100)
            {
                content = content.Substring(0, 97) + "...";
            }

            PageContext.RegisterStartupScript(String.Format("updateEditor2({0});", JsHelper.Enquote(content)));
        }
    }
}