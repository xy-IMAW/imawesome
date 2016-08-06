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
namespace Maticsoft.Web.admin
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string admin_id= Request.Params["id"];
					ShowInfo(admin_id);
				}
			}
		}
			
	private void ShowInfo(string admin_id)
	{
		Maticsoft.BLL.adminBLL bll=new Maticsoft.BLL.adminBLL();
		Maticsoft.Model.admin model=bll.GetModel(admin_id);
		this.lbladmin_id.Text=model.admin_id;
		this.txtadmin_pwd.Text=model.admin_pwd;
		this.txtadmin_class.Text=model.admin_class.ToString();
		this.txtadmin_lastlogintime.Text=model.admin_lastlogintime;
		this.txtadmin_loginnum.Text=model.admin_loginnum;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtadmin_pwd.Text.Trim().Length==0)
			{
				strErr+="admin_pwd不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtadmin_class.Text))
			{
				strErr+="admin_class格式错误！\\n";	
			}
			if(this.txtadmin_lastlogintime.Text.Trim().Length==0)
			{
				strErr+="admin_lastlogintime不能为空！\\n";	
			}
			if(this.txtadmin_loginnum.Text.Trim().Length==0)
			{
				strErr+="admin_loginnum不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string admin_id=this.lbladmin_id.Text;
			string admin_pwd=this.txtadmin_pwd.Text;
			int admin_class=int.Parse(this.txtadmin_class.Text);
			string admin_lastlogintime=this.txtadmin_lastlogintime.Text;
			string admin_loginnum=this.txtadmin_loginnum.Text;


			Maticsoft.Model.admin model=new Maticsoft.Model.admin();
			model.admin_id=admin_id;
			model.admin_pwd=admin_pwd;
			model.admin_class=admin_class;
			model.admin_lastlogintime=admin_lastlogintime;
			model.admin_loginnum=admin_loginnum;

			Maticsoft.BLL.adminBLL bll=new Maticsoft.BLL.adminBLL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
