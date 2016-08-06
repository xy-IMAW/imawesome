using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;

namespace imaw.Admin
{
    public partial class newsdetails : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                //int news_id = Convert.ToInt32(Request.QueryString["id"].Trim());
                int news_id = 3;
                //查找文章;
                IMAW.BLL.newsBLL bll = new IMAW.BLL.newsBLL();
                IMAW.Model.news newsModel = new IMAW.Model.news();
                newsModel = bll.GetModel(news_id);
                LoadData(newsModel);
            }

        }

        private void LoadData(IMAW.Model.news model)
        {
            string format = "yyyy-MM-dd";
            //数据绑定到表格
            news_id.Text = model.news_id.ToString();
            news_createtime.Text = model.news_createtime.ToString(format);

            news_posterid.Text = model.news_posterid.ToString();
            news_postername.Text = model.news_postername.ToString();
            news_title.Text = model.news_title.ToString();
            news_abstract.Text = model.news_abstract.ToString();
            news_content.Text = model.news_content.ToString();
            news_state.SelectedIndex = model.news_state;
            btnClose.OnClientClick = ActiveWindow.GetHideReference();
        }


        protected void btnSaveContinue_Click(object sender, EventArgs e)
        {
            IMAW.BLL.newsBLL bll = new IMAW.BLL.newsBLL();
            IMAW.Model.news model = new IMAW.Model.news();
            // 1. 这里放置保存窗体中数据的逻辑
            model.news_id = Convert.ToInt32(news_id.Text);
            model.news_createtime = Convert.ToDateTime(news_createtime.Text);
            model.news_class = "官网新闻";
            model.news_posterid = news_posterid.Text;
            model.news_postername = news_postername.Text;
            model.news_title = news_title.Text;
            model.news_abstract = news_abstract.Text;
            model.news_content = news_content.Text;
            model.news_state = news_state.SelectedIndex;

            if (bll.Update(model) == true){
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