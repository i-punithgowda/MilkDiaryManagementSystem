<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchMilkDairyRecord
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchMilkDairyRecord))
        Me.DairyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DairyDataSet2 = New MilkDairyManagementSystemVB.dairyDataSet2()
        Me.label2 = New System.Windows.Forms.Label()
        Me.DairyTableAdapter = New MilkDairyManagementSystemVB.dairyDataSet2TableAdapters.dairyTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbAcc = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.Year = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTtl = New System.Windows.Forms.Label()
        Me.payBtn = New System.Windows.Forms.Button()
        CType(Me.DairyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DairyDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DairyBindingSource
        '
        Me.DairyBindingSource.DataMember = "dairy"
        Me.DairyBindingSource.DataSource = Me.DairyDataSet2
        '
        'DairyDataSet2
        '
        Me.DairyDataSet2.DataSetName = "dairyDataSet2"
        Me.DairyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Forte", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(307, 36)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(246, 37)
        Me.label2.TabIndex = 61
        Me.label2.Text = "Pay Customers"
        '
        'DairyTableAdapter
        '
        Me.DairyTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(33, 258)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(687, 261)
        Me.DataGridView1.TabIndex = 63
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(618, 13)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(275, 238)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 64
        Me.pictureBox1.TabStop = False
        '
        'cmbAcc
        '
        Me.cmbAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAcc.FormattingEnabled = True
        Me.cmbAcc.Location = New System.Drawing.Point(364, 195)
        Me.cmbAcc.Name = "cmbAcc"
        Me.cmbAcc.Size = New System.Drawing.Size(121, 34)
        Me.cmbAcc.TabIndex = 86
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(190, 203)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(148, 20)
        Me.label3.TabIndex = 87
        Me.label3.Text = "Account Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 108)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Month"
        '
        'cmbMonth
        '
        Me.cmbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.cmbMonth.Location = New System.Drawing.Point(364, 94)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(121, 34)
        Me.cmbMonth.TabIndex = 89
        '
        'Year
        '
        Me.Year.AutoSize = True
        Me.Year.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Year.Location = New System.Drawing.Point(236, 155)
        Me.Year.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(47, 20)
        Me.Year.TabIndex = 90
        Me.Year.Text = "Year"
        '
        'cmbYear
        '
        Me.cmbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025"})
        Me.cmbYear.Location = New System.Drawing.Point(364, 141)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 34)
        Me.cmbYear.TabIndex = 91
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(502, 538)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 46)
        Me.Button1.TabIndex = 92
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblTtl
        '
        Me.lblTtl.AutoSize = True
        Me.lblTtl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTtl.ForeColor = System.Drawing.Color.White
        Me.lblTtl.Location = New System.Drawing.Point(677, 543)
        Me.lblTtl.Name = "lblTtl"
        Me.lblTtl.Size = New System.Drawing.Size(0, 31)
        Me.lblTtl.TabIndex = 93
        '
        'payBtn
        '
        Me.payBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payBtn.Location = New System.Drawing.Point(629, 587)
        Me.payBtn.Name = "payBtn"
        Me.payBtn.Size = New System.Drawing.Size(117, 46)
        Me.payBtn.TabIndex = 94
        Me.payBtn.Text = "Pay"
        Me.payBtn.UseVisualStyleBackColor = True
        '
        'SearchMilkDairyRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(877, 645)
        Me.Controls.Add(Me.payBtn)
        Me.Controls.Add(Me.lblTtl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.cmbAcc)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "SearchMilkDairyRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pay customers"
        CType(Me.DairyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DairyDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label2 As Label
    Friend WithEvents DairyDataSet2 As dairyDataSet2
    Friend WithEvents DairyBindingSource As BindingSource
    Friend WithEvents DairyTableAdapter As dairyDataSet2TableAdapters.dairyTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents cmbAcc As ComboBox
    Private WithEvents label3 As Label
    Private WithEvents Label1 As Label
    Friend WithEvents cmbMonth As ComboBox
    Private WithEvents Year As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTtl As Label
    Friend WithEvents payBtn As Button
End Class
