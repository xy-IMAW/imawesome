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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
			
	private void ShowInfo()
	{
		Maticsoft.BLL.apply_memberBLL bll=new Maticsoft.BLL.apply_memberBLL();
		Maticsoft.Model.apply_member model=bll.GetModel();
		this.txtuser_id.Text=model.user_id;
		this.txtapplydate.Text=model.applydate;
		this.txtchecker_id.Text=model.checker_id;
		this.txtcheckdate.Text=model.checkdate;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
