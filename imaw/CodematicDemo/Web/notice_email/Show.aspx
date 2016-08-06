<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.notice_email.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		email_sn
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblemail_sn" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		email_class
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblemail_class" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		email_theme
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblemail_theme" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		email_content
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblemail_content" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		email_doc_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblemail_doc_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		email_postitme
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblemail_postitme" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		email_settime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblemail_settime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sender_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsender_id" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




