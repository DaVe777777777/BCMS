<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Citizen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Citizen))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.citizenll = New System.Windows.Forms.LinkLabel()
        Me.homell = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.donebtn = New FontAwesome.Sharp.IconButton()
        Me.logoutbtn = New FontAwesome.Sharp.IconButton()
        Me.requestbtn = New FontAwesome.Sharp.IconButton()
        Me.citizenbtn = New FontAwesome.Sharp.IconButton()
        Me.homebtn = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nametb = New System.Windows.Forms.TextBox()
        Me.agetb = New System.Windows.Forms.TextBox()
        Me.contacttb = New System.Windows.Forms.TextBox()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.gendercb = New System.Windows.Forms.ComboBox()
        Me.purokcb = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.searchtb = New System.Windows.Forms.TextBox()
        Me.search_txt = New System.Windows.Forms.Label()
        Me.requestcb = New System.Windows.Forms.ComboBox()
        Me.request_txt = New System.Windows.Forms.Label()
        Me.citizenip = New FontAwesome.Sharp.IconPictureBox()
        Me.statuscb = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.citizenip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1924, 150)
        Me.Panel1.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(38, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(155, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 69)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "BCMS"
        '
        'citizenll
        '
        Me.citizenll.ActiveLinkColor = System.Drawing.Color.LightSkyBlue
        Me.citizenll.LinkColor = System.Drawing.Color.White
        Me.citizenll.Location = New System.Drawing.Point(112, 190)
        Me.citizenll.Name = "citizenll"
        Me.citizenll.Size = New System.Drawing.Size(100, 50)
        Me.citizenll.TabIndex = 13
        Me.citizenll.TabStop = True
        Me.citizenll.Text = "CITIZENS"
        '
        'homell
        '
        Me.homell.ActiveLinkColor = System.Drawing.Color.LightSkyBlue
        Me.homell.AutoSize = True
        Me.homell.LinkColor = System.Drawing.Color.White
        Me.homell.Location = New System.Drawing.Point(109, 116)
        Me.homell.Name = "homell"
        Me.homell.Size = New System.Drawing.Size(87, 16)
        Me.homell.TabIndex = 12
        Me.homell.TabStop = True
        Me.homell.Text = "HOME PAGE"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.donebtn)
        Me.Panel2.Controls.Add(Me.logoutbtn)
        Me.Panel2.Controls.Add(Me.requestbtn)
        Me.Panel2.Controls.Add(Me.citizenbtn)
        Me.Panel2.Controls.Add(Me.homebtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 150)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(362, 905)
        Me.Panel2.TabIndex = 16
        '
        'donebtn
        '
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
        Me.donebtn.TabIndex = 38
        Me.donebtn.Text = "READY TO PICK"
        Me.donebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.donebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.donebtn.UseVisualStyleBackColor = True
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
        Me.citizenbtn.BackColor = System.Drawing.Color.Gold
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
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(583, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "NAME :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(562, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "GENDER :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(595, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "AGE :"
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
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "PUROK :"
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
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "CONTACT :"
        '
        'nametb
        '
        Me.nametb.Location = New System.Drawing.Point(674, 331)
        Me.nametb.Name = "nametb"
        Me.nametb.Size = New System.Drawing.Size(247, 22)
        Me.nametb.TabIndex = 22
        '
        'agetb
        '
        Me.agetb.Location = New System.Drawing.Point(674, 412)
        Me.agetb.Name = "agetb"
        Me.agetb.Size = New System.Drawing.Size(247, 22)
        Me.agetb.TabIndex = 24
        '
        'contacttb
        '
        Me.contacttb.Location = New System.Drawing.Point(674, 494)
        Me.contacttb.Name = "contacttb"
        Me.contacttb.Size = New System.Drawing.Size(247, 22)
        Me.contacttb.TabIndex = 26
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.addbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.addbtn.Location = New System.Drawing.Point(655, 664)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(122, 46)
        Me.addbtn.TabIndex = 27
        Me.addbtn.Text = "ADD"
        Me.addbtn.UseVisualStyleBackColor = False
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
        Me.DataGridView1.TabIndex = 28
        '
        'gendercb
        '
        Me.gendercb.FormattingEnabled = True
        Me.gendercb.Location = New System.Drawing.Point(674, 370)
        Me.gendercb.Name = "gendercb"
        Me.gendercb.Size = New System.Drawing.Size(247, 24)
        Me.gendercb.TabIndex = 30
        '
        'purokcb
        '
        Me.purokcb.FormattingEnabled = True
        Me.purokcb.Location = New System.Drawing.Point(674, 450)
        Me.purokcb.Name = "purokcb"
        Me.purokcb.Size = New System.Drawing.Size(247, 24)
        Me.purokcb.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(469, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(245, 54)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "CITIZENS"
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.Color.Blue
        Me.updatebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.ForeColor = System.Drawing.Color.White
        Me.updatebtn.Location = New System.Drawing.Point(799, 663)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(122, 46)
        Me.updatebtn.TabIndex = 33
        Me.updatebtn.Text = "UPDATE"
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.Color.Red
        Me.deletebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.ForeColor = System.Drawing.Color.White
        Me.deletebtn.Location = New System.Drawing.Point(655, 742)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(122, 46)
        Me.deletebtn.TabIndex = 34
        Me.deletebtn.Text = "DELETE"
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.clearbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.ForeColor = System.Drawing.Color.White
        Me.clearbtn.Location = New System.Drawing.Point(799, 742)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(122, 46)
        Me.clearbtn.TabIndex = 35
        Me.clearbtn.Text = "CLEAR"
        Me.clearbtn.UseVisualStyleBackColor = False
        '
        'searchtb
        '
        Me.searchtb.Location = New System.Drawing.Point(953, 287)
        Me.searchtb.Name = "searchtb"
        Me.searchtb.Size = New System.Drawing.Size(543, 22)
        Me.searchtb.TabIndex = 37
        '
        'search_txt
        '
        Me.search_txt.AutoSize = True
        Me.search_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_txt.ForeColor = System.Drawing.Color.Navy
        Me.search_txt.Location = New System.Drawing.Point(950, 258)
        Me.search_txt.Name = "search_txt"
        Me.search_txt.Size = New System.Drawing.Size(69, 16)
        Me.search_txt.TabIndex = 36
        Me.search_txt.Text = "SEARCH"
        '
        'requestcb
        '
        Me.requestcb.FormattingEnabled = True
        Me.requestcb.Location = New System.Drawing.Point(674, 534)
        Me.requestcb.Name = "requestcb"
        Me.requestcb.Size = New System.Drawing.Size(247, 24)
        Me.requestcb.TabIndex = 39
        '
        'request_txt
        '
        Me.request_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.request_txt.AutoSize = True
        Me.request_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.request_txt.ForeColor = System.Drawing.Color.Navy
        Me.request_txt.Location = New System.Drawing.Point(554, 534)
        Me.request_txt.Name = "request_txt"
        Me.request_txt.Size = New System.Drawing.Size(88, 16)
        Me.request_txt.TabIndex = 38
        Me.request_txt.Text = "REQUEST :"
        '
        'citizenip
        '
        Me.citizenip.BackColor = System.Drawing.SystemColors.Control
        Me.citizenip.ForeColor = System.Drawing.Color.Navy
        Me.citizenip.IconChar = FontAwesome.Sharp.IconChar.User
        Me.citizenip.IconColor = System.Drawing.Color.Navy
        Me.citizenip.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.citizenip.IconSize = 54
        Me.citizenip.Location = New System.Drawing.Point(409, 202)
        Me.citizenip.Name = "citizenip"
        Me.citizenip.Size = New System.Drawing.Size(54, 54)
        Me.citizenip.TabIndex = 40
        Me.citizenip.TabStop = False
        '
        'statuscb
        '
        Me.statuscb.FormattingEnabled = True
        Me.statuscb.Location = New System.Drawing.Point(674, 576)
        Me.statuscb.Name = "statuscb"
        Me.statuscb.Size = New System.Drawing.Size(247, 24)
        Me.statuscb.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(565, 576)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 16)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "STATUS :"
        '
        'Citizen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.statuscb)
        Me.Controls.Add(Me.citizenip)
        Me.Controls.Add(Me.requestcb)
        Me.Controls.Add(Me.request_txt)
        Me.Controls.Add(Me.searchtb)
        Me.Controls.Add(Me.search_txt)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.purokcb)
        Me.Controls.Add(Me.gendercb)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.contacttb)
        Me.Controls.Add(Me.agetb)
        Me.Controls.Add(Me.nametb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.citizenll)
        Me.Controls.Add(Me.homell)
        Me.Name = "Citizen"
        Me.Text = "CITIZENS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.citizenip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents citizenll As LinkLabel
    Friend WithEvents homell As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nametb As TextBox
    Friend WithEvents agetb As TextBox
    Friend WithEvents contacttb As TextBox
    Friend WithEvents addbtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents gendercb As ComboBox
    Friend WithEvents purokcb As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents homebtn As FontAwesome.Sharp.IconButton
    Friend WithEvents updatebtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents clearbtn As Button
    Friend WithEvents searchtb As TextBox
    Friend WithEvents search_txt As Label
    Friend WithEvents requestcb As ComboBox
    Friend WithEvents request_txt As Label
    Friend WithEvents requestbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents citizenbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents citizenip As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents logoutbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents donebtn As FontAwesome.Sharp.IconButton
    Friend WithEvents statuscb As ComboBox
    Friend WithEvents Label8 As Label
End Class
