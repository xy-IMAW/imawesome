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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtadmin_id.Text.Trim().Length==0)
			{
				strErr+="admin_id不能为空！\\n";	
			}
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
			string admin_id=this.txtadmin_id.Text;
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
