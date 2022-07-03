<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupDialogForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetupDialogForm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelCopyRight = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxSwitchName7 = New System.Windows.Forms.TextBox()
        Me.TextBoxSwitchName6 = New System.Windows.Forms.TextBox()
        Me.TextBoxSwitchName5 = New System.Windows.Forms.TextBox()
        Me.TextBoxSwitchName4 = New System.Windows.Forms.TextBox()
        Me.TextBoxSwitchName3 = New System.Windows.Forms.TextBox()
        Me.TextBoxSwitchName2 = New System.Windows.Forms.TextBox()
        Me.TextBoxSwitchName1 = New System.Windows.Forms.TextBox()
        Me.TextBoxSwitchName0 = New System.Windows.Forms.TextBox()
        Me.LabelSwitchName7 = New System.Windows.Forms.Label()
        Me.LabelSwitchName6 = New System.Windows.Forms.Label()
        Me.LabelSwitchName5 = New System.Windows.Forms.Label()
        Me.LabelSwitchName4 = New System.Windows.Forms.Label()
        Me.LabelSwitchName3 = New System.Windows.Forms.Label()
        Me.LabelSwitchName2 = New System.Windows.Forms.Label()
        Me.LabelSwitchName1 = New System.Windows.Forms.Label()
        Me.LabelSwitchName0 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxIP = New System.Windows.Forms.TextBox()
        Me.ComboBoxnumSwitch = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(232, 390)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.ASCOM.wittinobiArduinoSwitchASCOMv2wifiDRIVER.My.Resources.Resources.ASCOM
        Me.PictureBox1.Location = New System.Drawing.Point(329, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Arduino IP Adress"
        '
        'LabelCopyRight
        '
        Me.LabelCopyRight.AutoSize = True
        Me.LabelCopyRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCopyRight.Location = New System.Drawing.Point(12, 406)
        Me.LabelCopyRight.Name = "LabelCopyRight"
        Me.LabelCopyRight.Size = New System.Drawing.Size(187, 13)
        Me.LabelCopyRight.TabIndex = 125
        Me.LabelCopyRight.Text = "© 2022 by Tobias Wittmann (wittinobi)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Relay"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Switch Name"
        '
        'TextBoxSwitchName7
        '
        Me.TextBoxSwitchName7.Location = New System.Drawing.Point(61, 341)
        Me.TextBoxSwitchName7.Name = "TextBoxSwitchName7"
        Me.TextBoxSwitchName7.Size = New System.Drawing.Size(316, 20)
        Me.TextBoxSwitchName7.TabIndex = 122
        '
        'TextBoxSwitchName6
        '
        Me.TextBoxSwitchName6.Location = New System.Drawing.Point(61, 315)
        Me.TextBoxSwitchName6.Name = "TextBoxSwitchName6"
        Me.TextBoxSwitchName6.Size = New System.Drawing.Size(316, 20)
        Me.TextBoxSwitchName6.TabIndex = 121
        '
        'TextBoxSwitchName5
        '
        Me.TextBoxSwitchName5.Location = New System.Drawing.Point(61, 289)
        Me.TextBoxSwitchName5.Name = "TextBoxSwitchName5"
        Me.TextBoxSwitchName5.Size = New System.Drawing.Size(316, 20)
        Me.TextBoxSwitchName5.TabIndex = 120
        '
        'TextBoxSwitchName4
        '
        Me.TextBoxSwitchName4.Location = New System.Drawing.Point(61, 263)
        Me.TextBoxSwitchName4.Name = "TextBoxSwitchName4"
        Me.TextBoxSwitchName4.Size = New System.Drawing.Size(316, 20)
        Me.TextBoxSwitchName4.TabIndex = 119
        '
        'TextBoxSwitchName3
        '
        Me.TextBoxSwitchName3.Location = New System.Drawing.Point(61, 237)
        Me.TextBoxSwitchName3.Name = "TextBoxSwitchName3"
        Me.TextBoxSwitchName3.Size = New System.Drawing.Size(316, 20)
        Me.TextBoxSwitchName3.TabIndex = 118
        '
        'TextBoxSwitchName2
        '
        Me.TextBoxSwitchName2.Location = New System.Drawing.Point(61, 211)
        Me.TextBoxSwitchName2.Name = "TextBoxSwitchName2"
        Me.TextBoxSwitchName2.Size = New System.Drawing.Size(316, 20)
        Me.TextBoxSwitchName2.TabIndex = 117
        '
        'TextBoxSwitchName1
        '
        Me.TextBoxSwitchName1.Location = New System.Drawing.Point(61, 185)
        Me.TextBoxSwitchName1.Name = "TextBoxSwitchName1"
        Me.TextBoxSwitchName1.Size = New System.Drawing.Size(316, 20)
        Me.TextBoxSwitchName1.TabIndex = 116
        '
        'TextBoxSwitchName0
        '
        Me.TextBoxSwitchName0.Location = New System.Drawing.Point(61, 159)
        Me.TextBoxSwitchName0.Name = "TextBoxSwitchName0"
        Me.TextBoxSwitchName0.Size = New System.Drawing.Size(316, 20)
        Me.TextBoxSwitchName0.TabIndex = 115
        '
        'LabelSwitchName7
        '
        Me.LabelSwitchName7.AutoSize = True
        Me.LabelSwitchName7.Location = New System.Drawing.Point(12, 344)
        Me.LabelSwitchName7.Name = "LabelSwitchName7"
        Me.LabelSwitchName7.Size = New System.Drawing.Size(43, 13)
        Me.LabelSwitchName7.TabIndex = 114
        Me.LabelSwitchName7.Text = "Relay 8"
        '
        'LabelSwitchName6
        '
        Me.LabelSwitchName6.AutoSize = True
        Me.LabelSwitchName6.Location = New System.Drawing.Point(12, 318)
        Me.LabelSwitchName6.Name = "LabelSwitchName6"
        Me.LabelSwitchName6.Size = New System.Drawing.Size(43, 13)
        Me.LabelSwitchName6.TabIndex = 113
        Me.LabelSwitchName6.Text = "Relay 7"
        '
        'LabelSwitchName5
        '
        Me.LabelSwitchName5.AutoSize = True
        Me.LabelSwitchName5.Location = New System.Drawing.Point(12, 292)
        Me.LabelSwitchName5.Name = "LabelSwitchName5"
        Me.LabelSwitchName5.Size = New System.Drawing.Size(43, 13)
        Me.LabelSwitchName5.TabIndex = 112
        Me.LabelSwitchName5.Text = "Relay 6"
        '
        'LabelSwitchName4
        '
        Me.LabelSwitchName4.AutoSize = True
        Me.LabelSwitchName4.Location = New System.Drawing.Point(12, 266)
        Me.LabelSwitchName4.Name = "LabelSwitchName4"
        Me.LabelSwitchName4.Size = New System.Drawing.Size(43, 13)
        Me.LabelSwitchName4.TabIndex = 111
        Me.LabelSwitchName4.Text = "Relay 5"
        '
        'LabelSwitchName3
        '
        Me.LabelSwitchName3.AutoSize = True
        Me.LabelSwitchName3.Location = New System.Drawing.Point(12, 240)
        Me.LabelSwitchName3.Name = "LabelSwitchName3"
        Me.LabelSwitchName3.Size = New System.Drawing.Size(43, 13)
        Me.LabelSwitchName3.TabIndex = 110
        Me.LabelSwitchName3.Text = "Relay 4"
        '
        'LabelSwitchName2
        '
        Me.LabelSwitchName2.AutoSize = True
        Me.LabelSwitchName2.Location = New System.Drawing.Point(12, 214)
        Me.LabelSwitchName2.Name = "LabelSwitchName2"
        Me.LabelSwitchName2.Size = New System.Drawing.Size(43, 13)
        Me.LabelSwitchName2.TabIndex = 109
        Me.LabelSwitchName2.Text = "Relay 3"
        '
        'LabelSwitchName1
        '
        Me.LabelSwitchName1.AutoSize = True
        Me.LabelSwitchName1.Location = New System.Drawing.Point(12, 188)
        Me.LabelSwitchName1.Name = "LabelSwitchName1"
        Me.LabelSwitchName1.Size = New System.Drawing.Size(43, 13)
        Me.LabelSwitchName1.TabIndex = 108
        Me.LabelSwitchName1.Text = "Relay 2"
        '
        'LabelSwitchName0
        '
        Me.LabelSwitchName0.AutoSize = True
        Me.LabelSwitchName0.Location = New System.Drawing.Point(12, 162)
        Me.LabelSwitchName0.Name = "LabelSwitchName0"
        Me.LabelSwitchName0.Size = New System.Drawing.Size(43, 13)
        Me.LabelSwitchName0.TabIndex = 107
        Me.LabelSwitchName0.Text = "Relay 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 45)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "wittinobiArduinoSwitchASCOMv2wifiDRIVER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Setup"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBoxIP
        '
        Me.TextBoxIP.Location = New System.Drawing.Point(109, 86)
        Me.TextBoxIP.Name = "TextBoxIP"
        Me.TextBoxIP.Size = New System.Drawing.Size(111, 20)
        Me.TextBoxIP.TabIndex = 154
        '
        'ComboBoxnumSwitch
        '
        Me.ComboBoxnumSwitch.FormattingEnabled = True
        Me.ComboBoxnumSwitch.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.ComboBoxnumSwitch.Location = New System.Drawing.Point(329, 86)
        Me.ComboBoxnumSwitch.Name = "ComboBoxnumSwitch"
        Me.ComboBoxnumSwitch.Size = New System.Drawing.Size(48, 21)
        Me.ComboBoxnumSwitch.TabIndex = 156
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(250, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Max Switches"
        '
        'SetupDialogForm
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(390, 431)
        Me.Controls.Add(Me.ComboBoxnumSwitch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxIP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelCopyRight)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxSwitchName7)
        Me.Controls.Add(Me.TextBoxSwitchName6)
        Me.Controls.Add(Me.TextBoxSwitchName5)
        Me.Controls.Add(Me.TextBoxSwitchName4)
        Me.Controls.Add(Me.TextBoxSwitchName3)
        Me.Controls.Add(Me.TextBoxSwitchName2)
        Me.Controls.Add(Me.TextBoxSwitchName1)
        Me.Controls.Add(Me.TextBoxSwitchName0)
        Me.Controls.Add(Me.LabelSwitchName7)
        Me.Controls.Add(Me.LabelSwitchName6)
        Me.Controls.Add(Me.LabelSwitchName5)
        Me.Controls.Add(Me.LabelSwitchName4)
        Me.Controls.Add(Me.LabelSwitchName3)
        Me.Controls.Add(Me.LabelSwitchName2)
        Me.Controls.Add(Me.LabelSwitchName1)
        Me.Controls.Add(Me.LabelSwitchName0)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetupDialogForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "wittinobiArduinoSwitchASCOMv2wifiDRIVER Setup"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxIP As TextBox
    Friend WithEvents LabelCopyRight As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxSwitchName7 As TextBox
    Friend WithEvents TextBoxSwitchName6 As TextBox
    Friend WithEvents TextBoxSwitchName5 As TextBox
    Friend WithEvents TextBoxSwitchName4 As TextBox
    Friend WithEvents TextBoxSwitchName3 As TextBox
    Friend WithEvents TextBoxSwitchName2 As TextBox
    Friend WithEvents TextBoxSwitchName1 As TextBox
    Friend WithEvents TextBoxSwitchName0 As TextBox
    Private WithEvents LabelSwitchName7 As Label
    Private WithEvents LabelSwitchName6 As Label
    Private WithEvents LabelSwitchName5 As Label
    Private WithEvents LabelSwitchName4 As Label
    Private WithEvents LabelSwitchName3 As Label
    Private WithEvents LabelSwitchName2 As Label
    Private WithEvents LabelSwitchName1 As Label
    Private WithEvents LabelSwitchName0 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxnumSwitch As ComboBox
    Friend WithEvents Label6 As Label
End Class
