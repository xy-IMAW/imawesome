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
namespace Maticsoft.Web.dept_role
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int role_id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(role_id);
				}
			}
		}
			
	private void ShowInfo(int role_id)
	{
		Maticsoft.BLL.dept_roleBLL bll=new Maticsoft.BLL.dept_roleBLL();
		Maticsoft.Model.dept_role model=bll.GetModel(role_id);
		this.lblrole_id.Text=model.role_id.ToString();
		this.txtdept_id.Text=model.dept_id.ToString();
		this.txtrole_introduce.Text=model.role_introduce;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtdept_id.Text))
			{
				strErr+="dept_id格式错误！\\n";	
			}
			if(this.txtrole_introduce.Text.Trim().Length==0)
			{
				strErr+="role_introduce不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int role_id=int.Parse(this.lblrole_id.Text);
			int dept_id=int.Parse(this.txtdept_id.Text);
			string role_introduce=this.txtrole_introduce.Text;


			Maticsoft.Model.dept_role model=new Maticsoft.Model.dept_role();
			model.role_id=role_id;
			model.dept_id=dept_id;
			model.role_introduce=role_introduce;

			Maticsoft.BLL.dept_roleBLL bll=new Maticsoft.BLL.dept_roleBLL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
