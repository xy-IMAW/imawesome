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
namespace Maticsoft.Web.dept_info
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int dept_id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(dept_id);
				}
			}
		}
			
	private void ShowInfo(int dept_id)
	{
		Maticsoft.BLL.dept_infoBLL bll=new Maticsoft.BLL.dept_infoBLL();
		Maticsoft.Model.dept_info model=bll.GetModel(dept_id);
		this.lbldept_id.Text=model.dept_id.ToString();
		this.txtdept_name.Text=model.dept_name;
		this.txtdept_introduce.Text=model.dept_introduce;
		this.txtdept_minister_id.Text=model.dept_minister_id;
		this.txtdept_num.Text=model.dept_num.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtdept_name.Text.Trim().Length==0)
			{
				strErr+="dept_name不能为空！\\n";	
			}
			if(this.txtdept_introduce.Text.Trim().Length==0)
			{
				strErr+="dept_introduce不能为空！\\n";	
			}
			if(this.txtdept_minister_id.Text.Trim().Length==0)
			{
				strErr+="dept_minister_id不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtdept_num.Text))
			{
				strErr+="dept_num格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int dept_id=int.Parse(this.lbldept_id.Text);
			string dept_name=this.txtdept_name.Text;
			string dept_introduce=this.txtdept_introduce.Text;
			string dept_minister_id=this.txtdept_minister_id.Text;
			int dept_num=int.Parse(this.txtdept_num.Text);


			Maticsoft.Model.dept_info model=new Maticsoft.Model.dept_info();
			model.dept_id=dept_id;
			model.dept_name=dept_name;
			model.dept_introduce=dept_introduce;
			model.dept_minister_id=dept_minister_id;
			model.dept_num=dept_num;

			Maticsoft.BLL.dept_infoBLL bll=new Maticsoft.BLL.dept_infoBLL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
