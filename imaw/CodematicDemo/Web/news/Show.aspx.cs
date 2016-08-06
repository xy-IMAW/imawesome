using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace Maticsoft.Web.news
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int news_id=(Convert.ToInt32(strid));
					ShowInfo(news_id);
				}
			}
		}
		
	private void ShowInfo(int news_id)
	{
		Maticsoft.BLL.newsBLL bll=new Maticsoft.BLL.newsBLL();
		Maticsoft.Model.news model=bll.GetModel(news_id);
		this.lblnews_id.Text=model.news_id.ToString();
		this.lblnews_createtime.Text=model.news_createtime.ToString();
		this.lblnews_posterid.Text=model.news_posterid;
		this.lblnews_title.Text=model.news_title;
		this.lblnews_class.Text=model.news_class;
		this.lblnews_abstract.Text=model.news_abstract;
		this.lblnews_content.Text=model.news_content;
		this.lblnews_readnum.Text=model.news_readnum.ToString();
		this.lblnews_state.Text=model.news_state.ToString();

	}


    }
}
