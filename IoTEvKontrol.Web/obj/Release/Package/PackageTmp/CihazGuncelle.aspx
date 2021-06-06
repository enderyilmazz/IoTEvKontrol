<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="CihazGuncelle.aspx.cs" Inherits="IoTEvKontrol.Web.CihazGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1 class="m-0">Cihaz Güncelle</h1>
                </div>
                <div class="col-sm-6">
                    <ol class="breadcrumb float-sm-right">
                        <li class="breadcrumb-item"><a href="#">Anasayfa</a></li>
                        <li class="breadcrumb-item active">Cihaz</li>
                    </ol>
                </div>
            </div>
        </div>
    </div>
    <div class="content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-12">
                    <div class="card card-info">
                        <div class="card-header">
                            <h3 class="card-title">
                                <i class="far fa-plus-square"></i>
                                Cihaz Düzenle
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
                                <div class="col-sm-12">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="CihazAd">Cihaz Adı</asp:Label>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="CihazAd" placeholder="Cihaz Adı" />
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="IpAdres">IP Adres</asp:Label>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="IpAdres" placeholder="IP Adres" />
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="PortNo">Port No</asp:Label>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="PortNo" placeholder="Port No" />
                                    </div>
                                    <div class="form-group">
                                        <asp:Button CssClass="btn btn-block bg-gradient-success w-25 float-right" runat="server" OnClick="Guncelle_Click" Text="Güncelle" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
