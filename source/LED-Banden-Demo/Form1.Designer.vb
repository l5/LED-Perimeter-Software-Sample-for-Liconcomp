<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Button1 = New System.Windows.Forms.Button
        Me.RadioButtonLAnlinks = New System.Windows.Forms.RadioButton
        Me.RadioButtonLAnrechts = New System.Windows.Forms.RadioButton
        Me.RadioButtonLArechts = New System.Windows.Forms.RadioButton
        Me.RadioButtonLAmitte = New System.Windows.Forms.RadioButton
        Me.RadioButtonLAlinks = New System.Windows.Forms.RadioButton
        Me.ButtonLAToff = New System.Windows.Forms.Button
        Me.ButtonLATon = New System.Windows.Forms.Button
        Me.TextBoxLAText = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.NumericUpDownLAvideoheight = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.NumericUpDownLAvideowidth = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.NumericUpDownLAoverlap = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDownLAbreak = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDownLAYpos = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDownLAXPos = New System.Windows.Forms.NumericUpDown
        Me.ButtonLLvoff = New System.Windows.Forms.Button
        Me.BLLplay = New System.Windows.Forms.Button
        Me.BLLpause = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.CheckBoxB3 = New System.Windows.Forms.CheckBox
        Me.CheckBoxB4 = New System.Windows.Forms.CheckBox
        Me.CheckBoxB5 = New System.Windows.Forms.CheckBox
        Me.CheckBoxB2 = New System.Windows.Forms.CheckBox
        Me.CheckBoxB1 = New System.Windows.Forms.CheckBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button6 = New System.Windows.Forms.Button
        CType(Me.NumericUpDownLAvideoheight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownLAvideowidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownLAoverlap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownLAbreak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownLAYpos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownLAXPos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Einschalten"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButtonLAnlinks
        '
        Me.RadioButtonLAnlinks.AutoSize = True
        Me.RadioButtonLAnlinks.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RadioButtonLAnlinks.Location = New System.Drawing.Point(48, 74)
        Me.RadioButtonLAnlinks.Name = "RadioButtonLAnlinks"
        Me.RadioButtonLAnlinks.Size = New System.Drawing.Size(29, 30)
        Me.RadioButtonLAnlinks.TabIndex = 31
        Me.RadioButtonLAnlinks.Text = "<<<"
        Me.RadioButtonLAnlinks.UseVisualStyleBackColor = True
        '
        'RadioButtonLAnrechts
        '
        Me.RadioButtonLAnrechts.AutoSize = True
        Me.RadioButtonLAnrechts.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RadioButtonLAnrechts.Location = New System.Drawing.Point(129, 74)
        Me.RadioButtonLAnrechts.Name = "RadioButtonLAnrechts"
        Me.RadioButtonLAnrechts.Size = New System.Drawing.Size(29, 30)
        Me.RadioButtonLAnrechts.TabIndex = 30
        Me.RadioButtonLAnrechts.Text = ">>>"
        Me.RadioButtonLAnrechts.UseVisualStyleBackColor = True
        '
        'RadioButtonLArechts
        '
        Me.RadioButtonLArechts.AutoSize = True
        Me.RadioButtonLArechts.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RadioButtonLArechts.Location = New System.Drawing.Point(164, 74)
        Me.RadioButtonLArechts.Name = "RadioButtonLArechts"
        Me.RadioButtonLArechts.Size = New System.Drawing.Size(45, 30)
        Me.RadioButtonLArechts.TabIndex = 28
        Me.RadioButtonLArechts.Text = "Rechts"
        Me.RadioButtonLArechts.UseVisualStyleBackColor = True
        '
        'RadioButtonLAmitte
        '
        Me.RadioButtonLAmitte.AutoSize = True
        Me.RadioButtonLAmitte.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RadioButtonLAmitte.Checked = True
        Me.RadioButtonLAmitte.Location = New System.Drawing.Point(89, 74)
        Me.RadioButtonLAmitte.Name = "RadioButtonLAmitte"
        Me.RadioButtonLAmitte.Size = New System.Drawing.Size(34, 30)
        Me.RadioButtonLAmitte.TabIndex = 27
        Me.RadioButtonLAmitte.TabStop = True
        Me.RadioButtonLAmitte.Text = "Mitte"
        Me.RadioButtonLAmitte.UseVisualStyleBackColor = True
        '
        'RadioButtonLAlinks
        '
        Me.RadioButtonLAlinks.AutoSize = True
        Me.RadioButtonLAlinks.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RadioButtonLAlinks.Location = New System.Drawing.Point(6, 74)
        Me.RadioButtonLAlinks.Name = "RadioButtonLAlinks"
        Me.RadioButtonLAlinks.Size = New System.Drawing.Size(36, 30)
        Me.RadioButtonLAlinks.TabIndex = 26
        Me.RadioButtonLAlinks.Text = "Links"
        Me.RadioButtonLAlinks.UseVisualStyleBackColor = True
        '
        'ButtonLAToff
        '
        Me.ButtonLAToff.Location = New System.Drawing.Point(6, 50)
        Me.ButtonLAToff.Name = "ButtonLAToff"
        Me.ButtonLAToff.Size = New System.Drawing.Size(64, 23)
        Me.ButtonLAToff.TabIndex = 21
        Me.ButtonLAToff.Text = "OFF"
        Me.ButtonLAToff.UseVisualStyleBackColor = True
        '
        'ButtonLATon
        '
        Me.ButtonLATon.Location = New System.Drawing.Point(129, 50)
        Me.ButtonLATon.Name = "ButtonLATon"
        Me.ButtonLATon.Size = New System.Drawing.Size(81, 23)
        Me.ButtonLATon.TabIndex = 20
        Me.ButtonLATon.Text = "ON/refresh"
        Me.ButtonLATon.UseVisualStyleBackColor = True
        '
        'TextBoxLAText
        '
        Me.TextBoxLAText.Location = New System.Drawing.Point(6, 24)
        Me.TextBoxLAText.Name = "TextBoxLAText"
        Me.TextBoxLAText.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxLAText.TabIndex = 15
        Me.TextBoxLAText.Text = "Liconcomp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Höhe"
        '
        'NumericUpDownLAvideoheight
        '
        Me.NumericUpDownLAvideoheight.Location = New System.Drawing.Point(64, 162)
        Me.NumericUpDownLAvideoheight.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.NumericUpDownLAvideoheight.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
        Me.NumericUpDownLAvideoheight.Name = "NumericUpDownLAvideoheight"
        Me.NumericUpDownLAvideoheight.Size = New System.Drawing.Size(82, 20)
        Me.NumericUpDownLAvideoheight.TabIndex = 24
        Me.NumericUpDownLAvideoheight.Value = New Decimal(New Integer() {72, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Breite"
        '
        'NumericUpDownLAvideowidth
        '
        Me.NumericUpDownLAvideowidth.Location = New System.Drawing.Point(64, 136)
        Me.NumericUpDownLAvideowidth.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.NumericUpDownLAvideowidth.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
        Me.NumericUpDownLAvideowidth.Name = "NumericUpDownLAvideowidth"
        Me.NumericUpDownLAvideowidth.Size = New System.Drawing.Size(82, 20)
        Me.NumericUpDownLAvideowidth.TabIndex = 22
        Me.NumericUpDownLAvideowidth.Value = New Decimal(New Integer() {704, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Overlap"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Linebreak"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "PosY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "PosX"
        '
        'NumericUpDownLAoverlap
        '
        Me.NumericUpDownLAoverlap.Location = New System.Drawing.Point(64, 106)
        Me.NumericUpDownLAoverlap.Name = "NumericUpDownLAoverlap"
        Me.NumericUpDownLAoverlap.Size = New System.Drawing.Size(82, 20)
        Me.NumericUpDownLAoverlap.TabIndex = 14
        '
        'NumericUpDownLAbreak
        '
        Me.NumericUpDownLAbreak.Location = New System.Drawing.Point(64, 80)
        Me.NumericUpDownLAbreak.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.NumericUpDownLAbreak.Name = "NumericUpDownLAbreak"
        Me.NumericUpDownLAbreak.Size = New System.Drawing.Size(82, 20)
        Me.NumericUpDownLAbreak.TabIndex = 13
        '
        'NumericUpDownLAYpos
        '
        Me.NumericUpDownLAYpos.Location = New System.Drawing.Point(64, 48)
        Me.NumericUpDownLAYpos.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.NumericUpDownLAYpos.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
        Me.NumericUpDownLAYpos.Name = "NumericUpDownLAYpos"
        Me.NumericUpDownLAYpos.Size = New System.Drawing.Size(82, 20)
        Me.NumericUpDownLAYpos.TabIndex = 12
        '
        'NumericUpDownLAXPos
        '
        Me.NumericUpDownLAXPos.Location = New System.Drawing.Point(64, 22)
        Me.NumericUpDownLAXPos.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.NumericUpDownLAXPos.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
        Me.NumericUpDownLAXPos.Name = "NumericUpDownLAXPos"
        Me.NumericUpDownLAXPos.Size = New System.Drawing.Size(82, 20)
        Me.NumericUpDownLAXPos.TabIndex = 11
        '
        'ButtonLLvoff
        '
        Me.ButtonLLvoff.Location = New System.Drawing.Point(6, 133)
        Me.ButtonLLvoff.Name = "ButtonLLvoff"
        Me.ButtonLLvoff.Size = New System.Drawing.Size(204, 23)
        Me.ButtonLLvoff.TabIndex = 35
        Me.ButtonLLvoff.Text = "OFF"
        Me.ButtonLLvoff.UseVisualStyleBackColor = True
        '
        'BLLplay
        '
        Me.BLLplay.Location = New System.Drawing.Point(153, 162)
        Me.BLLplay.Name = "BLLplay"
        Me.BLLplay.Size = New System.Drawing.Size(57, 23)
        Me.BLLplay.TabIndex = 4
        Me.BLLplay.Text = "play"
        Me.BLLplay.UseVisualStyleBackColor = True
        '
        'BLLpause
        '
        Me.BLLpause.Location = New System.Drawing.Point(6, 162)
        Me.BLLpause.Name = "BLLpause"
        Me.BLLpause.Size = New System.Drawing.Size(55, 23)
        Me.BLLpause.TabIndex = 3
        Me.BLLpause.Text = "pause"
        Me.BLLpause.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(138, 340)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(214, 23)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Videos aus Verzeichnis laden"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Silver
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.CheckBoxB3)
        Me.GroupBox4.Controls.Add(Me.CheckBoxB4)
        Me.GroupBox4.Controls.Add(Me.CheckBoxB5)
        Me.GroupBox4.Controls.Add(Me.CheckBoxB2)
        Me.GroupBox4.Controls.Add(Me.CheckBoxB1)
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(928, 383)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(760, 226)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 149)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Playlists"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(6, 19)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(145, 95)
        Me.ListBox2.TabIndex = 37
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LED_Banden_Demo.My.Resources.Resources.liconcomp_logo_xx
        Me.PictureBox1.Location = New System.Drawing.Point(544, 340)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 32)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(379, 300)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(116, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Sideline"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(257, 300)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Backline"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButtonLAnlinks)
        Me.GroupBox2.Controls.Add(Me.TextBoxLAText)
        Me.GroupBox2.Controls.Add(Me.RadioButtonLAnrechts)
        Me.GroupBox2.Controls.Add(Me.ButtonLATon)
        Me.GroupBox2.Controls.Add(Me.RadioButtonLArechts)
        Me.GroupBox2.Controls.Add(Me.ButtonLAToff)
        Me.GroupBox2.Controls.Add(Me.RadioButtonLAmitte)
        Me.GroupBox2.Controls.Add(Me.RadioButtonLAlinks)
        Me.GroupBox2.Location = New System.Drawing.Point(538, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 112)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Text"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(135, 300)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Keine Banden"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.NumericUpDownLAXPos)
        Me.GroupBox3.Controls.Add(Me.NumericUpDownLAYpos)
        Me.GroupBox3.Controls.Add(Me.NumericUpDownLAbreak)
        Me.GroupBox3.Controls.Add(Me.NumericUpDownLAoverlap)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.NumericUpDownLAvideoheight)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.NumericUpDownLAvideowidth)
        Me.GroupBox3.Location = New System.Drawing.Point(760, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(158, 199)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Positionierung"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Alle Banden"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ListBox1)
        Me.GroupBox5.Controls.Add(Me.ButtonLLvoff)
        Me.GroupBox5.Controls.Add(Me.BLLpause)
        Me.GroupBox5.Controls.Add(Me.BLLplay)
        Me.GroupBox5.Location = New System.Drawing.Point(538, 21)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(216, 199)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Videosteuerung"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(204, 108)
        Me.ListBox1.TabIndex = 36
        '
        'CheckBoxB3
        '
        Me.CheckBoxB3.AutoSize = True
        Me.CheckBoxB3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.CheckBoxB3.ForeColor = System.Drawing.Color.White
        Me.CheckBoxB3.Location = New System.Drawing.Point(223, 39)
        Me.CheckBoxB3.Name = "CheckBoxB3"
        Me.CheckBoxB3.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxB3.TabIndex = 4
        Me.CheckBoxB3.Text = "Bande 3"
        Me.CheckBoxB3.UseVisualStyleBackColor = False
        '
        'CheckBoxB4
        '
        Me.CheckBoxB4.AutoSize = True
        Me.CheckBoxB4.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.CheckBoxB4.ForeColor = System.Drawing.Color.White
        Me.CheckBoxB4.Location = New System.Drawing.Point(358, 39)
        Me.CheckBoxB4.Name = "CheckBoxB4"
        Me.CheckBoxB4.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxB4.TabIndex = 3
        Me.CheckBoxB4.Text = "Bande 4"
        Me.CheckBoxB4.UseVisualStyleBackColor = False
        '
        'CheckBoxB5
        '
        Me.CheckBoxB5.AutoSize = True
        Me.CheckBoxB5.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.CheckBoxB5.ForeColor = System.Drawing.Color.White
        Me.CheckBoxB5.Location = New System.Drawing.Point(445, 147)
        Me.CheckBoxB5.Name = "CheckBoxB5"
        Me.CheckBoxB5.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxB5.TabIndex = 2
        Me.CheckBoxB5.Text = "Bande 5"
        Me.CheckBoxB5.UseVisualStyleBackColor = False
        '
        'CheckBoxB2
        '
        Me.CheckBoxB2.AutoSize = True
        Me.CheckBoxB2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.CheckBoxB2.ForeColor = System.Drawing.Color.White
        Me.CheckBoxB2.Location = New System.Drawing.Point(85, 39)
        Me.CheckBoxB2.Name = "CheckBoxB2"
        Me.CheckBoxB2.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxB2.TabIndex = 1
        Me.CheckBoxB2.Text = "Bande 2"
        Me.CheckBoxB2.UseVisualStyleBackColor = False
        '
        'CheckBoxB1
        '
        Me.CheckBoxB1.AutoSize = True
        Me.CheckBoxB1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.CheckBoxB1.ForeColor = System.Drawing.Color.White
        Me.CheckBoxB1.Location = New System.Drawing.Point(10, 147)
        Me.CheckBoxB1.Name = "CheckBoxB1"
        Me.CheckBoxB1.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxB1.TabIndex = 0
        Me.CheckBoxB1.Text = "Bande 1"
        Me.CheckBoxB1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.LED_Banden_Demo.My.Resources.Resources.court
        Me.PictureBox2.Location = New System.Drawing.Point(13, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(519, 293)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(358, 340)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(169, 23)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Playlists laden"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 399)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "Form1"
        Me.Text = "Liconcomp *** LED-Banden Demo"
        CType(Me.NumericUpDownLAvideoheight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownLAvideowidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownLAoverlap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownLAbreak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownLAYpos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownLAXPos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents BLLplay As System.Windows.Forms.Button
    Friend WithEvents BLLpause As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownLAoverlap As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownLAbreak As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownLAYpos As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownLAXPos As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownLAvideoheight As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownLAvideowidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents ButtonLAToff As System.Windows.Forms.Button
    Friend WithEvents ButtonLATon As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxLAText As System.Windows.Forms.TextBox
    Friend WithEvents RadioButtonLArechts As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonLAmitte As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonLAlinks As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonLLvoff As System.Windows.Forms.Button
    Friend WithEvents RadioButtonLAnlinks As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonLAnrechts As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxB3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxB4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxB5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxB2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxB1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Button6 As System.Windows.Forms.Button

End Class
