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
namespace Maticsoft.Web.activities_record
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
					string act_sn= strid;
					ShowInfo(act_sn);
				}
			}
		}
		
	private void ShowInfo(string act_sn)
	{
		Maticsoft.BLL.activities_recordBLL bll=new Maticsoft.BLL.activities_recordBLL();
		Maticsoft.Model.activities_record model=bll.GetModel(act_sn);
		this.lblact_sn.Text=model.act_sn;
		this.lblact_appleytime.Text=model.act_appleytime.ToString();
		this.lblact_id.Text=model.act_id;
		this.lblmember_id.Text=model.member_id;
		this.lblstate.Text=model.state;
		this.lblchecker_id.Text=model.checker_id;
		this.lblchecker_date.Text=model.checker_date;
		this.lblmember_evaluate.Text=model.member_evaluate;
		this.lblreply_id.Text=model.reply_id;
		this.lblreply_date.Text=model.reply_date.ToString();

	}


    }
}
