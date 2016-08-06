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
namespace Maticsoft.Web.apply_member
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtuser_id.Text.Trim().Length==0)
			{
				strErr+="user_id不能为空！\\n";	
			}
			if(this.txtapplydate.Text.Trim().Length==0)
			{
				strErr+="applydate不能为空！\\n";	
			}
			if(this.txtchecker_id.Text.Trim().Length==0)
			{
				strErr+="checker_id不能为空！\\n";	
			}
			if(this.txtcheckdate.Text.Trim().Length==0)
			{
				strErr+="checkdate不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string user_id=this.txtuser_id.Text;
			string applydate=this.txtapplydate.Text;
			string checker_id=this.txtchecker_id.Text;
			string checkdate=this.txtcheckdate.Text;

			Maticsoft.Model.apply_member model=new Maticsoft.Model.apply_member();
			model.user_id=user_id;
			model.applydate=applydate;
			model.checker_id=checker_id;
			model.checkdate=checkdate;

			Maticsoft.BLL.apply_memberBLL bll=new Maticsoft.BLL.apply_memberBLL();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
