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
namespace Maticsoft.Web.user_ider
{
    public partial class Show : Page
    {        
        		public string strid=""; 
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
		Maticsoft.BLL.user_iderBLL bll=new Maticsoft.BLL.user_iderBLL();
		Maticsoft.Model.user_ider model=bll.GetModel();
		this.lblider_id.Text=model.ider_id;
		this.lbldept_id.Text=model.dept_id.ToString();
		this.lblrole_id.Text=model.role_id.ToString();
		this.lblrole_starttime.Text=model.role_starttime.ToString();
		this.lblrole_endtime.Text=model.role_endtime.ToString();
		this.lblider_balance.Text=model.ider_balance.ToString();

	}


    }
}
