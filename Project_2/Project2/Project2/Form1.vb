Public Class Project2

  '**********************************************************
  'Program: CIS 14A - Project 2
  '         This program will take order options for burgers,
  '         fries, and drinks and will calculate the total 
  '         cost of the order.  The program can also reset
  '         or close itself upon clicking buttons.
  'Name   : Irfan Ahmad
  'Date   : 2/17/2019
  '**********************************************************

  'On event of form loading in, all category boxes will be unchecked and hide the group boxes
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    lblCost.Text = ""          'Label box will not display any characters by default
    chkBurgers.Checked = False 'Burgers groupbox will be hidden
    chkFries.Checked = False   'Fries groupbox will be hidden
    chkDrinks.Checked = False  'Drinks groupbox will be hidden

  End Sub

  'On event of checking the burgers box
  Private Sub chkBurgers_CheckedChanged(sender As Object, e As EventArgs) Handles chkBurgers.CheckedChanged

    If chkBurgers.Checked = True Then
      grpBurgers.Visible = True       'If the burger box is checked, then the groupbox will be visible
      radRegular.Checked = True       'The default choice when visible will be the regular burger

    Else
      grpBurgers.Visible = False      'If the burger box is unchecked, the groupbox will not be visible
      radRegular.Checked = False      'Unchecked due to hidden groupbox
      radCheese.Checked = False       'Unchecked due to hidden groupbox
      radBacon.Checked = False        'Unchecked due to hidden groupbox
      radCheese_Bacon.Checked = False 'Unchecked due to hidden groupbox
    End If

  End Sub

  Private Sub chkFries_CheckedChanged(sender As Object, e As EventArgs) Handles chkFries.CheckedChanged

    If chkFries.Checked = True Then
      grpFries.Visible = True        'If the fries box is checked, the groupbox will be visible
      radSize_Small.Checked = True   'The default choice when visible will be the small fries

    Else
      grpFries.Visible = False       'If the fries box is unchecked, the groupbox will not be visible
      radSize_Small.Checked = False  'Unchecked due to hidden groupbox
      radSize_Medium.Checked = False 'Unchecked due to hidden groupbox
      radSize_Large.Checked = False  'Unchecked due to hidden groupbox

    End If

  End Sub

  Private Sub chkDrinks_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrinks.CheckedChanged

    If chkDrinks.Checked = True Then
      grpDrinks.Visible = True  'If the drinks box is checked, the groupbox will be visible
      radSoda.Checked = True    'The default choice when visible will be the soda

    Else
      grpDrinks.Visible = False 'If the fries box is unchecked, the groupbox will not be visible
      radSoda.Checked = False   'Unchecked due to hidden groupbox
      radWater.Checked = False  'Unchecked due to hidden groupbox

    End If

  End Sub

  'On event of clicking the close button
  Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    Me.Close() 'Exits program
  End Sub

  'On event of clicking the reset button
  Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

    lblCost.Text = "Ready for next meal..." 'Phrase will pop up waiting for the next order
    chkBurgers.Checked = False              'Burger box will be unchecked
    chkFries.Checked = False                'Fries box will be unchecked
    chkDrinks.Checked = False               'Drinks box will be unchecked

  End Sub

  'On event of cost button being clicked
  Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click

    lblCost.Visible = True 'Cost label will be visible
    Dim dblCost As Double  'Cost variable declared as double

    If (chkBurgers.Checked = False And
        chkDrinks.Checked = False And
        chkFries.Checked = False) Then
      lblCost.Text = "Must Check Something..." 'If none of the boxes are checked, cost cannot be calculated
    End If



    If radRegular.Checked = True Then          'If the option is checked, the tag value will be added to the cost
      dblCost += radRegular.Tag
    End If

    If radCheese.Checked = True Then           'If the option is checked, the tag value will be added to the cost
      dblCost += radCheese.Tag
    End If

    If radBacon.Checked = True Then            'If the option is checked, the tag value will be added to the cost
      dblCost += radBacon.Tag
    End If

    If radCheese_Bacon.Checked = True Then     'If the option is checked, the tag value will be added to the cost
      dblCost += radCheese_Bacon.Tag
    End If

    If radSize_Small.Checked = True Then       'If the option is checked, the tag value will be added to the cost
      dblCost += radSize_Small.Tag
    End If

    If radSize_Medium.Checked = True Then      'If the option is checked, the tag value will be added to the cost
      dblCost += radSize_Medium.Tag
    End If

    If radSize_Large.Checked = True Then       'If the option is checked, the tag value will be added to the cost
      dblCost += radSize_Large.Tag
    End If




    If radSoda.Checked = True Then             'If the option is checked, the tag value will be added to the cost
      dblCost += radSoda.Tag
    End If

    If radWater.Checked = True Then            'If the option is checked, the tag value will be added to the cost
      dblCost += radWater.Tag
    End If



    If (chkBurgers.Checked = True Or           'If at least one category is checked, cost can be calculated and will output
        chkDrinks.Checked = True Or
        chkFries.Checked = True) Then
      lblCost.Text = "Total Cost: " & FormatCurrency(dblCost) 'Total cost will be displayed in form of currency
    End If

  End Sub

End Class
