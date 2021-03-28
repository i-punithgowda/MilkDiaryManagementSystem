<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetFatePrice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetFatePrice))
        Me.RateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DairyDataSet3 = New MilkDairyManagementSystemVB.dairyDataSet3()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textbox1 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.RateTableAdapter = New MilkDairyManagementSystemVB.dairyDataSet3TableAdapters.rateTableAdapter()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.RateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DairyDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RateBindingSource
        '
        Me.RateBindingSource.DataMember = "rate"
        Me.RateBindingSource.DataSource = Me.DairyDataSet3
        '
        'DairyDataSet3
        '
        Me.DairyDataSet3.DataSetName = "dairyDataSet3"
        Me.DairyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(268, 283)
        Me.button1.Margin = New System.Windows.Forms.Padding(4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(108, 34)
        Me.button1.TabIndex = 67
        Me.button1.Text = "Update"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox3
        '
        Me.textBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox3.Location = New System.Drawing.Point(311, 222)
        Me.textBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(197, 26)
        Me.textBox3.TabIndex = 66
        '
        'textbox1
        '
        Me.textbox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox1.Location = New System.Drawing.Point(311, 162)
        Me.textbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox1.Name = "textbox1"
        Me.textbox1.Size = New System.Drawing.Size(197, 26)
        Me.textbox1.TabIndex = 65
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(123, 225)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(138, 20)
        Me.label4.TabIndex = 64
        Me.label4.Text = "New Fate Price"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(97, 166)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(165, 20)
        Me.label1.TabIndex = 63
        Me.label1.Text = "Current Fate Price"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Forte", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(184, 60)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(304, 37)
        Me.label2.TabIndex = 59
        Me.label2.Text = "Update Milk Price"
        '
        'RateTableAdapter
        '
        Me.RateTableAdapter.ClearBeforeFill = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(552, 24)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(194, 162)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 70
        Me.pictureBox1.TabStop = False
        '
        'SetFatePrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(759, 487)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textbox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "SetFatePrice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update price"
        CType(Me.RateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DairyDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button1 As Button
    Private WithEvents textBox3 As TextBox
    Private WithEvents textbox1 As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Friend WithEvents DairyDataSet3 As dairyDataSet3
    Friend WithEvents RateBindingSource As BindingSource
    Friend WithEvents RateTableAdapter As dairyDataSet3TableAdapters.rateTableAdapter
    Private WithEvents pictureBox1 As PictureBox
End Class
