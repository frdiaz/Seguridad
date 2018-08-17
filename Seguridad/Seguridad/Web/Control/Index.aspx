<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Sistema.Web.Index" %>
<asp:Content id="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Index</title>
</asp:Content>

<asp:Content id="Content2" ContentPlaceHolderID="contentPlaceHolder1" runat="server">
    <div class="be-content">
        <div class="page-head">
          <h2 class="page-head-title">Without sidebarrrrr</h2>
          <ol class="breadcrumb page-head-nav">
            <li><a href="#">Home</a></li>
            <li><a href="#">Layouts</a></li>
            <li class="active">No sidebar left</li>
          </ol>
        </div>
        <div class="main-content container-fluid">
          <div class="row">
            <div class="col-xs-12 col-md-6 col-md-offset-3">
              <div class="panel panel-default">
                <div class="panel-heading"><span class="title">Remove sidebar left</span></div>
                <div class="panel-body">
                  <p>You can remove the <b>Left Sidebar</b> by default just adding the class <code>be-nosidebar-left</code> into the main wapper element, like this:</p>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
</asp:Content>