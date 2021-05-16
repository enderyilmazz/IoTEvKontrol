<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="IoTEvKontrol.Web.Giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>IoT Ev Kontrol Sistemi | Giriş Yap</title>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback">
    <link rel="stylesheet" href="Resource/Template/plugins/fontawesome-free/css/all.min.css">
    <link rel="stylesheet" href="Resource/Template/plugins/icheck-bootstrap/icheck-bootstrap.min.css">
    <link rel="stylesheet" href="Resource/Template/dist/css/adminlte.min.css">
</head>
<body class="hold-transition login-page">
    <div class="login-box">
        <asp:PlaceHolder ID="HataMesaj" runat="server" Visible="false">
            <div class="col-12">
                <div class="alert alert-danger alert-dismissible fade show" role="alert">
                    <strong>Hata!</strong>
                    <small>Kullanıcı adı veya şifre yanlış.</small>
                <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
                </div>
            </div>
        </asp:PlaceHolder>
        <div class="login-logo">
            <a href="#"><b>IoTEv</b>Kontrol</a>
        </div>
        <div class="card">
            <div class="card-body login-card-body">
                <p class="login-box-msg">Sisteme Giriş</p>
                <form id="form1" runat="server">
                    <div class="input-group mb-3">
                        <asp:TextBox CssClass="form-control" runat="server" ID="KullaniciAdi" placeholder="Kullanıcı Adı" />
                        <div class="input-group-append">
                            <div class="input-group-text">
                                <span class="fas fa-user"></span>
                            </div>
                        </div>
                    </div>
                    <div class="input-group mb-3">
                        <asp:TextBox CssClass="form-control" runat="server" ID="Sifre" TextMode="Password" placeholder="Şifre" />
                        <div class="input-group-append">
                            <div class="input-group-text">
                                <span class="fas fa-lock"></span>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-8">
                            <div class="icheck-primary">
                                <input type="checkbox" id="remember">
                                <label for="remember">
                                    Beni hatırla
                                </label>
                            </div>
                        </div>
                        <div class="col-4">
                            <asp:Button CssClass="btn btn-primary btn-block" runat="server" OnClick="Giris_Click" Text="Giriş Yap" />
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
    <script src="Resource/Template/plugins/jquery/jquery.min.js"></script>
    <script src="Resource/Template/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="Resource/Template/dist/js/adminlte.min.js"></script>
</body>
</html>
