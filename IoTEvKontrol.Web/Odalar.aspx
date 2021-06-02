<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="Odalar.aspx.cs" Inherits="IoTEvKontrol.Web.Odalar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1 class="m-0">Odalar</h1>
                </div>
                <div class="col-sm-6">
                    <ol class="breadcrumb float-sm-right">
                        <li class="breadcrumb-item"><a href="#">Anasayfa</a></li>
                        <li class="breadcrumb-item active">Ev</li>
                    </ol>
                </div>
            </div>
        </div>
    </div>
    <div class="content">
        <div class="container-fluid">
            <div class="row">
                <asp:Repeater ID="OdaTablo" runat="server" OnItemCommand="OdaTabloCommand">
                    <ItemTemplate>
                        <div class="col-md-6">
                            <div class="card card-info shadow-lg">
                                <div class="card-header">
                                    <h3 class="card-title">
                                        <small><%# Eval("OdaAdi") %></small>
                                    </h3>
                                    <div class="card-tools">
                                        <button type="button" class="btn btn-tool" data-card-widget="collapse">
                                            <i class="fas fa-minus"></i>
                                        </button>
                                        <button type="button" class="btn btn-tool" data-card-widget="remove">
                                            <i class="fas fa-times"></i>
                                        </button>
                                    </div>
                                </div>
                                <div class="card-body">
                                    <div class="row">
                                        <div class="col-6 col-md-3 text-center">
                                            <asp:TextBox CssClass="knob" ID="TextBox1" runat="server" data-thickness="0.2" data-anglearc="250" data-angleoffset="-125"
                                                value="0" data-width="100" data-height="100" data-fgcolor="#dc3545" data-readonly="true"></asp:TextBox>
                                            <div class="knob-label">Sıcaklık °C</div>
                                        </div>
                                        <div class="col-6 col-md-3 text-center">
                                            <asp:TextBox CssClass="knob" ID="TextBox2" runat="server" data-thickness="0.2" data-anglearc="250" data-angleoffset="-125"
                                                value="0" data-width="100" data-height="100" data-fgcolor="#17a2b8" data-readonly="true"></asp:TextBox>
                                            <div class="knob-label">Nem %</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
