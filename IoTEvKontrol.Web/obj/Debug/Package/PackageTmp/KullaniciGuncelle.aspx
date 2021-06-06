<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="KullaniciGuncelle.aspx.cs" Inherits="IoTEvKontrol.Web.KullaniciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1 class="m-0">Kullanıcı Güncelle</h1>
                </div>
                <div class="col-sm-6">
                    <ol class="breadcrumb float-sm-right">
                        <li class="breadcrumb-item"><a href="#">Anasayfa</a></li>
                        <li class="breadcrumb-item active">Kullanıcı</li>
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
                                <i class="far fa-edit"></i>
                                Kullanıcı Güncelle
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
                                <div class="col-sm-6">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="KullaniciAdi">Kullanıcı Adı</asp:Label>
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text">@</span>
                                            </div>
                                            <asp:TextBox CssClass="form-control" type="text" runat="server" ID="KullaniciAdi" Enabled="false" placeholder="Kullanıcı Adı" />
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="Telefon">Telefon</asp:Label>
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fas fa-phone"></i></span>
                                            </div>
                                            <asp:TextBox CssClass="form-control" runat="server" ID="Telefon" placeholder="Telefon" />
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="Eposta">E-posta</asp:Label>
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fas fa-envelope"></i></span>
                                            </div>
                                            <asp:TextBox CssClass="form-control" runat="server" ID="Eposta" TextMode="Email" placeholder="E-posta" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-sm-6">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="MevcutSifre">Mevcut Şifre</asp:Label>
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fas fa-lock"></i></span>
                                            </div>
                                            <asp:TextBox CssClass="form-control" runat="server" ID="MevcutSifre" TextMode="Password" placeholder="Şifre" />
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="YeniSifre">Yeni Şifre</asp:Label>
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fas fa-lock"></i></span>
                                            </div>
                                            <asp:TextBox CssClass="form-control" runat="server" ID="YeniSifre" TextMode="Password" placeholder="Şifre Tekrar" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                                <asp:Label runat="server" AssociatedControlID="Rol">Rol</asp:Label>
                                                <asp:DropDownList CssClass="form-control" ID="Rol" runat="server" Enabled="false">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                                <asp:Label runat="server" AssociatedControlID="YeniRol">Yeni Rol</asp:Label>
                                                <asp:DropDownList CssClass="form-control" ID="YeniRol" runat="server">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-6"></div>
                                        <div class="col-sm-6">
                                            <asp:Button CssClass="btn btn-block bg-gradient-success" runat="server" OnClick="Guncelle_Click" Text="Güncelle" />
                                        </div>
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
