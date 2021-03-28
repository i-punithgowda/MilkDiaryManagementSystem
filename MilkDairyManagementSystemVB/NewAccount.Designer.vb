<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewAccount
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewAccount))
        Me.AcntBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DairyDataSet = New MilkDairyManagementSystemVB.dairyDataSet()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Fname = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.AcntTableAdapter = New MilkDairyManagementSystemVB.dairyDataSetTableAdapters.acntTableAdapter()
        Me.label6 = New System.Windows.Forms.Label()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AcntBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DairyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AcntBindingSource
        '
        Me.AcntBindingSource.DataMember = "acnt"
        Me.AcntBindingSource.DataSource = Me.DairyDataSet
        '
        'DairyDataSet
        '
        Me.DairyDataSet.DataSetName = "dairyDataSet"
        Me.DairyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'button3
        '
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(612, 431)
        Me.button3.Margin = New System.Windows.Forms.Padding(4)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(108, 34)
        Me.button3.TabIndex = 74
        Me.button3.Text = "Reset"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.Location = New System.Drawing.Point(468, 431)
        Me.button4.Margin = New System.Windows.Forms.Padding(4)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(108, 34)
        Me.button4.TabIndex = 73
        Me.button4.Text = "Update"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(319, 431)
        Me.button2.Margin = New System.Windows.Forms.Padding(4)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(108, 34)
        Me.button2.TabIndex = 72
        Me.button2.Text = "Search"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(175, 431)
        Me.button1.Margin = New System.Windows.Forms.Padding(4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(108, 34)
        Me.button1.TabIndex = 71
        Me.button1.Text = "Add"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox4
        '
        Me.textBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox4.Location = New System.Drawing.Point(375, 361)
        Me.textBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(197, 26)
        Me.textBox4.TabIndex = 69
        '
        'textBox3
        '
        Me.textBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox3.Location = New System.Drawing.Point(375, 287)
        Me.textBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(197, 26)
        Me.textBox3.TabIndex = 68
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(375, 154)
        Me.textBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(197, 26)
        Me.textBox2.TabIndex = 67
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(188, 364)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(76, 25)
        Me.label5.TabIndex = 65
        Me.label5.Text = "Mobile"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(187, 287)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(92, 25)
        Me.label4.TabIndex = 64
        Me.label4.Text = "Address"
        '
        'Fname
        '
        Me.Fname.AutoSize = True
        Me.Fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fname.Location = New System.Drawing.Point(186, 154)
        Me.Fname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(68, 25)
        Me.Fname.TabIndex = 63
        Me.Fname.Text = "Name"
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(375, 81)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(197, 26)
        Me.textBox1.TabIndex = 61
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(185, 85)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(172, 25)
        Me.label3.TabIndex = 60
        Me.label3.Text = "Account Number"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Forte", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(331, 26)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(218, 37)
        Me.label2.TabIndex = 59
        Me.label2.Text = "New Account"
        '
        'AcntTableAdapter
        '
        Me.AcntTableAdapter.ClearBeforeFill = True
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(183, 222)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(115, 25)
        Me.label6.TabIndex = 76
        Me.label6.Text = "Last Name"
        '
        'textBox5
        '
        Me.textBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox5.Location = New System.Drawing.Point(375, 219)
        Me.textBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(197, 26)
        Me.textBox5.TabIndex = 77
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 502)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(748, 190)
        Me.DataGridView1.TabIndex = 79
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(631, 13)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(225, 165)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 62
        Me.pictureBox1.TabStop = False
        '
        'NewAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(857, 704)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.textBox5)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.Fname)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "NewAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewAccount"
        CType(Me.AcntBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DairyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button3 As Button
    Private WithEvents button4 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents textBox4 As TextBox
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents Fname As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Friend WithEvents DairyDataSet As dairyDataSet
    Friend WithEvents AcntBindingSource As BindingSource
    Friend WithEvents AcntTableAdapter As dairyDataSetTableAdapters.acntTableAdapter
    Private WithEvents label6 As Label
    Private WithEvents textBox5 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
