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
namespace Maticsoft.Web.apply_member
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
		Maticsoft.BLL.apply_memberBLL bll=new Maticsoft.BLL.apply_memberBLL();
		Maticsoft.Model.apply_member model=bll.GetModel();
		this.lbluser_id.Text=model.user_id;
		this.lblapplydate.Text=model.applydate;
		this.lblchecker_id.Text=model.checker_id;
		this.lblcheckdate.Text=model.checkdate;

	}


    }
}
