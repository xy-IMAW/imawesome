using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using COMMON;
using IMAW.Model;

namespace imaw.Admin
{
    public partial class newsadd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                //查找文章;
                IMAW.Model.admin admin = (IMAW.Model.admin) SessionHelper.GetSession("admin");
                LoadData( admin);
            }

        }

        private void LoadData(IMAW.Model.admin admin)
        {
            IMAW.BLL.user_infoBLL user = new IMAW.BLL.user_infoBLL();
            string format = "yyyy-MM-dd";
            DateTime now =  new DateTime();
            //数据绑定到表格
            news_createtime.Text = now.ToString(format);
            news_posterid.Text = admin.admin_id.ToString();

            news_postername.Text = user.GetModel(admin.admin_id).user_realname;

            news_title.Text = "";
            news_abstract.Text = "";
            news_content.Text = "";
            btnClose.OnClientClick = ActiveWindow.GetHideReference();
        }


        protected void btnSaveContinue_Click(object sender, EventArgs e)
        {
            IMAW.BLL.newsBLL bll = new IMAW.BLL.newsBLL();
            IMAW.Model.news model = new IMAW.Model.news();
            // 1. 这里放置保存窗体中数据的逻辑
            model.news_createtime = Convert.ToDateTime(news_createtime.Text);
            model.news_class = "官网新闻";
            model.news_posterid = news_posterid.Text;
            model.news_postername = news_postername.Text;
            model.news_title = news_title.Text;
            model.news_abstract = news_abstract.Text;
            model.news_content = news_content.Text;
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

    }
}