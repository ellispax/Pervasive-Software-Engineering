<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblvisitors = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblMCount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblresidents = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.panelMembers = New System.Windows.Forms.Panel()
        Me.lblUsed = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblfree = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.panelSlots = New System.Windows.Forms.Panel()
        Me.lblSlots = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblweather = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.panelMembers.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.panelSlots.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Panel11)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.panelMembers)
        Me.Panel1.Controls.Add(Me.panelSlots)
        Me.Panel1.Controls.Add(Me.lblweather)
        Me.Panel1.Controls.Add(Me.lbltime)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 532)
        Me.Panel1.TabIndex = 0
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Blue
        Me.Panel11.Location = New System.Drawing.Point(549, 283)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(255, 28)
        Me.Panel11.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Location = New System.Drawing.Point(549, 215)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(255, 96)
        Me.Panel3.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.lblvisitors)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Panel10)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Location = New System.Drawing.Point(291, 215)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(252, 96)
        Me.Panel2.TabIndex = 6
        '
        'lblvisitors
        '
        Me.lblvisitors.AutoSize = True
        Me.lblvisitors.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblvisitors.Location = New System.Drawing.Point(184, 14)
        Me.lblvisitors.Name = "lblvisitors"
        Me.lblvisitors.Size = New System.Drawing.Size(61, 43)
        Me.lblvisitors.TabIndex = 4
        Me.lblvisitors.Text = "35"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(18, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Visitors"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Blue
        Me.Panel10.Location = New System.Drawing.Point(1, 68)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(251, 28)
        Me.Panel10.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel5.Controls.Add(Me.lblMCount)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel5.Location = New System.Drawing.Point(550, 95)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(254, 96)
        Me.Panel5.TabIndex = 5
        '
        'lblMCount
        '
        Me.lblMCount.AutoSize = True
        Me.lblMCount.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMCount.Location = New System.Drawing.Point(181, 14)
        Me.lblMCount.Name = "lblMCount"
        Me.lblMCount.Size = New System.Drawing.Size(61, 43)
        Me.lblMCount.TabIndex = 4
        Me.lblMCount.Text = "35"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(15, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 21)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Active Memebers"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Blue
        Me.Panel8.Controls.Add(Me.LinkLabel3)
        Me.Panel8.Location = New System.Drawing.Point(-1, 67)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(254, 28)
        Me.Panel8.TabIndex = 1
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.Blue
        Me.LinkLabel3.DisabledLinkColor = System.Drawing.Color.White
        Me.LinkLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel3.ForeColor = System.Drawing.Color.Blue
        Me.LinkLabel3.LinkColor = System.Drawing.Color.White
        Me.LinkLabel3.Location = New System.Drawing.Point(67, 7)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(91, 17)
        Me.LinkLabel3.TabIndex = 2
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "More Info >>"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.lblresidents)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Panel9)
        Me.Panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel4.Location = New System.Drawing.Point(33, 215)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(252, 96)
        Me.Panel4.TabIndex = 4
        '
        'lblresidents
        '
        Me.lblresidents.AutoSize = True
        Me.lblresidents.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblresidents.Location = New System.Drawing.Point(180, 11)
        Me.lblresidents.Name = "lblresidents"
        Me.lblresidents.Size = New System.Drawing.Size(61, 43)
        Me.lblresidents.TabIndex = 3
        Me.lblresidents.Text = "35"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(25, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Residents"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Blue
        Me.Panel9.Controls.Add(Me.LinkLabel4)
        Me.Panel9.Location = New System.Drawing.Point(1, 68)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(251, 28)
        Me.Panel9.TabIndex = 1
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.BackColor = System.Drawing.Color.Blue
        Me.LinkLabel4.DisabledLinkColor = System.Drawing.Color.White
        Me.LinkLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel4.ForeColor = System.Drawing.Color.Blue
        Me.LinkLabel4.LinkColor = System.Drawing.Color.White
        Me.LinkLabel4.Location = New System.Drawing.Point(64, 6)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(91, 17)
        Me.LinkLabel4.TabIndex = 1
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "More Info >>"
        '
        'panelMembers
        '
        Me.panelMembers.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panelMembers.Controls.Add(Me.lblUsed)
        Me.panelMembers.Controls.Add(Me.Label1)
        Me.panelMembers.Controls.Add(Me.lblfree)
        Me.panelMembers.Controls.Add(Me.Label5)
        Me.panelMembers.Controls.Add(Me.Panel7)
        Me.panelMembers.Location = New System.Drawing.Point(291, 95)
        Me.panelMembers.Name = "panelMembers"
        Me.panelMembers.Size = New System.Drawing.Size(253, 96)
        Me.panelMembers.TabIndex = 3
        '
        'lblUsed
        '
        Me.lblUsed.AutoSize = True
        Me.lblUsed.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUsed.ForeColor = System.Drawing.Color.Red
        Me.lblUsed.Location = New System.Drawing.Point(195, 38)
        Me.lblUsed.Name = "lblUsed"
        Me.lblUsed.Size = New System.Drawing.Size(41, 29)
        Me.lblUsed.TabIndex = 5
        Me.lblUsed.Text = "35"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Used Spaces"
        '
        'lblfree
        '
        Me.lblfree.AutoSize = True
        Me.lblfree.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblfree.ForeColor = System.Drawing.Color.White
        Me.lblfree.Location = New System.Drawing.Point(195, 6)
        Me.lblfree.Name = "lblfree"
        Me.lblfree.Size = New System.Drawing.Size(41, 29)
        Me.lblfree.TabIndex = 3
        Me.lblfree.Text = "35"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(18, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Free Spaces"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Blue
        Me.Panel7.Controls.Add(Me.LinkLabel2)
        Me.Panel7.Location = New System.Drawing.Point(0, 68)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(253, 28)
        Me.Panel7.TabIndex = 1
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Blue
        Me.LinkLabel2.DisabledLinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel2.ForeColor = System.Drawing.Color.Blue
        Me.LinkLabel2.LinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Location = New System.Drawing.Point(81, 6)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(91, 17)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "More Info >>"
        '
        'panelSlots
        '
        Me.panelSlots.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panelSlots.Controls.Add(Me.lblSlots)
        Me.panelSlots.Controls.Add(Me.lblName)
        Me.panelSlots.Controls.Add(Me.Panel6)
        Me.panelSlots.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.panelSlots.Location = New System.Drawing.Point(33, 95)
        Me.panelSlots.Name = "panelSlots"
        Me.panelSlots.Size = New System.Drawing.Size(252, 96)
        Me.panelSlots.TabIndex = 2
        '
        'lblSlots
        '
        Me.lblSlots.AutoSize = True
        Me.lblSlots.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSlots.Location = New System.Drawing.Point(188, 14)
        Me.lblSlots.Name = "lblSlots"
        Me.lblSlots.Size = New System.Drawing.Size(61, 43)
        Me.lblSlots.TabIndex = 1
        Me.lblSlots.Text = "35"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(25, 28)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(108, 21)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Parking Lots "
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Blue
        Me.Panel6.Controls.Add(Me.LinkLabel1)
        Me.Panel6.Location = New System.Drawing.Point(0, 67)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(251, 28)
        Me.Panel6.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Blue
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Blue
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(64, 6)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(91, 17)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "More Info >>"
        '
        'lblweather
        '
        Me.lblweather.AutoSize = True
        Me.lblweather.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblweather.Location = New System.Drawing.Point(655, 30)
        Me.lblweather.Name = "lblweather"
        Me.lblweather.Size = New System.Drawing.Size(149, 32)
        Me.lblweather.TabIndex = 1
        Me.lblweather.Text = "Jakarta, 32C"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbltime.Location = New System.Drawing.Point(58, 30)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(189, 32)
        Me.lbltime.TabIndex = 0
        Me.lbltime.Text = "DATE AND TIME"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 556)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "dashboard"
        Me.Text = "dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.panelMembers.ResumeLayout(False)
        Me.panelMembers.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.panelSlots.ResumeLayout(False)
        Me.panelSlots.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents panelMembers As Panel
    Friend WithEvents panelSlots As Panel
    Friend WithEvents lblweather As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblfree As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents lblSlots As Label
    Friend WithEvents lblName As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lblMCount As Label
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblUsed As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblresidents As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents lblvisitors As Label
    Friend WithEvents Label4 As Label
End Class
