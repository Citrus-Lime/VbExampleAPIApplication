'---------------------------------------------------------------------------------------------------
' copyright file="CustomerOrder.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------

'''-------------------------------------------------------------------------------------------------
''' <summary>A customer order.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class CustomerOrder

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the UID.</summary>
    ''' <value>The UID.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property uid As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the client reference.</summary>
    ''' <value>The client reference.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property ClientRef As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether the order is closed.</summary>
    ''' <value>Whether the order is closed.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Closed As Boolean

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the date created.</summary>
    ''' <value>The date created.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property DateCreated As DateTime

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the type of order.</summary>
    ''' <remarks>0: Not an Order, 2: Workorder, 3: Quote, 4: Backorder, 5: Layaway, 6: Workshop</remarks>
    ''' <value>The type of order.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Type As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the comment.</summary>
    ''' <value>The comment.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Comment As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier of the customer.</summary>
    ''' <value>The identifier of the customer.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property CustomerID As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier of the ship to address.</summary>
    ''' <value>The identifier of the ship to address.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property ShipToID As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the deposit.</summary>
    ''' <value>The deposit.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Deposit As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the tax.</summary>
    ''' <value>The tax.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Tax As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the total.</summary>
    ''' <value>The total.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Total As Decimal

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the last updated date.</summary>
    ''' <value>The last updated date.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property LastUpdated As DateTime

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the due date.</summary>
    ''' <value>The due date.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property DueDate As DateTime

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether the order is taxable.</summary>
    ''' <value>Whether the order is taxable.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Taxable As Boolean

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier of the sales rep.</summary>
    ''' <value>The identifier of the sales rep.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property SalesRepID As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the reference number.</summary>
    ''' <value>The reference number.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property ReferenceNumber As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the shipping charge on the order.</summary>
    ''' <value>The shipping charge on the order.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property ShippingChargeOnOrder As Double

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the type of the channel.</summary>
    ''' <value>The type of the channel.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property ChannelType As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether the customer has checked in parts to fulfill the order.</summary>
    ''' <remarks>This is used for workshop orders.</remarks>
    ''' <value>Whether the customer has checked in parts.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property CheckedIn As Boolean

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the name of the customer.</summary>
    ''' <value>The name of the customer.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property CustomerName As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the order lines.</summary>
    ''' <value>The order lines.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property orderlines As OrderLine()

End Class