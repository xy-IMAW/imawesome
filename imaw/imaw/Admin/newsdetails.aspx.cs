using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using System.Text.RegularExpressions;

namespace imaw.Admin
{
    public partial class newsdetails : System.Web.UI.Page
    {
        public  static string new_cont = "";
        public static  string new_abs  = "";

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


        /// <summary>
        /// 加载文章的内容
        /// </summary>
        /// <param name="model"></param>
        private void LoadData(IMAW.Model.news model)
        {
            string format = "yyyy-MM-dd";
            //数据绑定到表格
            news_id.Text = model.news_id.ToString();
            news_createtime.Text = model.news_createtime.ToString(format);
            news_posterid.Text = model.news_posterid.ToString();
            news_postername.Text = model.news_postername.ToString();
            news_title.Text = model.news_title.ToString();
            news_state.SelectedIndex = model.news_state;

            //绑定文章内容与文章摘要
             new_cont = HttpUtility.HtmlDecode(model.news_content);
             new_abs = model.news_abstract;

            PageContext.RegisterStartupScript(String.Format("updateEditor1({0});", JsHelper.Enquote(new_cont)));
            PageContext.RegisterStartupScript(String.Format("updateEditor2({0});", JsHelper.Enquote(new_abs)));

            btnClose.OnClientClick = ActiveWindow.GetHideReference();
        }



        /// <summary>
        /// 保存文章
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSaveContinue_Click(object sender, EventArgs e)
        {
            string news_content = Request.Form["Editor1"];
            string news_abstract = Request.Form["Editor2"];

            if (String.IsNullOrEmpty(news_content))
            {
                Alert.ShowInTop("文章正文不能为空！");
                return;
            }

            IMAW.BLL.newsBLL bll = new IMAW.BLL.newsBLL();
            IMAW.Model.news model = new IMAW.Model.news();
            // 1. 这里放置保存窗体中数据的逻辑
            model.news_id = Convert.ToInt32(news_id.Text);
            model.news_createtime = Convert.ToDateTime(news_createtime.Text);
            model.news_class = "官网新闻";
            model.news_posterid = news_posterid.Text;
            model.news_postername = news_postername.Text;
            model.news_title = news_title.Text;
            model.news_state = news_state.SelectedIndex;


            //文章概要与文章内容
            model.news_content = HttpUtility.HtmlEncode(news_content);
            model.news_abstract = news_abstract;


            //数据库中修改数据
            if (bll.Update(model) == true)
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

        protected void btnSaveRefresh_Click(object sender, EventArgs e)
        {
            // 1. 这里放置保存窗体中数据的逻辑



            // 2. 关闭本窗体，然后刷新父窗体
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

    }
}

