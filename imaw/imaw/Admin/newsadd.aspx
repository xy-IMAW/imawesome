<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newsadd.aspx.cs" Inherits="imaw.Admin.newsadd" ValidateRequest="false" %>

<!DOCTYPE html>
<html>
<head id="head1" runat="server">
    <title></title>
    <link href="../res/ueditor/themes/default/css/ueditor.min.css" rel="stylesheet" />
</head>
<body>


    <form id="_form1" runat="server">
        <f:PageManager ID="PageManager1" AutoSizePanelID="SimpleForm1" runat="server" />
        <f:Form ID="SimpleForm1" ShowBorder="false" ShowHeader="false" AutoScroll="true" BodyPadding="10px" runat="server">
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
                        <f:Label ID="news_posterid" Label="发布者编号" Text="" runat="server" />
                        <f:Label ID="news_postername" Label="发布者姓名" Text="" runat="server" />
                        <f:DropDownList runat="server" ID="news_state" AutoSelectFirstItem="false" AutoPostBack="false" Label="新闻类别">
                            <f:ListItem Text="头条新闻" Value="1" />
                            <f:ListItem Text="强调新闻" Value="2" />
                            <f:ListItem Text="普通新闻" Value="3" />
                        </f:DropDownList>
                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:TextBox runat="server" ID="news_title" Label="新闻标题" EmptyText="输入字符会立即触发TextChanged事件" AutoPostBack="true"></f:TextBox>
                        <f:DatePicker ID="news_createtime" Required="True" ShowRedStar="true" runat="server"
                            SelectedDate="2008-05-09" Label="发布时间" Text="2008-05-09">
                        </f:DatePicker>
                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:Panel ID="Panel2" Layout="Column" CssClass="formitem" ShowHeader="false" ShowBorder="false" runat="server">
                            <Items>
                                <f:Label ID="Label2" Width="80px" runat="server" CssClass="marginr" ShowLabel="false"
                                    Text="文章正文：">
                                </f:Label>
                                <f:ContentPanel ID="ContentPanel2" ColumnWidth="100%" runat="server" ShowBorder="false" ShowHeader="false">
                                    <script type="text/plain" name="Editor1" id="Editor1">
                                    </script>
                                </f:ContentPanel>
                            </Items>
                        </f:Panel>
                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:Panel ID="Panel1" Layout="Column" CssClass="formitem" ShowHeader="false" ShowBorder="false" runat="server">
                            <Items>
                                <f:Label ID="Label1" Width="80px" runat="server" CssClass="marginr" ShowLabel="false"
                                    Text="文章摘要：">
                                </f:Label>
                                <f:ContentPanel ID="ContentPanel3" ColumnWidth="100%" runat="server" ShowBorder="false" ShowHeader="false">
                                    <script type="text/plain" name="Editor2" id="Editor2">
                                    </script>
                                </f:ContentPanel>
                            </Items>
                        </f:Panel>
                    </Items>
                </f:FormRow>
            </Rows>
            <Toolbars>
                <f:Toolbar runat="server" ToolbarAlign="Right" Position="Bottom">
                    <Items>
                        <f:Button ID="Button2" runat="server" Text="更新文章摘要" OnClick="Button2_Click">
                        </f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
        </f:Form>
    </form>

    <script type="text/javascript">
        window.UEDITOR_HOME_URL = '<%= ResolveUrl("/res/ueditor/") %>';
    </script>
    <script type="text/javascript" src="../res/js/jquery.min.js"></script>
    <script type="text/javascript" src="../res/ueditor/ueditor.config.js"></script>
    <script type="text/javascript" src="../res/ueditor/ueditor.all.min.js"></script>
    <script type="text/javascript">

        var containerClientID = '<%= SimpleForm1.ClientID %>';

        var editor1, editor2;

        $(document).ready(function () {
            editor1 = UE.getEditor('Editor1', {
                initialFrameWidth: '100%',
                initialFrameHeight: 150,
                autoHeightEnabled: false,
                autoFloatEnabled: false,
                onready: function () {
                    // 重新布局外部容器
                    doLayout();
                }
            });


            editor2 = UE.getEditor('Editor2', {
                initialFrameWidth: '100%',
                initialFrameHeight: 80,
                initialContent: '',
                autoHeightEnabled: false,
                autoFloatEnabled: false,
                toolbars: [['fullscreen', 'source', '|', 'undo', 'redo', '|',
                'bold', 'italic', 'underline', 'strikethrough', 'superscript', 'subscript',
                'removeformat', 'formatmatch', 'autotypeset', 'blockquote', 'pasteplain']],
                onready: function () {
                    // 重新布局外部容器
                    doLayout();
                }
            });

        });

        function doLayout() {
            if ((editor1 && editor1.isReady) && (editor2 && editor2.isReady)) {
                // 重新布局外部容器
                F(containerClientID).updateLayout();
            }
        }

        // 更新编辑器内容
        function updateEditor1(content) {
            if (editor1 && editor1.isReady) {
                editor1.setContent(content);
            }
        }

        function updateEditor2(content) {
            if (editor2 && editor2.isReady) {
                editor2.setContent(content);
            }
        }
    </script>

</body>
</html>
