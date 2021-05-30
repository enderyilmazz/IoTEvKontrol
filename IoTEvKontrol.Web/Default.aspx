<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IoTEvKontrol.Web.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="content-header">
                <div class="container-fluid">
                    <div class="row mb-2">
                        <div class="col-sm-6">
                            <h1 class="m-0">Kontrol Panel</h1>
                        </div>
                        <div class="col-sm-6">
                            <ol class="breadcrumb float-sm-right">
                                <li class="breadcrumb-item"><a href="#">Anasayfa</a></li>
                                <li class="breadcrumb-item active">Kontrol Panel</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>
            <div class="content">
                <div class="container-fluid">
                    <div id="istek" class="row">
                        <div class="col-12">
                            <div class="card">
                                <div class="card-header">
                                    <h3 class="card-title">
                                        <i class="far fa-chart-bar"></i>
                                        DHT11 Sensör Okuma Bilgileri
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
                                    <asp:Button CssClass="btn btn-success" ID="Button1" runat="server" OnClick="Button1_Click" Text="Led Aç" />
                                    <asp:Button CssClass="btn btn-warning" ID="Button2" runat="server" OnClick="Button2_Click" Text="Led Kapat" />
                                    <asp:Button CssClass="btn btn-danger" ID="Button3" runat="server" OnClick="Button3_Click" Text="Sıcaklık" />
                                    <asp:Button CssClass="btn btn-primary" ID="Button4" runat="server" OnClick="Nem_Click" Text="Nem" />
                                    <asp:Label ID="Label1" runat="server" Text="Durum : ---"></asp:Label>
                                    <div class="row">
                                        <div class="col-6 col-md-3 text-center">
                                            <asp:TextBox CssClass="knob" ID="TextBox1" runat="server" data-thickness="0.2" data-anglearc="250" data-angleoffset="-125"
                                                value="0" data-width="150" data-height="150" data-fgcolor="#dc3545" data-readonly="true"></asp:TextBox>
                                            <div class="knob-label">Sıcaklık °C</div>
                                        </div>
                                        <div class="col-6 col-md-3 text-center">
                                            <asp:TextBox CssClass="knob" ID="TextBox2" runat="server" data-thickness="0.2" data-anglearc="250" data-angleoffset="-125"
                                                value="0" data-width="150" data-height="150" data-fgcolor="#17a2b8" data-readonly="true"></asp:TextBox>
                                            <div class="knob-label">Nem %</div>
                                        </div>
                                    </div>
                                </div>
                                <asp:Image ID="Image1" runat="server" />

                                <asp:Repeater ID="rptOrnek" runat="server">
                                    <HeaderTemplate>
                                        <table class="table table-striped table-hover ">
                                            <thead>
                                                <tr class="warning">
                                                    <th>ID</th>
                                                    <th>Rol</th>
                                                    <th>Açıklama</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr class="active">
                                            <td><%# Eval("ID") %></td>
                                            <td><%# Eval("RolAdi") %></td>
                                            <td><%# Eval("Aciklama") %></td>
                                        </tr>
                                    </ItemTemplate>
                                    <AlternatingItemTemplate>
                                        <tr class="info">
                                            <td><%# Eval("ID") %></td>
                                            <td><%# Eval("RolAdi") %></td>
                                            <td><%# Eval("Aciklama") %></td>
                                    </AlternatingItemTemplate>
                                    <FooterTemplate>
                                        </tbody>
                                        </table> 
                                    </FooterTemplate>
                                </asp:Repeater>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
