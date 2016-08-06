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
namespace Maticsoft.Web.admin
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
					string admin_id= strid;
					ShowInfo(admin_id);
				}
			}
		}
		
	private void ShowInfo(string admin_id)
	{
		Maticsoft.BLL.adminBLL bll=new Maticsoft.BLL.adminBLL();
		Maticsoft.Model.admin model=bll.GetModel(admin_id);
		this.lbladmin_id.Text=model.admin_id;
		this.lbladmin_pwd.Text=model.admin_pwd;
		this.lbladmin_class.Text=model.admin_class.ToString();
		this.lbladmin_lastlogintime.Text=model.admin_lastlogintime;
		this.lbladmin_loginnum.Text=model.admin_loginnum;

	}


    }
}
