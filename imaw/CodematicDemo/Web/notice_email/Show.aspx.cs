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
namespace Maticsoft.Web.notice_email
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
					string email_sn= strid;
					ShowInfo(email_sn);
				}
			}
		}
		
	private void ShowInfo(string email_sn)
	{
		Maticsoft.BLL.notice_emailBLL bll=new Maticsoft.BLL.notice_emailBLL();
		Maticsoft.Model.notice_email model=bll.GetModel(email_sn);
		this.lblemail_sn.Text=model.email_sn;
		this.lblemail_class.Text=model.email_class;
		this.lblemail_theme.Text=model.email_theme?"是":"否";
		this.lblemail_content.Text=model.email_content.ToString();
		this.lblemail_doc_id.Text=model.email_doc_id;
		this.lblemail_postitme.Text=model.email_postitme.ToString();
		this.lblemail_settime.Text=model.email_settime.ToString();
		this.lblsender_id.Text=model.sender_id;

	}


    }
}
