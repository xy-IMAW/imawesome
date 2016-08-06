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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.activities
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int act_id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(act_id);
				}
			}
		}
			
	private void ShowInfo(int act_id)
	{
		Maticsoft.BLL.activitiesBLL bll=new Maticsoft.BLL.activitiesBLL();
		Maticsoft.Model.activities model=bll.GetModel(act_id);
		this.lblact_id.Text=model.act_id.ToString();
		this.txtact_class.Text=model.act_class;
		this.txtact_name.Text=model.act_name;
		this.txtact_applytime.Text=model.act_applytime.ToString();
		this.txtact_applysettime.Text=model.act_applysettime.ToString();
		this.txtact_startime.Text=model.act_startime.ToString();
		this.txtact_endtime.Text=model.act_endtime.ToString();
		this.txtposter_id.Text=model.poster_id;
		this.txtdoc_id.Text=model.doc_id;
		this.txtact_abstract.Text=model.act_abstract;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtact_class.Text.Trim().Length==0)
			{
				strErr+="act_class不能为空！\\n";	
			}
			if(this.txtact_name.Text.Trim().Length==0)
			{
				strErr+="act_name不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtact_applytime.Text))
			{
				strErr+="act_applytime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtact_applysettime.Text))
			{
				strErr+="act_applysettime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtact_startime.Text))
			{
				strErr+="act_startime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtact_endtime.Text))
			{
				strErr+="act_endtime格式错误！\\n";	
			}
			if(this.txtposter_id.Text.Trim().Length==0)
			{
				strErr+="poster_id不能为空！\\n";	
			}
			if(this.txtdoc_id.Text.Trim().Length==0)
			{
				strErr+="doc_id不能为空！\\n";	
			}
			if(this.txtact_abstract.Text.Trim().Length==0)
			{
				strErr+="act_abstract不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int act_id=int.Parse(this.lblact_id.Text);
			string act_class=this.txtact_class.Text;
			string act_name=this.txtact_name.Text;
			DateTime act_applytime=DateTime.Parse(this.txtact_applytime.Text);
			DateTime act_applysettime=DateTime.Parse(this.txtact_applysettime.Text);
			DateTime act_startime=DateTime.Parse(this.txtact_startime.Text);
			DateTime act_endtime=DateTime.Parse(this.txtact_endtime.Text);
			string poster_id=this.txtposter_id.Text;
			string doc_id=this.txtdoc_id.Text;
			string act_abstract=this.txtact_abstract.Text;


			Maticsoft.Model.activities model=new Maticsoft.Model.activities();
			model.act_id=act_id;
			model.act_class=act_class;
			model.act_name=act_name;
			model.act_applytime=act_applytime;
			model.act_applysettime=act_applysettime;
			model.act_startime=act_startime;
			model.act_endtime=act_endtime;
			model.poster_id=poster_id;
			model.doc_id=doc_id;
			model.act_abstract=act_abstract;

			Maticsoft.BLL.activitiesBLL bll=new Maticsoft.BLL.activitiesBLL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
