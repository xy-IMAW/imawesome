<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="newsdetails.aspx.cs" Inherits="imaw.Admin.newsdetails" %>

<!DOCTYPE html>
<html>
<head id="head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager ID="PageManager1" AutoSizePanelID="SimpleForm1" runat="server" />
        <f:Form ID="SimpleForm1" ShowBorder="false" ShowHeader="false"
            AutoScroll="true" BodyPadding="10px" runat="server">
            <Toolbars>
                <f:Toolbar ID="Toolbar1" runat="server">
                    <Items>
                        <f:Button ID="btnClose" EnablePostBack="false" Text="关闭" runat="server" Icon="SystemClose">
                        </f:Button>
                        <f:Button ID="btnSaveContinue" Text="回发-关闭-回发父页面" runat="server" Icon="SystemSave"
                            OnClick="btnSaveContinue_Click">
                        </f:Button>
                        <f:Button ID="btnSaveRefresh" Text="回发-关闭-刷新父页面" runat="server" Icon="SystemSave"
                            OnClick="btnSaveRefresh_Click">
                        </f:Button>
                        <f:ToolbarFill ID="ToolbarFill1" runat="server">
                        </f:ToolbarFill>

                        <f:ToolbarText ID="ToolbarText1" Text="提示一" runat="server">
                        </f:ToolbarText>
                    </Items>
                </f:Toolbar>
            </Toolbars>
            <Rows>
                <f:FormRow>
                    <Items>
                        <f:Label ID="news_id" Label="新闻编号" Text="" runat="server" />
                        <f:Label ID="news_posterid" Label="发布者编号" Text=""  runat="server" />
                        <f:Label ID="news_postername" Label="发布者姓名" Text=""  runat="server" />
                        <f:DropDownList runat="server" ID="news_state" AutoSelectFirstItem="false" AutoPostBack="false" Label="新闻类别">
                            <f:ListItem Text="头条新闻" Value="1" />
                            <f:ListItem Text="强调新闻" Value="2" />
                            <f:ListItem Text="普通新闻" Value="3" />
                        </f:DropDownList>
                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:TextBox runat="server" ID="news_title" Label="新闻标题" EmptyText="输入字符会立即触发TextChanged事件" AutoPostBack="true" ></f:TextBox>
                        <f:DatePicker ID="news_createtime" Required="True" ShowRedStar="true" runat="server"
                            SelectedDate="2008-05-09" Label="发布时间" Text="2008-05-09">
                        </f:DatePicker>
                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:TextArea ID="news_abstract" Height="80px" Label="新闻概述" runat="server" Required="True" ShowRedStar="true" />
                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:HtmlEditor ID="news_content" Label="详细描述" Height="180px" runat="server">
                        </f:HtmlEditor>
                    </Items>
                </f:FormRow>
            </Rows>
        </f:Form>
    </form>
</body>
</html>
