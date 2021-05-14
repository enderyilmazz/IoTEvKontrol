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
        <div class="login-logo">
            <a href="#"><b>IoTEv</b>Kontrol</a>
        </div>
        <div class="card">
            <div class="card-body login-card-body">
                <p class="login-box-msg">Sisteme Giriş</p>

                <form action="Default.aspx" method="post">
                    <div class="input-group mb-3">
                        <input type="email" class="form-control" placeholder="Kullanıcı Adı">
                        <div class="input-group-append">
                            <div class="input-group-text">
                                <span class="fas fa-envelope"></span>
                            </div>
                        </div>
                    </div>
                    <div class="input-group mb-3">
                        <input type="password" class="form-control" placeholder="Şifre">
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
                        <!-- /.col -->
                        <div class="col-4">
                            <button type="submit" class="btn btn-primary btn-block">Giriş Yap</button>
                        </div>
                        <!-- /.col -->
                    </div>
                </form>

                <p class="mb-1">
                    <a href="forgot-password.html">Şifremi unuttum</a>
                </p>
            </div>
            <!-- /.login-card-body -->
        </div>
    </div>

    <script src="Resource/Template/plugins/jquery/jquery.min.js"></script>
    <script src="Resource/Template/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="Resource/Template/dist/js/adminlte.min.js"></script>

    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
