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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string act_sn= Request.Params["id"];
					ShowInfo(act_sn);
				}
			}
		}
			
	private void ShowInfo(string act_sn)
	{
		Maticsoft.BLL.activities_recordBLL bll=new Maticsoft.BLL.activities_recordBLL();
		Maticsoft.Model.activities_record model=bll.GetModel(act_sn);
		this.lblact_sn.Text=model.act_sn;
		this.txtact_appleytime.Text=model.act_appleytime.ToString();
		this.txtact_id.Text=model.act_id;
		this.txtmember_id.Text=model.member_id;
		this.txtstate.Text=model.state;
		this.txtchecker_id.Text=model.checker_id;
		this.txtchecker_date.Text=model.checker_date;
		this.txtmember_evaluate.Text=model.member_evaluate;
		this.txtreply_id.Text=model.reply_id;
		this.txtreply_date.Text=model.reply_date.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
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
			string act_sn=this.lblact_sn.Text;
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
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
