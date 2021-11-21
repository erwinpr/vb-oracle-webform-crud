Imports System.Data.OleDb

Public Class Index
    Inherits System.Web.UI.Page

    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim str As String

    Public du As New DBUtils
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Connect()
    End Sub

    Protected Sub Connect()
        Try
            str = "Provider=ORAOLEDB.ORACLE;Data Source=localhost:1521/XEPDB1;User Id=erwinpr;Password=erwinpr;"
            'conn = New OleDbConnection("Provider=ORAOLEDB.ORACLE;User ID=erwinpr;Password=erwinpr;database=XEPDB1")
            'conn = New OleDbConnection(str)
            'conn.Open()
            du.ConnectionString = str
            FillDGR()
        Catch ex As Exception
            LB_ERR.Text = ex.Message
        End Try
    End Sub

    Protected Sub FillDGR()
        du.QueryString = "select * from test"
        DGR_TEST.DataSource = du.GetDataTable()
        DGR_TEST.DataBind()

        LB_ERR.Text = du.GetDataTable.Rows.Count.ToString

        For i As Integer = 0 To DGR_TEST.Items.Count - 1
            Dim lb As LinkButton = DGR_TEST.Items(i).FindControl("LB_NOMOR")
            lb.Text = DGR_TEST.Items(i).Cells(1).Text
        Next
    End Sub

    Protected Sub BT_SAVE_Click(sender As Object, e As EventArgs)
        'du.QueryString = "exec SP_PRODUCT_UPSERT '" + TXT_CD.Text + "','" + TXT_NAME.Text + "','LOAN'"
        'du.ExecuteNonQuery()
        'FillDGR()
    End Sub

    Protected Sub DGR_TEST_PageIndexChanged(source As Object, e As DataGridPageChangedEventArgs)
        DGR_TEST.CurrentPageIndex = e.NewPageIndex
        FillDGR()
    End Sub

    Protected Sub DGR_TEST_ItemCommand(source As Object, e As DataGridCommandEventArgs)
        If e.CommandName = "Edit" Then
            TXT_NOMOR.Text = e.Item.Cells(1).Text
            TXT_KETERANGAN.Text = e.Item.Cells(2).Text
        End If
    End Sub
End Class