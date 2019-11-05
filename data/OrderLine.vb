'---------------------------------------------------------------------------------------------------
' copyright file="OrderLine.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------

'''-------------------------------------------------------------------------------------------------
''' <summary>A customer order line.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class OrderLine

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the cost.</summary>
    ''' <value>The cost.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Cost As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the UID.</summary>
    ''' <value>The UID.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property uid As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier of the item.</summary>
    ''' <value>The identifier of the item.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property ItemID As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the full price.</summary>
    ''' <remarks>This is the normal price of the item, but may differ from what it was sold at.</remarks>
    ''' <value>The full price.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property FullPrice As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the price.</summary>
    ''' <value>The price.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Price As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the quantity on order.</summary>
    ''' <value>The quantity on order.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property QuantityOnOrder As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier of the sales rep.</summary>
    ''' <value>The identifier of the sales rep.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property SalesRepID As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the taxable amount.</summary>
    ''' <value>The taxable amount.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Taxable As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the description.</summary>
    ''' <value>The description.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Description As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the quantity returned.</summary>
    ''' <value>The quantity returned.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property QuantityRTD As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the last updated date.</summary>
    ''' <value>The last updated date.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property LastUpdated As DateTime

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the comment.</summary>
    ''' <value>The comment.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Comment As String

End Class
