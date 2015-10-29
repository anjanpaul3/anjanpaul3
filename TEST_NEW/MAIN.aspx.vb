Imports System.Web.Security
Public Class MAIN
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Me.Page.User.Identity.IsAuthenticated Then
                FormsAuthentication.RedirectToLoginPage()
            Else
                uname1.Text = Session("user_name").ToString
            End If
        Catch ex As Exception
            Response.Write(ex.ToString)
        End Try
    End Sub
End Class