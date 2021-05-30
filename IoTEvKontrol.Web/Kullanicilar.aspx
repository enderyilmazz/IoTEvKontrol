<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="Kullanicilar.aspx.cs" Inherits="IoTEvKontrol.Web.Kullanicilar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1 class="m-0">Kullanıcılar</h1>
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
                <asp:PlaceHolder ID="BasariMesaj" runat="server" Visible="false">
                    <div class="col-12">
                        <div class="alert alert-success alert-dismissible fade show" role="alert">
                            <strong>Başarılı!</strong>
                            Kullanıcı silindi.
                            <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                    </div>
                </asp:PlaceHolder>
                <asp:PlaceHolder ID="HataMesaj" runat="server" Visible="false">
                    <div class="col-12">
                        <div class="alert alert-danger alert-dismissible fade show" role="alert">
                            <strong>Başarısız!</strong>
                            Kullanıcı silinemedi.
                            <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                    </div>
                </asp:PlaceHolder>
            </div>
            <div class="row">
                <div class="col-12">
                    <div class="card card-info">
                        <div class="card-header">
                            <h3 class="card-title">
                                <i class="far fa-list-alt"></i>
                                Kullanıcılar
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
                        <div class="card-body table-responsive p-0">
                            <table class="table table-striped">
                                <asp:Repeater ID="KullaniciTablo" runat="server" OnItemCommand="KullaniciTabloCommand">
                                    <HeaderTemplate>
                                        <thead>
                                            <tr>
                                                <th style="width: 1%">#</th>
                                                <th style="width: auto">Kullanıcı Adı</th>
                                                <th style="width: auto">E-posta</th>
                                                <th style="width: auto">Rol</th>
                                                <th style="width: auto"></th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td>1</td>
                                            <td>
                                                <a>@<%# Eval("UserName") %></a>
                                            </td>
                                            <td>
                                                <a><%# Eval("Email") %></a>
                                            </td>
                                            <td>
                                                <span class="badge badge-danger">Yönetici</span>
                                            </td>
                                            <td class="text-right">
                                                <asp:LinkButton CssClass="btn btn-info btn-sm" ID="LinkButton1" runat="server" CommandName="kullaniciGuncelle" CommandArgument='<%# Eval("Id") %>'>
                                                <i class="fas fa-pencil-alt"></i>
                                                </asp:LinkButton>
                                                <asp:LinkButton CssClass="btn btn-danger btn-sm" ID="LinkButton2" runat="server" CommandName="kullaniciSil" CommandArgument='<%# Eval("Id") %>'>
                                                <i class="fas fa-trash"></i>
                                                </asp:LinkButton>
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        </tbody>
                                    </FooterTemplate>
                                </asp:Repeater>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
