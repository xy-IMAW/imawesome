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
namespace Maticsoft.Web.user_info
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
		Maticsoft.BLL.user_infoBLL bll=new Maticsoft.BLL.user_infoBLL();
		Maticsoft.Model.user_info model=bll.GetModel(user_id);
		this.lbluser_id.Text=model.user_id;
		this.lbluser_realname.Text=model.user_realname;
		this.lbluser_stuid.Text=model.user_stuid;
		this.lbluser_school.Text=model.user_school;
		this.lbluser_major.Text=model.user_major;
		this.lbluser_sex.Text=model.user_sex;
		this.lbluser_phone.Text=model.user_phone;
		this.lbluser_email.Text=model.user_email;
		this.lbluser_qq.Text=model.user_qq;
		this.lbluser_birthday.Text=model.user_birthday.ToString();
		this.lbluser_home.Text=model.user_home;
		this.lbluser_nation.Text=model.user_nation;
		this.lbluser_politices.Text=model.user_politices;

	}


    }
}
