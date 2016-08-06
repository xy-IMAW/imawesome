<%@ Page Title="user_account" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.user_account.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="user_id" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="user_id" HeaderText="user_id" SortExpression="user_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="user_pwd" HeaderText="user_pwd" SortExpression="user_pwd" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="user_nickname" HeaderText="user_nickname" SortExpression="user_nickname" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="user_registerdate" HeaderText="user_registerdate" SortExpression="user_registerdate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="user_lastlogindate" HeaderText="user_lastlogindate" SortExpression="user_lastlogindate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="user_loginnum" HeaderText="user_loginnum" SortExpression="user_loginnum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="user_email" HeaderText="user_email" SortExpression="user_email" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="user_photo" HeaderText="user_photo" SortExpression="user_photo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="user_pwd_que" HeaderText="user_pwd_que" SortExpression="user_pwd_que" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="user_pwd_ans" HeaderText="user_pwd_ans" SortExpression="user_pwd_ans" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="user_class" HeaderText="user_class" SortExpression="user_class" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="user_id" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="user_id" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
