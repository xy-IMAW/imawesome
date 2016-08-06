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
namespace Maticsoft.Web.dept_info
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
					int dept_id=(Convert.ToInt32(strid));
					ShowInfo(dept_id);
				}
			}
		}
		
	private void ShowInfo(int dept_id)
	{
		Maticsoft.BLL.dept_infoBLL bll=new Maticsoft.BLL.dept_infoBLL();
		Maticsoft.Model.dept_info model=bll.GetModel(dept_id);
		this.lbldept_id.Text=model.dept_id.ToString();
		this.lbldept_name.Text=model.dept_name;
		this.lbldept_introduce.Text=model.dept_introduce;
		this.lbldept_minister_id.Text=model.dept_minister_id;
		this.lbldept_num.Text=model.dept_num.ToString();

	}


    }
}
