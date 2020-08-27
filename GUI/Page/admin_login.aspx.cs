using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BUS;

namespace GUI.Page
{
    public partial class admin_login : System.Web.UI.Page
    {
        Users user = new Users();
        Bus bus = new Bus();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            user.username = txtUsername.Text;
            user.password = txtPassword.Text;
            int index = bus.getUser(user.username, user.password);
            if (index >= 1)
            {
                Response.Write("<script>alert('Dang nhap thanh cong')</script>");
            }
            else {
                lblLogin.Text = "Tài khoản hoặc mật khẩu không chính xác";
            }
        }
    }
}