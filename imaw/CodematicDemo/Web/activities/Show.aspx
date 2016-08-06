<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.activities.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		act_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblact_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		act_class
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblact_class" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		act_name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblact_name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		act_applytime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblact_applytime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		act_applysettime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblact_applysettime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		act_startime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblact_startime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		act_endtime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblact_endtime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		poster_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblposter_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		doc_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldoc_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		act_abstract
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblact_abstract" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




