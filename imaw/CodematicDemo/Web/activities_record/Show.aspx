<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.activities_record.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		act_sn
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblact_sn" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		act_appleytime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblact_appleytime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		act_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblact_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		member_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmember_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		state
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		checker_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblchecker_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		checker_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblchecker_date" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		member_evaluate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmember_evaluate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		reply_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblreply_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		reply_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblreply_date" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




