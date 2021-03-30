Imports AxSHDocVw

Public Class tab
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxWebBrowser1.GoBack()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWebBrowser1.GoForward()
    End Sub

    Private Sub AxWebBrowser1_NavigateComplete2(sender As Object, e As DWebBrowserEvents2_NavigateComplete2Event) Handles AxWebBrowser1.NavigateComplete2
        Parent.Text = AxWebBrowser1.LocationName
    End Sub

    Private Sub NewTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTabToolStripMenuItem.Click
        Dim t As New TabPage
        Dim newtab As New tab
        newtab.Show()
        newtab.TopLevel = False
        newtab.Dock = DockStyle.Fill
        t.Controls.Add(newtab)
        Form1.TabControl1.TabPages.Add(t)
    End Sub

    Private Sub RemoveTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveTabToolStripMenuItem.Click
        Form1.TabControl1.TabPages.Remove(Form1.TabControl1.SelectedTab)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Form1.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWebBrowser1.Refresh()
    End Sub

    Private Sub tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWebBrowser1.Navigate("http://google.com")
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        settings.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If My.Settings.search = 1 Then
            AxWebBrowser1.Navigate("http://www.google.com/#sclient=psy&hl=en&site=&source=hp&q=" + TextBox2.Text)
        End If
        If My.Settings.search = 2 Then
            AxWebBrowser1.Navigate("https://search.yahoo.com/search?p=" + TextBox2.Text)
        End If
        If My.Settings.search = 3 Then
            AxWebBrowser1.Navigate("https://www.bing.com/search?q=" + TextBox2.Text)
        End If
    End Sub

    Private Sub AxWebBrowser1_Enter(sender As Object, e As EventArgs) Handles AxWebBrowser1.Enter

    End Sub

    Private Sub AxWebBrowser1_NewWindow2(sender As Object, e As DWebBrowserEvents2_NewWindow2Event) Handles AxWebBrowser1.NewWindow2
        Dim t As New TabPage
        Dim newtab As New tab
        newtab.Show()
        newtab.TopLevel = False
        newtab.Dock = DockStyle.Fill
        t.Controls.Add(newtab)
        Form1.TabControl1.TabPages.Add(t)
    End Sub
End Class