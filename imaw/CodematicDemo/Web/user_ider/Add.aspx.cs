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
namespace Maticsoft.Web.user_ider
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtider_id.Text.Trim().Length==0)
			{
				strErr+="ider_id不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtdept_id.Text))
			{
				strErr+="dept_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtrole_id.Text))
			{
				strErr+="role_id格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtrole_starttime.Text))
			{
				strErr+="role_starttime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtrole_endtime.Text))
			{
				strErr+="role_endtime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtider_balance.Text))
			{
				strErr+="ider_balance格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ider_id=this.txtider_id.Text;
			int dept_id=int.Parse(this.txtdept_id.Text);
			int role_id=int.Parse(this.txtrole_id.Text);
			DateTime role_starttime=DateTime.Parse(this.txtrole_starttime.Text);
			DateTime role_endtime=DateTime.Parse(this.txtrole_endtime.Text);
			int ider_balance=int.Parse(this.txtider_balance.Text);

			Maticsoft.Model.user_ider model=new Maticsoft.Model.user_ider();
			model.ider_id=ider_id;
			model.dept_id=dept_id;
			model.role_id=role_id;
			model.role_starttime=role_starttime;
			model.role_endtime=role_endtime;
			model.ider_balance=ider_balance;

			Maticsoft.BLL.user_iderBLL bll=new Maticsoft.BLL.user_iderBLL();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
