﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Maticsoft.Web.apply_ider.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		apply_sn
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtapply_sn" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		user_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtuser_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		password
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpassword" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		firstChoice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfirstChoice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		secondChoice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsecondChoice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		adjusted
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkadjusted" Text="adjusted" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		apply_phote
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtapply_phote" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		apply_introduce
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtapply_introduce" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		apply_hobby
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtapply_hobby" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		apply_advantage
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtapply_advantage" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		apply_workplan
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtapply_workplan" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		apply_time
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtapply_time" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		apply_state
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtapply_state" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		apply_remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtapply_remark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
