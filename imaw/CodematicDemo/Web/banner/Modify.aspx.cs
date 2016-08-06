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
namespace Maticsoft.Web.banner
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int banner_id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(banner_id);
				}
			}
		}
			
	private void ShowInfo(int banner_id)
	{
		Maticsoft.BLL.bannerBLL bll=new Maticsoft.BLL.bannerBLL();
		Maticsoft.Model.banner model=bll.GetModel(banner_id);
		this.lblbanner_id.Text=model.banner_id.ToString();
		this.txtbanner_title.Text=model.banner_title;
		this.txtbanner_abstract.Text=model.banner_abstract;
		this.txtbanner_link.Text=model.banner_link;
		this.txtbanner_img.Text=model.banner_img;
		this.txtbanner_state.Text=model.banner_state.ToString();
		this.txtbanner_posterid.Text=model.banner_posterid;
		this.txtbanner_postdate.Text=model.banner_postdate.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtbanner_title.Text.Trim().Length==0)
			{
				strErr+="banner_title不能为空！\\n";	
			}
			if(this.txtbanner_abstract.Text.Trim().Length==0)
			{
				strErr+="banner_abstract不能为空！\\n";	
			}
			if(this.txtbanner_link.Text.Trim().Length==0)
			{
				strErr+="banner_link不能为空！\\n";	
			}
			if(this.txtbanner_img.Text.Trim().Length==0)
			{
				strErr+="banner_img不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtbanner_state.Text))
			{
				strErr+="banner_state格式错误！\\n";	
			}
			if(this.txtbanner_posterid.Text.Trim().Length==0)
			{
				strErr+="banner_posterid不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtbanner_postdate.Text))
			{
				strErr+="banner_postdate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int banner_id=int.Parse(this.lblbanner_id.Text);
			string banner_title=this.txtbanner_title.Text;
			string banner_abstract=this.txtbanner_abstract.Text;
			string banner_link=this.txtbanner_link.Text;
			string banner_img=this.txtbanner_img.Text;
			int banner_state=int.Parse(this.txtbanner_state.Text);
			string banner_posterid=this.txtbanner_posterid.Text;
			DateTime banner_postdate=DateTime.Parse(this.txtbanner_postdate.Text);


			Maticsoft.Model.banner model=new Maticsoft.Model.banner();
			model.banner_id=banner_id;
			model.banner_title=banner_title;
			model.banner_abstract=banner_abstract;
			model.banner_link=banner_link;
			model.banner_img=banner_img;
			model.banner_state=banner_state;
			model.banner_posterid=banner_posterid;
			model.banner_postdate=banner_postdate;

			Maticsoft.BLL.bannerBLL bll=new Maticsoft.BLL.bannerBLL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
