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
    Me.lblDesc = New System.Windows.Forms.Label()
    Me.lblYearPurchased = New System.Windows.Forms.Label()
    Me.lblPurchaseAmount = New System.Windows.Forms.Label()
    Me.lblYearsDepreciated = New System.Windows.Forms.Label()
    Me.txtDesc = New System.Windows.Forms.TextBox()
    Me.txtYearPurchased = New System.Windows.Forms.TextBox()
    Me.txtPurchaseAmount = New System.Windows.Forms.TextBox()
    Me.txtYearsDepreciated = New System.Windows.Forms.TextBox()
    Me.grpMethod = New System.Windows.Forms.GroupBox()
    Me.radDoubleDecline = New System.Windows.Forms.RadioButton()
    Me.radStraightLine = New System.Windows.Forms.RadioButton()
    Me.btnCalculation = New System.Windows.Forms.Button()
    Me.btnRestart = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.txtOutput = New System.Windows.Forms.TextBox()
    Me.lblDepreciation = New System.Windows.Forms.Label()
    Me.grpMethod.SuspendLayout()
    Me.SuspendLayout()
    '
    'lblDesc
    '
    Me.lblDesc.AutoSize = True
    Me.lblDesc.Location = New System.Drawing.Point(290, 122)
    Me.lblDesc.Name = "lblDesc"
    Me.lblDesc.Size = New System.Drawing.Size(83, 17)
    Me.lblDesc.TabIndex = 0
    Me.lblDesc.Text = "&Description:"
    '
    'lblYearPurchased
    '
    Me.lblYearPurchased.AutoSize = True
    Me.lblYearPurchased.Location = New System.Drawing.Point(259, 168)
    Me.lblYearPurchased.Name = "lblYearPurchased"
    Me.lblYearPurchased.Size = New System.Drawing.Size(114, 17)
    Me.lblYearPurchased.TabIndex = 1
    Me.lblYearPurchased.Text = "&Year Purchased:"
    '
    'lblPurchaseAmount
    '
    Me.lblPurchaseAmount.AutoSize = True
    Me.lblPurchaseAmount.Location = New System.Drawing.Point(249, 201)
    Me.lblPurchaseAmount.Name = "lblPurchaseAmount"
    Me.lblPurchaseAmount.Size = New System.Drawing.Size(124, 17)
    Me.lblPurchaseAmount.TabIndex = 2
    Me.lblPurchaseAmount.Text = "&Purchase Amount:"
    '
    'lblYearsDepreciated
    '
    Me.lblYearsDepreciated.AutoSize = True
    Me.lblYearsDepreciated.Location = New System.Drawing.Point(227, 241)
    Me.lblYearsDepreciated.Name = "lblYearsDepreciated"
    Me.lblYearsDepreciated.Size = New System.Drawing.Size(138, 34)
    Me.lblYearsDepreciated.TabIndex = 3
    Me.lblYearsDepreciated.Text = "&Years to Depreciate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Over:"
    Me.lblYearsDepreciated.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'txtDesc
    '
    Me.txtDesc.Location = New System.Drawing.Point(399, 119)
    Me.txtDesc.Name = "txtDesc"
    Me.txtDesc.Size = New System.Drawing.Size(358, 22)
    Me.txtDesc.TabIndex = 0
    '
    'txtYearPurchased
    '
    Me.txtYearPurchased.Location = New System.Drawing.Point(399, 165)
    Me.txtYearPurchased.Name = "txtYearPurchased"
    Me.txtYearPurchased.Size = New System.Drawing.Size(201, 22)
    Me.txtYearPurchased.TabIndex = 1
    '
    'txtPurchaseAmount
    '
    Me.txtPurchaseAmount.Location = New System.Drawing.Point(399, 201)
    Me.txtPurchaseAmount.Name = "txtPurchaseAmount"
    Me.txtPurchaseAmount.Size = New System.Drawing.Size(201, 22)
    Me.txtPurchaseAmount.TabIndex = 2
    '
    'txtYearsDepreciated
    '
    Me.txtYearsDepreciated.Location = New System.Drawing.Point(399, 241)
    Me.txtYearsDepreciated.Name = "txtYearsDepreciated"
    Me.txtYearsDepreciated.Size = New System.Drawing.Size(201, 22)
    Me.txtYearsDepreciated.TabIndex = 3
    '
    'grpMethod
    '
    Me.grpMethod.Controls.Add(Me.radDoubleDecline)
    Me.grpMethod.Controls.Add(Me.radStraightLine)
    Me.grpMethod.Location = New System.Drawing.Point(362, 294)
    Me.grpMethod.Name = "grpMethod"
    Me.grpMethod.Size = New System.Drawing.Size(238, 100)
    Me.grpMethod.TabIndex = 4
    Me.grpMethod.TabStop = False
    Me.grpMethod.Text = "Select a Depreciation Method"
    '
    'radDoubleDecline
    '
    Me.radDoubleDecline.AutoSize = True
    Me.radDoubleDecline.Location = New System.Drawing.Point(6, 59)
    Me.radDoubleDecline.Name = "radDoubleDecline"
    Me.radDoubleDecline.Size = New System.Drawing.Size(220, 21)
    Me.radDoubleDecline.TabIndex = 6
    Me.radDoubleDecline.TabStop = True
    Me.radDoubleDecline.Text = "Double-declining Method (2/n)"
    Me.radDoubleDecline.UseVisualStyleBackColor = True
    '
    'radStraightLine
    '
    Me.radStraightLine.AutoSize = True
    Me.radStraightLine.Checked = True
    Me.radStraightLine.Location = New System.Drawing.Point(6, 21)
    Me.radStraightLine.Name = "radStraightLine"
    Me.radStraightLine.Size = New System.Drawing.Size(190, 21)
    Me.radStraightLine.TabIndex = 5
    Me.radStraightLine.TabStop = True
    Me.radStraightLine.Text = "Straight-line Method (1/n)"
    Me.radStraightLine.UseVisualStyleBackColor = True
    '
    'btnCalculation
    '
    Me.btnCalculation.Location = New System.Drawing.Point(294, 420)
    Me.btnCalculation.Name = "btnCalculation"
    Me.btnCalculation.Size = New System.Drawing.Size(127, 33)
    Me.btnCalculation.TabIndex = 7
    Me.btnCalculation.Text = "&Show Calculation"
    Me.btnCalculation.UseVisualStyleBackColor = True
    '
    'btnRestart
    '
    Me.btnRestart.Location = New System.Drawing.Point(454, 420)
    Me.btnRestart.Name = "btnRestart"
    Me.btnRestart.Size = New System.Drawing.Size(108, 33)
    Me.btnRestart.TabIndex = 8
    Me.btnRestart.Text = "&ReStart"
    Me.btnRestart.UseVisualStyleBackColor = True
    '
    'btnClose
    '
    Me.btnClose.Location = New System.Drawing.Point(607, 420)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(108, 33)
    Me.btnClose.TabIndex = 9
    Me.btnClose.Text = "&Close"
    Me.btnClose.UseVisualStyleBackColor = True
    '
    'txtOutput
    '
    Me.txtOutput.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtOutput.Location = New System.Drawing.Point(25, 499)
    Me.txtOutput.Multiline = True
    Me.txtOutput.Name = "txtOutput"
    Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.txtOutput.Size = New System.Drawing.Size(943, 214)
    Me.txtOutput.TabIndex = 10
    '
    'lblDepreciation
    '
    Me.lblDepreciation.AutoSize = True
    Me.lblDepreciation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDepreciation.Location = New System.Drawing.Point(224, 34)
    Me.lblDepreciation.Name = "lblDepreciation"
    Me.lblDepreciation.Size = New System.Drawing.Size(557, 32)
    Me.lblDepreciation.TabIndex = 11
    Me.lblDepreciation.Text = "Depreciation to a Salvage Value of Zero" & Global.Microsoft.VisualBasic.ChrW(13)
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1005, 759)
    Me.Controls.Add(Me.lblDepreciation)
    Me.Controls.Add(Me.txtOutput)
    Me.Controls.Add(Me.btnClose)
    Me.Controls.Add(Me.btnRestart)
    Me.Controls.Add(Me.btnCalculation)
    Me.Controls.Add(Me.grpMethod)
    Me.Controls.Add(Me.txtYearsDepreciated)
    Me.Controls.Add(Me.txtPurchaseAmount)
    Me.Controls.Add(Me.txtYearPurchased)
    Me.Controls.Add(Me.txtDesc)
    Me.Controls.Add(Me.lblYearsDepreciated)
    Me.Controls.Add(Me.lblPurchaseAmount)
    Me.Controls.Add(Me.lblYearPurchased)
    Me.Controls.Add(Me.lblDesc)
    Me.Name = "Form1"
    Me.Text = " Project3: Depreciation to a Salvage Value of Zero"
    Me.grpMethod.ResumeLayout(False)
    Me.grpMethod.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents lblDesc As Label
  Friend WithEvents lblYearPurchased As Label
  Friend WithEvents lblPurchaseAmount As Label
  Friend WithEvents lblYearsDepreciated As Label
  Friend WithEvents txtDesc As TextBox
  Friend WithEvents txtYearPurchased As TextBox
  Friend WithEvents txtPurchaseAmount As TextBox
  Friend WithEvents txtYearsDepreciated As TextBox
  Friend WithEvents grpMethod As GroupBox
  Friend WithEvents radDoubleDecline As RadioButton
  Friend WithEvents radStraightLine As RadioButton
  Friend WithEvents btnCalculation As Button
  Friend WithEvents btnRestart As Button
  Friend WithEvents btnClose As Button
  Friend WithEvents txtOutput As TextBox
  Friend WithEvents lblDepreciation As Label
End Class
