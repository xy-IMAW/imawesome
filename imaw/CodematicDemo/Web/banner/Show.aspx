<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.banner.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		banner_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbanner_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		banner_title
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbanner_title" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		banner_abstract
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbanner_abstract" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		banner_link
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbanner_link" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		banner_img
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbanner_img" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		banner_state
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbanner_state" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		banner_posterid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbanner_posterid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		banner_postdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbanner_postdate" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




