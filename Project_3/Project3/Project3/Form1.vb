Public Class Form1

  '*******************************************************************************
  'Program: CIS 14A - Project 3
  '         This program will take an items name, year purchased, purchase amount, 
  '         and lifetime in years. It will then provide the item's beginning year
  '         value, during year depreciation, and overall depreciation for all the
  '         years until the lifetime is complete.
  'Name   : Irfan Ahmad
  'Date   : 3/09/2019
  '*******************************************************************************


  'Format of default text boxes after Form load
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    txtDesc.Text = "<Enter Item Description>"            'Default text
    txtYearPurchased.Text = "<Enter Year Purchased>"     'Default text
    txtPurchaseAmount.Text = "<Enter Amount>"            'Default text
    txtYearsDepreciated.Text = "<Enter Number of Years>" 'Default text

  End Sub

  'On event of close button being clicked
  Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    Me.Close() 'Closes program
  End Sub

  'On event of restart button being clicked
  Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click

    txtDesc.Text = "<Enter Item Description>"            'Resets textbox to default text
    txtYearPurchased.Text = "<Enter Year Purchased>"     'Resets textbox to default text
    txtPurchaseAmount.Text = "<Enter Amount>"            'Resets textbox to default text
    txtYearsDepreciated.Text = "<Enter Number of Years>" 'Resets textbox to default text

    txtOutput.Text = ""                                  'Resets output textbox to default text

    radStraightLine.Checked = True                       'Resets radio button to default choice

  End Sub


  'On event of calcualtion button being clicked
  Private Sub btnCalculation_Click(sender As Object, e As EventArgs) Handles btnCalculation.Click

    Dim Description As String     'Item description
    Dim YearOfPurchase As Integer 'Year when item was bought
    Dim Cost As Integer           'Price item was purchased for
    Dim EstimatedLife As Integer  'Estimated lifetime

    Dim Method As String          'Method of straight line calculation or double decline
    Dim DuringValue As Integer    'Amount of depreciation during the year

    Dim StartingYear As Integer     'Year 0 used to count it's way up to the lifetime
    Dim PurchaseAmount As Integer   'Purchase amount passed by Value
    Dim TotalDeprecation As Integer 'Total depreciation 


    'Input Validation
    If txtDesc.Text = "" Or txtDesc.Text = "<Enter Item Description>" Then   'If description is not inputted
      MessageBox.Show("Enter a description")

    ElseIf IsNumeric(txtYearPurchased.Text) = False Then
      MessageBox.Show("Year Purchased is not Numeric.")

    ElseIf txtYearPurchased.Text < 1900 Or txtYearPurchased.Text > 9999 Then 'If year is not between 1900 and 9999
      MessageBox.Show("Year Purchased is not between 1900 and 9999")

    ElseIf IsNumeric(txtPurchaseAmount.Text) = False Then                    'If purchase amount is not a numeric value
      MessageBox.Show("Purchase Amount is not Numeric.")

    ElseIf PurchaseAmount < 0 Then                                           'If purchase amount is less than zero
      MessageBox.Show("Purchase Amount must be > than zero")

    ElseIf IsNumeric(txtYearsDepreciated.Text) = False Then                  'If years depreciated is not a numeric value
      MessageBox.Show("Years to Depreciate is not numeric.")

    ElseIf EstimatedLife < 0 Or EstimatedLife > 999 Then                     'If years depreciated is not between 0 and 999
      MessageBox.Show("Number of years must be between 1 and 999.")

    End If



    'Assigning textbox input to variable values
    Description = txtDesc.Text               'From user input
    YearOfPurchase = txtYearPurchased.Text   'From user input
    Cost = txtPurchaseAmount.Text            'From user input
    EstimatedLife = txtYearsDepreciated.Text 'From user input
    PurchaseAmount = txtPurchaseAmount.Text  'From user input

    'Method determination
    If radStraightLine.Checked = True Then
      Method = "straight-line-balance"   'If straight line is checked then method is straight line

    Else
      Method = "double-decline-balance"  'If double decline is checked then method is double decline

    End If

    'Declaring output and formatting
    Dim strOut As String                                         'Output for reiteration of input
    Dim strFrm As String = "{0,-23}"                             'Declaring zone for reiteration of input format
    Dim strDeprFrm As String = "{0,-18} {1,-18} {2,-18} {3,-18}" 'Declaring zones for depreciation value format
    Dim strHdr As String =
           "                   Value at" &       'Formatting of depreciation table _
           "           Amount Deprec" &          'Formatting of depreciation table _
           "      Total Depreciation" & vbCrLf & 'Formatting of depreciation table _
           "Year" & "               beg of Yr" & 'Formatting of depreciation table _
           "          During Year" &             'Formatting of depreciation table _
           "        to End of Year" & vbCrLf &   'Formatting of depreciation table _
           "" & vbCrLf

    Dim CurrentDate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now) & "  " & Format(Now, "hh:mm:ss tt") 'Formatting current date and time display

    'Formatting reiteration of input 
    strOut = String.Format(strFrm, "Date/Time Of Report   : " & CurrentDate & vbCrLf _
                           & "" & vbCrLf _
                           & "Description           : " & Description & vbCrLf _
                           & "Year of Purchase      : " & YearOfPurchase & vbCrLf _
                           & "Cost                  : " & Cost & vbCrLf _
                           & "Estimated Life        : " & EstimatedLife & vbCrLf _
                           & "Method of Depreciation: " & Method & vbCrLf _
                           & "" & vbCrLf _
                           & strHdr)

    txtOutput.Text = strOut 'Outputing reiteration of input


    'Event of straight line method being selected
    If radStraightLine.Checked = True Then

      If StartingYear < EstimatedLife - (EstimatedLife - 1) Then 'Output for the first year

        DepreciationSingle(YearOfPurchase, Cost, EstimatedLife, DuringValue, TotalDeprecation, PurchaseAmount) 'Passing input values to function

        'Formatting depreciation output into currency
        Dim strDeprCalc1 As String = String.Format(strDeprFrm,
                                                   YearOfPurchase,
                                                   FormatCurrency(Cost, 2),
                                                   FormatCurrency(DuringValue, 2),
                                                   FormatCurrency(TotalDeprecation, 2))

        txtOutput.Text += strDeprCalc1 & vbCrLf 'Adding depreciation output to reiteration output

      End If

      Do While StartingYear < EstimatedLife - 1 'Output for years between 1 and n, will loop until satisfied

        DepreciationSingle2(YearOfPurchase, Cost, EstimatedLife, DuringValue, TotalDeprecation, PurchaseAmount) 'Passing input values to function

        'Formatting depreciation output into currency
        Dim strDeprCalc As String = String.Format(strDeprFrm,
                                                  YearOfPurchase,
                                                  FormatCurrency(Cost, 2),
                                                  FormatCurrency(DuringValue, 2),
                                                  FormatCurrency(TotalDeprecation, 2))

        txtOutput.Text += strDeprCalc & vbCrLf 'Adding depreciation output to existing output
        StartingYear += 1                      'Increasing year value by one for next iteration

      Loop
    End If

    'Event of double decline method being selected
    If radDoubleDecline.Checked = True Then

      If StartingYear < EstimatedLife - (EstimatedLife - 1) Then 'Output for first year

        DepreciationDouble(YearOfPurchase, 'Passing input values to first year depreciation function
                           Cost,
                           EstimatedLife,
                           DuringValue,
                           TotalDeprecation,
                           PurchaseAmount)

        Dim strDeprCalc1 As String = String.Format(strDeprFrm,                            'Formatting depreciation values to currency
                                                   YearOfPurchase,
                                                   FormatCurrency(PurchaseAmount, 2),
                                                   FormatCurrency(DuringValue, 2),
                                                   FormatCurrency(TotalDeprecation, 2))

        txtOutput.Text += strDeprCalc1 & vbCrLf     'Adding depreciation output to existing output

      End If

      Do While StartingYear < EstimatedLife - 2 'Output for years in between first and last, will loop until satisfied

        DepreciationDouble2(YearOfPurchase,   'Passing input values to middle depreciation function
                            Cost,
                            EstimatedLife,
                            DuringValue,
                            TotalDeprecation,
                            PurchaseAmount)

        Dim strDeprCalc2 As String = String.Format(strDeprFrm,                          'Formatting depreciation values into currency
                                                   YearOfPurchase,
                                                   FormatCurrency(PurchaseAmount, 2),
                                                   FormatCurrency(DuringValue, 2),
                                                   FormatCurrency(TotalDeprecation, 2))

        txtOutput.Text += strDeprCalc2 & vbCrLf 'Adding depreciation output to existing output
        StartingYear += 1                       'Increasing yearcount by one

      Loop

      If StartingYear < EstimatedLife Then 'Output for last year
        DepreciationDouble3(YearOfPurchase,
                            Cost,
                            EstimatedLife,
                            DuringValue,
                            TotalDeprecation,
                            PurchaseAmount)

        Dim strDeprCalc3 As String = String.Format(strDeprFrm,    'Formatting depreciation values into currency
                                                   YearOfPurchase,
                                                   FormatCurrency(PurchaseAmount, 2),
                                                   FormatCurrency(DuringValue, 2),
                                                   FormatCurrency(TotalDeprecation, 2))

        txtOutput.Text += strDeprCalc3 & vbCrLf  'Adding depreciation output to existing output
      End If

    End If
  End Sub


  Sub DepreciationSingle(ByRef Year As Integer,    'Function for first year of straight line
                        ByRef Value As Integer,
                        ByRef Lifetime As Integer,
                        ByRef During As Integer,
                        ByRef Total As Integer,
                        ByVal SecondValue As Integer)


    During = SecondValue / Lifetime 'Calculating depreciation
    Total += During                 'Adding depreciation to total depreciation

  End Sub

  Sub DepreciationSingle2(ByRef Year As Integer, 'Function for remaining years of straight line
                          ByRef Value As Integer,
                          ByRef Lifetime As Integer,
                          ByRef During As Integer,
                          ByRef Total As Integer,
                          ByVal SecondValue As Integer)


    Year += 1                       'Incrementing one year
    During = SecondValue / Lifetime 'Calculating depreciation
    Value -= During                 'Subtracting depreciation from price
    Total += During                 'Adding depreciation to total depreciation

  End Sub


  Sub DepreciationDouble(ByRef Year As Integer, 'Function for first year of double decline
                         ByRef Value As Integer,
                         ByRef Lifetime As Integer,
                         ByRef During As Integer,
                         ByRef Total As Integer,
                         ByVal SecondValue As Integer)

    During = (Value * 2) / Lifetime 'Calculating depreciation 
    Total += During                 'Adding depreciation to total depreciation

    Value -= During                 'Subtracting depreciation from price

  End Sub

  Sub DepreciationDouble2(ByRef Year As Integer, 'Function for middle years of double decline
                        ByRef Value As Integer,
                        ByRef Lifetime As Integer,
                        ByRef During As Integer,
                        ByRef Total As Integer,
                        ByRef SecondValue As Integer)

    SecondValue -= During            'Cost subtracts during depreciation before proceeding         
    Year += 1                        'Incrementing one year 
    During = (Value * 2) / Lifetime  'Calculating depreciation
    Value -= During                  'Subtracting depreciation from price
    Total += During                  'Adding depreciation to total amount


  End Sub

  Sub DepreciationDouble3(ByRef Year As Integer, 'Function for last year of double decline
                          ByRef Price As Integer,
                          ByRef Lifetime As Integer,
                          ByRef During As Integer,
                          ByRef Total As Integer,
                          ByRef SecondValue As Integer)
    SecondValue = Price 'Cost presented for final year will be equal to price
    Year += 1           'Year incremented by one
    During = Price      'During depreciation equal to price
    Total += Price      'Total depreciation
  End Sub

End Class
