Imports Microsoft.Win32
Imports System.ComponentModel
Imports System.Security.Principal
Public Class Form2
    Private keyName As String = "HKEY_CURRENT_USER\YasmineAntiAfk"
    Dim Sound As Boolean
    Dim Exc As Boolean
    Dim loclvl As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newloc()
        Dim registeredValueStartup As Object = Registry.GetValue(keyName, "YasmineAntiAfkStartup", False)

        If Not registeredValueStartup Is Nothing AndAlso CStr(registeredValueStartup) = "Checked" Then
            CheckBox1.Checked = True
        End If
        Dim registeredValue12 As Object = Registry.GetValue(keyName, "YasmineAntiAfk12", False)

        If Not registeredValue12 Is Nothing AndAlso CStr(registeredValue12) = "Checked" Then
            CheckBox8.Checked = True
        End If
        Dim registeredValue11 As Object = Registry.GetValue(keyName, "YasmineAntiAfk11", False)

        If Not registeredValue11 Is Nothing AndAlso CStr(registeredValue11) = "Checked" Then
            CheckBox7.Checked = True
        End If
        Dim registeredValue10 As Object = Registry.GetValue(keyName, "YasmineAntiAfk10", False)

        If Not registeredValue10 Is Nothing AndAlso CStr(registeredValue10) = "Checked" Then
            CheckBox6.Checked = True
        End If
        Dim registeredValueNotif As Object = Registry.GetValue(keyName, "YasmineAntiAfkNotif", False)

        If Not registeredValueNotif Is Nothing AndAlso CStr(registeredValueNotif) = "Checked" Then
            CheckBox2.Checked = True
        End If
        Dim registeredValue As Object = Registry.GetValue(keyName, "YasmineAntiAfk", False)

        If Not registeredValue Is Nothing AndAlso CStr(registeredValue) = "Checked" Then
            CheckBox3.Checked = True
        End If
        Dim registeredValueALT As Object = Registry.GetValue(keyName, "YasmineAntiAfkALT", False)

        If Not registeredValueALT Is Nothing AndAlso CStr(registeredValueALT) = "Checked" Then
            CheckBox4.Checked = True
        End If
        Dim registeredValue6 As Object = Registry.GetValue(keyName, "YasmineAntiAfk6", False)

        If Not registeredValue6 Is Nothing AndAlso CStr(registeredValue6) = "Checked" Then
            CheckBox5.Checked = True
        End If
        Dim registeredValue8 As Object = Registry.GetValue(keyName, "YasmineAntiAfk8", False)

        If Not registeredValue8 Is Nothing AndAlso CStr(registeredValue8) = "True" Then
            RadioButton1.Checked = True
        End If
        Dim registeredValue9 As Object = Registry.GetValue(keyName, "YasmineAntiAfk9", False)

        If Not registeredValue9 Is Nothing AndAlso CStr(registeredValue9) = "True" Then
            RadioButton2.Checked = True
        End If
        Dim registeredValueSong1 As Object = Registry.GetValue(keyName, "YasmineAntiAfkSong1", False)

        If Not registeredValueSong1 Is Nothing Then
            TextBox1.Text = registeredValueSong1
        End If
        If TextBox1.Text = "False" Then TextBox1.Text = ""
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then RadioButton1.Checked = True
        If CheckBox5.Checked = True And RadioButton2.Checked = True Then
            GroupBox2.Visible = True
            GroupBox4.Location = New Point(12, 248)
            Sound = True
        Else
            GroupBox2.Visible = False
            GroupBox4.Location = New Point(12, 152)
            Sound = False
        End If
        If CheckBox7.Checked = False Then
            GroupBox4.Visible = False
            Exc = False
        Else
            GroupBox4.Visible = True
            Exc = True
        End If
        newloc()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("This application is coded by Jev1337" + Environment.NewLine + "Made specifically for Discord." + Environment.NewLine + Environment.NewLine + "v4.6 Public.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Registry.SetValue(keyName, "YasmineAntiAfkStartup", CheckBox1.CheckState)
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Registry.SetValue(keyName, "YasmineAntiAfk", CheckBox3.CheckState)
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Registry.SetValue(keyName, "YasmineAntiAfkALT", CheckBox4.CheckState)
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        Registry.SetValue(keyName, "YasmineAntiAfk6", CheckBox5.CheckState)
        If CheckBox5.Checked = True And RadioButton2.Checked = True Then
            GroupBox2.Visible = True
            GroupBox4.Location = New Point(12, 248)
            Sound = True
        Else
            GroupBox2.Visible = False
            GroupBox4.Location = New Point(12, 152)
            Sound = False
        End If
        newloc()
    End Sub

    Private Sub newloc()
        If Exc = False And Sound = False Then
            GroupBox3.Size = New Size(298, 166)
            RichTextBox1.Size = New Size(284, 141)
            Button1.Location = New Point(242, 152)
            Button2.Location = New Point(118, 152)
            Button4.Location = New Point(12, 152)
            If Button4.Text = "Show Changelog" Then
                Me.Size = New Size(426, 223)
            Else
                Me.Size = New Size(734, 223)
            End If
            loclvl = 1
        End If
        If Exc = False And Sound = True Then
            GroupBox3.Size = New Size(298, 262)
            RichTextBox1.Size = New Size(284, 237)
            Button1.Location = New Point(242, 248)
            Button2.Location = New Point(118, 248)
            Button4.Location = New Point(12, 248)
            If Button4.Text = "Show Changelog" Then
                Me.Size = New Size(426, 319)
            Else
                Me.Size = New Size(734, 319)
            End If
            loclvl = 2
        End If
        If Exc = True And Sound = False Then
            GroupBox3.Size = New Size(298, 297)
            RichTextBox1.Size = New Size(284, 272)
            Button1.Location = New Point(242, 283)
            Button2.Location = New Point(118, 283)
            Button4.Location = New Point(12, 283)
            If Button4.Text = "Show Changelog" Then
                Me.Size = New Size(426, 354)
            Else
                Me.Size = New Size(734, 354)
            End If
            loclvl = 3
        End If
        If Exc = True And Sound = True Then
            GroupBox3.Size = New Size(298, 393)
            RichTextBox1.Size = New Size(284, 368)
            Button1.Location = New Point(242, 379)
            Button2.Location = New Point(118, 379)
            Button4.Location = New Point(12, 379)
            If Button4.Text = "Show Changelog" Then
                Me.Size = New Size(426, 452)
            Else
                Me.Size = New Size(734, 452)
            End If
            loclvl = 4
        End If
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        e.Cancel = True
    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim registeredValueSong1 As Object = Registry.GetValue(keyName, "YasmineAntiAfkSong1", False)
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Choose Song"
        If registeredValueSong1 Is Nothing Then fd.InitialDirectory = "C:\" Else fd.InitialDirectory = registeredValueSong1
        fd.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            TextBox1.Text = strFileName
            Registry.SetValue(keyName, "YasmineAntiAfkSong1", TextBox1.Text)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Registry.SetValue(keyName, "YasmineAntiAfk8", RadioButton1.Checked)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Registry.SetValue(keyName, "YasmineAntiAfk9", RadioButton2.Checked)
        If CheckBox5.Checked = True And RadioButton2.Checked = True Then
            GroupBox2.Visible = True
            GroupBox4.Location = New Point(12, 248)
            Sound = True
        Else
            GroupBox2.Visible = False
            GroupBox4.Location = New Point(12, 152)
            Sound = False
        End If
        newloc()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Registry.SetValue(keyName, "YasmineAntiAfkSong1", TextBox1.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "Show Changelog" Then Button4.Text = "Hide Changelog" Else Button4.Text = "Show Changelog"
        If Button4.Text = "Show Changelog" Then
            newloc()
        End If
        If Button4.Text = "Hide Changelog" Then
            If loclvl = 1 Then
                Me.Size = New Size(734, 223)
            End If
            If loclvl = 2 Then
                Me.Size = New Size(734, 318)
            End If
            If loclvl = 3 Then
                Me.Size = New Size(734, 354)
            End If
            If loclvl = 4 Then
                Me.Size = New Size(734, 452)
            End If
        End If
    End Sub
    Private Sub RichTextBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles RichTextBox1.MouseDown
        Button1.Focus()
    End Sub
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Registry.SetValue(keyName, "YasmineAntiAfkNotif", CheckBox2.CheckState)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            Dim fileName = FolderBrowserDialog1.SelectedPath
            Dim FILE_NAME As String = fileName & "\AntiAFK.bat"

            Dim sTextFile As New System.Text.StringBuilder



            sTextFile.AppendLine("@ECHO OFF")
            sTextFile.AppendLine(":start")
            sTextFile.AppendLine("echo set WshShell = CreateObject(""WScript.Shell"") >alttab.vbs")
            sTextFile.AppendLine("cls")


            If Form1.CheckBox1.Checked = True Then
                sTextFile.AppendLine("echo WshShell.Sendkeys ""%%%{TAB}"" >>alttab.vbs")
                sTextFile.AppendLine("echo WScript.Sleep 200 >>alttab.vbs")
                sTextFile.AppendLine("echo WshShell.Sendkeys ""%%%{TAB}"" >>alttab.vbs")
                sTextFile.AppendLine("cls")
            End If
            sTextFile.AppendLine("echo WScript.Sleep 200 >>alttab.vbs")
            If Form1.CheckBox2.Checked = True And Form1.RadioButton2.Checked = True Then
                If Form1.ComboBox1.SelectedItem = "CTRL+V" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""^{V}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "ALT+F4" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""%{F4}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "ALT+TAB" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""%({TAB}{TAB}{TAB}{TAB})"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "ALT+ESC" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""%{ESC}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "Windows Button" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""^{ESC}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "Enter Button" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""{Enter}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "Help Button" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""{Help}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "Printscreen Button" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""{PrtScr}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "Tab Button" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""{Tab}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "Backspace Button" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""{BS}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "Delete Button" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""{Del}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "Insert Button" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""{Ins}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "Left Arrow Button" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""{Left}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "Right Arrow Button" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""{Right}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "Up Arrow Button" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""{Up}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "Down Arrow Button" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""{Down}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "PageUp Button" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""{PgUp}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "PageDown Button" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""{PgDn}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "Home Button" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""{Home}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "End Button" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""{End}"" >>alttab.vbs")
                End If
                If Form1.ComboBox1.SelectedItem = "!" Then
                    sTextFile.AppendLine("echo WshShell.Sendkeys ""{!}"" >>alttab.vbs")
                End If

                sTextFile.AppendLine("cls")
            End If
            If Form1.CheckBox2.Checked = True And Form1.RadioButton2.Checked = False Then
                sTextFile.AppendLine("echo WshShell.Sendkeys """ & Form1.TextBox2.Text & """ >>alttab.vbs")
                sTextFile.AppendLine("cls")
            End If
            sTextFile.AppendLine("cscript alttab.vbs")
            sTextFile.AppendLine("cls")
            If Form1.ComboBox2.Text = "m" Then
                sTextFile.AppendLine("timeout " & Form1.TextBox1.Text * 60 & " /nobreak")
                sTextFile.AppendLine("cls")
            End If
            If Form1.ComboBox2.Text = "s" Then
                sTextFile.AppendLine("timeout " & Form1.TextBox1.Text & " /nobreak")
                sTextFile.AppendLine("cls")
            End If
            If Form1.ComboBox2.Text = "h" Then
                sTextFile.AppendLine("timeout " & Form1.TextBox1.Text * 3600 & " /nobreak")
            End If
            sTextFile.AppendLine("del alttab.vbs")
            sTextFile.AppendLine("cls")
            sTextFile.AppendLine("goto start")
            sTextFile.AppendLine("cls")

            Dim FileDelete As String

            FileDelete = fileName & "\AntiAFK.bat"

            If System.IO.File.Exists(FileDelete) = True Then
                System.IO.File.Delete(FileDelete)
                MessageBox.Show("Similar Script Detected! Continuing will overwrite existing script!" & Environment.NewLine & "File Location: " & fileName & "\AntiAFK.bat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
            System.IO.File.AppendAllText(FILE_NAME, sTextFile.ToString)

            MessageBox.Show("Script Successfully Created!" & Environment.NewLine & "File Location: " & fileName & "\AntiAFK.bat", "Script Created", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest_1(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        Registry.SetValue(keyName, "YasmineAntiAfk10", CheckBox6.CheckState)
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub CheckedListBox1_ValueMemberChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.ValueMemberChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CheckedListBox1.Items.Clear()
        Dim P As Process
        For Each P In Process.GetProcesses()
            CheckedListBox1.Items.Add(P.ProcessName, CheckState.Unchecked)
        Next
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        Registry.SetValue(keyName, "YasmineAntiAfk11", CheckBox7.CheckState)
        If CheckBox7.Checked = False Then
            GroupBox4.Visible = False
            Exc = False
        Else
            GroupBox4.Visible = True
            Exc = True
        End If
        newloc()
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        Registry.SetValue(keyName, "YasmineAntiAfk12", CheckBox8.CheckState)
        If CheckBox8.Checked = True Then
            Form1.BackgroundImage = My.Resources.unnamed
            Me.BackgroundImage = My.Resources.unnamed
            Form1.GroupBox1.ForeColor = Color.White
            Form1.GroupBox2.ForeColor = Color.White
            Form1.CheckBox1.ForeColor = Color.White
            Form1.CheckBox2.ForeColor = Color.White
            Form1.RadioButton1.ForeColor = Color.White
            Form1.RadioButton2.ForeColor = Color.White
            Form1.Label5.ForeColor = Color.White
            Form1.Label3.ForeColor = Color.White
            Form1.Label2.ForeColor = Color.White
            Form1.ContextMenuStrip1.BackgroundImage = My.Resources.unnamed
            Form1.ShowToolStripMenuItem.ForeColor = Color.White
            Form1.EnableANTIAFKToolStripMenuItem.ForeColor = Color.White
            Form1.AboutToolStripMenuItem.ForeColor = Color.White
            Form1.ToolStripMenuItem1.ForeColor = Color.White
            Form1.ExitToolStripMenuItem.ForeColor = Color.White


            Label1.ForeColor = Color.White
            GroupBox2.ForeColor = Color.White
            GroupBox3.ForeColor = Color.White
            GroupBox4.ForeColor = Color.White
            CheckBox1.ForeColor = Color.White
            CheckBox2.ForeColor = Color.White
            CheckBox3.ForeColor = Color.White
            CheckBox4.ForeColor = Color.White
            CheckBox5.ForeColor = Color.White
            CheckBox6.ForeColor = Color.White
            CheckBox7.ForeColor = Color.White
            CheckBox8.ForeColor = Color.White
            RadioButton1.ForeColor = Color.White
            RadioButton2.ForeColor = Color.White
            TabPage1.BackgroundImage = My.Resources.unnamed
            TabPage2.BackgroundImage = My.Resources.unnamed
            TabPage3.BackgroundImage = My.Resources.unnamed
        Else
            TabPage1.BackgroundImage = Nothing
            TabPage2.BackgroundImage = Nothing
            TabPage3.BackgroundImage = Nothing
            Me.BackgroundImage = Nothing
            Form1.BackgroundImage = Nothing
            Form1.GroupBox1.ForeColor = Color.Black
            Form1.GroupBox2.ForeColor = Color.Black
            Form1.CheckBox1.ForeColor = Color.Black
            Form1.CheckBox2.ForeColor = Color.Black
            Form1.RadioButton1.ForeColor = Color.Black
            Form1.RadioButton2.ForeColor = Color.Black
            Form1.Label5.ForeColor = Color.Black
            Form1.Label3.ForeColor = Color.Black
            Form1.Label2.ForeColor = Color.Black
            Form1.ContextMenuStrip1.BackgroundImage = Nothing
            Form1.ShowToolStripMenuItem.ForeColor = Color.Black
            Form1.EnableANTIAFKToolStripMenuItem.ForeColor = Color.Black
            Form1.AboutToolStripMenuItem.ForeColor = Color.Black
            Form1.ToolStripMenuItem1.ForeColor = Color.Black
            Form1.ExitToolStripMenuItem.ForeColor = Color.Black

            Label1.ForeColor = Color.Black
            GroupBox2.ForeColor = Color.Black
            GroupBox3.ForeColor = Color.Black
            GroupBox4.ForeColor = Color.Black
            CheckBox1.ForeColor = Color.Black
            CheckBox2.ForeColor = Color.Black
            CheckBox3.ForeColor = Color.Black
            CheckBox4.ForeColor = Color.Black
            CheckBox5.ForeColor = Color.Black
            CheckBox6.ForeColor = Color.Black
            CheckBox7.ForeColor = Color.Black
            CheckBox8.ForeColor = Color.Black
            RadioButton1.ForeColor = Color.Black
            RadioButton2.ForeColor = Color.Black
            RichTextBox1.ForeColor = Color.Black

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        If CheckBox1.Checked = True Then
            If isElevated = False Then
                CheckBox1.Checked = False
                MessageBox.Show("Please run this application as administrator in order to use this feature!")
            Else
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
                CheckBox1.Checked = True
            End If
        Else
            If isElevated = False Then
                CheckBox1.Checked = True
                MessageBox.Show("Please run this application as administrator in order to disable!")
            Else
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
                CheckBox1.Checked = False
            End If
        End If
    End Sub

    Private Sub CheckBox1_MouseHover(sender As Object, e As EventArgs) Handles CheckBox1.MouseHover
        ToolTip1.SetToolTip(CheckBox1, "Starts program on Windows Startup")
    End Sub

    Private Sub CheckBox3_MouseHover(sender As Object, e As EventArgs) Handles CheckBox3.MouseHover
        ToolTip1.SetToolTip(CheckBox3, "Minimizes application to tray when you click Enable")
    End Sub

    Private Sub CheckBox6_MouseHover(sender As Object, e As EventArgs) Handles CheckBox6.MouseHover
        ToolTip1.SetToolTip(CheckBox6, "Automatically Enables itself when you start the program")
    End Sub

    Private Sub CheckBox2_MouseHover(sender As Object, e As EventArgs) Handles CheckBox2.MouseHover
        ToolTip1.SetToolTip(CheckBox2, "Do you want to be notified?")
    End Sub

    Private Sub CheckBox4_MouseHover(sender As Object, e As EventArgs) Handles CheckBox4.MouseHover
        ToolTip1.SetToolTip(CheckBox4, "Enable this if Auto Alttab doesn't work")
    End Sub

    Private Sub CheckBox8_MouseHover(sender As Object, e As EventArgs) Handles CheckBox8.MouseHover
        ToolTip1.SetToolTip(CheckBox8, "Darker for a better experience")
    End Sub

    Private Sub CheckBox7_MouseHover(sender As Object, e As EventArgs) Handles CheckBox7.MouseHover
        ToolTip1.SetToolTip(CheckBox7, "Enable exceptions here so you won't get disturbed, Auto is better, trust me")
    End Sub

    Private Sub CheckBox9_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox9_MouseHover(sender As Object, e As EventArgs)
        ToolTip1.SetToolTip(CheckBox9, "Click to see the beauty")
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        ToolTip1.SetToolTip(Button5, "Saves this as a script to make it portable")
    End Sub

    Private Sub CheckBox5_MouseHover(sender As Object, e As EventArgs) Handles CheckBox5.MouseHover
        ToolTip1.SetToolTip(CheckBox5, "Automatically plays a song when you Enable the program")
    End Sub

    Private Sub CheckBox9_CheckedChanged_2(sender As Object, e As EventArgs)
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs)
    End Sub

    Private Sub Timer1_Tick_2(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Dim wsh
        'wsh = CreateObject("Wscript.Shell")
        'Dim time As String = Format(Now, "hh:mm:ss tt")
        'If time = "12:00:00 AM" Then

        '    wsh.sendkeys("Before we start, this message is created by Yasmine ANTI-AFK Annivaresary Version: Hey babe, I wanna say that, Happy 1 year annivaresary")
        '    Threading.Thread.Sleep(100)
        '    wsh.sendkeys(" It's been the best year in my life, and I'm happy that I got to spend it with you rahter than anyone else, Having you by my side makes me the happiest, most grateful and luckiest person in the world.")
        '    Threading.Thread.Sleep(100)
        '    wsh.sendkeys(" Thanks for spending this year with me and I'm looking forward to make it even longer so I can live longer with a happy life (aka with you), Ik you miss minecraft and you're probably sayin we shouldve written")
        '    Threading.Thread.Sleep(100)
        '    wsh.sendkeys(" there instead, sorry, Happy 1 year ANNIVERSARY and don't worry I love you more and more every year and it only grows stronger with the years that pass")
        '    Threading.Thread.Sleep(100)
        '    wsh.sendkeys("{ENTER}")
        'End If
    End Sub

    Private Sub Button7_Click_2(sender As Object, e As EventArgs)
        Keyboard.Show()
    End Sub

    Private Sub Button7_Click_3(sender As Object, e As EventArgs) Handles Button7.Click
        Keyboard.Show()
        MsgBox("Modifications made here will not be corrected in the Anti AFK System!" & Environment.NewLine & "If you wish use Keyboard Locker with the Anti AFK System, then please use the checkbox in the main form that says 'Lock Keyboard'.")
    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Process.Start("cmd.exe", "/c REG EXPORT HKEY_CURRENT_USER\YasmineAntiAfk ExportedSettingsYAAFK.reg")
        MsgBox("Saved next to Yasmine Anti AFK Executable Location")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim strpath As String = My.Application.Info.DirectoryPath
        If My.Computer.FileSystem.FileExists(strpath + "\ExportedSettingsYAAFK.reg") = False Then
            MsgBox("File not found! Please place the exported settings next to the executable!")
        Else
            Process.Start("cmd.exe", "/c /s REG IMPORT ExportedSettingsYAAFK.reg")
            MsgBox("Settings Imported! Please restart the application.")
            End
        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim strpath As String = My.Application.Info.DirectoryPath
        Process.Start(strpath)
    End Sub
End Class