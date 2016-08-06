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
namespace Maticsoft.Web.user_account
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
		Maticsoft.BLL.user_accountBLL bll=new Maticsoft.BLL.user_accountBLL();
		Maticsoft.Model.user_account model=bll.GetModel(user_id);
		this.lbluser_id.Text=model.user_id;
		this.txtuser_pwd.Text=model.user_pwd;
		this.txtuser_nickname.Text=model.user_nickname;
		this.txtuser_registerdate.Text=model.user_registerdate.ToString();
		this.txtuser_lastlogindate.Text=model.user_lastlogindate.ToString();
		this.txtuser_loginnum.Text=model.user_loginnum.ToString();
		this.txtuser_email.Text=model.user_email;
		this.txtuser_photo.Text=model.user_photo;
		this.txtuser_pwd_que.Text=model.user_pwd_que;
		this.txtuser_pwd_ans.Text=model.user_pwd_ans;
		this.txtuser_class.Text=model.user_class.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtuser_pwd.Text.Trim().Length==0)
			{
				strErr+="user_pwd不能为空！\\n";	
			}
			if(this.txtuser_nickname.Text.Trim().Length==0)
			{
				strErr+="user_nickname不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtuser_registerdate.Text))
			{
				strErr+="user_registerdate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtuser_lastlogindate.Text))
			{
				strErr+="user_lastlogindate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtuser_loginnum.Text))
			{
				strErr+="user_loginnum格式错误！\\n";	
			}
			if(this.txtuser_email.Text.Trim().Length==0)
			{
				strErr+="user_email不能为空！\\n";	
			}
			if(this.txtuser_photo.Text.Trim().Length==0)
			{
				strErr+="user_photo不能为空！\\n";	
			}
			if(this.txtuser_pwd_que.Text.Trim().Length==0)
			{
				strErr+="user_pwd_que不能为空！\\n";	
			}
			if(this.txtuser_pwd_ans.Text.Trim().Length==0)
			{
				strErr+="user_pwd_ans不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtuser_class.Text))
			{
				strErr+="user_class格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string user_id=this.lbluser_id.Text;
			string user_pwd=this.txtuser_pwd.Text;
			string user_nickname=this.txtuser_nickname.Text;
			DateTime user_registerdate=DateTime.Parse(this.txtuser_registerdate.Text);
			DateTime user_lastlogindate=DateTime.Parse(this.txtuser_lastlogindate.Text);
			int user_loginnum=int.Parse(this.txtuser_loginnum.Text);
			string user_email=this.txtuser_email.Text;
			string user_photo=this.txtuser_photo.Text;
			string user_pwd_que=this.txtuser_pwd_que.Text;
			string user_pwd_ans=this.txtuser_pwd_ans.Text;
			int user_class=int.Parse(this.txtuser_class.Text);


			Maticsoft.Model.user_account model=new Maticsoft.Model.user_account();
			model.user_id=user_id;
			model.user_pwd=user_pwd;
			model.user_nickname=user_nickname;
			model.user_registerdate=user_registerdate;
			model.user_lastlogindate=user_lastlogindate;
			model.user_loginnum=user_loginnum;
			model.user_email=user_email;
			model.user_photo=user_photo;
			model.user_pwd_que=user_pwd_que;
			model.user_pwd_ans=user_pwd_ans;
			model.user_class=user_class;

			Maticsoft.BLL.user_accountBLL bll=new Maticsoft.BLL.user_accountBLL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
