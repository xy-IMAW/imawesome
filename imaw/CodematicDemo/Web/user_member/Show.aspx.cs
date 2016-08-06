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
namespace Maticsoft.Web.user_member
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
		Maticsoft.BLL.user_memberBLL bll=new Maticsoft.BLL.user_memberBLL();
		Maticsoft.Model.user_member model=bll.GetModel();
		this.lbluser_id.Text=model.user_id;
		this.lblmember_id.Text=model.member_id;
		this.lblmember_stuid.Text=model.member_stuid;
		this.lblmember_balance.Text=model.member_balance.ToString();
		this.lblmember_level.Text=model.member_level.ToString();
		this.lblmember_activities_sn.Text=model.member_activities_sn;

	}


    }
}
