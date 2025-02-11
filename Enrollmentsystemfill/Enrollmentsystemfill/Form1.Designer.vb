<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDoB = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblPn = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblYr = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtDoB = New System.Windows.Forms.TextBox()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.txtPn = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtYr = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSelect = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enrollment System"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(47, 63)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 15)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(58, 105)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(36, 15)
        Me.lblAge.TabIndex = 2
        Me.lblAge.Text = "Age:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(47, 144)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(59, 15)
        Me.lblGender.TabIndex = 3
        Me.lblGender.Text = "Gender:"
        '
        'lblDoB
        '
        Me.lblDoB.AutoSize = True
        Me.lblDoB.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoB.Location = New System.Drawing.Point(9, 182)
        Me.lblDoB.Name = "lblDoB"
        Me.lblDoB.Size = New System.Drawing.Size(92, 15)
        Me.lblDoB.TabIndex = 4
        Me.lblDoB.Text = "Date of Birth:"
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(39, 221)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(67, 15)
        Me.lblAdd.TabIndex = 5
        Me.lblAdd.Text = "Address: "
        '
        'lblPn
        '
        Me.lblPn.AutoSize = True
        Me.lblPn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPn.Location = New System.Drawing.Point(-1, 260)
        Me.lblPn.Name = "lblPn"
        Me.lblPn.Size = New System.Drawing.Size(107, 15)
        Me.lblPn.TabIndex = 6
        Me.lblPn.Text = "Phone Number:"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(42, 298)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(58, 15)
        Me.lblCourse.TabIndex = 7
        Me.lblCourse.Text = "Course:"
        '
        'lblYr
        '
        Me.lblYr.AutoSize = True
        Me.lblYr.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYr.Location = New System.Drawing.Point(53, 338)
        Me.lblYr.Name = "lblYr"
        Me.lblYr.Size = New System.Drawing.Size(41, 15)
        Me.lblYr.TabIndex = 8
        Me.lblYr.Text = "Year:"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(103, 61)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(202, 20)
        Me.txtname.TabIndex = 9
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(103, 103)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(202, 20)
        Me.txtAge.TabIndex = 10
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(103, 141)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(202, 20)
        Me.txtGender.TabIndex = 11
        '
        'txtDoB
        '
        Me.txtDoB.Location = New System.Drawing.Point(103, 180)
        Me.txtDoB.Name = "txtDoB"
        Me.txtDoB.Size = New System.Drawing.Size(202, 20)
        Me.txtDoB.TabIndex = 12
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(103, 218)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(202, 20)
        Me.txtAdd.TabIndex = 13
        '
        'txtPn
        '
        Me.txtPn.Location = New System.Drawing.Point(103, 258)
        Me.txtPn.Name = "txtPn"
        Me.txtPn.Size = New System.Drawing.Size(202, 20)
        Me.txtPn.TabIndex = 14
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(103, 295)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(202, 20)
        Me.txtCourse.TabIndex = 15
        '
        'txtYr
        '
        Me.txtYr.Location = New System.Drawing.Point(103, 335)
        Me.txtYr.Name = "txtYr"
        Me.txtYr.Size = New System.Drawing.Size(202, 20)
        Me.txtYr.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(172, 410)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Select"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(332, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(476, 247)
        Me.DataGridView1.TabIndex = 19
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Transparent
        Me.btnSelect.BackgroundImage = Global.Enrollmentsystemfill.My.Resources.Resources.add1
        Me.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSelect.Location = New System.Drawing.Point(171, 361)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(50, 47)
        Me.btnSelect.TabIndex = 17
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(829, 434)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.txtYr)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.txtPn)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.txtDoB)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblYr)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblPn)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.lblDoB)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "1st year"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblDoB As System.Windows.Forms.Label
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents lblPn As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblYr As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents txtDoB As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtPn As System.Windows.Forms.TextBox
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents txtYr As System.Windows.Forms.TextBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
