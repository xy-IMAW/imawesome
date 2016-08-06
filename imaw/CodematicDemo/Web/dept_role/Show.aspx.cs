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
namespace Maticsoft.Web.dept_role
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
					int role_id=(Convert.ToInt32(strid));
					ShowInfo(role_id);
				}
			}
		}
		
	private void ShowInfo(int role_id)
	{
		Maticsoft.BLL.dept_roleBLL bll=new Maticsoft.BLL.dept_roleBLL();
		Maticsoft.Model.dept_role model=bll.GetModel(role_id);
		this.lblrole_id.Text=model.role_id.ToString();
		this.lbldept_id.Text=model.dept_id.ToString();
		this.lblrole_introduce.Text=model.role_introduce;

	}


    }
}
