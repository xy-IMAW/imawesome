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
namespace Maticsoft.Web.apply_ider
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
					string apply_sn= strid;
					ShowInfo(apply_sn);
				}
			}
		}
		
	private void ShowInfo(string apply_sn)
	{
		Maticsoft.BLL.apply_iderBLL bll=new Maticsoft.BLL.apply_iderBLL();
		Maticsoft.Model.apply_ider model=bll.GetModel(apply_sn);
		this.lblapply_sn.Text=model.apply_sn;
		this.lbluser_id.Text=model.user_id;
		this.lblpassword.Text=model.password;
		this.lblfirstChoice.Text=model.firstChoice;
		this.lblsecondChoice.Text=model.secondChoice;
		this.lbladjusted.Text=model.adjusted?"是":"否";
		this.lblapply_phote.Text=model.apply_phote;
		this.lblapply_introduce.Text=model.apply_introduce;
		this.lblapply_hobby.Text=model.apply_hobby;
		this.lblapply_advantage.Text=model.apply_advantage;
		this.lblapply_workplan.Text=model.apply_workplan;
		this.lblapply_time.Text=model.apply_time.ToString();
		this.lblapply_state.Text=model.apply_state.ToString();
		this.lblapply_remark.Text=model.apply_remark;

	}


    }
}
