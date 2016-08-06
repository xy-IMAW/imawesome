﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="imaw.Admin.admin" %>


<!DOCTYPE html>

<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>学生成绩管理系统</title>
    <style>
        .header .title a,
        .header .pro a {
            font-weight: bold;
            font-size: 24px;
            text-decoration: none;
            line-height: 50px;
            margin-left: 10px;
        }

        .header .pro {
            position: absolute;
            top: 0;
            right: 10px;
        }

        .bottomtable {
            width: 100%;
            font-size: 12px;
        }


        /* 主题相关样式 - neptune */
        .f-theme-neptune .header,
        .f-theme-neptune .bottomtable,
        .f-theme-neptune .x-splitter {
            background-color: #1475BB;
            color: #fff;
        }

            .f-theme-neptune .header a,
            .f-theme-neptune .bottomtable a {
                color: #fff;
            }

            .f-theme-neptune .header .x-panel-body {
                background-color: transparent;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager ID="PageManager1" AutoSizePanelID="RegionPanel1" runat="server"></f:PageManager>
        <f:RegionPanel ID="RegionPanel1" ShowBorder="false" runat="server">
            <Regions>
                <f:Region ID="Region1" ShowBorder="false" Height="50px" ShowHeader="false"
                    Position="Top" Layout="Fit" runat="server">
                    <Items>
                        <f:ContentPanel ShowBorder="false" ShowHeader="false" ID="ContentPanel1" CssClass="header"
                            runat="server">
                            <div class="title">
                                <a href="./default.aspx" style="color: #fff;">协会官网后台管理系统</a>
                            </div>
                        </f:ContentPanel>
                    </Items>
                </f:Region>

                <f:Region ID="Region2" Split="true" Width="200px" ShowHeader="true" Title="菜单"
                    EnableCollapse="true" Layout="Container " Position="Left" runat="server">
                    <Items>
                        <f:Tree runat="server" ShowBorder="false" ShowHeader="false" EnableArrows="true" EnableLines="true" ID="leftMenuTree">
                            <Nodes>
                                <f:TreeNode Text="新闻模块" Expanded="true">
                                    <f:TreeNode Text="首页大图" NavigateUrl="banner.aspx"></f:TreeNode>
                                    <f:TreeNode Text="新闻管理" NavigateUrl="news.aspx"></f:TreeNode>
                                    <f:TreeNode Text="留言回复" NavigateUrl=""></f:TreeNode>
                                </f:TreeNode>
                                <f:TreeNode Text="活动模块" Expanded="true">
                                    <f:TreeNode Text="活动发布" NavigateUrl=""></f:TreeNode>
                                    <f:TreeNode Text="报名管理" NavigateUrl=""></f:TreeNode>
                                </f:TreeNode>
                                <f:TreeNode Text="招新管理" Expanded="true">
                                    <f:TreeNode Text="信息管理" NavigateUrl=""></f:TreeNode>
                                    <f:TreeNode Text="招新管理" NavigateUrl="true">
                                        <f:TreeNode Text="申请信息" NavigateUrl=""></f:TreeNode>
                                        <f:TreeNode Text="技术部" NavigateUrl=""></f:TreeNode>
                                        <f:TreeNode Text="项目部" NavigateUrl=""></f:TreeNode>
                                        <f:TreeNode Text="策划部" NavigateUrl=""></f:TreeNode>
                                        <f:TreeNode Text="综管部" NavigateUrl=""></f:TreeNode>
                                        <f:TreeNode Text="公关部" NavigateUrl=""></f:TreeNode>
                                    </f:TreeNode>
                                </f:TreeNode>
                                <f:TreeNode Text="用户管理" Expanded="true">
                                    <f:TreeNode Text="网站用户" NavigateUrl=""></f:TreeNode>
                                    <f:TreeNode Text="协会会员" NavigateUrl=""></f:TreeNode>
                                    <f:TreeNode Text="协会成员" NavigateUrl=""></f:TreeNode>
                                </f:TreeNode>
                            </Nodes>
                        </f:Tree>
                    </Items>
                </f:Region>
                <f:Region ID="mainRegion" ShowHeader="false" Layout="Fit" Position="Center"
                    runat="server">
                    <Items>
                        <f:TabStrip ID="mainTabStrip" EnableTabCloseMenu="true" ShowBorder="false" runat="server">
                            <Tabs>
                                <f:Tab ID="Tab1" Title="首页" Layout="Fit" Icon="House" runat="server">
                                    <Items>
                                        <f:ContentPanel ID="ContentPanel2" ShowBorder="false" BodyPadding="10px" ShowHeader="false" AutoScroll="true"
                                            runat="server">
                                            <h2>FineUI（开源版）</h2>
                                            基于 ExtJS 的开源 ASP.NET 控件库
                                        
                                            <br />
                                            <h2>FineUI的使命</h2>
                                            创建 No JavaScript，No CSS，No UpdatePanel，No ViewState，No WebServices 的网站应用程序
                                        
                                            <br />
                                            <h2>支持的浏览器</h2>
                                            Chrome、Firefox、Safari、IE 8.0+
                                        
                                            <br />
                                            <h2>授权协议</h2>
                                            Apache License v2.0（ExtJS 库在 <a target="_blank" href="http://www.sencha.com/license">GPL v3</a> 协议下发布）
                                            
                                            <br />
                                            <h2>相关链接</h2>
                                            首页：<a target="_blank" href="http://fineui.com/">http://fineui.com/</a>
                                            <br />
                                            论坛：<a target="_blank" href="http://fineui.com/bbs/">http://fineui.com/bbs/</a>
                                            <br />
                                            示例：<a target="_blank" href="http://fineui.com/demo/">http://fineui.com/demo/</a>
                                            <br />
                                            文档：<a target="_blank" href="http://fineui.com/doc/">http://fineui.com/doc/</a>
                                            <br />
                                            <br />
                                            <br />
                                            <br />

                                            <hr />
                                            <br />
                                        </f:ContentPanel>
                                    </Items>
                                </f:Tab>
                            </Tabs>
                        </f:TabStrip>
                    </Items>
                </f:Region>
                <f:Region ID="bottomPanel" RegionPosition="Bottom" ShowBorder="false" ShowHeader="false" EnableCollapse="false" runat="server" Layout="Fit">
                    <Items>
                        <f:ContentPanel ID="ContentPanel3" runat="server" ShowBorder="false" ShowHeader="false">
                            <table class="bottomtable">
                                <tr>
                                    <td style="width: 300px;">
                                        
                                        <f:Label ID="ad" Text="" runat="server">
                                        </f:Label>
                                        <f:Label ID="ad_class" Text="" runat="server">
                                        </f:Label>
                                    </td>
                                    <td style="text-align: center;">Copyright &copy; 武汉理工大学信息管理协会</td>
                                    <td style="width: 300px; text-align: right;">&nbsp;</td>
                                </tr>
                            </table>
                        </f:ContentPanel>
                    </Items>
                </f:Region>
            </Regions>
        </f:RegionPanel>
    </form>
    <script>
        var menuClientID = '<%= leftMenuTree.ClientID %>';
        var tabStripClientID = '<%= mainTabStrip.ClientID %>';

        // 页面控件初始化完毕后，会调用用户自定义的onReady函数
        F.ready(function () {

            // 初始化主框架中的树(或者Accordion+Tree)和选项卡互动，以及地址栏的更新
            // treeMenu： 主框架中的树控件实例，或者内嵌树控件的手风琴控件实例
            // mainTabStrip： 选项卡实例
            // createToolbar： 创建选项卡前的回调函数（接受tabConfig参数）
            // updateLocationHash: 切换Tab时，是否更新地址栏Hash值
            // refreshWhenExist： 添加选项卡时，如果选项卡已经存在，是否刷新内部IFrame
            // refreshWhenTabChange: 切换选项卡时，是否刷新内部IFrame
            F.util.initTreeTabStrip(F(menuClientID), F(tabStripClientID), null, true, false, false);

        });
    </script>
</body>
</html>
