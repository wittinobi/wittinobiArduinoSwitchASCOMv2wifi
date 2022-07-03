Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Net
Imports ASCOM.Utilities
Imports ASCOM.wittinobiArduinoSwitchASCOMv2wifiDRIVER

<ComVisible(False)>
Public Class SetupDialogForm

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click ' OK button event handler
        ' Persist new values of user settings to the ASCOM profile
        Switch.comPort = TextBoxIP.Text
        Switch.numSwitch = ComboBoxnumSwitch.SelectedItem ' Update the state variables with results from the dialogue
        Switch.SwitchName0 = TextBoxSwitchName0.Text
        Switch.SwitchName1 = TextBoxSwitchName1.Text
        Switch.SwitchName2 = TextBoxSwitchName2.Text
        Switch.SwitchName3 = TextBoxSwitchName3.Text
        Switch.SwitchName4 = TextBoxSwitchName4.Text
        Switch.SwitchName5 = TextBoxSwitchName5.Text
        Switch.SwitchName6 = TextBoxSwitchName6.Text
        Switch.SwitchName7 = TextBoxSwitchName7.Text
        Dim httpRequest As HttpWebRequest
        httpRequest = HttpWebRequest.Create("http://" + Switch.comPort.ToString() + "/?MAXSWITCH=" + Switch.numSwitch.ToString())
        Dim httpResponse As HttpWebResponse
        httpResponse = httpRequest.GetResponse()
        Using reader As New System.IO.StreamReader(httpResponse.GetResponseStream())
            reader.ReadToEnd()
        End Using
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click 'Cancel button event handler
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ShowAscomWebPage(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick, PictureBox1.Click
        ' Click on ASCOM logo event handler
        Try
            System.Diagnostics.Process.Start("https://ascom-standards.org/")
        Catch noBrowser As System.ComponentModel.Win32Exception
            If noBrowser.ErrorCode = -2147467259 Then
                MessageBox.Show(noBrowser.Message)
            End If
        Catch other As System.Exception
            MessageBox.Show(other.Message)
        End Try
    End Sub

    Private Sub SetupDialogForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load ' Form load event handler
        ' Retrieve current values of user settings from the ASCOM Profile
        InitUI()
    End Sub

    Private Sub InitUI()
        TextBoxIP.Text = Switch.comPort
        ComboBoxnumSwitch.SelectedItem = Switch.numSwitch
        TextBoxSwitchName0.Text = Switch.SwitchName0
        TextBoxSwitchName1.Text = Switch.SwitchName1
        TextBoxSwitchName2.Text = Switch.SwitchName2
        TextBoxSwitchName3.Text = Switch.SwitchName3
        TextBoxSwitchName4.Text = Switch.SwitchName4
        TextBoxSwitchName5.Text = Switch.SwitchName5
        TextBoxSwitchName6.Text = Switch.SwitchName6
        TextBoxSwitchName7.Text = Switch.SwitchName7
    End Sub

End Class
