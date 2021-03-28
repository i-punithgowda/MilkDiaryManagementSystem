<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.milkDairyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.setFatePriceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchMilkDairyRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menuStrip1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.menuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStrip1.GripMargin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.milkDairyToolStripMenuItem, Me.setFatePriceToolStripMenuItem, Me.searchAccountToolStripMenuItem, Me.searchMilkDairyRecordToolStripMenuItem, Me.newAccountToolStripMenuItem, Me.exitToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Margin = New System.Windows.Forms.Padding(5)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Padding = New System.Windows.Forms.Padding(10, 2, 0, 2)
        Me.menuStrip1.Size = New System.Drawing.Size(851, 30)
        Me.menuStrip1.TabIndex = 5
        Me.menuStrip1.Text = "menuStrip1"
        '
        'milkDairyToolStripMenuItem
        '
        Me.milkDairyToolStripMenuItem.AutoToolTip = True
        Me.milkDairyToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.milkDairyToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.milkDairyToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.milkDairyToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.milkDairyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.milkDairyToolStripMenuItem.Name = "milkDairyToolStripMenuItem"
        Me.milkDairyToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.milkDairyToolStripMenuItem.Text = "Milk Dairy"
        Me.milkDairyToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'setFatePriceToolStripMenuItem
        '
        Me.setFatePriceToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.setFatePriceToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.setFatePriceToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.setFatePriceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.setFatePriceToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.setFatePriceToolStripMenuItem.Name = "setFatePriceToolStripMenuItem"
        Me.setFatePriceToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.setFatePriceToolStripMenuItem.Text = "Set Fate Price"
        Me.setFatePriceToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'searchAccountToolStripMenuItem
        '
        Me.searchAccountToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.searchAccountToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.searchAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.searchAccountToolStripMenuItem.Name = "searchAccountToolStripMenuItem"
        Me.searchAccountToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.searchAccountToolStripMenuItem.Text = "Search Account"
        Me.searchAccountToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'searchMilkDairyRecordToolStripMenuItem
        '
        Me.searchMilkDairyRecordToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.searchMilkDairyRecordToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.searchMilkDairyRecordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.searchMilkDairyRecordToolStripMenuItem.Name = "searchMilkDairyRecordToolStripMenuItem"
        Me.searchMilkDairyRecordToolStripMenuItem.Size = New System.Drawing.Size(239, 24)
        Me.searchMilkDairyRecordToolStripMenuItem.Text = "Search Milk Dairy Record"
        Me.searchMilkDairyRecordToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'newAccountToolStripMenuItem
        '
        Me.newAccountToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.newAccountToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.newAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem"
        Me.newAccountToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.newAccountToolStripMenuItem.Text = "New Account"
        Me.newAccountToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.exitToolStripMenuItem.Text = "Exit"
        Me.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(-11, 32)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(999, 467)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 62
        Me.pictureBox1.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(985, 494)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.menuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents milkDairyToolStripMenuItem As ToolStripMenuItem
    Private WithEvents setFatePriceToolStripMenuItem As ToolStripMenuItem
    Private WithEvents searchAccountToolStripMenuItem As ToolStripMenuItem
    Private WithEvents searchMilkDairyRecordToolStripMenuItem As ToolStripMenuItem
    Private WithEvents newAccountToolStripMenuItem As ToolStripMenuItem
    Private WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Private WithEvents pictureBox1 As PictureBox
End Class
