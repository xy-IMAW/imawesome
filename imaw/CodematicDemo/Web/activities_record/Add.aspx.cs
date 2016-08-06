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
namespace Maticsoft.Web.activities_record
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtact_sn.Text.Trim().Length==0)
			{
				strErr+="act_sn不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtact_appleytime.Text))
			{
				strErr+="act_appleytime格式错误！\\n";	
			}
			if(this.txtact_id.Text.Trim().Length==0)
			{
				strErr+="act_id不能为空！\\n";	
			}
			if(this.txtmember_id.Text.Trim().Length==0)
			{
				strErr+="member_id不能为空！\\n";	
			}
			if(this.txtstate.Text.Trim().Length==0)
			{
				strErr+="state不能为空！\\n";	
			}
			if(this.txtchecker_id.Text.Trim().Length==0)
			{
				strErr+="checker_id不能为空！\\n";	
			}
			if(this.txtchecker_date.Text.Trim().Length==0)
			{
				strErr+="checker_date不能为空！\\n";	
			}
			if(this.txtmember_evaluate.Text.Trim().Length==0)
			{
				strErr+="member_evaluate不能为空！\\n";	
			}
			if(this.txtreply_id.Text.Trim().Length==0)
			{
				strErr+="reply_id不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtreply_date.Text))
			{
				strErr+="reply_date格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string act_sn=this.txtact_sn.Text;
			DateTime act_appleytime=DateTime.Parse(this.txtact_appleytime.Text);
			string act_id=this.txtact_id.Text;
			string member_id=this.txtmember_id.Text;
			string state=this.txtstate.Text;
			string checker_id=this.txtchecker_id.Text;
			string checker_date=this.txtchecker_date.Text;
			string member_evaluate=this.txtmember_evaluate.Text;
			string reply_id=this.txtreply_id.Text;
			DateTime reply_date=DateTime.Parse(this.txtreply_date.Text);

			Maticsoft.Model.activities_record model=new Maticsoft.Model.activities_record();
			model.act_sn=act_sn;
			model.act_appleytime=act_appleytime;
			model.act_id=act_id;
			model.member_id=member_id;
			model.state=state;
			model.checker_id=checker_id;
			model.checker_date=checker_date;
			model.member_evaluate=member_evaluate;
			model.reply_id=reply_id;
			model.reply_date=reply_date;

			Maticsoft.BLL.activities_recordBLL bll=new Maticsoft.BLL.activities_recordBLL();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
