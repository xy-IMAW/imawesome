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
namespace Maticsoft.Web.banner
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
					int banner_id=(Convert.ToInt32(strid));
					ShowInfo(banner_id);
				}
			}
		}
		
	private void ShowInfo(int banner_id)
	{
		Maticsoft.BLL.bannerBLL bll=new Maticsoft.BLL.bannerBLL();
		Maticsoft.Model.banner model=bll.GetModel(banner_id);
		this.lblbanner_id.Text=model.banner_id.ToString();
		this.lblbanner_title.Text=model.banner_title;
		this.lblbanner_abstract.Text=model.banner_abstract;
		this.lblbanner_link.Text=model.banner_link;
		this.lblbanner_img.Text=model.banner_img;
		this.lblbanner_state.Text=model.banner_state.ToString();
		this.lblbanner_posterid.Text=model.banner_posterid;
		this.lblbanner_postdate.Text=model.banner_postdate.ToString();

	}


    }
}
