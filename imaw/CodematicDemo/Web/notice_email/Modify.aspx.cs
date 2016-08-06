﻿using System;
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
namespace Maticsoft.Web.notice_email
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string email_sn= Request.Params["id"];
					ShowInfo(email_sn);
				}
			}
		}
			
	private void ShowInfo(string email_sn)
	{
		Maticsoft.BLL.notice_emailBLL bll=new Maticsoft.BLL.notice_emailBLL();
		Maticsoft.Model.notice_email model=bll.GetModel(email_sn);
		this.lblemail_sn.Text=model.email_sn;
		this.txtemail_class.Text=model.email_class;
		this.chkemail_theme.Checked=model.email_theme;
		this.txtemail_content.Text=model.email_content.ToString();
		this.txtemail_doc_id.Text=model.email_doc_id;
		this.txtemail_postitme.Text=model.email_postitme.ToString();
		this.txtemail_settime.Text=model.email_settime.ToString();
		this.txtsender_id.Text=model.sender_id;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtemail_class.Text.Trim().Length==0)
			{
				strErr+="email_class不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtemail_content.Text))
			{
				strErr+="email_content格式错误！\\n";	
			}
			if(this.txtemail_doc_id.Text.Trim().Length==0)
			{
				strErr+="email_doc_id不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtemail_postitme.Text))
			{
				strErr+="email_postitme格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtemail_settime.Text))
			{
				strErr+="email_settime格式错误！\\n";	
			}
			if(this.txtsender_id.Text.Trim().Length==0)
			{
				strErr+="sender_id不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string email_sn=this.lblemail_sn.Text;
			string email_class=this.txtemail_class.Text;
			bool email_theme=this.chkemail_theme.Checked;
			DateTime email_content=DateTime.Parse(this.txtemail_content.Text);
			string email_doc_id=this.txtemail_doc_id.Text;
			DateTime email_postitme=DateTime.Parse(this.txtemail_postitme.Text);
			DateTime email_settime=DateTime.Parse(this.txtemail_settime.Text);
			string sender_id=this.txtsender_id.Text;


			Maticsoft.Model.notice_email model=new Maticsoft.Model.notice_email();
			model.email_sn=email_sn;
			model.email_class=email_class;
			model.email_theme=email_theme;
			model.email_content=email_content;
			model.email_doc_id=email_doc_id;
			model.email_postitme=email_postitme;
			model.email_settime=email_settime;
			model.sender_id=sender_id;

			Maticsoft.BLL.notice_emailBLL bll=new Maticsoft.BLL.notice_emailBLL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
