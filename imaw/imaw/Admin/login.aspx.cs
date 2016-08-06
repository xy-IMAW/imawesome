using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using IMAW.Model;
using IMAW.BLL;
using COMMON;

namespace imaw.FineUI
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            IMAW.BLL.adminBLL adminbll = new IMAW.BLL.adminBLL();
            IMAW.Model.admin admin = new IMAW.Model.admin();
            
            string admin_id = ad_id.Text.Trim();
            string admin_pwd = ad_pwd.Text.Trim();
            int admin_class = ad_class.SelectedIndex + 1;

            //检查用户是否存在
            if(adminbll.Exists(admin_id))
            {
                admin = adminbll.GetModel(admin_id);
                //检验密码是否正确
                if(admin.admin_pwd != admin_pwd)
                {
                    Alert.ShowInTop("密码错误！", MessageBoxIcon.Error);
                }
                else
                {
                    if(admin.admin_class == admin_class)
                    {
                        string admin_lastlogintime = TimeHelper.FormatDate(DateTime.Now, "1");
                        string admin_loginnum = admin.admin_loginnum + 1;
                        SessionHelper.AddObject("admin",admin);
                        Alert.ShowInTop("成功登录！");
                        Response.Redirect("admin.aspx");
                    }
                    else
                    {
                        Alert.ShowInTop("权限错误！", MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                Alert.ShowInTop("用户名错误！", MessageBoxIcon.Error);
            }
        }
    }
}