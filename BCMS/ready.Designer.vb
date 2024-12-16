<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ready
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ready))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.donebtn = New FontAwesome.Sharp.IconButton()
        Me.logoutbtn = New FontAwesome.Sharp.IconButton()
        Me.requestbtn = New FontAwesome.Sharp.IconButton()
        Me.citizenbtn = New FontAwesome.Sharp.IconButton()
        Me.homebtn = New FontAwesome.Sharp.IconButton()
        Me.readyip = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.requestcb = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.searchtb = New System.Windows.Forms.TextBox()
        Me.search_txt = New System.Windows.Forms.Label()
        Me.clearbtn2 = New System.Windows.Forms.Button()
        Me.deletebtn2 = New System.Windows.Forms.Button()
        Me.updatebtn2 = New System.Windows.Forms.Button()
        Me.purokcb = New System.Windows.Forms.ComboBox()
        Me.gendercb = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.addbtn2 = New System.Windows.Forms.Button()
        Me.contacttb = New System.Windows.Forms.TextBox()
        Me.agetb = New System.Windows.Forms.TextBox()
        Me.nametb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.statuscb = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.readyip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(155, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 69)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "BCMS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(38, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Gold
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1924, 150)
        Me.Panel1.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Controls.Add(Me.donebtn)
        Me.Panel4.Controls.Add(Me.logoutbtn)
        Me.Panel4.Controls.Add(Me.requestbtn)
        Me.Panel4.Controls.Add(Me.citizenbtn)
        Me.Panel4.Controls.Add(Me.homebtn)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 150)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(362, 905)
        Me.Panel4.TabIndex = 19
        '
        'donebtn
        '
        Me.donebtn.BackColor = System.Drawing.Color.Gold
        Me.donebtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.donebtn.FlatAppearance.BorderSize = 0
        Me.donebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.donebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.donebtn.ForeColor = System.Drawing.Color.White
        Me.donebtn.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.donebtn.IconColor = System.Drawing.Color.White
        Me.donebtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.donebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.donebtn.Location = New System.Drawing.Point(0, 210)
        Me.donebtn.Name = "donebtn"
        Me.donebtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.donebtn.Size = New System.Drawing.Size(362, 70)
        Me.donebtn.TabIndex = 37
        Me.donebtn.Text = "READY TO PICK"
        Me.donebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.donebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.donebtn.UseVisualStyleBackColor = False
        '
        'logoutbtn
        '
        Me.logoutbtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.logoutbtn.FlatAppearance.BorderSize = 0
        Me.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutbtn.ForeColor = System.Drawing.Color.White
        Me.logoutbtn.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.logoutbtn.IconColor = System.Drawing.Color.White
        Me.logoutbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logoutbtn.Location = New System.Drawing.Point(0, 835)
        Me.logoutbtn.Name = "logoutbtn"
        Me.logoutbtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.logoutbtn.Size = New System.Drawing.Size(362, 70)
        Me.logoutbtn.TabIndex = 36
        Me.logoutbtn.Text = "LOGOUT"
        Me.logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logoutbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.logoutbtn.UseVisualStyleBackColor = True
        '
        'requestbtn
        '
        Me.requestbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.requestbtn.FlatAppearance.BorderSize = 0
        Me.requestbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.requestbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestbtn.ForeColor = System.Drawing.Color.White
        Me.requestbtn.IconChar = FontAwesome.Sharp.IconChar.File
        Me.requestbtn.IconColor = System.Drawing.Color.White
        Me.requestbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.requestbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.requestbtn.Location = New System.Drawing.Point(0, 140)
        Me.requestbtn.Name = "requestbtn"
        Me.requestbtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.requestbtn.Size = New System.Drawing.Size(362, 70)
        Me.requestbtn.TabIndex = 35
        Me.requestbtn.Text = "REQUEST"
        Me.requestbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.requestbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.requestbtn.UseVisualStyleBackColor = True
        '
        'citizenbtn
        '
        Me.citizenbtn.BackColor = System.Drawing.Color.Navy
        Me.citizenbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.citizenbtn.FlatAppearance.BorderSize = 0
        Me.citizenbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.citizenbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.citizenbtn.ForeColor = System.Drawing.Color.White
        Me.citizenbtn.IconChar = FontAwesome.Sharp.IconChar.User
        Me.citizenbtn.IconColor = System.Drawing.Color.White
        Me.citizenbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.citizenbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.citizenbtn.Location = New System.Drawing.Point(0, 70)
        Me.citizenbtn.Name = "citizenbtn"
        Me.citizenbtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.citizenbtn.Size = New System.Drawing.Size(362, 70)
        Me.citizenbtn.TabIndex = 34
        Me.citizenbtn.Text = "CITIZENS"
        Me.citizenbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.citizenbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.citizenbtn.UseVisualStyleBackColor = False
        '
        'homebtn
        '
        Me.homebtn.BackColor = System.Drawing.Color.Navy
        Me.homebtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.homebtn.FlatAppearance.BorderSize = 0
        Me.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homebtn.ForeColor = System.Drawing.Color.White
        Me.homebtn.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.homebtn.IconColor = System.Drawing.Color.White
        Me.homebtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.homebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.homebtn.Location = New System.Drawing.Point(0, 0)
        Me.homebtn.Name = "homebtn"
        Me.homebtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.homebtn.Size = New System.Drawing.Size(362, 70)
        Me.homebtn.TabIndex = 33
        Me.homebtn.Text = "HOME PAGE"
        Me.homebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.homebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.homebtn.UseVisualStyleBackColor = False
        '
        'readyip
        '
        Me.readyip.BackColor = System.Drawing.SystemColors.Control
        Me.readyip.ForeColor = System.Drawing.Color.Navy
        Me.readyip.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.readyip.IconColor = System.Drawing.Color.Navy
        Me.readyip.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.readyip.IconSize = 54
        Me.readyip.Location = New System.Drawing.Point(409, 202)
        Me.readyip.Name = "readyip"
        Me.readyip.Size = New System.Drawing.Size(54, 54)
        Me.readyip.TabIndex = 23
        Me.readyip.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(469, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 54)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "READY TO PICK"
        '
        'requestcb
        '
        Me.requestcb.FormattingEnabled = True
        Me.requestcb.Location = New System.Drawing.Point(674, 534)
        Me.requestcb.Name = "requestcb"
        Me.requestcb.Size = New System.Drawing.Size(247, 24)
        Me.requestcb.TabIndex = 77
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(554, 534)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "REQUEST :"
        '
        'searchtb
        '
        Me.searchtb.Location = New System.Drawing.Point(953, 287)
        Me.searchtb.Name = "searchtb"
        Me.searchtb.Size = New System.Drawing.Size(543, 22)
        Me.searchtb.TabIndex = 75
        '
        'search_txt
        '
        Me.search_txt.AutoSize = True
        Me.search_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_txt.ForeColor = System.Drawing.Color.Navy
        Me.search_txt.Location = New System.Drawing.Point(950, 258)
        Me.search_txt.Name = "search_txt"
        Me.search_txt.Size = New System.Drawing.Size(69, 16)
        Me.search_txt.TabIndex = 74
        Me.search_txt.Text = "SEARCH"
        '
        'clearbtn2
        '
        Me.clearbtn2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.clearbtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn2.ForeColor = System.Drawing.Color.White
        Me.clearbtn2.Location = New System.Drawing.Point(799, 742)
        Me.clearbtn2.Name = "clearbtn2"
        Me.clearbtn2.Size = New System.Drawing.Size(122, 46)
        Me.clearbtn2.TabIndex = 73
        Me.clearbtn2.Text = "CLEAR"
        Me.clearbtn2.UseVisualStyleBackColor = False
        '
        'deletebtn2
        '
        Me.deletebtn2.BackColor = System.Drawing.Color.Red
        Me.deletebtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn2.ForeColor = System.Drawing.Color.White
        Me.deletebtn2.Location = New System.Drawing.Point(655, 742)
        Me.deletebtn2.Name = "deletebtn2"
        Me.deletebtn2.Size = New System.Drawing.Size(122, 46)
        Me.deletebtn2.TabIndex = 72
        Me.deletebtn2.Text = "DELETE"
        Me.deletebtn2.UseVisualStyleBackColor = False
        '
        'updatebtn2
        '
        Me.updatebtn2.BackColor = System.Drawing.Color.Blue
        Me.updatebtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn2.ForeColor = System.Drawing.Color.White
        Me.updatebtn2.Location = New System.Drawing.Point(799, 663)
        Me.updatebtn2.Name = "updatebtn2"
        Me.updatebtn2.Size = New System.Drawing.Size(122, 46)
        Me.updatebtn2.TabIndex = 71
        Me.updatebtn2.Text = "UPDATE"
        Me.updatebtn2.UseVisualStyleBackColor = False
        '
        'purokcb
        '
        Me.purokcb.FormattingEnabled = True
        Me.purokcb.Location = New System.Drawing.Point(674, 450)
        Me.purokcb.Name = "purokcb"
        Me.purokcb.Size = New System.Drawing.Size(247, 24)
        Me.purokcb.TabIndex = 70
        '
        'gendercb
        '
        Me.gendercb.FormattingEnabled = True
        Me.gendercb.Location = New System.Drawing.Point(674, 370)
        Me.gendercb.Name = "gendercb"
        Me.gendercb.Size = New System.Drawing.Size(247, 24)
        Me.gendercb.TabIndex = 69
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(953, 331)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1137, 510)
        Me.DataGridView1.TabIndex = 68
        '
        'addbtn2
        '
        Me.addbtn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.addbtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn2.ForeColor = System.Drawing.SystemColors.Control
        Me.addbtn2.Location = New System.Drawing.Point(655, 664)
        Me.addbtn2.Name = "addbtn2"
        Me.addbtn2.Size = New System.Drawing.Size(122, 46)
        Me.addbtn2.TabIndex = 67
        Me.addbtn2.Text = "ADD"
        Me.addbtn2.UseVisualStyleBackColor = False
        '
        'contacttb
        '
        Me.contacttb.Location = New System.Drawing.Point(674, 494)
        Me.contacttb.Name = "contacttb"
        Me.contacttb.Size = New System.Drawing.Size(247, 22)
        Me.contacttb.TabIndex = 66
        '
        'agetb
        '
        Me.agetb.Location = New System.Drawing.Point(674, 412)
        Me.agetb.Name = "agetb"
        Me.agetb.Size = New System.Drawing.Size(247, 22)
        Me.agetb.TabIndex = 65
        '
        'nametb
        '
        Me.nametb.Location = New System.Drawing.Point(674, 331)
        Me.nametb.Name = "nametb"
        Me.nametb.Size = New System.Drawing.Size(247, 22)
        Me.nametb.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(554, 494)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "CONTACT :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(574, 450)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "PUROK :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(595, 412)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "AGE :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(562, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "GENDER :"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(583, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "NAME :"
        '
        'statuscb
        '
        Me.statuscb.FormattingEnabled = True
        Me.statuscb.Location = New System.Drawing.Point(674, 576)
        Me.statuscb.Name = "statuscb"
        Me.statuscb.Size = New System.Drawing.Size(247, 24)
        Me.statuscb.TabIndex = 78
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(565, 576)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "STATUS :"
        '
        'ready
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.statuscb)
        Me.Controls.Add(Me.requestcb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.searchtb)
        Me.Controls.Add(Me.search_txt)
        Me.Controls.Add(Me.clearbtn2)
        Me.Controls.Add(Me.deletebtn2)
        Me.Controls.Add(Me.updatebtn2)
        Me.Controls.Add(Me.purokcb)
        Me.Controls.Add(Me.gendercb)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.addbtn2)
        Me.Controls.Add(Me.contacttb)
        Me.Controls.Add(Me.agetb)
        Me.Controls.Add(Me.nametb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.readyip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ready"
        Me.Text = "READY TO PICK"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.readyip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents donebtn As FontAwesome.Sharp.IconButton
    Friend WithEvents logoutbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents requestbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents citizenbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents homebtn As FontAwesome.Sharp.IconButton
    Friend WithEvents readyip As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents requestcb As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents searchtb As TextBox
    Friend WithEvents search_txt As Label
    Friend WithEvents clearbtn2 As Button
    Friend WithEvents deletebtn2 As Button
    Friend WithEvents updatebtn2 As Button
    Friend WithEvents purokcb As ComboBox
    Friend WithEvents gendercb As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents addbtn2 As Button
    Friend WithEvents contacttb As TextBox
    Friend WithEvents agetb As TextBox
    Friend WithEvents nametb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents statuscb As ComboBox
    Friend WithEvents Label9 As Label
End Class
