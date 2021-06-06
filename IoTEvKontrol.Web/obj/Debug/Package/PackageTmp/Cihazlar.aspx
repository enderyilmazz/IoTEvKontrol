<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="Cihazlar.aspx.cs" Inherits="IoTEvKontrol.Web.Cihazlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1 class="m-0">Cihazlar</h1>
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
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="container-fluid">
                    <div class="row">
                        <asp:PlaceHolder ID="HataMesaj" runat="server" Visible="false">
                            <div class="col-12">
                                <div class="alert alert-danger alert-dismissible fade show" role="alert">
                                    <strong>Başarısız!</strong>
                                    Cihaz silinemedi.
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
                                        Cihazlar
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
                                        <asp:Repeater ID="CihazTablo" runat="server" OnItemCommand="CihazTabloCommand">
                                            <HeaderTemplate>
                                                <thead>
                                                    <tr>
                                                        <th style="width: 1%">#</th>
                                                        <th style="width: auto">Cihaz Adı</th>
                                                        <th style="width: auto">IP Adres</th>
                                                        <th style="width: auto">Port No</th>
                                                        <th style="width: auto"></th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <tr>
                                                    <td>#</td>
                                                    <td>
                                                        <a><%# Eval("CihazAdi") %></a>
                                                    </td>
                                                    <td>
                                                        <a><%# Eval("IpAdres") %></a>
                                                    </td>
                                                    <td>
                                                        <a><%# Eval("PortNo") %></a>
                                                    </td>
                                                    <td class="text-right">
                                                        <asp:LinkButton CssClass="btn btn-info btn-sm" ID="LinkButton1" runat="server" CommandName="cihazGuncelle" CommandArgument='<%# Eval("ID") %>'>
                                                <i class="fas fa-pencil-alt"></i>
                                                        </asp:LinkButton>
                                                        <asp:LinkButton CssClass="btn btn-danger btn-sm" ID="LinkButton2" runat="server" CommandName="cihazSil" CommandArgument='<%# Eval("ID") %>'>
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
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
