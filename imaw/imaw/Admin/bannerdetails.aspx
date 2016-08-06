<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bannerdetails.aspx.cs" Inherits="imaw.Admin.bannerdetails" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
    <style>
        .photo {
            height: 150px;
            line-height: 150px;
            overflow: hidden;
        }
 
            .photo img {
                height: 150px;
                vertical-align: middle;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      <f:PageManager ID="PageManager1" AutoSizePanelID="Panel1" runat="server" />

        <f:SimpleForm ID="SimpleForm1" BodyPadding="5px" runat="server"   EnableCollapse="true"
            ShowBorder="True" Title="表单">
            <Items>
                <f:Image ID="imgPhoto" CssClass="photo" ImageUrl="~/res/images/blank.png" ShowEmptyLabel="true" runat="server">
                </f:Image>
                <f:TextBox runat="server" Label="标题" ID="tbxUserName" Required="true" ShowRedStar="true">
                </f:TextBox>

                <f:TextBox runat="server" Label="连接地址" ID="tbxEmail" Required="true" RegexPattern="EMAIL"
                    ShowRedStar="true">
                </f:TextBox>
 
            </Items>
            <Toolbars>
                <f:Toolbar Position="Bottom" ToolbarAlign="Right" runat="server">
                    <Items>
                        <f:FileUpload runat="server" ID="filePhoto" ButtonText="上传首页大图" AcceptFileTypes="image/*" ButtonOnly="true"
                            AutoPostBack="true" OnFileSelected="filePhoto_FileSelected">
                        </f:FileUpload>
                        <f:Button runat="server" Icon="SystemSave" ID="btnSubmit" OnClick="btnSubmit_Click"
                            ValidateForms="SimpleForm1" Text="提交">
                        </f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
        </f:SimpleForm>
        <br />
        注意：上传个人头像通过 AcceptFileTypes="image/*" 来控制默认显示的文件类型。
        上传首页大图的格式要求为。


    </form>
</body>
</html>
