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
namespace Maticsoft.Web.activities
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
					int act_id=(Convert.ToInt32(strid));
					ShowInfo(act_id);
				}
			}
		}
		
	private void ShowInfo(int act_id)
	{
		Maticsoft.BLL.activitiesBLL bll=new Maticsoft.BLL.activitiesBLL();
		Maticsoft.Model.activities model=bll.GetModel(act_id);
		this.lblact_id.Text=model.act_id.ToString();
		this.lblact_class.Text=model.act_class;
		this.lblact_name.Text=model.act_name;
		this.lblact_applytime.Text=model.act_applytime.ToString();
		this.lblact_applysettime.Text=model.act_applysettime.ToString();
		this.lblact_startime.Text=model.act_startime.ToString();
		this.lblact_endtime.Text=model.act_endtime.ToString();
		this.lblposter_id.Text=model.poster_id;
		this.lbldoc_id.Text=model.doc_id;
		this.lblact_abstract.Text=model.act_abstract;

	}


    }
}
