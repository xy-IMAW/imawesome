<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.news.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		news_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnews_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		news_createtime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnews_createtime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		news_posterid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnews_posterid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		news_title
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnews_title" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		news_class
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnews_class" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		news_abstract
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnews_abstract" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		news_content
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnews_content" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		news_readnum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnews_readnum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		news_state
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnews_state" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




