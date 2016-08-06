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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string banner_title=this.txtbanner_title.Text;
			string banner_abstract=this.txtbanner_abstract.Text;
			string banner_link=this.txtbanner_link.Text;
			string banner_img=this.txtbanner_img.Text;
			int banner_state=int.Parse(this.txtbanner_state.Text);
			string banner_posterid=this.txtbanner_posterid.Text;
			DateTime banner_postdate=DateTime.Parse(this.txtbanner_postdate.Text);

			Maticsoft.Model.banner model=new Maticsoft.Model.banner();
			model.banner_title=banner_title;
			model.banner_abstract=banner_abstract;
			model.banner_link=banner_link;
			model.banner_img=banner_img;
			model.banner_state=banner_state;
			model.banner_posterid=banner_posterid;
			model.banner_postdate=banner_postdate;

			Maticsoft.BLL.bannerBLL bll=new Maticsoft.BLL.bannerBLL();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
