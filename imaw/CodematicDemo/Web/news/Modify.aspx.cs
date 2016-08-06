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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.news
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int news_id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(news_id);
				}
			}
		}
			
	private void ShowInfo(int news_id)
	{
		Maticsoft.BLL.newsBLL bll=new Maticsoft.BLL.newsBLL();
		Maticsoft.Model.news model=bll.GetModel(news_id);
		this.lblnews_id.Text=model.news_id.ToString();
		this.txtnews_createtime.Text=model.news_createtime.ToString();
		this.txtnews_posterid.Text=model.news_posterid;
		this.txtnews_title.Text=model.news_title;
		this.txtnews_class.Text=model.news_class;
		this.txtnews_abstract.Text=model.news_abstract;
		this.txtnews_content.Text=model.news_content;
		this.txtnews_readnum.Text=model.news_readnum.ToString();
		this.txtnews_state.Text=model.news_state.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtnews_createtime.Text))
			{
				strErr+="news_createtime格式错误！\\n";	
			}
			if(this.txtnews_posterid.Text.Trim().Length==0)
			{
				strErr+="news_posterid不能为空！\\n";	
			}
			if(this.txtnews_title.Text.Trim().Length==0)
			{
				strErr+="news_title不能为空！\\n";	
			}
			if(this.txtnews_class.Text.Trim().Length==0)
			{
				strErr+="news_class不能为空！\\n";	
			}
			if(this.txtnews_abstract.Text.Trim().Length==0)
			{
				strErr+="news_abstract不能为空！\\n";	
			}
			if(this.txtnews_content.Text.Trim().Length==0)
			{
				strErr+="news_content不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtnews_readnum.Text))
			{
				strErr+="news_readnum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtnews_state.Text))
			{
				strErr+="news_state格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int news_id=int.Parse(this.lblnews_id.Text);
			DateTime news_createtime=DateTime.Parse(this.txtnews_createtime.Text);
			string news_posterid=this.txtnews_posterid.Text;
			string news_title=this.txtnews_title.Text;
			string news_class=this.txtnews_class.Text;
			string news_abstract=this.txtnews_abstract.Text;
			string news_content=this.txtnews_content.Text;
			int news_readnum=int.Parse(this.txtnews_readnum.Text);
			int news_state=int.Parse(this.txtnews_state.Text);


			Maticsoft.Model.news model=new Maticsoft.Model.news();
			model.news_id=news_id;
			model.news_createtime=news_createtime;
			model.news_posterid=news_posterid;
			model.news_title=news_title;
			model.news_class=news_class;
			model.news_abstract=news_abstract;
			model.news_content=news_content;
			model.news_readnum=news_readnum;
			model.news_state=news_state;

			Maticsoft.BLL.newsBLL bll=new Maticsoft.BLL.newsBLL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
