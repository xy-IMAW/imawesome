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
namespace Maticsoft.Web.user_info
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string user_id= Request.Params["id"];
					ShowInfo(user_id);
				}
			}
		}
			
	private void ShowInfo(string user_id)
	{
		Maticsoft.BLL.user_infoBLL bll=new Maticsoft.BLL.user_infoBLL();
		Maticsoft.Model.user_info model=bll.GetModel(user_id);
		this.lbluser_id.Text=model.user_id;
		this.txtuser_realname.Text=model.user_realname;
		this.txtuser_stuid.Text=model.user_stuid;
		this.txtuser_school.Text=model.user_school;
		this.txtuser_major.Text=model.user_major;
		this.txtuser_sex.Text=model.user_sex;
		this.txtuser_phone.Text=model.user_phone;
		this.txtuser_email.Text=model.user_email;
		this.txtuser_qq.Text=model.user_qq;
		this.txtuser_birthday.Text=model.user_birthday.ToString();
		this.txtuser_home.Text=model.user_home;
		this.txtuser_nation.Text=model.user_nation;
		this.txtuser_politices.Text=model.user_politices;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtuser_realname.Text.Trim().Length==0)
			{
				strErr+="user_realname不能为空！\\n";	
			}
			if(this.txtuser_stuid.Text.Trim().Length==0)
			{
				strErr+="user_stuid不能为空！\\n";	
			}
			if(this.txtuser_school.Text.Trim().Length==0)
			{
				strErr+="user_school不能为空！\\n";	
			}
			if(this.txtuser_major.Text.Trim().Length==0)
			{
				strErr+="user_major不能为空！\\n";	
			}
			if(this.txtuser_sex.Text.Trim().Length==0)
			{
				strErr+="user_sex不能为空！\\n";	
			}
			if(this.txtuser_phone.Text.Trim().Length==0)
			{
				strErr+="user_phone不能为空！\\n";	
			}
			if(this.txtuser_email.Text.Trim().Length==0)
			{
				strErr+="user_email不能为空！\\n";	
			}
			if(this.txtuser_qq.Text.Trim().Length==0)
			{
				strErr+="user_qq不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtuser_birthday.Text))
			{
				strErr+="user_birthday格式错误！\\n";	
			}
			if(this.txtuser_home.Text.Trim().Length==0)
			{
				strErr+="user_home不能为空！\\n";	
			}
			if(this.txtuser_nation.Text.Trim().Length==0)
			{
				strErr+="user_nation不能为空！\\n";	
			}
			if(this.txtuser_politices.Text.Trim().Length==0)
			{
				strErr+="user_politices不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string user_id=this.lbluser_id.Text;
			string user_realname=this.txtuser_realname.Text;
			string user_stuid=this.txtuser_stuid.Text;
			string user_school=this.txtuser_school.Text;
			string user_major=this.txtuser_major.Text;
			string user_sex=this.txtuser_sex.Text;
			string user_phone=this.txtuser_phone.Text;
			string user_email=this.txtuser_email.Text;
			string user_qq=this.txtuser_qq.Text;
			DateTime user_birthday=DateTime.Parse(this.txtuser_birthday.Text);
			string user_home=this.txtuser_home.Text;
			string user_nation=this.txtuser_nation.Text;
			string user_politices=this.txtuser_politices.Text;


			Maticsoft.Model.user_info model=new Maticsoft.Model.user_info();
			model.user_id=user_id;
			model.user_realname=user_realname;
			model.user_stuid=user_stuid;
			model.user_school=user_school;
			model.user_major=user_major;
			model.user_sex=user_sex;
			model.user_phone=user_phone;
			model.user_email=user_email;
			model.user_qq=user_qq;
			model.user_birthday=user_birthday;
			model.user_home=user_home;
			model.user_nation=user_nation;
			model.user_politices=user_politices;

			Maticsoft.BLL.user_infoBLL bll=new Maticsoft.BLL.user_infoBLL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
