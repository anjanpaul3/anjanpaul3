﻿Imports System.Data.SqlClient
Imports System.Web.Security
Public Class POP
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Me.Page.User.Identity.IsAuthenticated Then
                FormsAuthentication.RedirectToLoginPage()
            Else
                uname1.Text = Session("user_name").ToString
            End If
            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("APPHARBOR").ConnectionString)
            con.Open()
            Dim da As New SqlDataAdapter("select STYPE from pmr GROUP BY STYPE", con)
            Dim dt As New DataTable
            da.Fill(dt)
            For i As Integer = 0 To dt.Rows.Count - 1
                stype1.Items.Add(dt(i)("stype").ToString)
            Next
        Catch ex As Exception
            err_display(ex.Message)
        End Try
    End Sub
    Public Sub DATALOAD()
        Try
            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("APPHARBOR").ConnectionString)
            con.Open()
            Dim da As New SqlDataAdapter("select * from MAINPOPU", con)
            Dim dt As New DataTable
            da.Fill(dt)
        Catch ex As Exception
            err_display(ex.Message)
        End Try
    End Sub
    Protected Sub Edit(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim btnsubmit As LinkButton = TryCast(sender, LinkButton)
            Dim gRow As GridViewRow = DirectCast(btnsubmit.NamingContainer, GridViewRow)
            Dim fid As String = GridView1.DataKeys(gRow.RowIndex).Value.ToString()
            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("APPHARBOR").ConnectionString)
            con.Open()
            Dim DA As New SqlDataAdapter("SELECT * FROM MAINPOPU", con)
            Dim dt As New DataTable
            DA.Fill(dt)
            Dim dv As New DataView(dt)
            dv.RowFilter = "RID='" & fid & "'"
            recid1.Text = GridView1.DataKeys(gRow.RowIndex).Value.ToString()
            If Not IsDBNull(dv(0)("sid")) Then sid.Text = dv(0)("sid").ToString
            If Not IsDBNull(dv(0)("sname")) Then sname.Text = dv(0)("sname").ToString
            If Not IsDBNull(dv(0)("cname")) Then cname.Text = dv(0)("cname").ToString
            If Not IsDBNull(dv(0)("addr")) Then addr.Text = dv(0)("addr")
            If Not IsDBNull(dv(0)("dist")) Then dist.Text = dv(0)("dist")
            If Not IsDBNull(dv(0)("state")) Then state.Text = dv(0)("state")
            If Not IsDBNull(dv(0)("cpn")) Then cpn.Text = dv(0)("cpn")
            If Not IsDBNull(dv(0)("phno")) Then phno.Text = dv(0)("phno")
            If Not IsDBNull(dv(0)("oea")) Then oea.Text = dv(0)("oea")
            If Not IsDBNull(dv(0)("doc")) Then doc.Text = dv(0)("doc")
            If Not IsDBNull(dv(0)("amc")) Then amc.Text = dv(0)("amc")
            If Not IsDBNull(dv(0)("warr")) Then warr.Text = dv(0)("warr")
            If Not IsDBNull(dv(0)("rat_ph")) Then rat_ph.Text = dv(0)("rat_ph")
            If Not IsDBNull(dv(0)("phase")) Then phase.Text = dv(0)("phase")
            If Not IsDBNull(dv(0)("model")) Then model.Text = dv(0)("model")
            If Not IsDBNull(dv(0)("ens")) Then ens.Text = dv(0)("ens")
            If Not IsDBNull(dv(0)("dgno")) Then dgno.Text = dv(0)("dgno")
            If Not IsDBNull(dv(0)("amake")) Then amake.Text = dv(0)("amake")
            If Not IsDBNull(dv(0)("alsn")) Then alsn.Text = dv(0)("alsn")
            If Not IsDBNull(dv(0)("bsn")) Then bsn.Text = dv(0)("bsn")
            If Not IsDBNull(dv(0)("chmr")) Then chmr.Text = dv(0)("chmr")
            If Not IsDBNull(dv(0)("chmd")) Then chmd.Text = dv(0)("chmd")
            If Not IsDBNull(dv(0)("lhmr")) Then Lhmr.Text = dv(0)("lhmr")
            If Not IsDBNull(dv(0)("lsd")) Then lsd.Text = dv(0)("lsd")
            If Not IsDBNull(dv(0)("nsd")) Then nsd.Text = dv(0)("nsd")
            If Not IsDBNull(dv(0)("spin")) Then spin.Text = dv(0)("spin")
            If Not IsDBNull(dv(0)("hmage")) Then hmage.Text = dv(0)("hmage")
            If Not IsDBNull(dv(0)("ahm")) Then ahm.Text = dv(0)("ahm")
            If Not IsDBNull(dv(0)("dpcode")) Then dpcode.Text = dv(0)("dpcode")
            If Not IsDBNull(dv(0)("action")) Then action.Text = dv(0)("action")
            If Not IsDBNull(dv(0)("llop")) Then llop.Text = dv(0)("llop")
            If Not IsDBNull(dv(0)("solenoid")) Then solenoid.Text = dv(0)("solenoid")
            If Not IsDBNull(dv(0)("chalt")) Then chalt.Text = dv(0)("chalt")
            If Not IsDBNull(dv(0)("starter")) Then starter.Text = dv(0)("starter")
            If Not IsDBNull(dv(0)("cnmake")) Then cnmake.Text = dv(0)("cnmake")
            If Not IsDBNull(dv(0)("cntype")) Then cntype.Text = dv(0)("cntype")
            If Not IsDBNull(dv(0)("sauto")) Then sauto.Text = dv(0)("sauto")
            If Not IsDBNull(dv(0)("frame")) Then frame.Text = dv(0)("frame")
            popup.Show()
        Catch ex As Exception
            err_display(ex.Message)
        End Try
    End Sub
    Protected Sub Edit1(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim btnsubmit1 As LinkButton = TryCast(sender, LinkButton)
            Dim gRow As GridViewRow = DirectCast(btnsubmit1.NamingContainer, GridViewRow)
            Dim fid As String = GridView1.DataKeys(gRow.RowIndex).Value.ToString()
            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("APPHARBOR").ConnectionString)
            con.Open()
            Dim DA As New SqlDataAdapter("SELECT * FROM MAINPOPU", con)
            Dim dt As New DataTable
            DA.Fill(dt)
            Dim dv As New DataView(dt)
            dv.RowFilter = "RID='" & fid & "'"
            Dim ENS As String = dv(0)("ENS")
            Dim DA1 As New SqlDataAdapter("SELECT * FROM PMR", con)
            Dim DT1 As New DataTable
            DA1.Fill(DT1)
            Dim dv1 As New DataView(DT1)
            dv1.RowFilter = "ENGINE_No='" & ENS & "'"
            If dv1.Count < 1 Then
                SDTL.Text = "No Records Found!"
                DG1.Visible = False
            Else
                DG1.Visible = True
                SDTL.Text = "SITE NAME:  " & dv1(0)("SNAME") & ",  SITE ID:  " & dv1(0)("SID")
                DG1.DataSource = dv1
                DG1.DataBind()
            End If
            popup1.Show()
        Catch ex As Exception
            err_display(ex.Message)
        End Try
    End Sub

    Private Sub btncls_Click(sender As Object, e As EventArgs) Handles btncls.Click
        recid1.Text = ""
        sid.Text = ""
        sname.Text = ""
        cname.Text = ""
        addr.Text = ""
        dist.Text = ""
        state.Text = ""
        cpn.Text = ""
        phno.Text = ""
        oea.Text = ""
        doc.Text = ""
        amc.Text = ""
        warr.Text = ""
        rat_ph.Text = ""
        phase.Text = ""
        model.Text = ""
        ens.Text = ""
        dgno.Text = ""
        amake.Text = ""
        alsn.Text = ""
        bsn.Text = ""
        chmr.Text = ""
        chmd.Text = ""
        Lhmr.Text = ""
        lsd.Text = ""
        nsd.Text = ""
        spin.Text = ""
        hmage.Text = ""
        ahm.Text = ""
        dpcode.Text = ""
        action.Text = ""
        llop.Text = ""
        chalt.Text = ""
        starter.Text = ""
        solenoid.Text = ""
        frame.Text = ""
        sauto.Text = ""
        cnmake.Text = ""
        cntype.Text = ""
        popup.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("APPHARBOR").ConnectionString)
            con.Open()
            Dim DA As New SqlDataAdapter("SELECT * FROM MAINPOPU", con)
            Dim udt As New SqlCommandBuilder(DA)
            Dim dt As New DataTable
            DA.Fill(dt)
            If recid1.Text <> "" Then
                Dim dv As New DataView(dt)
                dv.RowFilter = "RID='" & recid1.Text & "'"
                dv(0)("sid") = sid.Text
                dv(0)("sname") = sname.Text
                dv(0)("cname") = cname.Text
                dv(0)("addr") = addr.Text
                dv(0)("dist") = dist.Text
                dv(0)("state") = state.Text
                dv(0)("cpn") = cpn.Text
                dv(0)("phno") = phno.Text
                dv(0)("oea") = oea.Text
                dv(0)("doc") = doc.Text
                dv(0)("amc") = amc.Text
                dv(0)("warr") = warr.Text
                dv(0)("rat_ph") = rat_ph.Text
                dv(0)("phase") = phase.Text
                dv(0)("model") = model.Text
                dv(0)("ens") = ens.Text
                dv(0)("dgno") = dgno.Text
                dv(0)("amake") = amake.Text
                dv(0)("alsn") = alsn.Text
                dv(0)("bsn") = bsn.Text
                dv(0)("chmr") = chmr.Text
                If IsDate(chmd.Text) Then dv(0)("chmd") = chmd.Text
                dv(0)("lhmr") = Lhmr.Text
                If IsDate(lsd.Text) Then dv(0)("lsd") = lsd.Text
                If IsDate(nsd.Text) Then dv(0)("nsd") = nsd.Text
                dv(0)("spin") = spin.Text
                dv(0)("hmage") = hmage.Text
                dv(0)("ahm") = ahm.Text
                dv(0)("dpcode") = dpcode.Text
                dv(0)("action") = action.Text
                dv(0)("lmodi") = Format(Now, "ddMMyyyyhhmmssfff") & "A1587"
                dv(0)("llop") = llop.Text
                dv(0)("solenoid") = solenoid.Text
                dv(0)("chalt") = chalt.Text
                dv(0)("starter") = starter.Text
                dv(0)("cnmake") = cnmake.Text
                dv(0)("cntype") = cntype.Text
                dv(0)("sauto") = sauto.Text
                dv(0)("frame") = frame.Text
                DA.Update(dt)
                GridView1.DataBind()
                recid1.Text = ""
                sid.Text = ""
                sname.Text = ""
                cname.Text = ""
                addr.Text = ""
                dist.Text = ""
                state.Text = ""
                cpn.Text = ""
                phno.Text = ""
                oea.Text = ""
                doc.Text = ""
                amc.Text = ""
                warr.Text = ""
                rat_ph.Text = ""
                phase.Text = ""
                model.Text = ""
                ens.Text = ""
                dgno.Text = ""
                amake.Text = ""
                alsn.Text = ""
                bsn.Text = ""
                chmr.Text = ""
                chmd.Text = ""
                Lhmr.Text = ""
                lsd.Text = ""
                nsd.Text = ""
                spin.Text = ""
                hmage.Text = ""
                ahm.Text = ""
                dpcode.Text = ""
                action.Text = ""
                llop.Text = ""
                chalt.Text = ""
                starter.Text = ""
                solenoid.Text = ""
                frame.Text = ""
                sauto.Text = ""
                cnmake.Text = ""
                cntype.Text = ""
            Else
                Dim dr As DataRow = dt.NewRow
                dr("rid1") = Format(Now, "ddMMyyyyhhmmssfff") & "A1587"
                dr("sid") = sid.Text
                dr("sname") = sname.Text
                dr("cname") = cname.Text
                dr("addr") = addr.Text
                dr("dist") = dist.Text
                dr("state") = state.Text
                dr("cpn") = cpn.Text
                dr("phno") = phno.Text
                dr("oea") = oea.Text
                dr("doc") = doc.Text
                dr("amc") = amc.Text
                dr("warr") = warr.Text
                dr("rat_ph") = rat_ph.Text
                dr("phase") = phase.Text
                dr("model") = model.Text
                dr("ens") = ens.Text
                dr("dgno") = dgno.Text
                dr("amake") = amake.Text
                dr("alsn") = alsn.Text
                dr("bsn") = bsn.Text
                dr("chmr") = chmr.Text
                If IsDate(chmd.Text) Then dr("chmd") = chmd.Text
                dr("lhmr") = Lhmr.Text
                If IsDate(lsd.Text) Then dr("lsd") = lsd.Text
                If IsDate(nsd.Text) Then dr("nsd") = nsd.Text
                dr("spin") = spin.Text
                dr("hmage") = hmage.Text
                dr("ahm") = ahm.Text
                dr("dpcode") = dpcode.Text
                dr("action") = action.Text
                dr("lmodi") = Format(Now, "ddMMyyyyhhmmssfff") & "A1587"
                dr("ssta") = "NEW"
                dr("llop") = llop.Text
                dr("solenoid") = solenoid.Text
                dr("chalt") = chalt.Text
                dr("starter") = starter.Text
                dr("cnmake") = cnmake.Text
                dr("cntype") = cntype.Text
                dr("sauto") = sauto.Text
                dr("frame") = frame.Text
                dt.Rows.Add(dr)
                DA.Update(dt)
                GridView1.DataBind()
                recid1.Text = ""
                sid.Text = ""
                sname.Text = ""
                cname.Text = ""
                addr.Text = ""
                dist.Text = ""
                state.Text = ""
                cpn.Text = ""
                phno.Text = ""
                oea.Text = ""
                doc.Text = ""
                amc.Text = ""
                warr.Text = ""
                rat_ph.Text = ""
                phase.Text = ""
                model.Text = ""
                ens.Text = ""
                dgno.Text = ""
                amake.Text = ""
                alsn.Text = ""
                bsn.Text = ""
                chmr.Text = ""
                chmd.Text = ""
                Lhmr.Text = ""
                lsd.Text = ""
                nsd.Text = ""
                spin.Text = ""
                hmage.Text = ""
                ahm.Text = ""
                dpcode.Text = ""
                action.Text = ""
                llop.Text = ""
                chalt.Text = ""
                starter.Text = ""
                solenoid.Text = ""
                frame.Text = ""
                sauto.Text = ""
                cnmake.Text = ""
                cntype.Text = ""
            End If
        Catch ex As Exception
            err_display(ex.Message)
        End Try
    End Sub

    Private Sub Btnfnddg_Click(sender As Object, e As EventArgs) Handles Btnfnddg.Click
        Try
                    Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("APPHARBOR").ConnectionString)
                    con.Open()
                    Dim DA As New SqlDataAdapter("SELECT * FROM MAINPOPU", con)
                    Dim udt As New SqlCommandBuilder(DA)
                    Dim dt As New DataTable
                    DA.Fill(dt)
                    Dim dv As New DataView(dt)
                    dv.RowFilter = "sname like '%" & fnddg.Text & "%'"
                    If dv.Count < 1 Then
                        Label40.Text = "No Record Found"
                        dg2.Visible = False
                    Else
                        dg2.Visible = True
                        Label40.Text = "Total Record Found  " & dv.Count
                        dg2.DataSource = dv
                        dg2.DataBind()
                    End If
                    popup2.Show()
        Catch ex As Exception
            err_display(ex.Message)
        End Try
    End Sub
    Protected Sub fndreco()
        Try
            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("APPHARBOR").ConnectionString)
            con.Open()
            Dim DA As New SqlDataAdapter("SELECT * FROM MAINPOPU", con)
            Dim udt As New SqlCommandBuilder(DA)
            Dim dt As New DataTable
            DA.Fill(dt)
            Dim dv As New DataView(dt)
            dv.RowFilter = "sname like '%" & fnddg.Text & "%'"
            If dv.Count < 1 Then
                Label40.Text = "No Record Found"
                dg2.Visible = False
            Else
                dg2.Visible = True
                Label40.Text = "Total Record Found  " & dv.Count
                dg2.DataSource = dv
                dg2.DataBind()
            End If
            popup2.Show()
        Catch ex As Exception
            err_display(ex.Message)
        End Try
    End Sub

    Private Sub btnexport_Click(sender As Object, e As EventArgs) Handles btnexport.Click
        Try
            ExporttoExcel()
        Catch ex As Exception
            err_display(ex.Message)
        End Try
    End Sub
  
    Protected Sub Edit2(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim btnsubmit1 As LinkButton = TryCast(sender, LinkButton)
            Dim gRow As GridViewRow = DirectCast(btnsubmit1.NamingContainer, GridViewRow)
            Dim fid As String = dg2.DataKeys(gRow.RowIndex).Value.ToString()
            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("APPHARBOR").ConnectionString)
            con.Open()
            Dim DA As New SqlDataAdapter("SELECT * FROM MAINPOPU", con)
            Dim dt As New DataTable
            DA.Fill(dt)
            Dim dv As New DataView(dt)
            dv.RowFilter = "RID='" & fid & "'"
            Dim ENS As String = dv(0)("ENS")
            Dim DA1 As New SqlDataAdapter("SELECT * FROM PMR", con)
            Dim DT1 As New DataTable
            DA1.Fill(DT1)
            Dim dv1 As New DataView(DT1)
            dv1.RowFilter = "ENGINE_No='" & ENS & "'"
            If dv1.Count < 1 Then
                SDTL.Text = "No Records Found!"
                DG1.Visible = False
            Else
                DG1.Visible = True
                SDTL.Text = "SITE NAME:  " & dv1(0)("SNAME") & ",  SITE ID:  " & dv1(0)("SID")
                DG1.DataSource = dv1
                DG1.DataBind()
            End If
            popup1.Show()
        Catch ex As Exception
            err_display(ex.Message)
        End Try
    End Sub
    Protected Sub edit3(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim btnsubmit As LinkButton = TryCast(sender, LinkButton)
            Dim gRow As GridViewRow = DirectCast(btnsubmit.NamingContainer, GridViewRow)
            Dim fid As String = dg2.DataKeys(gRow.RowIndex).Value.ToString()
            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("APPHARBOR").ConnectionString)
            con.Open()
            Dim DA As New SqlDataAdapter("SELECT * FROM MAINPOPU", con)
            Dim dt As New DataTable
            DA.Fill(dt)
            Dim dv As New DataView(dt)
            dv.RowFilter = "RID='" & fid & "'"
            recid1.Text = dg2.DataKeys(gRow.RowIndex).Value.ToString()
            If Not IsDBNull(dv(0)("sid")) Then sid.Text = dv(0)("sid").ToString
            If Not IsDBNull(dv(0)("sname")) Then sname.Text = dv(0)("sname").ToString
            If Not IsDBNull(dv(0)("cname")) Then cname.Text = dv(0)("cname").ToString
            If Not IsDBNull(dv(0)("addr")) Then addr.Text = dv(0)("addr")
            If Not IsDBNull(dv(0)("dist")) Then dist.Text = dv(0)("dist")
            If Not IsDBNull(dv(0)("state")) Then state.Text = dv(0)("state")
            If Not IsDBNull(dv(0)("cpn")) Then cpn.Text = dv(0)("cpn")
            If Not IsDBNull(dv(0)("phno")) Then phno.Text = dv(0)("phno")
            If Not IsDBNull(dv(0)("oea")) Then oea.Text = dv(0)("oea")
            If Not IsDBNull(dv(0)("doc")) Then doc.Text = dv(0)("doc")
            If Not IsDBNull(dv(0)("amc")) Then amc.Text = dv(0)("amc")
            If Not IsDBNull(dv(0)("warr")) Then warr.Text = dv(0)("warr")
            If Not IsDBNull(dv(0)("rat_ph")) Then rat_ph.Text = dv(0)("rat_ph")
            If Not IsDBNull(dv(0)("phase")) Then phase.Text = dv(0)("phase")
            If Not IsDBNull(dv(0)("model")) Then model.Text = dv(0)("model")
            If Not IsDBNull(dv(0)("ens")) Then ens.Text = dv(0)("ens")
            If Not IsDBNull(dv(0)("dgno")) Then dgno.Text = dv(0)("dgno")
            If Not IsDBNull(dv(0)("amake")) Then amake.Text = dv(0)("amake")
            If Not IsDBNull(dv(0)("alsn")) Then alsn.Text = dv(0)("alsn")
            If Not IsDBNull(dv(0)("bsn")) Then bsn.Text = dv(0)("bsn")
            If Not IsDBNull(dv(0)("chmr")) Then chmr.Text = dv(0)("chmr")
            If Not IsDBNull(dv(0)("chmd")) Then chmd.Text = dv(0)("chmd")
            If Not IsDBNull(dv(0)("lhmr")) Then Lhmr.Text = dv(0)("lhmr")
            If Not IsDBNull(dv(0)("lsd")) Then lsd.Text = dv(0)("lsd")
            If Not IsDBNull(dv(0)("nsd")) Then nsd.Text = dv(0)("nsd")
            If Not IsDBNull(dv(0)("spin")) Then spin.Text = dv(0)("spin")
            If Not IsDBNull(dv(0)("hmage")) Then hmage.Text = dv(0)("hmage")
            If Not IsDBNull(dv(0)("ahm")) Then ahm.Text = dv(0)("ahm")
            If Not IsDBNull(dv(0)("dpcode")) Then dpcode.Text = dv(0)("dpcode")
            If Not IsDBNull(dv(0)("action")) Then action.Text = dv(0)("action")
            If Not IsDBNull(dv(0)("llop")) Then llop.Text = dv(0)("llop")
            If Not IsDBNull(dv(0)("solenoid")) Then solenoid.Text = dv(0)("solenoid")
            If Not IsDBNull(dv(0)("chalt")) Then chalt.Text = dv(0)("chalt")
            If Not IsDBNull(dv(0)("starter")) Then starter.Text = dv(0)("starter")
            If Not IsDBNull(dv(0)("cnmake")) Then cnmake.Text = dv(0)("cnmake")
            If Not IsDBNull(dv(0)("cntype")) Then cntype.Text = dv(0)("cntype")
            If Not IsDBNull(dv(0)("sauto")) Then sauto.Text = dv(0)("sauto")
            If Not IsDBNull(dv(0)("frame")) Then frame.Text = dv(0)("frame")
            popup.Show()
        Catch ex As Exception
            err_display(ex.Message)
        End Try
    End Sub
    Protected Sub PMRADD(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim btnsubmit As LinkButton = TryCast(sender, LinkButton)
            Dim gRow As GridViewRow = DirectCast(btnsubmit.NamingContainer, GridViewRow)
            Dim fid As String = GridView1.DataKeys(gRow.RowIndex).Value.ToString()
            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("APPHARBOR").ConnectionString)
            con.Open()
            Dim DA As New SqlDataAdapter("SELECT * FROM MAINPOPU", con)
            Dim dt As New DataTable
            DA.Fill(dt)
            Dim dv As New DataView(dt)
            dv.RowFilter = "RID='" & fid & "'"
            If Not dv.Count < 1 Then
                Engine_no.Text = dv(0)("ENS").ToString
                PMRSID.Text = dv(0)("sid").ToString
                PMRSNAME.Text = dv(0)("sname").ToString
                cust.Text = dv(0)("cname").ToString
                PMRDIST.Text = dv(0)("dist").ToString
                PMRDGNO.Text = dv(0)("DGNO").ToString
                PMRAMAKE.Text = dv(0)("AMAKE").ToString
                PMRALSN.Text = dv(0)("ALSN").ToString
                PMRBSN.Text = dv(0)("BSN").ToString
                PMRWARR.Text = dv(0)("WARR").ToString
                PMROEA.Text = dv(0)("OEA").ToString
                PMRAMC.Text = dv(0)("AMC").ToString
                PMRSTATE.Text = dv(0)("staTE").ToString
                kva.Text = dv(0)("RAT_PH").ToString
                PMRMODEL.Text = dv(0)("MODEL").ToString
                doi.Text = dv(0)("DOc").ToString
            End If
            PMRPOPUP.Show()
        Catch ex As Exception
            err_display(ex.Message)
        End Try
    End Sub

    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        Try
            If IsDate(cdati.Text) = True Then
                Dim span As TimeSpan
                Dim starttime As DateTime = Convert.ToDateTime(DOS.Text)
                Dim endtime As DateTime = Convert.ToDateTime(cdati.Text)
                span = endtime.Subtract(starttime)
                Dim sec As String = span.TotalSeconds
                ttr.Text = Val(sec) / 3600
            End If

            Select Case Val(ttr.Text)
                Case Is >= 72
                    tslot.Text = ">72"
                Case Is >= 48
                    tslot.Text = "48-72"
                Case Is >= 24
                    tslot.Text = "24-48"
                Case Is >= 10
                    tslot.Text = "10-24"
                Case Else
                    tslot.Text = "0-10"
            End Select

            Select Case Val(HMR.Text)
                Case Is >= 15000
                    hmage1.Text = ">15000"
                Case Is >= 12500
                    hmage1.Text = "12500-15000"
                Case Is >= 10000
                    hmage1.Text = "10000-12500"
                Case Is >= 7500
                    hmage1.Text = "7500-10000"
                Case Is >= 5000
                    hmage1.Text = "5000-7500"
                Case Is >= 2500
                    hmage1.Text = "2500-5000"
                Case Else
                    hmage1.Text = "<2500"
            End Select
            If stype1.Text = "OIL SERVICE" Then
                Select Case kva.Text
                    Case "7.5"
                        meterial.Text = "1)LUBE OIL 7.5 LTR , 2)LUBE OIL FILTER 1 NOS , 3)FUEL FILTER 1 NOS"
                    Case "10"
                        meterial.Text = "1)LUBE OIL 7.5 LTR , 2)LUBE OIL FILTER 1 NOS , 3)FUEL FILTER 1 NOS"
                    Case "15"
                        meterial.Text = "1)LUBE OIL 8 LTR , 2)LUBE OIL FILTER 1 NOS , 3)FUEL FILTER 2 NOS"
                    Case "20"
                        meterial.Text = "1)LUBE OIL 9.5 LTR , 2)LUBE OIL FILTER 1 NOS , 3)FUEL FILTER 2 NOS"
                    Case "25"
                        meterial.Text = "1)LUBE OIL 9.5 LTR , 2)LUBE OIL FILTER 1 NOS , 3)FUEL FILTER 2 NOS"
                    Case "30"
                        meterial.Text = "1)LUBE OIL 9.5 LTR , 2)LUBE OIL FILTER 1 NOS , 3)FUEL FILTER 2 NOS"
                    Case "35"
                        meterial.Text = "1)LUBE OIL 9.5 LTR , 2)LUBE OIL FILTER 1 NOS , 3)FUEL FILTER 2 NOS"
                    Case "40"
                        meterial.Text = "1)LUBE OIL 8 LTR , 2)LUBE OIL FILTER 1 NOS , 3)FUEL FILTER 2 NOS"
                    Case "45"
                        meterial.Text = "1)LUBE OIL 8 LTR , 2)LUBE OIL FILTER 1 NOS , 3)FUEL FILTER 2 NOS"
                    Case "62.5"
                        meterial.Text = "1)LUBE OIL 8 LTR , 2)LUBE OIL FILTER 1 NOS , 3)FUEL FILTER 2 NOS"
                End Select
                ccate.Text = "ENGINE"
                Cnat.Text = "NA"
                serv.Text = "NA"
                sta.Text = "CLOSED"
                PMRACTION.Text = "SERVICING DONE"
                rfail.Text = "NA"
            End If


            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("APPHARBOR").ConnectionString)
            con.Open()
            Dim DA As New SqlDataAdapter("SELECT * FROM PMR", con)
            Dim dt As New DataTable
            DA.Fill(dt)
            Dim DA1 As New SqlDataAdapter("SELECT * FROM mainpopu", con)
            Dim dt1 As New DataTable
            DA1.Fill(dt1)

            If IsDate(cdati.Text) Then
                Dim dv1 As New DataView(dt1, "", "ENS", DataViewRowState.CurrentRows)
                Dim index1 As Integer = dv1.Find(Engine_no.Text)
                If Not index1 = -1 Then
                    Dim chmr1 As String = dv1(index1)("chmr") & ""
                    If Val(chmr1) = Val(HMR.Text) Then
                        chmr1 = Val(chmr1) - 0.5
                    End If
                    Dim chmd1 As Date
                    If Not IsDBNull(dv1(index1)("chmd")) Then
                        chmd1 = dv1(index1)("chmd")
                    Else
                        chmd1 = DateAdd(DateInterval.Year, -1, Today)
                    End If

                    Dim DV As New DataView(dt)
                    DV.RowFilter = "engine_no='" & Engine_no.Text & "' and stype='" & "OIL SERVICE" & "'"
                    If DV.Count = 0 Then
                        Dim lasth As String = chmr1
                        Dim lastsd As Date = chmd1
                        Dim csd As Date = cdati.Text
                        If Val(HMR.Text) < Val(lasth) Then
                            ClientScript.RegisterStartupScript(Page.[GetType](), "validation", "<script language='javascript'>alert('Current Hmr is Lower Then The Privious HMR! Please Review')</script>")
                            PMRPOPUP.Show()
                            Exit Sub
                        ElseIf csd < lastsd Then
                            ClientScript.RegisterStartupScript(Page.[GetType](), "validation", "<script language='javascript'>alert('Current Service Date is Older Then The Previous Service Date! Please Review')</script>")
                            PMRPOPUP.Show()
                            Exit Sub
                        Else
                            Dim CURSD As Date = cdati.Text
                            Dim difd As String = DateDiff(DateInterval.Day, lastsd, CURSD)
                            Dim difh As String = Val(HMR.Text) - Val(lasth)
                            Dim avgh As String = difh / difd
                            Dim ab As String
                            ab = 500 / avgh
                            Dim bavg As Date = DateAdd(DateInterval.Day, Val(ab), CURSD)
                            Dim bdt As Date = DateAdd(DateInterval.Month, 6, CURSD)
                            If bavg > bdt Then
                                uname.Text = Format(bdt, "dd-MMMM-yyyy hh:mm:ss tt")
                            Else
                                uname.Text = Format(bavg, "dd-MMMM-yyyy hh:mm:ss tt")
                            End If
                            PMRAHM.Text = avgh
                        End If
                    Else
                        Dim I As Integer = DV.Count - 1
                        Dim lasth As String = DV(I)("HMR") & ""
                        Dim lastsd As Date = DV(I)("cdati") & ""
                        Dim csd As Date = cdati.Text
                        If Val(HMR.Text) < Val(lasth) Then
                            ClientScript.RegisterStartupScript(Page.[GetType](), "validation", "<script language='javascript'>alert('Current Hmr is Lower Then The Privious HMR! Please Review')</script>")
                            PMRPOPUP.Show()
                            Exit Sub
                        ElseIf csd < lastsd Then
                            ClientScript.RegisterStartupScript(Page.[GetType](), "validation", "<script language='javascript'>alert('Current Service Date is Older Then The Previous Service Date! Please Review')</script>")
                            PMRPOPUP.Show()
                            Exit Sub
                        Else
                            Dim CURSD As Date = cdati.Text
                            Dim difd As String = DateDiff(DateInterval.Day, lastsd, CURSD)
                            Dim difh As String = Val(HMR.Text) - Val(lasth)
                            Dim avgh As String = difh / difd
                            Dim ab As String
                            ab = 500 / avgh
                            Dim bavg As Date = DateAdd(DateInterval.Day, Val(ab), CURSD)
                            Dim bdt As Date = DateAdd(DateInterval.Month, 6, CURSD)
                            If bavg > bdt Then
                                uname.Text = Format(bdt, "dd-MMMM-yyyy hh:mm:ss tt")
                            Else
                                uname.Text = Format(bavg, "dd-MMMM-yyyy hh:mm:ss tt")
                            End If
                            PMRAHM.Text = avgh
                        End If
                    End If
                End If
            End If
            PMRPOPUP.Show()
        Catch ex As Exception
            err_display(ex.Message)
        End Try
    End Sub

    Private Sub PMRSAVE_Click(sender As Object, e As EventArgs) Handles PMRSAVE.Click
        Try
            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("APPHARBOR").ConnectionString)
            con.Open()
            Dim DA As New SqlDataAdapter("SELECT * FROM PMR", con)
            Dim dabld As New SqlCommandBuilder(DA)
            Dim dt As New DataTable
            DA.Fill(dt)
            Dim DA1 As New SqlDataAdapter("SELECT * FROM mainpopu", con)
            Dim dabld1 As New SqlCommandBuilder(DA1)
            Dim dt1 As New DataTable
            DA1.Fill(dt1)
                Dim dr As DataRow = dt.NewRow
            dr("sid") = PMRSID.Text
            dr("sname") = PMRSNAME.Text
                dr("engine_no") = Engine_no.Text
                If IsDate(DOS.Text) Then dr("dos") = DOS.Text
                dr("stype") = stype1.Text
                dr("hmr") = HMR.Text
                dr("report") = reportNo.Text
                dr("Technician") = technician.Text
                dr("METERIAL") = meterial.Text
                dr("cust") = cust.Text
                If IsDate(cdati.Text) Then dr("cdati") = cdati.Text
            dr("dist") = PMRDIST.Text
                dr("sta") = sta.Text
            dr("DGNO") = PMRDGNO.Text
            dr("AMAKE") = PMRAMAKE.Text
            dr("ALSN") = PMRALSN.Text
            dr("BSN") = PMRBSN.Text
                dr("sLA") = sla.Text
                dr("RESLA") = resla.Text
                dr("TTR") = ttr.Text
                dr("TSLOT") = tslot.Text
                dr("RFAIL") = rfail.Text
            dr("ACTION") = PMRACTION.Text
            dr("WARR") = PMRWARR.Text
            dr("OEA") = PMROEA.Text
            dr("AMC") = PMRAMC.Text
            dr("staTE") = PMRSTATE.Text
                dr("CCATE") = ccate.Text
                dr("CNAT") = Cnat.Text
                dr("sERV") = serv.Text
            dr("DPCODE") = PMRDPCODE.Text
                dr("KVA") = kva.Text
            dr("MODEL") = PMRMODEL.Text
                dr("DOI") = doi.Text
                dr("ssta") = "NEW"
                dr("lmodi") = Format(Now, "ddMMyyyyhhmmssfff") & "A1587"
                dr("recid") = Format(Now, "ddMMyyyyhhmmssfff") & "A1587"
                dt.Rows.Add(dr)

                Dim dv As New DataView(dt1, "", "ENS", DataViewRowState.CurrentRows)
                Dim index As Integer = dv.Find(Engine_no.Text)
                If Not index = -1 Then
                    dv(index)("chmr") = HMR.Text
                    If IsDate(cdati.Text) Then dv(index)("chmd") = cdati.Text
                    dv(index)("SSTA") = "MOD"
                    dv(index)("hmage") = hmage1.Text
                dv(index)("LMODI") = Format(Now, "ddMMyyyyhhmmssfff") & "A1587"
                dv(index)("AHM") = PMRAHM.Text
                dv(index)("action") = PMRACTION.Text
                    If stype1.Text = "OIL SERVICE" Then
                        dv(index)("LHMR") = HMR.Text
                        dv(index)("LSD") = cdati.Text
                        If IsDate(uname.Text) Then dv(index)("NSD") = uname.Text
                    End If
                End If
                DA.Update(dt)
                DA1.Update(dt1)
                recid1.Text = ""
            PMRSID.Text = ""
            PMRSNAME.Text = ""
                Engine_no.Text = ""
                DOS.Text = ""

                HMR.Text = ""
                reportNo.Text = ""
                technician.Text = ""
                meterial.Text = ""
                cust.Text = ""
                cdati.Text = ""
            PMRDIST.Text = ""
                sta.Text = ""
            PMRDGNO.Text = ""
            PMRAMAKE.Text = ""
            PMRALSN.Text = ""
            PMRBSN.Text = ""
                sla.Text = ""
                resla.Text = ""
                ttr.Text = ""
                tslot.Text = ""
                rfail.Text = ""
            PMRACTION.Text = ""
            PMRWARR.Text = ""
            PMROEA.Text = ""
            PMRAMC.Text = ""
            PMRSTATE.Text = ""
                ccate.Text = ""
                Cnat.Text = ""
                serv.Text = ""
            PMRDPCODE.Text = ""
                kva.Text = ""
                model.Text = ""
                doi.Text = ""
                uname.Text = ""
                hmage1.Text = ""
            PMRAHM.Text = ""
                GridView1.DataBind()
        Catch ex As Exception
            err_display(ex.Message)
        End Try
    End Sub
    Protected Sub PMRADDDG2(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim btnsubmit As LinkButton = TryCast(sender, LinkButton)
            Dim gRow As GridViewRow = DirectCast(btnsubmit.NamingContainer, GridViewRow)
            Dim fid As String = dg2.DataKeys(gRow.RowIndex).Value.ToString()
            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("APPHARBOR").ConnectionString)
            con.Open()
            Dim DA As New SqlDataAdapter("SELECT * FROM MAINPOPU", con)
            Dim dt As New DataTable
            DA.Fill(dt)
            Dim dv As New DataView(dt)
            dv.RowFilter = "RID='" & fid & "'"
            If Not dv.Count < 1 Then
                Engine_no.Text = dv(0)("ENS").ToString
                PMRSID.Text = dv(0)("sid").ToString
                PMRSNAME.Text = dv(0)("sname").ToString
                cust.Text = dv(0)("cname").ToString
                PMRDIST.Text = dv(0)("dist").ToString
                PMRDGNO.Text = dv(0)("DGNO").ToString
                PMRAMAKE.Text = dv(0)("AMAKE").ToString
                PMRALSN.Text = dv(0)("ALSN").ToString
                PMRBSN.Text = dv(0)("BSN").ToString
                PMRWARR.Text = dv(0)("WARR").ToString
                PMROEA.Text = dv(0)("OEA").ToString
                PMRAMC.Text = dv(0)("AMC").ToString
                PMRSTATE.Text = dv(0)("staTE").ToString
                kva.Text = dv(0)("RAT_PH").ToString
                PMRMODEL.Text = dv(0)("MODEL").ToString
                doi.Text = dv(0)("DOc").ToString
            End If
            PMRPOPUP.Show()
        Catch ex As Exception
            err_display(ex.Message)
        End Try
    End Sub
    Protected Sub err_display(ByVal msg As String)
        errdisplay.Text = msg
        errpopup.Show()
    End Sub

    Private Sub ExporttoExcel()
        Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("APPHARBOR").ConnectionString)
        con.Open()
        Dim DA As New SqlDataAdapter("SELECT cname as CUSTOMER, sname as SITE_NAME, SID AS SITE_ID, ENS AS ENGINE_NO, RAT_PH AS RATING, PHASE, MODEL, DIST AS DISTRICT, STATE, CPN AS CONTACT_PERSON, PHNO AS PHONE_NO, addr as ADDRESS, AMAKE AS ALT_MAKE, ALSN AS ALT_SR_NO, BSN AS BATTERY_SR_NO, DGNO AS DG_SET_NO, CHMR AS CURRENT_HMR, LHMR AS LAST_PM_HMR, LSD AS LAST_PM_DATE, NSD AS NEXT_PM_DATE, AHM AS AVG_HMR, HMAGE AS HMR_AGEING  FROM MAINPOPU", con)
        Dim dt As New DataTable
        DA.Fill(dt)
        HttpContext.Current.Response.Clear()
        HttpContext.Current.Response.ClearContent()
        HttpContext.Current.Response.ClearHeaders()
        HttpContext.Current.Response.Buffer = True
        HttpContext.Current.Response.ContentType = "application/ms-excel"
        HttpContext.Current.Response.Write("<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.0 Transitional//EN"">")
        HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment;filename=Reports.xls")

        HttpContext.Current.Response.Charset = "utf-8"
        HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.GetEncoding("windows-1250")
        'sets font
        HttpContext.Current.Response.Write("<font style='font-size:10.0pt; font-family:Calibri;'>")
        HttpContext.Current.Response.Write("<BR><BR><BR>")
        'sets the table border, cell spacing, border color, font of the text, background, foreground, font height
        HttpContext.Current.Response.Write("<Table border='1' bgColor='#ffffff' " + "borderColor='#000000' cellSpacing='0' cellPadding='0' " + "style='font-size:10.0pt; font-family:Calibri; background:white;'> <TR>")
        'am getting my grid's column headers
        Dim columnscount As Integer = dt.Columns.Count

        For j As Integer = 0 To columnscount - 1
            'write in new column
            HttpContext.Current.Response.Write("<Td>")
            'Get column headers  and make it as bold in excel columns
            HttpContext.Current.Response.Write("<B>")
            HttpContext.Current.Response.Write(dt.Columns(j).ToString)
            HttpContext.Current.Response.Write("</B>")
            HttpContext.Current.Response.Write("</Td>")
        Next
        HttpContext.Current.Response.Write("</TR>")
        For Each row As DataRow In dt.Rows
            'write in new row
            HttpContext.Current.Response.Write("<TR>")
            For i As Integer = 0 To dt.Columns.Count - 1
                HttpContext.Current.Response.Write("<Td>")
                HttpContext.Current.Response.Write(row(i).ToString())
                HttpContext.Current.Response.Write("</Td>")
            Next

            HttpContext.Current.Response.Write("</TR>")
        Next
        HttpContext.Current.Response.Write("</Table>")
        HttpContext.Current.Response.Write("</font>")
        HttpContext.Current.Response.Flush()
        HttpContext.Current.Response.[End]()
    End Sub
End Class