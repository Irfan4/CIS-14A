<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
    Me.lblMiles = New System.Windows.Forms.Label()
    Me.lblYards = New System.Windows.Forms.Label()
    Me.lblFeet = New System.Windows.Forms.Label()
    Me.lblInches = New System.Windows.Forms.Label()
    Me.txtMiles = New System.Windows.Forms.TextBox()
    Me.txtYards = New System.Windows.Forms.TextBox()
    Me.txtInches = New System.Windows.Forms.TextBox()
    Me.txtFeet = New System.Windows.Forms.TextBox()
    Me.lstOut = New System.Windows.Forms.ListBox()
    Me.btnConvert = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'lblMiles
    '
    Me.lblMiles.AutoSize = True
    Me.lblMiles.Location = New System.Drawing.Point(37, 31)
    Me.lblMiles.Name = "lblMiles"
    Me.lblMiles.Size = New System.Drawing.Size(44, 17)
    Me.lblMiles.TabIndex = 0
    Me.lblMiles.Text = "&Miles:"
    '
    'lblYards
    '
    Me.lblYards.AutoSize = True
    Me.lblYards.Location = New System.Drawing.Point(37, 76)
    Me.lblYards.Name = "lblYards"
    Me.lblYards.Size = New System.Drawing.Size(49, 17)
    Me.lblYards.TabIndex = 1
    Me.lblYards.Text = "&Yards:"
    '
    'lblFeet
    '
    Me.lblFeet.AutoSize = True
    Me.lblFeet.Location = New System.Drawing.Point(37, 121)
    Me.lblFeet.Name = "lblFeet"
    Me.lblFeet.Size = New System.Drawing.Size(40, 17)
    Me.lblFeet.TabIndex = 2
    Me.lblFeet.Text = "&Feet:"
    '
    'lblInches
    '
    Me.lblInches.AutoSize = True
    Me.lblInches.Location = New System.Drawing.Point(37, 159)
    Me.lblInches.Name = "lblInches"
    Me.lblInches.Size = New System.Drawing.Size(53, 17)
    Me.lblInches.TabIndex = 3
    Me.lblInches.Text = "&Inches:"
    '
    'txtMiles
    '
    Me.txtMiles.Location = New System.Drawing.Point(102, 31)
    Me.txtMiles.Name = "txtMiles"
    Me.txtMiles.Size = New System.Drawing.Size(100, 22)
    Me.txtMiles.TabIndex = 0
    Me.txtMiles.Text = "0"
    '
    'txtYards
    '
    Me.txtYards.Location = New System.Drawing.Point(102, 76)
    Me.txtYards.Name = "txtYards"
    Me.txtYards.Size = New System.Drawing.Size(100, 22)
    Me.txtYards.TabIndex = 1
    Me.txtYards.Text = "0"
    '
    'txtInches
    '
    Me.txtInches.Location = New System.Drawing.Point(102, 156)
    Me.txtInches.Name = "txtInches"
    Me.txtInches.Size = New System.Drawing.Size(100, 22)
    Me.txtInches.TabIndex = 3
    Me.txtInches.Text = "0"
    '
    'txtFeet
    '
    Me.txtFeet.Location = New System.Drawing.Point(102, 118)
    Me.txtFeet.Name = "txtFeet"
    Me.txtFeet.Size = New System.Drawing.Size(100, 22)
    Me.txtFeet.TabIndex = 2
    Me.txtFeet.Text = "0"
    '
    'lstOut
    '
    Me.lstOut.FormattingEnabled = True
    Me.lstOut.ItemHeight = 16
    Me.lstOut.Location = New System.Drawing.Point(102, 204)
    Me.lstOut.Name = "lstOut"
    Me.lstOut.Size = New System.Drawing.Size(236, 84)
    Me.lstOut.TabIndex = 4
    '
    'btnConvert
    '
    Me.btnConvert.Location = New System.Drawing.Point(229, 91)
    Me.btnConvert.Name = "btnConvert"
    Me.btnConvert.Size = New System.Drawing.Size(142, 38)
    Me.btnConvert.TabIndex = 5
    Me.btnConvert.Text = "&Convert To Metric"
    Me.btnConvert.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(383, 319)
    Me.Controls.Add(Me.btnConvert)
    Me.Controls.Add(Me.lstOut)
    Me.Controls.Add(Me.txtFeet)
    Me.Controls.Add(Me.txtInches)
    Me.Controls.Add(Me.txtYards)
    Me.Controls.Add(Me.txtMiles)
    Me.Controls.Add(Me.lblInches)
    Me.Controls.Add(Me.lblFeet)
    Me.Controls.Add(Me.lblYards)
    Me.Controls.Add(Me.lblMiles)
    Me.Name = "Form1"
    Me.Text = "Project1: Length Conversion"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents lblMiles As Label
  Friend WithEvents lblYards As Label
  Friend WithEvents lblFeet As Label
  Friend WithEvents lblInches As Label
  Friend WithEvents txtMiles As TextBox
  Friend WithEvents txtYards As TextBox
  Friend WithEvents txtInches As TextBox
  Friend WithEvents txtFeet As TextBox
  Friend WithEvents lstOut As ListBox
  Friend WithEvents btnConvert As Button
End Class
