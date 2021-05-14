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
                                <thead>
                                    <tr>
                                        <th style="width: 1%">#</th>
                                        <th style="width: auto">Kullanıcı</th>
                                        <th style="width: auto">Oluşturma</th>
                                        <th style="width: auto">Rol</th>
                                        <th style="width: auto">Durum</th>
                                        <th style="width: auto"></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>1</td>
                                        <td>
                                            <a>@enderyilmaz</a>
                                        </td>
                                        <td>
                                            <a>12.05.2021</a>
                                        </td>
                                        <td>
                                            <span class="badge badge-danger">Yönetici</span>
                                        </td>
                                        <td>
                                            <span class="badge badge-success">Aktif</span>
                                        </td>
                                        <td class="text-right">
                                            <a class="btn btn-info btn-sm" href="#">
                                                <i class="fas fa-pencil-alt"></i>
                                            </a>
                                            <a class="btn btn-danger btn-sm" href="#">
                                                <i class="fas fa-trash"></i>
                                            </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>2</td>
                                        <td>
                                            <a>@user</a>
                                        </td>
                                        <td>
                                            <a>12.05.2021</a>
                                        </td>
                                        <td>
                                            <span class="badge badge-primary">Kullanıcı</span>
                                        </td>
                                        <td>
                                            <span class="badge badge-secondary">Pasif</span>
                                        </td>
                                        <td class="text-right">
                                            <a class="btn btn-info btn-sm" href="#">
                                                <i class="fas fa-pencil-alt"></i>
                                            </a>
                                            <a class="btn btn-danger btn-sm" href="#">
                                                <i class="fas fa-trash"></i>
                                            </a>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
