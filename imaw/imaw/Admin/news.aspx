<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/SingleGrid.Master" AutoEventWireup="true" CodeBehind="news.aspx.cs" Inherits="imaw.Admin.news" %>

<%@ MasterType VirtualPath="~/Admin/SingleGrid.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainCPH" runat="server">
    <f:Form ID="Form6" ShowBorder="false" ShowHeader="false" runat="server">
        <Rows>
            <f:FormRow>
                <Items>
                    <f:TwinTriggerBox runat="server" EmptyText="在用户名中搜索" ShowLabel="false" ID="ttbSearch"
                        ShowTrigger1="false" OnTrigger1Click="ttbSearch_Trigger1Click" OnTrigger2Click="ttbSearch_Trigger2Click"
                        Trigger1Icon="Clear" Trigger2Icon="Search">
                    </f:TwinTriggerBox>
                    <f:DropDownList ID="DropDownList1" ShowLabel="false" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
                        runat="server">
                        <f:ListItem Text="过滤条件一" Value="filter1" />
                        <f:ListItem Text="过滤条件二" Value="filter2" />
                        <f:ListItem Text="过滤条件三" Value="filter3" />
                    </f:DropDownList>
                </Items>
            </f:FormRow>
        </Rows>
    </f:Form>
    <f:Grid ID="Grid1" EnableCollapse="false" PageSize="5" ShowBorder="true" ShowHeader="false"
        BoxFlex="1"
        AllowPaging="true" runat="server" EnableCheckBoxSelect="True"
        DataKeyNames="news_id,news_title" IsDatabasePaging="true"
        AllowSorting="true" SortField="news_id" SortDirection="ASC"
        OnRowDataBound="Grid1_RowDataBound">
        <Columns>
            <f:RowNumberField />
            <f:BoundField DataField="news_id" Width="100px" SortField="news_id" DataFormatString="{0}"
                HeaderText="新闻编号" />

            <f:BoundField DataField="news_title" Width="100px" SortField="news_title" DataFormatString="{0}"
                HeaderText="新闻名称" />

            <f:BoundField DataField="news_posterid" Width="100px" SortField="news_posterid" DataFormatString="{0}"
                HeaderText="发布者编号" />

            <f:BoundField DataField="news_postername" Width="100px" SortField="news_postername" DataFormatString="{0}"
                HeaderText="发布者姓名" />

            <f:BoundField DataField="news_createtime" Width="100px" SortField="news_createtime" DataFormatString="{0}"
                HeaderText="发布时间" />


            <f:TemplateField Width="100px" HeaderText="新闻状态" TextAlign="Center">
                <ItemTemplate>
                    <asp:Label ID="news_state" runat="server" Text=""></asp:Label>
                </ItemTemplate>
            </f:TemplateField>




            <f:BoundField DataField="news_abstract" Width="200px" SortField="news_abstract" DataFormatString="{0}"
                HeaderText="新闻概要" />

            <f:BoundField DataField="news_content" Width="200px" SortField="news_content" DataFormatString="{0}"
                HeaderText="新闻内容" />


        </Columns>
        <Toolbars>
            <f:Toolbar ID="Toolbar1" runat="server">
                <Items>
                    <f:Button ID="btnExport" EnableAjax="false" DisableControlBeforePostBack="false"
                        runat="server" Text="导出为Excel文件" OnClick="btnExport_Click">
                    </f:Button>
                </Items>
            </f:Toolbar>
        </Toolbars>
    </f:Grid>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="headCPH">
    <meta name="sourcefiles" content="~/Admin/SingleGrid.Master;~/Admin/ISingleGridPage.cs" />
</asp:Content>
