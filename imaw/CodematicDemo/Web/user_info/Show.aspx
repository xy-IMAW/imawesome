<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.user_info.Show" Title="显示页" %>
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
		user_realname
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_realname" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_stuid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_stuid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_school
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_school" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_major
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_major" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_sex
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_sex" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_phone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_phone" runat="server"></asp:Label>
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
		user_qq
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_qq" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_birthday
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_birthday" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_home
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_home" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_nation
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_nation" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_politices
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluser_politices" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




