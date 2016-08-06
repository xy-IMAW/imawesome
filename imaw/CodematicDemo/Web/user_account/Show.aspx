<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.user_account.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		user_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_pwd
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_pwd" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_nickname
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_nickname" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_registerdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_registerdate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_lastlogindate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_lastlogindate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_loginnum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_loginnum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_email
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_email" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_photo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_photo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_pwd_que
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_pwd_que" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_pwd_ans
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_pwd_ans" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_class
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_class" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




