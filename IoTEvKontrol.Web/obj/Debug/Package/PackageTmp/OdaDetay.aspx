<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="OdaDetay.aspx.cs" Inherits="IoTEvKontrol.Web.OdaDetay" %>

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
                        <div class="col-md-3">
                            <div class="card card-info">
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
                                    <div class="text-center mb-4">
                                        <strong><%# Eval("CihazAdi") %></strong>
                                    </div>
                                    <div class="row text-center">
                                        <div class="col-6">
                                            <asp:TextBox CssClass="knob" ID="TextBox1" runat="server" data-thickness="0.2" data-anglearc="250" data-angleoffset="-125"
                                                value="0" data-width="90" data-height="90" data-fgcolor="#dc3545" data-readonly="true"></asp:TextBox>
                                            <div class="knob-label"><small>Sıcaklık °C</small></div>
                                        </div>
                                        <div class="col-6">
                                            <asp:TextBox CssClass="knob" ID="TextBox2" runat="server" data-thickness="0.2" data-anglearc="250" data-angleoffset="-125"
                                                value="0" data-width="90" data-height="90" data-fgcolor="#17a2b8" data-readonly="true"></asp:TextBox>
                                            <div class="knob-label"><small>Nem %</small></div>
                                        </div>
                                    </div>
                                </div>
                                <asp:Button CssClass="btn btn-secondary btn-sm rounded-0" ID="Button1" runat="server" Text="Kontrol" />
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
