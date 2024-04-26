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
        components = New ComponentModel.Container()
        InvDataGroupBox = New GroupBox()
        itemComboBox = New ComboBox()
        wholesaleCostTextBox = New TextBox()
        quantityTextBox = New TextBox()
        ItemQuantLabel = New Label()
        WholesaleLabel = New Label()
        ItemLabel = New Label()
        itemListBox = New ListBox()
        Label1 = New Label()
        totalInventoryValueTextBox = New TextBox()
        TotalValueLabel = New Label()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        JToolStripMenuItem = New ToolStripMenuItem()
        InventoriesToolStripMenuItem = New ToolStripMenuItem()
        AddToItemListingToolStripMenuItem = New ToolStripMenuItem()
        ClearListingToolStripMenuItem = New ToolStripMenuItem()
        CountItemListingToolStripMenuItem = New ToolStripMenuItem()
        AddItemToComboBoxToolStripMenuItem = New ToolStripMenuItem()
        DeleteComboBoxItemToolStripMenuItem = New ToolStripMenuItem()
        ColorsAndFontsToolStripMenuItem = New ToolStripMenuItem()
        SetBackgroundColorToolStripMenuItem = New ToolStripMenuItem()
        changeFontButton = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        formContextMenu = New ContextMenuStrip(components)
        ColorToolStripMenuItem = New ToolStripMenuItem()
        FontToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        InvDataGroupBox.SuspendLayout()
        MenuStrip1.SuspendLayout()
        formContextMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' InvDataGroupBox
        ' 
        InvDataGroupBox.Controls.Add(itemComboBox)
        InvDataGroupBox.Controls.Add(wholesaleCostTextBox)
        InvDataGroupBox.Controls.Add(quantityTextBox)
        InvDataGroupBox.Controls.Add(ItemQuantLabel)
        InvDataGroupBox.Controls.Add(WholesaleLabel)
        InvDataGroupBox.Controls.Add(ItemLabel)
        InvDataGroupBox.Location = New Point(44, 27)
        InvDataGroupBox.Name = "InvDataGroupBox"
        InvDataGroupBox.Size = New Size(431, 116)
        InvDataGroupBox.TabIndex = 0
        InvDataGroupBox.TabStop = False
        InvDataGroupBox.Text = "Inventory Data"
        ' 
        ' itemComboBox
        ' 
        itemComboBox.AllowDrop = True
        itemComboBox.FormattingEnabled = True
        itemComboBox.Items.AddRange(New Object() {"TaylorMade R7 Driver RH 10-degree", "TaylorMade R7 Driver LH 10-degree", "TaylorMade R7 Driver RH 9-degree", "Titleist 907D2 Driver RH 9.5-degree", "Titleist 907D2 Driver RH 10.5-degree", "King Cobra HS9 X Driver RH 9-degree", "King Cobra HS9 X Driver LH 9-degree", "Adams Redline RPM Driver RH 10-degree", ""})
        itemComboBox.Location = New Point(123, 26)
        itemComboBox.Name = "itemComboBox"
        itemComboBox.Size = New Size(213, 23)
        itemComboBox.TabIndex = 6
        ' 
        ' wholesaleCostTextBox
        ' 
        wholesaleCostTextBox.Location = New Point(123, 52)
        wholesaleCostTextBox.Name = "wholesaleCostTextBox"
        wholesaleCostTextBox.Size = New Size(127, 23)
        wholesaleCostTextBox.TabIndex = 4
        wholesaleCostTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' quantityTextBox
        ' 
        quantityTextBox.Location = New Point(123, 80)
        quantityTextBox.Name = "quantityTextBox"
        quantityTextBox.Size = New Size(127, 23)
        quantityTextBox.TabIndex = 5
        quantityTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' ItemQuantLabel
        ' 
        ItemQuantLabel.AutoSize = True
        ItemQuantLabel.Location = New Point(11, 83)
        ItemQuantLabel.Name = "ItemQuantLabel"
        ItemQuantLabel.Size = New Size(97, 15)
        ItemQuantLabel.TabIndex = 2
        ItemQuantLabel.Text = "Quantity of Item:"
        ' 
        ' WholesaleLabel
        ' 
        WholesaleLabel.AutoSize = True
        WholesaleLabel.Location = New Point(11, 55)
        WholesaleLabel.Name = "WholesaleLabel"
        WholesaleLabel.Size = New Size(91, 15)
        WholesaleLabel.TabIndex = 1
        WholesaleLabel.Text = "Wholesale Cost:"
        ' 
        ' ItemLabel
        ' 
        ItemLabel.AutoSize = True
        ItemLabel.Location = New Point(11, 29)
        ItemLabel.Name = "ItemLabel"
        ItemLabel.Size = New Size(68, 15)
        ItemLabel.TabIndex = 0
        ItemLabel.Text = "Select Item:"
        ' 
        ' itemListBox
        ' 
        itemListBox.FormattingEnabled = True
        itemListBox.ItemHeight = 15
        itemListBox.Location = New Point(44, 177)
        itemListBox.Name = "itemListBox"
        itemListBox.Size = New Size(431, 79)
        itemListBox.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 15)
        Label1.TabIndex = 4
        Label1.Text = "Inventory Item Listing:"
        ' 
        ' totalInventoryValueTextBox
        ' 
        totalInventoryValueTextBox.Location = New Point(375, 270)
        totalInventoryValueTextBox.Name = "totalInventoryValueTextBox"
        totalInventoryValueTextBox.ReadOnly = True
        totalInventoryValueTextBox.Size = New Size(100, 23)
        totalInventoryValueTextBox.TabIndex = 5
        totalInventoryValueTextBox.TabStop = False
        totalInventoryValueTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' TotalValueLabel
        ' 
        TotalValueLabel.AutoSize = True
        TotalValueLabel.Location = New Point(230, 273)
        TotalValueLabel.Name = "TotalValueLabel"
        TotalValueLabel.Size = New Size(119, 15)
        TotalValueLabel.TabIndex = 6
        TotalValueLabel.Text = "Total Inventory Value:"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, InventoriesToolStripMenuItem, ColorsAndFontsToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(640, 24)
        MenuStrip1.TabIndex = 7
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {JToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' JToolStripMenuItem
        ' 
        JToolStripMenuItem.Name = "JToolStripMenuItem"
        JToolStripMenuItem.Size = New Size(93, 22)
        JToolStripMenuItem.Text = "E&xit"
        ' 
        ' InventoriesToolStripMenuItem
        ' 
        InventoriesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddToItemListingToolStripMenuItem, ClearListingToolStripMenuItem, CountItemListingToolStripMenuItem, AddItemToComboBoxToolStripMenuItem, DeleteComboBoxItemToolStripMenuItem})
        InventoriesToolStripMenuItem.Name = "InventoriesToolStripMenuItem"
        InventoriesToolStripMenuItem.Size = New Size(69, 20)
        InventoriesToolStripMenuItem.Text = "&Inventory"
        ' 
        ' AddToItemListingToolStripMenuItem
        ' 
        AddToItemListingToolStripMenuItem.Name = "AddToItemListingToolStripMenuItem"
        AddToItemListingToolStripMenuItem.Size = New Size(203, 22)
        AddToItemListingToolStripMenuItem.Text = "&Add Item To Listing"
        ' 
        ' ClearListingToolStripMenuItem
        ' 
        ClearListingToolStripMenuItem.Name = "ClearListingToolStripMenuItem"
        ClearListingToolStripMenuItem.Size = New Size(203, 22)
        ClearListingToolStripMenuItem.Text = "&Clear Listing "
        ' 
        ' CountItemListingToolStripMenuItem
        ' 
        CountItemListingToolStripMenuItem.Name = "CountItemListingToolStripMenuItem"
        CountItemListingToolStripMenuItem.Size = New Size(203, 22)
        CountItemListingToolStripMenuItem.Text = "C&ount Item Listing"
        ' 
        ' AddItemToComboBoxToolStripMenuItem
        ' 
        AddItemToComboBoxToolStripMenuItem.Name = "AddItemToComboBoxToolStripMenuItem"
        AddItemToComboBoxToolStripMenuItem.Size = New Size(203, 22)
        AddItemToComboBoxToolStripMenuItem.Text = "A&dd Item to Combo Box"
        ' 
        ' DeleteComboBoxItemToolStripMenuItem
        ' 
        DeleteComboBoxItemToolStripMenuItem.Name = "DeleteComboBoxItemToolStripMenuItem"
        DeleteComboBoxItemToolStripMenuItem.Size = New Size(203, 22)
        DeleteComboBoxItemToolStripMenuItem.Text = "&Delete Combo Box Item"
        ' 
        ' ColorsAndFontsToolStripMenuItem
        ' 
        ColorsAndFontsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SetBackgroundColorToolStripMenuItem, changeFontButton})
        ColorsAndFontsToolStripMenuItem.Name = "ColorsAndFontsToolStripMenuItem"
        ColorsAndFontsToolStripMenuItem.Size = New Size(108, 20)
        ColorsAndFontsToolStripMenuItem.Text = "&Colors and Fonts"
        ' 
        ' SetBackgroundColorToolStripMenuItem
        ' 
        SetBackgroundColorToolStripMenuItem.Name = "SetBackgroundColorToolStripMenuItem"
        SetBackgroundColorToolStripMenuItem.Size = New Size(189, 22)
        SetBackgroundColorToolStripMenuItem.Text = "Set &Background Color"
        ' 
        ' changeFontButton
        ' 
        changeFontButton.Name = "changeFontButton"
        changeFontButton.Size = New Size(189, 22)
        changeFontButton.Text = "Set &Font"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(180, 22)
        AboutToolStripMenuItem.Text = "&About"
        ' 
        ' formContextMenu
        ' 
        formContextMenu.Items.AddRange(New ToolStripItem() {ColorToolStripMenuItem, FontToolStripMenuItem, ExitToolStripMenuItem})
        formContextMenu.Name = "ContextMenuStrip1"
        formContextMenu.Size = New Size(181, 92)
        ' 
        ' ColorToolStripMenuItem
        ' 
        ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        ColorToolStripMenuItem.Size = New Size(180, 22)
        ColorToolStripMenuItem.Text = "Color"
        ' 
        ' FontToolStripMenuItem
        ' 
        FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        FontToolStripMenuItem.Size = New Size(180, 22)
        FontToolStripMenuItem.Text = "Font"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(180, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(640, 303)
        Controls.Add(TotalValueLabel)
        Controls.Add(totalInventoryValueTextBox)
        Controls.Add(Label1)
        Controls.Add(itemListBox)
        Controls.Add(InvDataGroupBox)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        InvDataGroupBox.ResumeLayout(False)
        InvDataGroupBox.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        formContextMenu.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents InvDataGroupBox As GroupBox
    Friend WithEvents wholesaleCostTextBox As TextBox
    Friend WithEvents quantityTextBox As TextBox
    Friend WithEvents ItemQuantLabel As Label
    Friend WithEvents WholesaleLabel As Label
    Friend WithEvents ItemLabel As Label
    Friend WithEvents itemListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents itemComboBox As ComboBox
    Friend WithEvents totalInventoryValueTextBox As TextBox
    Friend WithEvents TotalValueLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorsAndFontsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToItemListingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearListingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CountItemListingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddItemToComboBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteComboBoxItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetBackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents changeFontButton As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents formContextMenu As ContextMenuStrip
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
