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
namespace Maticsoft.Web.user_account
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					string user_id= strid;
					ShowInfo(user_id);
				}
			}
		}
		
	private void ShowInfo(string user_id)
	{
		Maticsoft.BLL.user_accountBLL bll=new Maticsoft.BLL.user_accountBLL();
		Maticsoft.Model.user_account model=bll.GetModel(user_id);
		this.lbluser_id.Text=model.user_id;
		this.lbluser_pwd.Text=model.user_pwd;
		this.lbluser_nickname.Text=model.user_nickname;
		this.lbluser_registerdate.Text=model.user_registerdate.ToString();
		this.lbluser_lastlogindate.Text=model.user_lastlogindate.ToString();
		this.lbluser_loginnum.Text=model.user_loginnum.ToString();
		this.lbluser_email.Text=model.user_email;
		this.lbluser_photo.Text=model.user_photo;
		this.lbluser_pwd_que.Text=model.user_pwd_que;
		this.lbluser_pwd_ans.Text=model.user_pwd_ans;
		this.lbluser_class.Text=model.user_class.ToString();

	}


    }
}
