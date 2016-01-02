﻿Public Class frmSelectManufacturingTabColumns

    Dim MaxColumnNumber As Integer
    Dim SelectedIndex As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        MaxColumnNumber = 1
        SelectedIndex = 0

    End Sub

    Private Sub SetMaxColumnNumber(InNumber As Integer)
        If InNumber > MaxColumnNumber Then
            MaxColumnNumber = InNumber
        End If
    End Sub

    ' Load all the current checks
    Private Sub frmSelectIndustryJobColumns_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Call ShowList()
    End Sub

    Private Sub UpdateListCheck(ByVal ColumnValue As Integer, Index As Integer)
        If ColumnValue <> 0 Then
            chkLstBoxColumns.SetItemChecked(Index, True)
            SetMaxColumnNumber(ColumnValue)
        Else
            chkLstBoxColumns.SetItemChecked(Index, False)
        End If
    End Sub

    Private Sub ShowList()
        With UserManufacturingTabColumnSettings
            Call UpdateListCheck(.ItemCategory, 0)
            Call UpdateListCheck(.ItemGroup, 1)
            Call UpdateListCheck(.ItemName, 2)
            Call UpdateListCheck(.Owned, 3)
            Call UpdateListCheck(.Tech, 4)
            Call UpdateListCheck(.BPME, 5)
            Call UpdateListCheck(.BPTE, 6)
            Call UpdateListCheck(.Inputs, 7)
            Call UpdateListCheck(.Compared, 8)
            Call UpdateListCheck(.TotalRuns, 9)
            Call UpdateListCheck(.SingleInventedBPCRuns, 10)
            Call UpdateListCheck(.ProductionLines, 11)
            Call UpdateListCheck(.LaboratoryLines, 12)
            Call UpdateListCheck(.TotalInventionCost, 13)
            Call UpdateListCheck(.TotalCopyCost, 14)
            Call UpdateListCheck(.Taxes, 15)
            Call UpdateListCheck(.BrokerFees, 16)
            Call UpdateListCheck(.BPProductionTime, 17)
            Call UpdateListCheck(.TotalProductionTime, 18)
            Call UpdateListCheck(.CopyTime, 19)
            Call UpdateListCheck(.InventionTime, 20)
            Call UpdateListCheck(.ItemMarketPrice, 21)
            Call UpdateListCheck(.Profit, 22)
            Call UpdateListCheck(.ProfitPercentage, 23)
            Call UpdateListCheck(.IskperHour, 24)
            Call UpdateListCheck(.SVR, 25)
            Call UpdateListCheck(.SVRxIPH, 26)
            Call UpdateListCheck(.PriceTrend, 27)
            Call UpdateListCheck(.TotalItemsSold, 28)
            Call UpdateListCheck(.TotalOrdersFilled, 29)
            Call UpdateListCheck(.AvgItemsperOrder, 30)
            Call UpdateListCheck(.CurrentSellOrders, 31)
            Call UpdateListCheck(.CurrentBuyOrders, 32)
            Call UpdateListCheck(.TotalCost, 33)
            Call UpdateListCheck(.BaseJobCost, 34)
            Call UpdateListCheck(.NumBPs, 35)
            Call UpdateListCheck(.InventionChance, 36)
            Call UpdateListCheck(.BPType, 37)
            Call UpdateListCheck(.Race, 38)
            Call UpdateListCheck(.VolumeperItem, 39)
            Call UpdateListCheck(.TotalVolume, 40)
            Call UpdateListCheck(.PortionSize, 41)
            Call UpdateListCheck(.ManufacturingJobFee, 42)
            Call UpdateListCheck(.ManufacturingFacilityName, 43)
            Call UpdateListCheck(.ManufacturingFacilitySystem, 44)
            Call UpdateListCheck(.ManufacturingFacilityRegion, 45)
            Call UpdateListCheck(.ManufacturingFacilitySystemIndex, 46)
            Call UpdateListCheck(.ManufacturingFacilityTax, 47)
            Call UpdateListCheck(.ManufacturingFacilityMEBonus, 48)
            Call UpdateListCheck(.ManufacturingFacilityTEBonus, 49)
            Call UpdateListCheck(.ManufacturingFacilityUsage, 50)
            Call UpdateListCheck(.ManufacturingFacilityFWSystemLevel, 51)
            Call UpdateListCheck(.ComponentFacilityName, 52)
            Call UpdateListCheck(.ComponentFacilitySystem, 53)
            Call UpdateListCheck(.ComponentFacilityRegion, 54)
            Call UpdateListCheck(.ComponentFacilitySystemIndex, 55)
            Call UpdateListCheck(.ComponentFacilityTax, 56)
            Call UpdateListCheck(.ComponentFacilityMEBonus, 57)
            Call UpdateListCheck(.ComponentFacilityTEBonus, 58)
            Call UpdateListCheck(.ComponentFacilityUsage, 59)
            Call UpdateListCheck(.ComponentFacilityFWSystemLevel, 60)
            Call UpdateListCheck(.CapComponentFacilityName, 61)
            Call UpdateListCheck(.CapComponentFacilitySystem, 62)
            Call UpdateListCheck(.CapComponentFacilityRegion, 63)
            Call UpdateListCheck(.CapComponentFacilitySystemIndex, 64)
            Call UpdateListCheck(.CapComponentFacilityTax, 65)
            Call UpdateListCheck(.CapComponentFacilityMEBonus, 66)
            Call UpdateListCheck(.CapComponentFacilityTEBonus, 67)
            Call UpdateListCheck(.CapComponentFacilityUsage, 68)
            Call UpdateListCheck(.CapComponentFacilityFWSystemLevel, 69)
            Call UpdateListCheck(.CopyingFacilityName, 70)
            Call UpdateListCheck(.CopyingFacilitySystem, 71)
            Call UpdateListCheck(.CopyingFacilityRegion, 72)
            Call UpdateListCheck(.CopyingFacilitySystemIndex, 73)
            Call UpdateListCheck(.CopyingFacilityTax, 74)
            Call UpdateListCheck(.CopyingFacilityMEBonus, 75)
            Call UpdateListCheck(.CopyingFacilityTEBonus, 76)
            Call UpdateListCheck(.CopyingFacilityUsage, 77)
            Call UpdateListCheck(.CopyingFacilityFWSystemLevel, 78)
            Call UpdateListCheck(.InventionFacilityName, 79)
            Call UpdateListCheck(.InventionFacilitySystem, 80)
            Call UpdateListCheck(.InventionFacilityRegion, 81)
            Call UpdateListCheck(.InventionFacilitySystemIndex, 82)
            Call UpdateListCheck(.InventionFacilityTax, 83)
            Call UpdateListCheck(.InventionFacilityMEBonus, 84)
            Call UpdateListCheck(.InventionFacilityTEBonus, 85)
            Call UpdateListCheck(.InventionFacilityUsage, 86)
            Call UpdateListCheck(.InventionFacilityFWSystemLevel, 87)

            chkLstBoxColumns.Update()

        End With
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub btnSaveSettings_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveSettings.Click

        If chkLstBoxColumns.CheckedItems.Count = 0 Then
            MsgBox("You must select at least one Column", vbExclamation, Application.ProductName)
            Exit Sub
        End If

        ' Save the local settings and the user settings
        Call SaveLocalColumnSettings()

        ' Save the data in the XML file
        Call AllSettings.SaveManufacturingTabColumnSettings(UserManufacturingTabColumnSettings)

        MsgBox("Columns Saved", vbInformation, Application.ProductName)
        ManufacturingTabColumnsChanged = True

        Me.Hide()

    End Sub

    ' Processes the column order
    Private Function GetColumnNumber(ByVal ChkState As CheckState, CurrentValue As Integer) As Integer
        Dim NewValue As Integer

        ' Change to max column order + 1 if checked and not already set
        If CurrentValue = 0 And ChkState = CheckState.Checked Then
            NewValue = MaxColumnNumber + 1
            MaxColumnNumber += 1
        ElseIf ChkState = CheckState.Unchecked Then
            NewValue = 0
        Else
            NewValue = CurrentValue
        End If

        Return NewValue

    End Function

    ' Save the items as viewed or not and order them from the last column
    Public Sub SaveLocalColumnSettings()
        Dim ColumnPositions(NumManufacturingTabColumns) As String
        Dim TempColumns(NumManufacturingTabColumns) As String
        Dim ColumnCount As Integer = 0
        Dim i As Integer = 1
        Dim j As Integer = 1

        With UserManufacturingTabColumnSettings
            ' First add any new check boxes that weren't checked before
            .ItemCategory = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(0), .ItemCategory)
            .ItemGroup = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(1), .ItemGroup)
            .ItemName = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(2), .ItemName)
            .Owned = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(3), .Owned)
            .Tech = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(4), .Tech)
            .BPME = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(5), .BPME)
            .BPTE = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(6), .BPTE)
            .Inputs = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(7), .Inputs)
            .Compared = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(8), .Compared)
            .TotalRuns = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(9), .TotalRuns)
            .SingleInventedBPCRuns = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(10), .SingleInventedBPCRuns)
            .ProductionLines = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(11), .ProductionLines)
            .LaboratoryLines = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(12), .LaboratoryLines)
            .TotalInventionCost = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(13), .TotalInventionCost)
            .TotalCopyCost = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(14), .TotalCopyCost)
            .Taxes = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(15), .Taxes)
            .BrokerFees = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(16), .BrokerFees)
            .BPProductionTime = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(17), .BPProductionTime)
            .TotalProductionTime = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(18), .TotalProductionTime)
            .CopyTime = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(19), .CopyTime)
            .InventionTime = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(20), .InventionTime)
            .ItemMarketPrice = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(21), .ItemMarketPrice)
            .Profit = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(22), .Profit)
            .ProfitPercentage = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(23), .ProfitPercentage)
            .IskperHour = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(24), .IskperHour)
            .SVR = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(25), .SVR)
            .SVRxIPH = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(26), .SVRxIPH)
            .PriceTrend = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(27), .PriceTrend)
            .TotalItemsSold = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(28), .TotalItemsSold)
            .TotalOrdersFilled = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(29), .TotalOrdersFilled)
            .AvgItemsperOrder = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(30), .AvgItemsperOrder)
            .CurrentSellOrders = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(31), .CurrentSellOrders)
            .CurrentBuyOrders = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(32), .CurrentBuyOrders)
            .TotalCost = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(33), .TotalCost)
            .BaseJobCost = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(34), .BaseJobCost)
            .NumBPs = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(35), .NumBPs)
            .InventionChance = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(36), .InventionChance)
            .BPType = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(37), .BPType)
            .Race = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(38), .Race)
            .VolumeperItem = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(39), .VolumeperItem)
            .TotalVolume = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(40), .TotalVolume)
            .PortionSize = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(41), .PortionSize)
            .ManufacturingJobFee = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(42), .ManufacturingJobFee)
            .ManufacturingFacilityName = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(43), .ManufacturingFacilityName)
            .ManufacturingFacilitySystem = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(44), .ManufacturingFacilitySystem)
            .ManufacturingFacilityRegion = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(45), .ManufacturingFacilityRegion)
            .ManufacturingFacilitySystemIndex = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(46), .ManufacturingFacilitySystemIndex)
            .ManufacturingFacilityTax = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(47), .ManufacturingFacilityTax)
            .ManufacturingFacilityMEBonus = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(48), .ManufacturingFacilityMEBonus)
            .ManufacturingFacilityTEBonus = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(49), .ManufacturingFacilityTEBonus)
            .ManufacturingFacilityUsage = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(50), .ManufacturingFacilityUsage)
            .ManufacturingFacilityFWSystemLevel = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(51), .ManufacturingFacilityFWSystemLevel)
            .ComponentFacilityName = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(52), .ComponentFacilityName)
            .ComponentFacilitySystem = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(53), .ComponentFacilitySystem)
            .ComponentFacilityRegion = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(54), .ComponentFacilityRegion)
            .ComponentFacilitySystemIndex = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(55), .ComponentFacilitySystemIndex)
            .ComponentFacilityTax = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(56), .ComponentFacilityTax)
            .ComponentFacilityMEBonus = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(57), .ComponentFacilityMEBonus)
            .ComponentFacilityTEBonus = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(58), .ComponentFacilityTEBonus)
            .ComponentFacilityUsage = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(59), .ComponentFacilityUsage)
            .ComponentFacilityFWSystemLevel = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(60), .ComponentFacilityFWSystemLevel)
            .CapComponentFacilityName = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(61), .CapComponentFacilityName)
            .CapComponentFacilitySystem = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(62), .CapComponentFacilitySystem)
            .CapComponentFacilityRegion = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(63), .CapComponentFacilityRegion)
            .CapComponentFacilitySystemIndex = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(64), .CapComponentFacilitySystemIndex)
            .CapComponentFacilityTax = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(65), .CapComponentFacilityTax)
            .CapComponentFacilityMEBonus = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(66), .CapComponentFacilityMEBonus)
            .CapComponentFacilityTEBonus = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(67), .CapComponentFacilityTEBonus)
            .CapComponentFacilityUsage = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(68), .CapComponentFacilityUsage)
            .CapComponentFacilityFWSystemLevel = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(69), .CapComponentFacilityFWSystemLevel)
            .CopyingFacilityName = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(70), .CopyingFacilityName)
            .CopyingFacilitySystem = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(71), .CopyingFacilitySystem)
            .CopyingFacilityRegion = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(72), .CopyingFacilityRegion)
            .CopyingFacilitySystemIndex = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(73), .CopyingFacilitySystemIndex)
            .CopyingFacilityTax = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(74), .CopyingFacilityTax)
            .CopyingFacilityMEBonus = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(75), .CopyingFacilityMEBonus)
            .CopyingFacilityTEBonus = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(76), .CopyingFacilityTEBonus)
            .CopyingFacilityUsage = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(77), .CopyingFacilityUsage)
            .CopyingFacilityFWSystemLevel = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(78), .CopyingFacilityFWSystemLevel)
            .InventionFacilityName = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(79), .InventionFacilityName)
            .InventionFacilitySystem = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(80), .InventionFacilitySystem)
            .InventionFacilityRegion = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(81), .InventionFacilityRegion)
            .InventionFacilitySystemIndex = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(82), .InventionFacilitySystemIndex)
            .InventionFacilityTax = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(83), .InventionFacilityTax)
            .InventionFacilityMEBonus = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(84), .InventionFacilityMEBonus)
            .InventionFacilityTEBonus = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(85), .InventionFacilityTEBonus)
            .InventionFacilityUsage = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(86), .InventionFacilityUsage)
            .InventionFacilityFWSystemLevel = GetColumnNumber(chkLstBoxColumns.GetItemCheckState(87), .InventionFacilityFWSystemLevel)

            ' Now in case something was removed, we want to update the indicies
            With UserManufacturingTabColumnSettings
                For i = 0 To ColumnPositions.Count - 1
                    ColumnPositions(i) = ""
                Next

                With UserManufacturingTabColumnSettings
                    ColumnPositions(.ItemCategory) = ProgramSettings.ItemCategoryColumnName
                    ColumnPositions(.ItemGroup) = ProgramSettings.ItemGroupColumnName
                    ColumnPositions(.ItemName) = ProgramSettings.ItemNameColumnName
                    ColumnPositions(.Owned) = ProgramSettings.OwnedColumnName
                    ColumnPositions(.Tech) = ProgramSettings.TechColumnName
                    ColumnPositions(.BPME) = ProgramSettings.BPMEColumnName
                    ColumnPositions(.BPTE) = ProgramSettings.BPTEColumnName
                    ColumnPositions(.Inputs) = ProgramSettings.InputsColumnName
                    ColumnPositions(.Compared) = ProgramSettings.ComparedColumnName
                    ColumnPositions(.TotalRuns) = ProgramSettings.TotalRunsColumnName
                    ColumnPositions(.SingleInventedBPCRuns) = ProgramSettings.SingleInventedBPCRunsColumnName
                    ColumnPositions(.ProductionLines) = ProgramSettings.ProductionLinesColumnName
                    ColumnPositions(.LaboratoryLines) = ProgramSettings.LaboratoryLinesColumnName
                    ColumnPositions(.TotalInventionCost) = ProgramSettings.TotalInventionCostColumnName
                    ColumnPositions(.TotalCopyCost) = ProgramSettings.TotalCopyCostColumnName
                    ColumnPositions(.Taxes) = ProgramSettings.TaxesColumnName
                    ColumnPositions(.BrokerFees) = ProgramSettings.BrokerFeesColumnName
                    ColumnPositions(.BPProductionTime) = ProgramSettings.BPProductionTimeColumnName
                    ColumnPositions(.TotalProductionTime) = ProgramSettings.TotalProductionTimeColumnName
                    ColumnPositions(.CopyTime) = ProgramSettings.CopyTimeColumnName
                    ColumnPositions(.InventionTime) = ProgramSettings.InventionTimeColumnName
                    ColumnPositions(.ItemMarketPrice) = ProgramSettings.ItemMarketPriceColumnName
                    ColumnPositions(.Profit) = ProgramSettings.ProfitColumnName
                    ColumnPositions(.ProfitPercentage) = ProgramSettings.ProfitPercentageColumnName
                    ColumnPositions(.IskperHour) = ProgramSettings.IskperHourColumnName
                    ColumnPositions(.SVR) = ProgramSettings.SVRColumnName
                    ColumnPositions(.SVRxIPH) = ProgramSettings.SVRxIPHColumnName
                    ColumnPositions(.PriceTrend) = ProgramSettings.PriceTrendColumnName
                    ColumnPositions(.TotalItemsSold) = ProgramSettings.TotalItemsSoldColumnName
                    ColumnPositions(.TotalOrdersFilled) = ProgramSettings.TotalOrdersFilledColumnName
                    ColumnPositions(.AvgItemsperOrder) = ProgramSettings.AvgItemsperOrderColumnName
                    ColumnPositions(.CurrentSellOrders) = ProgramSettings.CurrentSellOrdersColumnName
                    ColumnPositions(.CurrentBuyOrders) = ProgramSettings.CurrentBuyOrdersColumnName
                    ColumnPositions(.TotalCost) = ProgramSettings.TotalCostColumnName
                    ColumnPositions(.BaseJobCost) = ProgramSettings.BaseJobCostColumnName
                    ColumnPositions(.NumBPs) = ProgramSettings.NumBPsColumnName
                    ColumnPositions(.InventionChance) = ProgramSettings.InventionChanceColumnName
                    ColumnPositions(.BPType) = ProgramSettings.BPTypeColumnName
                    ColumnPositions(.Race) = ProgramSettings.RaceColumnName
                    ColumnPositions(.VolumeperItem) = ProgramSettings.VolumeperItemColumnName
                    ColumnPositions(.TotalVolume) = ProgramSettings.TotalVolumeColumnName
                    ColumnPositions(.PortionSize) = ProgramSettings.PortionSizeColumnName
                    ColumnPositions(.ManufacturingJobFee) = ProgramSettings.ManufacturingJobFeeColumnName
                    ColumnPositions(.ManufacturingFacilityName) = ProgramSettings.ManufacturingFacilityNameColumnName
                    ColumnPositions(.ManufacturingFacilitySystem) = ProgramSettings.ManufacturingFacilitySystemColumnName
                    ColumnPositions(.ManufacturingFacilityRegion) = ProgramSettings.ManufacturingFacilityRegionColumnName
                    ColumnPositions(.ManufacturingFacilitySystemIndex) = ProgramSettings.ManufacturingFacilitySystemIndexColumnName
                    ColumnPositions(.ManufacturingFacilityTax) = ProgramSettings.ManufacturingFacilityTaxColumnName
                    ColumnPositions(.ManufacturingFacilityMEBonus) = ProgramSettings.ManufacturingFacilityMEBonusColumnName
                    ColumnPositions(.ManufacturingFacilityTEBonus) = ProgramSettings.ManufacturingFacilityTEBonusColumnName
                    ColumnPositions(.ManufacturingFacilityUsage) = ProgramSettings.ManufacturingFacilityUsageColumnName
                    ColumnPositions(.ManufacturingFacilityFWSystemLevel) = ProgramSettings.ManufacturingFacilityFWSystemLevelColumnName
                    ColumnPositions(.ComponentFacilityName) = ProgramSettings.ComponentFacilityNameColumnName
                    ColumnPositions(.ComponentFacilitySystem) = ProgramSettings.ComponentFacilitySystemColumnName
                    ColumnPositions(.ComponentFacilityRegion) = ProgramSettings.ComponentFacilityRegionColumnName
                    ColumnPositions(.ComponentFacilitySystemIndex) = ProgramSettings.ComponentFacilitySystemIndexColumnName
                    ColumnPositions(.ComponentFacilityTax) = ProgramSettings.ComponentFacilityTaxColumnName
                    ColumnPositions(.ComponentFacilityMEBonus) = ProgramSettings.ComponentFacilityMEBonusColumnName
                    ColumnPositions(.ComponentFacilityTEBonus) = ProgramSettings.ComponentFacilityTEBonusColumnName
                    ColumnPositions(.ComponentFacilityUsage) = ProgramSettings.ComponentFacilityUsageColumnName
                    ColumnPositions(.ComponentFacilityFWSystemLevel) = ProgramSettings.ComponentFacilityFWSystemLevelColumnName
                    ColumnPositions(.CapComponentFacilityName) = ProgramSettings.CapComponentFacilityNameColumnName
                    ColumnPositions(.CapComponentFacilitySystem) = ProgramSettings.CapComponentFacilitySystemColumnName
                    ColumnPositions(.CapComponentFacilityRegion) = ProgramSettings.CapComponentFacilityRegionColumnName
                    ColumnPositions(.CapComponentFacilitySystemIndex) = ProgramSettings.CapComponentFacilitySystemIndexColumnName
                    ColumnPositions(.CapComponentFacilityTax) = ProgramSettings.CapComponentFacilityTaxColumnName
                    ColumnPositions(.CapComponentFacilityMEBonus) = ProgramSettings.CapComponentFacilityMEBonusColumnName
                    ColumnPositions(.CapComponentFacilityTEBonus) = ProgramSettings.CapComponentFacilityTEBonusColumnName
                    ColumnPositions(.CapComponentFacilityUsage) = ProgramSettings.CapComponentFacilityUsageColumnName
                    ColumnPositions(.CapComponentFacilityFWSystemLevel) = ProgramSettings.CapComponentFacilityFWSystemLevelColumnName
                    ColumnPositions(.CopyingFacilityName) = ProgramSettings.CopyingFacilityNameColumnName
                    ColumnPositions(.CopyingFacilitySystem) = ProgramSettings.CopyingFacilitySystemColumnName
                    ColumnPositions(.CopyingFacilityRegion) = ProgramSettings.CopyingFacilityRegionColumnName
                    ColumnPositions(.CopyingFacilitySystemIndex) = ProgramSettings.CopyingFacilitySystemIndexColumnName
                    ColumnPositions(.CopyingFacilityTax) = ProgramSettings.CopyingFacilityTaxColumnName
                    ColumnPositions(.CopyingFacilityMEBonus) = ProgramSettings.CopyingFacilityMEBonusColumnName
                    ColumnPositions(.CopyingFacilityTEBonus) = ProgramSettings.CopyingFacilityTEBonusColumnName
                    ColumnPositions(.CopyingFacilityUsage) = ProgramSettings.CopyingFacilityUsageColumnName
                    ColumnPositions(.CopyingFacilityFWSystemLevel) = ProgramSettings.CopyingFacilityFWSystemLevelColumnName
                    ColumnPositions(.InventionFacilityName) = ProgramSettings.InventionFacilityNameColumnName
                    ColumnPositions(.InventionFacilitySystem) = ProgramSettings.InventionFacilitySystemColumnName
                    ColumnPositions(.InventionFacilityRegion) = ProgramSettings.InventionFacilityRegionColumnName
                    ColumnPositions(.InventionFacilitySystemIndex) = ProgramSettings.InventionFacilitySystemIndexColumnName
                    ColumnPositions(.InventionFacilityTax) = ProgramSettings.InventionFacilityTaxColumnName
                    ColumnPositions(.InventionFacilityMEBonus) = ProgramSettings.InventionFacilityMEBonusColumnName
                    ColumnPositions(.InventionFacilityTEBonus) = ProgramSettings.InventionFacilityTEBonusColumnName
                    ColumnPositions(.InventionFacilityUsage) = ProgramSettings.InventionFacilityUsageColumnName
                    ColumnPositions(.InventionFacilityFWSystemLevel) = ProgramSettings.InventionFacilityFWSystemLevelColumnName
                End With

                ' Reset the first one with nothing since the first column is empty
                ColumnPositions(0) = "Sort Order"

                ' Now get the total number of columns in the list we want to see
                For i = 1 To ColumnPositions.Count - 1
                    If ColumnPositions(i) <> "" Then
                        ColumnCount += 1
                    End If
                Next

                ' Init temp
                For i = 0 To TempColumns.Count - 1
                    TempColumns(i) = ""
                Next

                ' Now loop through the columns and update the positions
                For i = 1 To ColumnPositions.Count - 1
                    If ColumnPositions(i) <> "" Then
                        TempColumns(j) = ColumnPositions(i)
                        j += 1
                    Else
                        If i = UserManufacturingTabColumnSettings.OrderByColumn Then
                            ' They removed the column they sorted, so default to the first column since you must have 1
                            UserManufacturingTabColumnSettings.OrderByColumn = 1
                        End If
                    End If
                Next

                ColumnPositions = TempColumns

                ' Finally save the columns based on the current order
                With UserManufacturingTabColumnSettings
                    For i = 1 To ColumnPositions.Count - 1
                        Select Case ColumnPositions(i)
                            Case ProgramSettings.ItemCategoryColumnName
                                .ItemCategory = i
                            Case ProgramSettings.ItemGroupColumnName
                                .ItemGroup = i
                            Case ProgramSettings.ItemNameColumnName
                                .ItemName = i
                            Case ProgramSettings.OwnedColumnName
                                .Owned = i
                            Case ProgramSettings.TechColumnName
                                .Tech = i
                            Case ProgramSettings.BPMEColumnName
                                .BPME = i
                            Case ProgramSettings.BPTEColumnName
                                .BPTE = i
                            Case ProgramSettings.InputsColumnName
                                .Inputs = i
                            Case ProgramSettings.ComparedColumnName
                                .Compared = i
                            Case ProgramSettings.TotalRunsColumnName
                                .TotalRuns = i
                            Case ProgramSettings.SingleInventedBPCRunsColumnName
                                .SingleInventedBPCRuns = i
                            Case ProgramSettings.ProductionLinesColumnName
                                .ProductionLines = i
                            Case ProgramSettings.LaboratoryLinesColumnName
                                .LaboratoryLines = i
                            Case ProgramSettings.TotalInventionCostColumnName
                                .TotalInventionCost = i
                            Case ProgramSettings.TotalCopyCostColumnName
                                .TotalCopyCost = i
                            Case ProgramSettings.TaxesColumnName
                                .Taxes = i
                            Case ProgramSettings.BrokerFeesColumnName
                                .BrokerFees = i
                            Case ProgramSettings.BPProductionTimeColumnName
                                .BPProductionTime = i
                            Case ProgramSettings.TotalProductionTimeColumnName
                                .TotalProductionTime = i
                            Case ProgramSettings.CopyTimeColumnName
                                .CopyTime = i
                            Case ProgramSettings.InventionTimeColumnName
                                .InventionTime = i
                            Case ProgramSettings.ItemMarketPriceColumnName
                                .ItemMarketPrice = i
                            Case ProgramSettings.ProfitColumnName
                                .Profit = i
                            Case ProgramSettings.ProfitPercentageColumnName
                                .ProfitPercentage = i
                            Case ProgramSettings.IskperHourColumnName
                                .IskperHour = i
                            Case ProgramSettings.SVRColumnName
                                .SVR = i
                            Case ProgramSettings.SVRxIPHColumnName
                                .SVRxIPH = i
                            Case ProgramSettings.PriceTrendColumnName
                                .PriceTrend = i
                            Case ProgramSettings.TotalItemsSoldColumnName
                                .TotalItemsSold = i
                            Case ProgramSettings.TotalOrdersFilledColumnName
                                .TotalOrdersFilled = i
                            Case ProgramSettings.AvgItemsperOrderColumnName
                                .AvgItemsperOrder = i
                            Case ProgramSettings.CurrentSellOrdersColumnName
                                .CurrentSellOrders = i
                            Case ProgramSettings.CurrentBuyOrdersColumnName
                                .CurrentBuyOrders = i
                            Case ProgramSettings.TotalCostColumnName
                                .TotalCost = i
                            Case ProgramSettings.BaseJobCostColumnName
                                .BaseJobCost = i
                            Case ProgramSettings.NumBPsColumnName
                                .NumBPs = i
                            Case ProgramSettings.InventionChanceColumnName
                                .InventionChance = i
                            Case ProgramSettings.BPTypeColumnName
                                .BPType = i
                            Case ProgramSettings.RaceColumnName
                                .Race = i
                            Case ProgramSettings.VolumeperItemColumnName
                                .VolumeperItem = i
                            Case ProgramSettings.TotalVolumeColumnName
                                .TotalVolume = i
                            Case ProgramSettings.PortionSizeColumnName
                                .PortionSize = i
                            Case ProgramSettings.ManufacturingJobFeeColumnName
                                .ManufacturingJobFee = i
                            Case ProgramSettings.ManufacturingFacilityNameColumnName
                                .ManufacturingFacilityName = i
                            Case ProgramSettings.ManufacturingFacilitySystemColumnName
                                .ManufacturingFacilitySystem = i
                            Case ProgramSettings.ManufacturingFacilityRegionColumnName
                                .ManufacturingFacilityRegion = i
                            Case ProgramSettings.ManufacturingFacilitySystemIndexColumnName
                                .ManufacturingFacilitySystemIndex = i
                            Case ProgramSettings.ManufacturingFacilityTaxColumnName
                                .ManufacturingFacilityTax = i
                            Case ProgramSettings.ManufacturingFacilityMEBonusColumnName
                                .ManufacturingFacilityMEBonus = i
                            Case ProgramSettings.ManufacturingFacilityTEBonusColumnName
                                .ManufacturingFacilityTEBonus = i
                            Case ProgramSettings.ManufacturingFacilityUsageColumnName
                                .ManufacturingFacilityUsage = i
                            Case ProgramSettings.ManufacturingFacilityFWSystemLevelColumnName
                                .ManufacturingFacilityFWSystemLevel = i
                            Case ProgramSettings.ComponentFacilityNameColumnName
                                .ComponentFacilityName = i
                            Case ProgramSettings.ComponentFacilitySystemColumnName
                                .ComponentFacilitySystem = i
                            Case ProgramSettings.ComponentFacilityRegionColumnName
                                .ComponentFacilityRegion = i
                            Case ProgramSettings.ComponentFacilitySystemIndexColumnName
                                .ComponentFacilitySystemIndex = i
                            Case ProgramSettings.ComponentFacilityTaxColumnName
                                .ComponentFacilityTax = i
                            Case ProgramSettings.ComponentFacilityMEBonusColumnName
                                .ComponentFacilityMEBonus = i
                            Case ProgramSettings.ComponentFacilityTEBonusColumnName
                                .ComponentFacilityTEBonus = i
                            Case ProgramSettings.ComponentFacilityUsageColumnName
                                .ComponentFacilityUsage = i
                            Case ProgramSettings.ComponentFacilityFWSystemLevelColumnName
                                .ComponentFacilityFWSystemLevel = i
                            Case ProgramSettings.CapComponentFacilityNameColumnName
                                .CapComponentFacilityName = i
                            Case ProgramSettings.CapComponentFacilitySystemColumnName
                                .CapComponentFacilitySystem = i
                            Case ProgramSettings.CapComponentFacilityRegionColumnName
                                .CapComponentFacilityRegion = i
                            Case ProgramSettings.CapComponentFacilitySystemIndexColumnName
                                .CapComponentFacilitySystemIndex = i
                            Case ProgramSettings.CapComponentFacilityTaxColumnName
                                .CapComponentFacilityTax = i
                            Case ProgramSettings.CapComponentFacilityMEBonusColumnName
                                .CapComponentFacilityMEBonus = i
                            Case ProgramSettings.CapComponentFacilityTEBonusColumnName
                                .CapComponentFacilityTEBonus = i
                            Case ProgramSettings.CapComponentFacilityUsageColumnName
                                .CapComponentFacilityUsage = i
                            Case ProgramSettings.CapComponentFacilityFWSystemLevelColumnName
                                .CapComponentFacilityFWSystemLevel = i
                            Case ProgramSettings.CopyingFacilityNameColumnName
                                .CopyingFacilityName = i
                            Case ProgramSettings.CopyingFacilitySystemColumnName
                                .CopyingFacilitySystem = i
                            Case ProgramSettings.CopyingFacilityRegionColumnName
                                .CopyingFacilityRegion = i
                            Case ProgramSettings.CopyingFacilitySystemIndexColumnName
                                .CopyingFacilitySystemIndex = i
                            Case ProgramSettings.CopyingFacilityTaxColumnName
                                .CopyingFacilityTax = i
                            Case ProgramSettings.CopyingFacilityMEBonusColumnName
                                .CopyingFacilityMEBonus = i
                            Case ProgramSettings.CopyingFacilityTEBonusColumnName
                                .CopyingFacilityTEBonus = i
                            Case ProgramSettings.CopyingFacilityUsageColumnName
                                .CopyingFacilityUsage = i
                            Case ProgramSettings.CopyingFacilityFWSystemLevelColumnName
                                .CopyingFacilityFWSystemLevel = i
                            Case ProgramSettings.InventionFacilityNameColumnName
                                .InventionFacilityName = i
                            Case ProgramSettings.InventionFacilitySystemColumnName
                                .InventionFacilitySystem = i
                            Case ProgramSettings.InventionFacilityRegionColumnName
                                .InventionFacilityRegion = i
                            Case ProgramSettings.InventionFacilitySystemIndexColumnName
                                .InventionFacilitySystemIndex = i
                            Case ProgramSettings.InventionFacilityTaxColumnName
                                .InventionFacilityTax = i
                            Case ProgramSettings.InventionFacilityMEBonusColumnName
                                .InventionFacilityMEBonus = i
                            Case ProgramSettings.InventionFacilityTEBonusColumnName
                                .InventionFacilityTEBonus = i
                            Case ProgramSettings.InventionFacilityUsageColumnName
                                .InventionFacilityUsage = i
                            Case ProgramSettings.InventionFacilityFWSystemLevelColumnName
                                .InventionFacilityFWSystemLevel = i
                        End Select
                    Next
                End With
            End With
        End With

    End Sub

    Private Sub chkLstBoxColumns_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles chkLstBoxColumns.SelectedIndexChanged

        If SelectedIndex <> chkLstBoxColumns.SelectedIndex Then
            SelectedIndex = chkLstBoxColumns.SelectedIndex

            If chkLstBoxColumns.GetItemChecked(chkLstBoxColumns.SelectedIndex) Then
                ' Uncheckit
                chkLstBoxColumns.SetItemChecked(chkLstBoxColumns.SelectedIndex, False)
            Else
                ' Checkit
                chkLstBoxColumns.SetItemChecked(chkLstBoxColumns.SelectedIndex, True)
            End If

        End If

    End Sub

    Private Sub btnDefaults_Click(sender As System.Object, e As System.EventArgs) Handles btnDefaults.Click
        UserManufacturingTabColumnSettings = AllSettings.SetDefaultManufacturingTabColumnSettings()
        Call ShowList()
        chkLstBoxColumns.Update()
    End Sub

End Class