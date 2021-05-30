<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="RolEkle.aspx.cs" Inherits="IoTEvKontrol.Web.RolEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1 class="m-0">Rol Ekle</h1>
                </div>
                <div class="col-sm-6">
                    <ol class="breadcrumb float-sm-right">
                        <li class="breadcrumb-item"><a href="#">Anasayfa</a></li>
                        <li class="breadcrumb-item active">Rol</li>
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
                            Yeni rol kaydedildi.
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
                            Yeni rol kaydedilemedi.
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
                                <i class="far fa-plus-square"></i>
                                Rol Ekle
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
                                        <asp:Label runat="server" AssociatedControlID="RolAd">Rol Adı</asp:Label>
                                        <asp:TextBox CssClass="form-control" runat="server" ID="RolAd" placeholder="Rol Adı" />
                                    </div> 
                                    <div class="form-group">
                                        <asp:Button CssClass="btn btn-block bg-gradient-success w-25 float-right" runat="server" OnClick="Kaydet_Click" Text="Kaydet" />
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
