<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Project2
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
    Me.chkBurgers = New System.Windows.Forms.CheckBox()
    Me.chkFries = New System.Windows.Forms.CheckBox()
    Me.chkDrinks = New System.Windows.Forms.CheckBox()
    Me.grpBurgers = New System.Windows.Forms.GroupBox()
    Me.radCheese_Bacon = New System.Windows.Forms.RadioButton()
    Me.radRegular = New System.Windows.Forms.RadioButton()
    Me.radBacon = New System.Windows.Forms.RadioButton()
    Me.radCheese = New System.Windows.Forms.RadioButton()
    Me.grpFries = New System.Windows.Forms.GroupBox()
    Me.radSize_Large = New System.Windows.Forms.RadioButton()
    Me.radSize_Medium = New System.Windows.Forms.RadioButton()
    Me.radSize_Small = New System.Windows.Forms.RadioButton()
    Me.grpDrinks = New System.Windows.Forms.GroupBox()
    Me.radWater = New System.Windows.Forms.RadioButton()
    Me.radSoda = New System.Windows.Forms.RadioButton()
    Me.btnCost = New System.Windows.Forms.Button()
    Me.btnReset = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.lblCost = New System.Windows.Forms.Label()
    Me.grpBurgers.SuspendLayout()
    Me.grpFries.SuspendLayout()
    Me.grpDrinks.SuspendLayout()
    Me.SuspendLayout()
    '
    'chkBurgers
    '
    Me.chkBurgers.AutoSize = True
    Me.chkBurgers.Checked = True
    Me.chkBurgers.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkBurgers.Location = New System.Drawing.Point(53, 57)
    Me.chkBurgers.Name = "chkBurgers"
    Me.chkBurgers.Size = New System.Drawing.Size(80, 21)
    Me.chkBurgers.TabIndex = 0
    Me.chkBurgers.Text = "Burgers"
    Me.chkBurgers.UseVisualStyleBackColor = True
    '
    'chkFries
    '
    Me.chkFries.AutoSize = True
    Me.chkFries.Checked = True
    Me.chkFries.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkFries.Location = New System.Drawing.Point(53, 239)
    Me.chkFries.Name = "chkFries"
    Me.chkFries.Size = New System.Drawing.Size(61, 21)
    Me.chkFries.TabIndex = 1
    Me.chkFries.Text = "Fries"
    Me.chkFries.UseVisualStyleBackColor = True
    '
    'chkDrinks
    '
    Me.chkDrinks.AutoSize = True
    Me.chkDrinks.Checked = True
    Me.chkDrinks.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkDrinks.Location = New System.Drawing.Point(53, 372)
    Me.chkDrinks.Name = "chkDrinks"
    Me.chkDrinks.Size = New System.Drawing.Size(70, 21)
    Me.chkDrinks.TabIndex = 2
    Me.chkDrinks.Text = "Drinks"
    Me.chkDrinks.UseVisualStyleBackColor = True
    '
    'grpBurgers
    '
    Me.grpBurgers.Controls.Add(Me.radCheese_Bacon)
    Me.grpBurgers.Controls.Add(Me.radRegular)
    Me.grpBurgers.Controls.Add(Me.radBacon)
    Me.grpBurgers.Controls.Add(Me.radCheese)
    Me.grpBurgers.Location = New System.Drawing.Point(189, 31)
    Me.grpBurgers.Name = "grpBurgers"
    Me.grpBurgers.Size = New System.Drawing.Size(244, 128)
    Me.grpBurgers.TabIndex = 3
    Me.grpBurgers.TabStop = False
    Me.grpBurgers.Text = "Choices for Burgers"
    '
    'radCheese_Bacon
    '
    Me.radCheese_Bacon.AutoSize = True
    Me.radCheese_Bacon.Location = New System.Drawing.Point(16, 100)
    Me.radCheese_Bacon.Name = "radCheese_Bacon"
    Me.radCheese_Bacon.Size = New System.Drawing.Size(204, 21)
    Me.radCheese_Bacon.TabIndex = 11
    Me.radCheese_Bacon.TabStop = True
    Me.radCheese_Bacon.Tag = "5.39"
    Me.radCheese_Bacon.Text = "w/Cheese and Bacon (5.39)"
    Me.radCheese_Bacon.UseVisualStyleBackColor = True
    '
    'radRegular
    '
    Me.radRegular.AutoSize = True
    Me.radRegular.Location = New System.Drawing.Point(16, 25)
    Me.radRegular.Name = "radRegular"
    Me.radRegular.Size = New System.Drawing.Size(121, 21)
    Me.radRegular.TabIndex = 8
    Me.radRegular.TabStop = True
    Me.radRegular.Tag = "4.19"
    Me.radRegular.Text = "Regular (4.19)"
    Me.radRegular.UseVisualStyleBackColor = True
    '
    'radBacon
    '
    Me.radBacon.AutoSize = True
    Me.radBacon.Location = New System.Drawing.Point(16, 73)
    Me.radBacon.Name = "radBacon"
    Me.radBacon.Size = New System.Drawing.Size(124, 21)
    Me.radBacon.TabIndex = 10
    Me.radBacon.TabStop = True
    Me.radBacon.Tag = "4.79"
    Me.radBacon.Text = "w/Bacon (4.79)"
    Me.radBacon.UseVisualStyleBackColor = True
    '
    'radCheese
    '
    Me.radCheese.AutoSize = True
    Me.radCheese.Location = New System.Drawing.Point(16, 50)
    Me.radCheese.Name = "radCheese"
    Me.radCheese.Size = New System.Drawing.Size(132, 21)
    Me.radCheese.TabIndex = 9
    Me.radCheese.TabStop = True
    Me.radCheese.Tag = "4.79"
    Me.radCheese.Text = "w/Cheese (4.79)"
    Me.radCheese.UseVisualStyleBackColor = True
    '
    'grpFries
    '
    Me.grpFries.Controls.Add(Me.radSize_Large)
    Me.grpFries.Controls.Add(Me.radSize_Medium)
    Me.grpFries.Controls.Add(Me.radSize_Small)
    Me.grpFries.Location = New System.Drawing.Point(189, 202)
    Me.grpFries.Name = "grpFries"
    Me.grpFries.Size = New System.Drawing.Size(200, 100)
    Me.grpFries.TabIndex = 0
    Me.grpFries.TabStop = False
    Me.grpFries.Text = "Choices for Fries"
    '
    'radSize_Large
    '
    Me.radSize_Large.AutoSize = True
    Me.radSize_Large.Location = New System.Drawing.Point(16, 70)
    Me.radSize_Large.Name = "radSize_Large"
    Me.radSize_Large.Size = New System.Drawing.Size(108, 21)
    Me.radSize_Large.TabIndex = 14
    Me.radSize_Large.TabStop = True
    Me.radSize_Large.Tag = "4.99"
    Me.radSize_Large.Text = "Large (4.99)"
    Me.radSize_Large.UseVisualStyleBackColor = True
    '
    'radSize_Medium
    '
    Me.radSize_Medium.AutoSize = True
    Me.radSize_Medium.Location = New System.Drawing.Point(16, 48)
    Me.radSize_Medium.Name = "radSize_Medium"
    Me.radSize_Medium.Size = New System.Drawing.Size(120, 21)
    Me.radSize_Medium.TabIndex = 13
    Me.radSize_Medium.TabStop = True
    Me.radSize_Medium.Tag = "3.09"
    Me.radSize_Medium.Text = "Medium (3.09)"
    Me.radSize_Medium.UseVisualStyleBackColor = True
    '
    'radSize_Small
    '
    Me.radSize_Small.AutoSize = True
    Me.radSize_Small.Location = New System.Drawing.Point(16, 21)
    Me.radSize_Small.Name = "radSize_Small"
    Me.radSize_Small.Size = New System.Drawing.Size(105, 21)
    Me.radSize_Small.TabIndex = 12
    Me.radSize_Small.TabStop = True
    Me.radSize_Small.Tag = "2.39"
    Me.radSize_Small.Text = "Small (2.39)"
    Me.radSize_Small.UseVisualStyleBackColor = True
    '
    'grpDrinks
    '
    Me.grpDrinks.Controls.Add(Me.radWater)
    Me.grpDrinks.Controls.Add(Me.radSoda)
    Me.grpDrinks.Location = New System.Drawing.Point(189, 338)
    Me.grpDrinks.Name = "grpDrinks"
    Me.grpDrinks.Size = New System.Drawing.Size(200, 79)
    Me.grpDrinks.TabIndex = 0
    Me.grpDrinks.TabStop = False
    Me.grpDrinks.Text = "Choices for Drinks"
    '
    'radWater
    '
    Me.radWater.AutoSize = True
    Me.radWater.Location = New System.Drawing.Point(16, 48)
    Me.radWater.Name = "radWater"
    Me.radWater.Size = New System.Drawing.Size(109, 21)
    Me.radWater.TabIndex = 16
    Me.radWater.TabStop = True
    Me.radWater.Tag = "1.49"
    Me.radWater.Text = "Water (1.49)"
    Me.radWater.UseVisualStyleBackColor = True
    '
    'radSoda
    '
    Me.radSoda.AutoSize = True
    Me.radSoda.Location = New System.Drawing.Point(16, 21)
    Me.radSoda.Name = "radSoda"
    Me.radSoda.Size = New System.Drawing.Size(104, 21)
    Me.radSoda.TabIndex = 15
    Me.radSoda.TabStop = True
    Me.radSoda.Tag = "1.69"
    Me.radSoda.Text = "Soda (1.69)"
    Me.radSoda.UseVisualStyleBackColor = True
    '
    'btnCost
    '
    Me.btnCost.Location = New System.Drawing.Point(468, 31)
    Me.btnCost.Name = "btnCost"
    Me.btnCost.Size = New System.Drawing.Size(116, 71)
    Me.btnCost.TabIndex = 4
    Me.btnCost.Text = "&Total Cost"
    Me.btnCost.UseVisualStyleBackColor = True
    '
    'btnReset
    '
    Me.btnReset.Location = New System.Drawing.Point(468, 222)
    Me.btnReset.Name = "btnReset"
    Me.btnReset.Size = New System.Drawing.Size(116, 71)
    Me.btnReset.TabIndex = 5
    Me.btnReset.Text = "&Reset"
    Me.btnReset.UseVisualStyleBackColor = True
    '
    'btnClose
    '
    Me.btnClose.Location = New System.Drawing.Point(468, 346)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(116, 71)
    Me.btnClose.TabIndex = 6
    Me.btnClose.Text = "&Close"
    Me.btnClose.UseVisualStyleBackColor = True
    '
    'lblCost
    '
    Me.lblCost.AutoSize = True
    Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCost.Location = New System.Drawing.Point(465, 114)
    Me.lblCost.Name = "lblCost"
    Me.lblCost.Size = New System.Drawing.Size(57, 17)
    Me.lblCost.TabIndex = 7
    Me.lblCost.Text = "Label1"
    '
    'Project2
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(658, 441)
    Me.Controls.Add(Me.lblCost)
    Me.Controls.Add(Me.btnClose)
    Me.Controls.Add(Me.btnReset)
    Me.Controls.Add(Me.btnCost)
    Me.Controls.Add(Me.grpFries)
    Me.Controls.Add(Me.grpDrinks)
    Me.Controls.Add(Me.grpBurgers)
    Me.Controls.Add(Me.chkDrinks)
    Me.Controls.Add(Me.chkFries)
    Me.Controls.Add(Me.chkBurgers)
    Me.Name = "Project2"
    Me.Text = "Project2: Fast Food Order Menu"
    Me.grpBurgers.ResumeLayout(False)
    Me.grpBurgers.PerformLayout()
    Me.grpFries.ResumeLayout(False)
    Me.grpFries.PerformLayout()
    Me.grpDrinks.ResumeLayout(False)
    Me.grpDrinks.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents chkBurgers As CheckBox
  Friend WithEvents chkFries As CheckBox
  Friend WithEvents chkDrinks As CheckBox
  Friend WithEvents grpBurgers As GroupBox
  Friend WithEvents grpFries As GroupBox
  Friend WithEvents grpDrinks As GroupBox
  Friend WithEvents btnCost As Button
  Friend WithEvents btnReset As Button
  Friend WithEvents btnClose As Button
  Friend WithEvents lblCost As Label
  Friend WithEvents radCheese_Bacon As RadioButton
  Friend WithEvents radRegular As RadioButton
  Friend WithEvents radBacon As RadioButton
  Friend WithEvents radCheese As RadioButton
  Friend WithEvents radSize_Large As RadioButton
  Friend WithEvents radSize_Medium As RadioButton
  Friend WithEvents radSize_Small As RadioButton
  Friend WithEvents radWater As RadioButton
  Friend WithEvents radSoda As RadioButton
End Class
