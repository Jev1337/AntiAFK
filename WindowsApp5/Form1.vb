Imports Microsoft.Win32
Imports System.Reflection
Public Class Form1
    Private keyName As String = "HKEY_CURRENT_USER\YasmineAntiAfk"
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Dim Stat As Boolean
    Dim Integral As Integer = -1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        enableyasmine()
    End Sub

    Private Sub alttabinterval_Tick(sender As Object, e As EventArgs) Handles alttabinterval.Tick
        If GetActiveWindow <> Me.Handle And GetActiveWindow <> Form2.Handle Then
            Dim wsh
            wsh = CreateObject("Wscript.Shell")
            If CheckBox1.Checked = True Then
                If Form2.CheckBox4.Checked = True Then
                    wsh.SendKeys("%({TAB}{TAB}{TAB}{TAB})")
                    Threading.Thread.Sleep(200)
                    wsh.SendKeys("%({TAB}{TAB}{TAB}{TAB})")
                Else
                    wsh.SendKeys("%{TAB}")
                    Threading.Thread.Sleep(200)
                    wsh.SendKeys("%{TAB}")
                End If
            End If
            If CheckBox2.Checked = True Then
                If RadioButton2.Checked = True Then
                    If ComboBox1.SelectedItem = "CTRL+V" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("^{V}")
                    End If
                    If ComboBox1.SelectedItem = "ALT+F4" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("%{F4}")
                    End If
                    If ComboBox1.SelectedItem = "ALT+TAB" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("%({TAB}{TAB}{TAB}{TAB})")
                    End If
                    If ComboBox1.SelectedItem = "ALT+ESC" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("%{ESC}")
                    End If
                    If ComboBox1.SelectedItem = "Windows Button" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("^{ESC}")
                    End If
                    If ComboBox1.SelectedItem = "Enter Button" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("{Enter}")
                    End If
                    If ComboBox1.SelectedItem = "Help Button" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("{Help}")
                    End If
                    If ComboBox1.SelectedItem = "Printscreen Button" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("{Prtsc}")
                    End If
                    If ComboBox1.SelectedItem = "Tab Button" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("{Tab}")
                    End If
                    If ComboBox1.SelectedItem = "Backspace Button" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("{BS}")
                    End If
                    If ComboBox1.SelectedItem = "Delete Button" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("{Del}")
                    End If
                    If ComboBox1.SelectedItem = "Insert Button" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("{Ins}")
                    End If
                    If ComboBox1.SelectedItem = "Left Arrow Button" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("{Left}")
                    End If
                    If ComboBox1.SelectedItem = "Right Arrow Button" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("{Right}")
                    End If
                    If ComboBox1.SelectedItem = "Up Arrow Button" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("{Up}")
                    End If
                    If ComboBox1.SelectedItem = "Down Arrow Button" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("{Down}")
                    End If
                    If ComboBox1.SelectedItem = "PageUp Button" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("{PgUp}")
                    End If
                    If ComboBox1.SelectedItem = "PageDown Button" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("{PgDn}")
                    End If
                    If ComboBox1.SelectedItem = "Home Button" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("{Home}")
                    End If
                    If ComboBox1.SelectedItem = "End Button" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("{End}")
                    End If
                    If ComboBox1.SelectedItem = "!" Then
                        Threading.Thread.Sleep(400)
                        wsh.sendkeys("{!}")
                    End If
                Else
                    Threading.Thread.Sleep(400)
                    wsh.sendkeys(TextBox2.Text)
                End If
            End If
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub AutoTimer_Tick(sender As Object, e As EventArgs) Handles AutoTimer.Tick
        Dim Inter As Integer
        Inter = 60000
        If ComboBox2.SelectedItem = "s" Then Inter = 1000
        If ComboBox2.SelectedItem = "m" Then Inter = 60000
        If ComboBox2.SelectedItem = "h" Then Inter = 3600000
        If CheckBox3.Checked = True Then
            alttabinterval.Interval = ((TextBox1.Text * Inter) - 1000) \ 2
        Else
            alttabinterval.Interval = (TextBox1.Text * Inter) - 1000
        End If
        SystemIdleTimer1.MaxIdleTime = CUInt(alttabinterval.Interval / 1000)

        If CheckBox3.Checked = True Then
            SystemIdleTimer1.MaxIdleTime = CUInt(alttabinterval.Interval / 1000)
            If Stat = True Then
                If Button1.Text = "Enable" Then
                    enableyasmine()
                End If
            Else
                If Button1.Text = "Disable" Then
                    Integral += 1
                    Label10.Text = "Auto - " & Integral & " times"
                    If Label10.Text = "Auto - 0 times" Then
                        Label10.Text = "Auto"
                    End If
                    If Label10.Text = "Auto - 1 times" Then
                        Label10.Text = "Auto - 1 time"
                    End If
                    ToolStripMenuItem3.Text = Label10.Text
                        enableyasmine()
                    End If
                End If
        End If
    End Sub
    Private Sub Checker_Tick(sender As Object, e As EventArgs) Handles Checker.Tick
        Label6.Text = (Label6.Text - 1)
        If Label6.Text = 0 Then Label6.Text = alttabinterval.Interval / 1000
        Dim total_seconds As Integer
        total_seconds = Label6.Text
        Label7.Text = (total_seconds \ 60) \ 60
        Label8.Text = (total_seconds - (Label7.Text * 60 * 60)) \ 60
        Label9.Text = total_seconds - ((Label7.Text * 3600) + (Label8.Text * 60))
        If Label8.Text < 10 And Label9.Text < 10 Then
            ToolStripMenuItem2.Text = ("Time Left: " & Label7.Text & ":0" & Label8.Text & ":0" & Label9.Text)
        Else
            If Label8.Text < 10 Then
                ToolStripMenuItem2.Text = ("Time Left: " & Label7.Text & ":0" & Label8.Text & ":" & Label9.Text)
            Else
                If Label9.Text < 10 Then
                    ToolStripMenuItem2.Text = ("Time Left: " & Label7.Text & ":" & Label8.Text & ":0" & Label9.Text)
                Else
                    ToolStripMenuItem2.Text = ("Time Left: " & Label7.Text & ":" & Label8.Text & ":" & Label9.Text)
                End If
            End If
        End If
        Label5.Text = ToolStripMenuItem2.Text
        StatusToolStripMenuItem.Text = Label4.Text
        If Label4.Text = "Enabled" Then EnableANTIAFKToolStripMenuItem.Checked = True
        If Label4.Text = "Disabled" Then EnableANTIAFKToolStripMenuItem.Checked = False
        If Form2.CheckBox7.Checked = True Then
            If Label6.Text = 1 Then
                If Form2.CheckedListBox1.CheckedItems.Count <> 0 Then
                    Dim x As Integer
                    Dim s As String = ""
                    Dim k As String
                    For x = 0 To Form2.CheckedListBox1.CheckedItems.Count - 1
                        k = Form2.CheckedListBox1.CheckedItems(x).ToString
                        s = s & "Checked Item " & (x + 1).ToString & " = " & k & ControlChars.CrLf
                    Next x
                    Dim pName As String = k
                    Dim psList() As Process
                    Try
                        psList = Process.GetProcesses()

                        For Each p As Process In psList
                            If (pName = p.ProcessName) Then
                                enableyasmine()
                                If Form2.CheckBox2.Checked = True Then
                                    If CheckBox3.Checked = False Then
                                        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                                        NotifyIcon1.BalloonTipText = "Anti AFK has been stopped by a running application!"
                                        NotifyIcon1.BalloonTipTitle = "AntiAFK"
                                        NotifyIcon1.ShowBalloonTip(3000)
                                    End If
                                End If
                                    Exit For
                            End If
                        Next p
                    Catch ex As Exception
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Registry.SetValue(keyName, "YasmineAntiAfk1", CheckBox1.CheckState)

    End Sub

    Private Sub CheckBox2_Check(sender As Object, e As EventArgs) Handles CheckBox2.Click
        If CheckBox1.Checked = False Then
            MessageBox.Show("You cannot disabled both options!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            CheckBox2.Checked = True
        End If

    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox2.Checked = False Then
            MessageBox.Show("You cannot disabled both options!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            CheckBox1.Checked = True
        End If
    End Sub
    ' Return True if another instance
    ' of this program is already running.
    Private Function AlreadyRunning() As Boolean
        Dim my_proc As Process = Process.GetCurrentProcess
        Dim my_name As String = my_proc.ProcessName
        Dim procs() As Process =
        Process.GetProcessesByName(my_name)
        If procs.Length = 1 Then Return False
        Dim i As Integer
        For i = 0 To procs.Length - 1
            If procs(i).StartTime < my_proc.StartTime Then _
            Return True
        Next i
        Return False
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AlreadyRunning() Then
            MessageBox.Show("Another instance is already running.", "Already Running", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
        End If

        Dim registeredValue12 As Object = Registry.GetValue(keyName, "YasmineAntiAfk12", False)

        If Not registeredValue12 Is Nothing AndAlso CStr(registeredValue12) = "Checked" Then
            Form2.CheckBox8.Checked = True
        End If

        If Form2.CheckBox8.Checked = True Then
            Me.BackgroundImage = My.Resources.unnamed
            Me.GroupBox1.ForeColor = Color.White
            Me.GroupBox2.ForeColor = Color.White
            Me.CheckBox1.ForeColor = Color.White
            Me.CheckBox2.ForeColor = Color.White
            Me.RadioButton1.ForeColor = Color.White
            Me.RadioButton2.ForeColor = Color.White
            Me.Label5.ForeColor = Color.White
            Me.Label3.ForeColor = Color.White
            Me.Label2.ForeColor = Color.White
            Me.ContextMenuStrip1.BackgroundImage = My.Resources.unnamed
            Me.ShowToolStripMenuItem.ForeColor = Color.White
            Me.EnableANTIAFKToolStripMenuItem.ForeColor = Color.White
            Me.AboutToolStripMenuItem.ForeColor = Color.White
            Me.ToolStripMenuItem1.ForeColor = Color.White
            Me.ExitToolStripMenuItem.ForeColor = Color.White

            Form2.TabPage1.BackgroundImage = My.Resources.unnamed
            Form2.TabPage2.BackgroundImage = My.Resources.unnamed
            Form2.TabPage3.BackgroundImage = My.Resources.unnamed
            Form2.BackgroundImage = My.Resources.unnamed
            Form2.Label1.ForeColor = Color.White
            Form2.GroupBox2.ForeColor = Color.White
            Form2.GroupBox3.ForeColor = Color.White
            Form2.GroupBox4.ForeColor = Color.White
            Form2.CheckBox1.ForeColor = Color.White
            Form2.CheckBox2.ForeColor = Color.White
            Form2.CheckBox3.ForeColor = Color.White
            Form2.CheckBox4.ForeColor = Color.White
            Form2.CheckBox5.ForeColor = Color.White
            Form2.CheckBox6.ForeColor = Color.White
            Form2.CheckBox7.ForeColor = Color.White
            Form2.CheckBox8.ForeColor = Color.White
            Form2.RadioButton1.ForeColor = Color.White
            Form2.RadioButton2.ForeColor = Color.White
        Else
            Me.BackgroundImage = Nothing
            Me.GroupBox1.ForeColor = Color.Black
            Me.GroupBox2.ForeColor = Color.Black
            Me.CheckBox1.ForeColor = Color.Black
            Me.CheckBox2.ForeColor = Color.Black
            Me.RadioButton1.ForeColor = Color.Black
            Me.RadioButton2.ForeColor = Color.Black
            Me.Label5.ForeColor = Color.Black
            Me.Label3.ForeColor = Color.Black
            Me.Label2.ForeColor = Color.Black
            Me.ContextMenuStrip1.BackgroundImage = Nothing
            Me.ShowToolStripMenuItem.ForeColor = Color.Black
            Me.EnableANTIAFKToolStripMenuItem.ForeColor = Color.Black
            Me.AboutToolStripMenuItem.ForeColor = Color.Black
            Me.ToolStripMenuItem1.ForeColor = Color.Black
            Me.ExitToolStripMenuItem.ForeColor = Color.Black

            Form2.TabPage1.BackgroundImage = Nothing
            Form2.TabPage2.BackgroundImage = Nothing
            Form2.TabPage3.BackgroundImage = Nothing
            Form2.BackgroundImage = Nothing
            Form2.BackgroundImage = Nothing
            Form2.Label1.ForeColor = Color.Black
            Form2.GroupBox2.ForeColor = Color.Black
            Form2.GroupBox3.ForeColor = Color.Black
            Form2.GroupBox4.ForeColor = Color.Black
            Form2.CheckBox1.ForeColor = Color.Black
            Form2.CheckBox2.ForeColor = Color.Black
            Form2.CheckBox3.ForeColor = Color.Black
            Form2.CheckBox4.ForeColor = Color.Black
            Form2.CheckBox5.ForeColor = Color.Black
            Form2.CheckBox6.ForeColor = Color.Black
            Form2.CheckBox7.ForeColor = Color.Black
            Form2.CheckBox8.ForeColor = Color.Black
            Form2.RadioButton1.ForeColor = Color.Black
            Form2.RadioButton2.ForeColor = Color.Black
            Form2.RichTextBox1.ForeColor = Color.Black
        End If

        Dim P As Process
        For Each P In Process.GetProcesses()
            Form2.CheckedListBox1.Items.Add(P.ProcessName, CheckState.Unchecked)
        Next

        Dim registeredValueStartup As Object = Registry.GetValue(keyName, "YasmineAntiAfkStartup", False)

        If Not registeredValueStartup Is Nothing AndAlso CStr(registeredValueStartup) = "Checked" Then
            Form2.CheckBox1.Checked = True
        End If
        Dim registeredValue11 As Object = Registry.GetValue(keyName, "YasmineAntiAfk11", False)

        If Not registeredValue11 Is Nothing AndAlso CStr(registeredValue11) = "Checked" Then
            Form2.CheckBox7.Checked = True
        End If
        Dim registeredValue10 As Object = Registry.GetValue(keyName, "YasmineAntiAfk10", False)

        If Not registeredValue10 Is Nothing AndAlso CStr(registeredValue10) = "Checked" Then
            Form2.CheckBox6.Checked = True
        End If
        Dim registeredValueNotif As Object = Registry.GetValue(keyName, "YasmineAntiAfkNotif", False)

        If Not registeredValueNotif Is Nothing AndAlso CStr(registeredValueNotif) = "Checked" Then
            Form2.CheckBox2.Checked = True
        End If
        Dim registeredValueSong1 As Object = Registry.GetValue(keyName, "YasmineAntiAfkSong1", False)

        If Not registeredValueSong1 Is Nothing Then
            Form2.TextBox1.Text = registeredValueSong1
        End If
        Dim registeredValue8 As Object = Registry.GetValue(keyName, "YasmineAntiAfk8", False)

        If Not registeredValue8 Is Nothing AndAlso CStr(registeredValue8) = "Checked" Then
            Form2.RadioButton1.Checked = True
        End If
        Dim registeredValue9 As Object = Registry.GetValue(keyName, "YasmineAntiAfk9", False)

        If Not registeredValue9 Is Nothing AndAlso CStr(registeredValue9) = "Checked" Then
            Form2.RadioButton2.Checked = True
        End If
        Dim registeredValue6 As Object = Registry.GetValue(keyName, "YasmineAntiAfk6", False)

        If Not registeredValue6 Is Nothing AndAlso CStr(registeredValue6) = "Checked" Then
            Form2.CheckBox5.Checked = True
        End If

        Dim registeredValueALT As Object = Registry.GetValue(keyName, "YasmineAntiAfkALT", False)

        If Not registeredValueALT Is Nothing AndAlso CStr(registeredValueALT) = "Checked" Then
            Form2.CheckBox4.Checked = True
        End If

        Dim registeredValue As Object = Registry.GetValue(keyName, "YasmineAntiAfk", False)

        If Not registeredValue Is Nothing AndAlso CStr(registeredValue) = "Checked" Then
            Form2.CheckBox3.Checked = True
        End If

        Dim registeredValue1 As Object = Registry.GetValue(keyName, "YasmineAntiAfk1", False)

        If Not registeredValue1 Is Nothing AndAlso CStr(registeredValue1) = "Checked" Then
            CheckBox1.Checked = True
        End If

        Dim registeredValue2 As Object = Registry.GetValue(keyName, "YasmineAntiAfk2", False)

        If Not registeredValue2 Is Nothing AndAlso CStr(registeredValue2) = "Checked" Then
            CheckBox2.Checked = True
        End If

        Dim registeredValueTimer As Object = Registry.GetValue(keyName, "YasmineAntiAfkTimer", False)

        If Not registeredValueTimer Is Nothing Then
            TextBox1.Text = registeredValueTimer
        End If
        If TextBox1.Text = "False" Then TextBox1.Text = ""

        Dim registeredValue3 As Object = Registry.GetValue(keyName, "YasmineAntiAfk3", False)

        If Not registeredValue3 Is Nothing AndAlso CStr(registeredValue3) = "True" Then
            RadioButton2.Checked = False
            RadioButton1.Checked = True
            TextBox2.Visible = True
            ComboBox1.Visible = False

        End If
        Dim registeredValueText As Object = Registry.GetValue(keyName, "YasmineAntiAfkText", False)

        If Not registeredValueText Is Nothing Then
            TextBox2.Text = registeredValueText

        End If
        If TextBox2.Text = "False" Then TextBox2.Text = ""
        Dim registeredValueSelected As Object = Registry.GetValue(keyName, "YasmineAntiAfkSelected", False)

        If Not registeredValueSelected Is Nothing Then
            ComboBox1.SelectedItem = registeredValueSelected
        End If

        Dim registeredValue4 As Object = Registry.GetValue(keyName, "YasmineAntiAfk4", False)

        If Not registeredValue4 Is Nothing AndAlso CStr(registeredValue4) = "True" Then
            RadioButton2.Checked = True
            RadioButton1.Checked = False
        End If
        Dim registeredValueSelected2 As Object = Registry.GetValue(keyName, "YasmineAntiAfkSelected2", False)

        If Not registeredValueSelected2 Is Nothing Then
            ComboBox2.SelectedItem = registeredValueSelected2
        End If
        Dim registeredValueKb As Object = Registry.GetValue(keyName, "YasmineAntiAfkKb", False)

        If Not registeredValueKb Is Nothing AndAlso CStr(registeredValueKb) = "Checked" Then
            CheckBox4.Checked = True
        End If

        If RadioButton1.Checked = False Then
            If RadioButton2.Checked = False Then
                RadioButton2.Checked = True
            End If
        End If
        If CheckBox1.Checked = False And CheckBox2.Checked = False Then
            CheckBox2.Checked = True
        End If
        If TextBox1.Text = "" Then TextBox1.Text = "30"
        If TextBox2.Text = "" Then TextBox2.Text = "Sample Text"
        If ComboBox1.SelectedItem = "" Then ComboBox1.SelectedItem = "!"
        If ComboBox2.SelectedItem = "" Then ComboBox2.SelectedItem = "m"
        Dim registeredValue13 As Object = Registry.GetValue(keyName, "YasmineAntiAfk13", False)
        If Not registeredValue13 Is Nothing AndAlso CStr(registeredValue13) = "Checked" Then
            CheckBox3.Checked = True
        End If
        If Form2.CheckBox6.Checked = True Then
            enableyasmine()
        End If
       
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            If Form2.CheckBox2.Checked = True Then
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.BalloonTipTitle = "Yasmine ANTI-AFK"
                NotifyIcon1.BalloonTipText = "Now hidden In the system tray's hidden icons"
                NotifyIcon1.ShowBalloonTip(50000)
            End If
            ShowInTaskbar = False
            Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
        End If
    End Sub
    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub
    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.FormBorderStyle = FormBorderStyle.Fixed3D
            ShowInTaskbar = True
            Me.WindowState = FormWindowState.Normal
            NotifyIcon1.Visible = False
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This application is coded by Malek for Yasmine(the cutest girl alive)", "About", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub EnableANTIAFKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableANTIAFKToolStripMenuItem.Click
        enableyasmine()
        If Label4.Text = "Enabled" Then
            If Form2.CheckBox2.Checked = True Then
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.BalloonTipText = "Enabled!"
                NotifyIcon1.BalloonTipTitle = "AntiAFK"
                NotifyIcon1.ShowBalloonTip(2000)
            End If
        End If
        If Label4.Text = "Disabled" Then
            If Form2.CheckBox2.Checked = True Then
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.BalloonTipText = "Disabled!"
                NotifyIcon1.BalloonTipTitle = "AntiAFK"
                NotifyIcon1.ShowBalloonTip(2000)
            End If
        End If
    End Sub
    Private Sub SystemIdleTimer1_OnEnterIdleState(ByVal sender As System.Object, ByVal e As EdinDazdarevic.IdleEventArgs) Handles SystemIdleTimer1.OnEnterIdleState
        Stat = True
    End Sub

    Private Sub SystemIdleTimer1_OnExitIdleState(ByVal sender As System.Object, ByVal e As EdinDazdarevic.IdleEventArgs) Handles SystemIdleTimer1.OnExitIdleState
        Stat = False
    End Sub
    Private Sub enableyasmine()
        Dim Inter As Integer
        Inter = 60000
        If ComboBox2.SelectedItem = "s" Then Inter = 1000
        If ComboBox2.SelectedItem = "m" Then Inter = 60000
        If ComboBox2.SelectedItem = "h" Then Inter = 3600000
        Dim Audi As String
        If Form2.RadioButton1.Checked = True Then
            Audi = "C:\Users\" & Environment.UserName & "\OneDrive\Our Files\Yasmine Anti-AFK\Our_Song.mp3"
        Else
            Audi = Form2.TextBox1.Text
        End If

        Dim audio As New AudioFile(Audi)

        If Button1.Text = "Enable" Then
            If IsNumeric(TextBox1.Text) = False Or Integer.Parse(TextBox1.Text) < 1 Then
                MessageBox.Show("Only numbers that are over 1 are allowed in timer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                TextBox1.Text = "1"
            End If
            If CheckBox3.Checked = True Then
                alttabinterval.Interval = (((Integer.Parse(TextBox1.Text) * Inter) - 1000) \ 2)
            Else
                alttabinterval.Interval = (Integer.Parse(TextBox1.Text) * Inter)
            End If
                Button1.Text = "Disable"
                alttabinterval.Start()
                Checker.Start()
                ComboBox2.Enabled = False
                TextBox1.Enabled = False
                Label4.Text = "Enabled"
                Label4.ForeColor = System.Drawing.Color.DarkGreen
                Label6.Text = alttabinterval.Interval / 1000
                Label7.Visible = True
                Label8.Visible = True
                Label9.Visible = True
                Label5.Visible = True
                If CheckBox3.Checked = True Then
                    Label5.Visible = False
                End If
                ToolStripMenuItem2.Visible = True
                If Form2.CheckBox5.Checked = True Then
                    If CheckBox3.Checked = False Then
                        audio.Play()
                    End If
                End If
                If Form2.CheckBox3.Checked = True Then
                    Me.WindowState = FormWindowState.Minimized
                End If

                Else
            Button1.Text = "Enable"
            alttabinterval.Stop()
            Checker.Stop()
            Label4.Text = "Disabled"
            If CheckBox3.Checked = False Then
                ComboBox2.Enabled = True
                TextBox1.Enabled = True
            End If
            Label4.ForeColor = System.Drawing.Color.Maroon
            Label6.Text = "-"
            Label7.Text = "-"
            Label8.Text = "-"
            Label9.Text = "-"
            Label5.Text = "Time Left: -:--:--"
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            Label5.Visible = False
            If CheckBox3.Checked = True Then
                Label10.Visible = True
            End If
            Label8.Location = New Point(101, 197)
            Label9.Location = New Point(134, 197)
            If CheckBox3.Checked = False Then
                audio.Stop()
                audio.Close()
            End If
            ToolStripMenuItem2.Visible = False
        End If
        StatusToolStripMenuItem.Text = Label4.Text
        If Label4.Text = "Enabled" Then EnableANTIAFKToolStripMenuItem.Checked = True
        If Label4.Text = "Disabled" Then EnableANTIAFKToolStripMenuItem.Checked = False
        'HERE
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Registry.SetValue(keyName, "YasmineAntiAfkText", TextBox2.Text)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Registry.SetValue(keyName, "YasmineAntiAfk3", RadioButton1.Checked)
        If RadioButton1.Checked = False Then ComboBox1.Visible = True Else ComboBox1.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton2.Checked = False Then TextBox2.Visible = True Else TextBox2.Visible = False
        Registry.SetValue(keyName, "YasmineAntiAfk4", RadioButton2.Checked)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub

    Private Sub StatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusToolStripMenuItem.Click
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Registry.SetValue(keyName, "YasmineAntiAfk2", CheckBox2.CheckState)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Registry.SetValue(keyName, "YasmineAntiAfkTimer", TextBox1.Text)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Registry.SetValue(keyName, "YasmineAntiAfkSelected", ComboBox1.SelectedItem)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form2.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub DetectAFK_Tick(sender As Object, e As EventArgs)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Registry.SetValue(keyName, "YasmineAntiAfkSelected2", ComboBox2.SelectedItem)
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub CheckBox3_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Registry.SetValue(keyName, "YasmineAntiAfk13", CheckBox3.CheckState)
        If Integer.Parse(TextBox1.Text) < 1 Then
            If CheckBox3.Checked = True Then
                MessageBox.Show("Only numbers over 1 are allowed in timer while using Auto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                TextBox1.Text = "1"
            End If
            CheckBox3.Checked = False
        Else
            If SystemIdleTimer1.IsRunning = False Then
                CheckBox3.Checked = True
                'SystemIdleTimer1.MaxIdleTime = CUInt(numOfSeconds.Value * 1000) ' seconds to miliseconds 
                SystemIdleTimer1.Start()
                AutoTimer.Start()
                Label10.Visible = True
                If Label4.Text = "Enabled" Then
                    enableyasmine()
                End If
                Button1.Enabled = False
                ToolStripMenuItem3.Visible = True
                StatusToolStripMenuItem.Visible = False
                ToolStripMenuItem2.Visible = False
                EnableANTIAFKToolStripMenuItem.Visible = False
                Label3.Visible = False
                Label4.Visible = False
                TextBox1.Enabled = False
                ComboBox2.Enabled = False
                Form2.CheckBox5.Enabled = False
                Form2.RadioButton1.Enabled = False
                Form2.RadioButton2.Enabled = False
                Form2.CheckBox5.Checked = False
            Else
                CheckBox3.Checked = False
                SystemIdleTimer1.Stop()
                Label10.Visible = False
                AutoTimer.Stop()
                Button1.Enabled = True
                ToolStripMenuItem3.Visible = False
                StatusToolStripMenuItem.Visible = True
                ToolStripMenuItem2.Visible = True
                EnableANTIAFKToolStripMenuItem.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                TextBox1.Enabled = True
                ComboBox2.Enabled = True
                Form2.CheckBox5.Enabled = True
                Form2.RadioButton1.Enabled = True
                Form2.RadioButton2.Enabled = True
            End If
        End If
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        ToolTip1.SetToolTip(Label2, "Do action every <Time> <In Seconds/Minutes/Hours>")
    End Sub

    Private Sub CheckBox1_MouseHover(sender As Object, e As EventArgs) Handles CheckBox1.MouseHover
        ToolTip1.SetToolTip(CheckBox1, "Automatically Alt Tabs")
    End Sub

    Private Sub CheckBox3_MouseHover(sender As Object, e As EventArgs) Handles CheckBox3.MouseHover
        ToolTip1.SetToolTip(CheckBox3, "Automatically enables when user is AFK (USES TIMER!)")
    End Sub

    Private Sub CheckBox2_MouseHover(sender As Object, e As EventArgs) Handles CheckBox2.MouseHover
        ToolTip1.SetToolTip(CheckBox2, "Automatically types something for you")
    End Sub

    Private Sub ComboBox2_MouseHover(sender As Object, e As EventArgs) Handles ComboBox2.MouseHover
        ToolTip1.SetToolTip(ComboBox2, "Timer Mesure as Integer")
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        ToolTip1.SetToolTip(CheckBox1, "Settings")
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            If RadioButton1.Checked = True Then
                CheckBox4.Checked = False
                MessageBox.Show("Keyboard Lock is not supported with Custom mode! Try using Functions!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ToolStripMenuItem4.Checked = True
                Keyboard.LockAll()
                If Form2.CheckBox2.Checked = True Then
                    NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                    NotifyIcon1.BalloonTipText = "Keyboard Has Been Locked!"
                    NotifyIcon1.BalloonTipTitle = "AntiAFK"
                    NotifyIcon1.ShowBalloonTip(2000)
                End If
            End If
        Else
            ToolStripMenuItem4.Checked = False
            Keyboard.UnlockAll()
        End If
        Registry.SetValue(keyName, "YasmineAntiAfkKb", CheckBox4.CheckState)
    End Sub

    Private Sub CheckBox4_Click(sender As Object, e As EventArgs) Handles CheckBox4.Click

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        If CheckBox4.Checked Then
            CheckBox4.Checked = False
            MessageBox.Show("Warning! Keyboard Lock is not supported with Custom mode! Keyboard lock has been disabled!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        If ToolStripMenuItem4.Checked Then
            CheckBox4.Checked = True
        Else
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs) Handles ContextMenuStrip1.Click
    End Sub
End Class
