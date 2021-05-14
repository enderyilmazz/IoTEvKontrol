<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="KullaniciEkle.aspx.cs" Inherits="IoTEvKontrol.Web.KullaniciEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1 class="m-0">Kullanıcı Ekle</h1>
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
                                <i class="far fa-plus-square"></i>
                                Kullanıcı Ekle
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
                                        <label for="adText">Ad</label>
                                        <input type="text" class="form-control" id="adText" placeholder="Ad">
                                    </div>
                                    <div class="form-group">
                                        <label for="soyadText">Soyad</label>
                                        <input type="text" class="form-control" id="soyadText" placeholder="Soyad">
                                    </div>
                                    <div class="form-group">
                                        <label for="telefonText">Telefon</label>
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fas fa-phone"></i></span>
                                            </div>
                                            <input type="text" class="form-control" id="telefonText" placeholder="Telefon">
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="epostaText">E-posta</label>
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fas fa-envelope"></i></span>
                                            </div>
                                            <input type="email" class="form-control" id="epostaText" placeholder="E-posta">
                                        </div>
                                    </div>
                                </div>
                                <div class="col-sm-6">
                                    <div class="form-group">
                                        <label for="kullaniciAdiText">Kullanıcı Adı</label>
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text">@</span>
                                            </div>
                                            <input type="text" class="form-control" id="kullaniciAdiText" placeholder="Kullanıcı Adı">
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="sifreText">Şifre</label>
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fas fa-lock"></i></span>
                                            </div>
                                            <input type="password" class="form-control" id="sifreText" placeholder="Şifre">
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="sifreTekrarText">Şifre Tekrar</label>
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fas fa-lock"></i></span>
                                            </div>
                                            <input type="password" class="form-control" id="sifreTekrarText" placeholder="Şifre Tekrar">
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                                <label>Rol</label>
                                                <select class="form-control">
                                                    <option>Üst Düz. Yönetici</option>
                                                    <option>Yönetici</option>
                                                    <option>Kullanıcı</option>
                                                    <option>Misafir</option>
                                                    <option>Test</option>
                                                </select>
                                            </div>
                                        </div>
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                                <label>Kullanıcı Durum</label>
                                                <select class="form-control">
                                                    <option>Aktif</option>
                                                    <option>Pasif</option>
                                                </select>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-6"></div>
                                        <div class="col-sm-6">
                                            <button type="button" class="btn btn-block bg-gradient-success">Kaydet</button>
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
