'---------------------------------------------------------------------------------------------------
' copyright file="Item.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------

'''-------------------------------------------------------------------------------------------------
''' <summary>An item.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class Item

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the UID.</summary>
    ''' <value>The UID.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property uid As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the description.</summary>
    ''' <value>The description.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Description As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the barcode description.</summary>
    ''' <value>The barcode description.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property BarcodeDescription As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether the item is not discountable.</summary>
    ''' <value>Whether the item is not discountable.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property ItemNotDiscountable As Boolean

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the last updated date.</summary>
    ''' <value>The last updated date.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property LastUpdated As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the notes.</summary>
    ''' <value>The notes.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Notes As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the item lookup code.</summary>
    ''' <value>The item lookup code.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property ItemLookupCode As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier of the department.</summary>
    ''' <value>The identifier of the department.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property DepartmentID As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier of the category.</summary>
    ''' <value>The identifier of the category.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property CategoryID As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier of the brand.</summary>
    ''' <value>The identifier of the brand.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Brand As Integer?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the gender.</summary>
    ''' <remarks>0 is male, 1 is female, 2 is not set.</remarks>
    ''' <value>The gender.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Gender As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier of the season.</summary>
    ''' <value>The identifier of the season.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Season As Integer?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the cost.</summary>
    ''' <value>The cost.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Cost As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the price.</summary>
    ''' <value>The price.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Price As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the MSRP.</summary>
    ''' <value>The MSRP.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property MSRP As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the price at price level A.</summary>
    ''' <value>The price at price level A.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PriceA As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the price at price level B.</summary>
    ''' <value>The price at price level B.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PriceB As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the price at price level C.</summary>
    ''' <value>The price at price level C.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PriceC As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the price at price level D.</summary>
    ''' <value>The price at price level D.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PriceD As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the price at price level E.</summary>
    ''' <value>The price at price level E.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PriceE As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the ebay price.</summary>
    ''' <value>The ebay price.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property EbayPrice As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the amazon price.</summary>
    ''' <value>The amazon price.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property AmazonPrice As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the website price.</summary>
    ''' <value>The website price.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property WebsitePrice As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether the item is on sale.</summary>
    ''' <value>Whether the item is on sale.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property OnSale As Boolean?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the sale price.</summary>
    ''' <value>The sale price.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property SalePrice As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the sale start date.</summary>
    ''' <value>The sale start date.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property SaleStartDate As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the sale end date.</summary>
    ''' <value>The sale end date.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property SaleEndDate As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier of the tax rate.</summary>
    ''' <value>The identifier of the tax rate.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property TaxID As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the type of the item.</summary>
    ''' <remarks>0: Standard, 1: Serialised, 2: Matrix, 7: Non-Inventory, 8: Assembly, 9: Voucher</remarks>
    ''' <value>The type of the item.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property ItemType As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the tare weight.</summary>
    ''' <value>The tare weight.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property TareWeight As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the weight.</summary>
    ''' <value>The weight.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Weight As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier of the supplier.</summary>
    ''' <value>The identifier of the supplier.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property SupplierID As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the last sold date.</summary>
    ''' <value>The last sold date.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property LastSold As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the extended description.</summary>
    ''' <value>The extended description.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property ExtendedDescription As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether quantity entry is not allowed in POS.</summary>
    ''' <value>Whether quantity entry is not allowed in POS.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property QuantityEntryNotAllowed As Boolean

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether the price must be entered in POS.</summary>
    ''' <value>Whether the price must be entered in POS.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PriceMustBeEntered As Boolean

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether the item is active.</summary>
    ''' <value>Whether the item is active.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Active As Boolean

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether the item is marked as do not order.</summary>
    ''' <value>Whether the item is marked as do not order.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property DoNotOrder As Boolean

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the date created.</summary>
    ''' <value>The date created.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property DateCreated As DateTime

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the date the price was last changed.</summary>
    ''' <value>The date the price was last changed.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Price_Changed As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the date the MSRP was last changed.</summary>
    ''' <value>The date the MSRP was last changed.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property MSRP_Changed As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets date the sale price was last changed.</summary>
    ''' <value>The date the sale price was last changed.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property SalePrice_Changed As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the date that price level A was last changed.</summary>
    ''' <value>The date that price level A was last changed.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PriceA_Changed As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the date that price level B was last changed.</summary>
    ''' <value>The date that price level B was last changed.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PriceB_Changed As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the date that price level C was last changed.</summary>
    ''' <value>The date that price level C was last changed.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PriceC_Changed As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the date that price level D was last changed.</summary>
    ''' <value>The date that price level D was last changed.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PriceD_Changed As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the date that price level E was last changed.</summary>
    ''' <value>The date that price level E was last changed.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PriceE_Changed As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the date the Amazon price was last changed.</summary>
    ''' <value>The date the Amazon price was last changed.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PriceAmazon_Changed As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the date the eBay price was last changed.</summary>
    ''' <value>The date the eBay price was last changed.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PriceEbay_Changed As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the date the website price was last changed.</summary>
    ''' <value>The date the website price was last changed.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property WebsitePrice_Changed As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether the item was imported through SIM.</summary>
    ''' <value>Whether the item was imported through SIM.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property SIMImported As Boolean?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the date the item was imported through SIM.</summary>
    ''' <value>The date the item was imported through SIM.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property SIMImportDate As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether to update the item through SIM.</summary>
    ''' <value>Whether to update the item through SIM.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property UpdateFromSIM As Boolean?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the date the item was last updated through SIM.</summary>
    ''' <value>The date the item was last updated through SIM.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property LastUpdatefromSIM As DateTime?

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the label mode.</summary>
    ''' <remarks>0: Normal (print by quantity), 1: Only print one label, 2: Never print labels</remarks>
    ''' <value>The label mode.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property LabelMode As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the matrix code.</summary>
    ''' <value>The matrix code.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property MatrixCode As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the matrix description.</summary>
    ''' <value>The matrix description.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property MatrixDescription As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the first dimension.</summary>
    ''' <value>The first dimension.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Dimension1 As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the second dimension.</summary>
    ''' <value>The second dimension.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Dimension2 As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the third dimension.</summary>
    ''' <value>The third dimension.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Dimension3 As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the supplier code.</summary>
    ''' <value>The supplier code.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property SupplierCode As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the supplier master pack quantity.</summary>
    ''' <value>The supplier master pack quantity.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property SupplierMasterPackQuantity As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the supplier cost.</summary>
    ''' <value>The supplier cost.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property SupplierCost As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the supplier minimum order.</summary>
    ''' <value>The supplier minimum order.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property SupplierMinimumOrder As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier of the supplier tax rate.</summary>
    ''' <value>The identifier of the supplier tax rate.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property SupplierTaxID As Integer

End Class
