<%@ Page Title="activities_record" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.activities_record.List" %>
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
                    BorderWidth="1px" DataKeyNames="act_sn" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="act_sn" HeaderText="act_sn" SortExpression="act_sn" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="act_appleytime" HeaderText="act_appleytime" SortExpression="act_appleytime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="act_id" HeaderText="act_id" SortExpression="act_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="member_id" HeaderText="member_id" SortExpression="member_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="state" HeaderText="state" SortExpression="state" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="checker_id" HeaderText="checker_id" SortExpression="checker_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="checker_date" HeaderText="checker_date" SortExpression="checker_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="member_evaluate" HeaderText="member_evaluate" SortExpression="member_evaluate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="reply_id" HeaderText="reply_id" SortExpression="reply_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="reply_date" HeaderText="reply_date" SortExpression="reply_date" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="act_sn" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="act_sn" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
