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
namespace Maticsoft.Web.apply_ider
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtapply_sn.Text.Trim().Length==0)
			{
				strErr+="apply_sn不能为空！\\n";	
			}
			if(this.txtuser_id.Text.Trim().Length==0)
			{
				strErr+="user_id不能为空！\\n";	
			}
			if(this.txtpassword.Text.Trim().Length==0)
			{
				strErr+="password不能为空！\\n";	
			}
			if(this.txtfirstChoice.Text.Trim().Length==0)
			{
				strErr+="firstChoice不能为空！\\n";	
			}
			if(this.txtsecondChoice.Text.Trim().Length==0)
			{
				strErr+="secondChoice不能为空！\\n";	
			}
			if(this.txtapply_phote.Text.Trim().Length==0)
			{
				strErr+="apply_phote不能为空！\\n";	
			}
			if(this.txtapply_introduce.Text.Trim().Length==0)
			{
				strErr+="apply_introduce不能为空！\\n";	
			}
			if(this.txtapply_hobby.Text.Trim().Length==0)
			{
				strErr+="apply_hobby不能为空！\\n";	
			}
			if(this.txtapply_advantage.Text.Trim().Length==0)
			{
				strErr+="apply_advantage不能为空！\\n";	
			}
			if(this.txtapply_workplan.Text.Trim().Length==0)
			{
				strErr+="apply_workplan不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtapply_time.Text))
			{
				strErr+="apply_time格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtapply_state.Text))
			{
				strErr+="apply_state格式错误！\\n";	
			}
			if(this.txtapply_remark.Text.Trim().Length==0)
			{
				strErr+="apply_remark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string apply_sn=this.txtapply_sn.Text;
			string user_id=this.txtuser_id.Text;
			string password=this.txtpassword.Text;
			string firstChoice=this.txtfirstChoice.Text;
			string secondChoice=this.txtsecondChoice.Text;
			bool adjusted=this.chkadjusted.Checked;
			string apply_phote=this.txtapply_phote.Text;
			string apply_introduce=this.txtapply_introduce.Text;
			string apply_hobby=this.txtapply_hobby.Text;
			string apply_advantage=this.txtapply_advantage.Text;
			string apply_workplan=this.txtapply_workplan.Text;
			DateTime apply_time=DateTime.Parse(this.txtapply_time.Text);
			DateTime apply_state=DateTime.Parse(this.txtapply_state.Text);
			string apply_remark=this.txtapply_remark.Text;

			Maticsoft.Model.apply_ider model=new Maticsoft.Model.apply_ider();
			model.apply_sn=apply_sn;
			model.user_id=user_id;
			model.password=password;
			model.firstChoice=firstChoice;
			model.secondChoice=secondChoice;
			model.adjusted=adjusted;
			model.apply_phote=apply_phote;
			model.apply_introduce=apply_introduce;
			model.apply_hobby=apply_hobby;
			model.apply_advantage=apply_advantage;
			model.apply_workplan=apply_workplan;
			model.apply_time=apply_time;
			model.apply_state=apply_state;
			model.apply_remark=apply_remark;

			Maticsoft.BLL.apply_iderBLL bll=new Maticsoft.BLL.apply_iderBLL();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
