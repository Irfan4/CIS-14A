Public Class Form1

  '**********************************************************
  'Program: CIS 14A - Project 1
  '         This program will convert Customary Units (miles, 
  '         yards, feet, and inches) into Metric lengths
  '         (kilometers, meters, and centimeters).
  'Name   : Irfan Ahmad
  'Date   : 2/3/2019
  '**********************************************************

  'Information the form will have prior to being changed
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Setting preloaded value as 0 for the list box
    lstOut.Items.Add(0)                                                        'List box output set to 0 by default
  End Sub

  'On event of convert button being clicked, processing and output will occur
  Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
    'Receiving input

    'Declaring all Customary units as variables
    Dim intMiles As Integer      'User input
    Dim intYards As Integer      'User input
    Dim intFeet As Integer       'User input
    Dim intInches As Integer     'User input
    Dim dblInchesTotal As Double 'Total amount of inches everything is equal to


    'Declaring all Metric units as variables
    Dim intKilometers As Integer 'Calculated kilometers
    Dim intMeters As Integer     'Calculated meters
    Dim dblCentimeters As Double 'Calculated centimeters
    Dim dblMetersTotal As Double 'Total amount of meters everything is equal to

    'Assigning Customary variables to user input
    On Error Resume Next 'Prevents program from crashing if inputs are not satisfactory, moves on to next line
    intMiles = txtMiles.Text
    intYards = txtYards.Text
    intFeet = txtFeet.Text
    intInches = txtInches.Text

    'Converting input into Metric Units
    dblInchesTotal = (63360 * intMiles) +
                     (36 * intYards) +
                     (12 * intFeet) + intInches 'Converts all customary units to inches

    dblMetersTotal = dblInchesTotal / 39.37                                'Converts total inches into total meters
    intKilometers = Int(dblMetersTotal / 1000)                             'Divides by 1000 to get kilometers
    intMeters = Int(dblMetersTotal Mod 1000)                               'Modulus used to find the remaining meters
    dblCentimeters = (dblMetersTotal - (intKilometers * 1000)) - intMeters 'Subtracting meter amount from used meters to find remaining meters
    dblCentimeters = dblCentimeters * 100                                  'Remaining meters multiplied by 100 to get centimeters

    'Outputting the result
    lstOut.Items.Clear()                                                       'Clearing any prior items/text in the list box
    lstOut.Items.Add("The Metric Length is " & intKilometers & " kilometers,") 'Text added to describe what unit each output is
    lstOut.Items.Add(intMeters & " meters,")
    lstOut.Items.Add(Math.Round(dblCentimeters, 1) & " centimeters.")          'Rounding the centimeters to the first decimal point


  End Sub

End Class
