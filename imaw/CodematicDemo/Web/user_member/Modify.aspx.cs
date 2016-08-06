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
namespace Maticsoft.Web.user_member
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
		Maticsoft.BLL.user_memberBLL bll=new Maticsoft.BLL.user_memberBLL();
		Maticsoft.Model.user_member model=bll.GetModel();
		this.txtuser_id.Text=model.user_id;
		this.txtmember_id.Text=model.member_id;
		this.txtmember_stuid.Text=model.member_stuid;
		this.txtmember_balance.Text=model.member_balance.ToString();
		this.txtmember_level.Text=model.member_level.ToString();
		this.txtmember_activities_sn.Text=model.member_activities_sn;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtuser_id.Text.Trim().Length==0)
			{
				strErr+="user_id不能为空！\\n";	
			}
			if(this.txtmember_id.Text.Trim().Length==0)
			{
				strErr+="member_id不能为空！\\n";	
			}
			if(this.txtmember_stuid.Text.Trim().Length==0)
			{
				strErr+="member_stuid不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtmember_balance.Text))
			{
				strErr+="member_balance格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtmember_level.Text))
			{
				strErr+="member_level格式错误！\\n";	
			}
			if(this.txtmember_activities_sn.Text.Trim().Length==0)
			{
				strErr+="member_activities_sn不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string user_id=this.txtuser_id.Text;
			string member_id=this.txtmember_id.Text;
			string member_stuid=this.txtmember_stuid.Text;
			int member_balance=int.Parse(this.txtmember_balance.Text);
			int member_level=int.Parse(this.txtmember_level.Text);
			string member_activities_sn=this.txtmember_activities_sn.Text;


			Maticsoft.Model.user_member model=new Maticsoft.Model.user_member();
			model.user_id=user_id;
			model.member_id=member_id;
			model.member_stuid=member_stuid;
			model.member_balance=member_balance;
			model.member_level=member_level;
			model.member_activities_sn=member_activities_sn;

			Maticsoft.BLL.user_memberBLL bll=new Maticsoft.BLL.user_memberBLL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
