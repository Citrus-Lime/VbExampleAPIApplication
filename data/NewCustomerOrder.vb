'---------------------------------------------------------------------------------------------------
' copyright file="NewCustomerOrder.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------

'''-------------------------------------------------------------------------------------------------
''' <summary>A new customer order.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class NewCustomerOrder

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the addresses.</summary>
    ''' <value>The addresses.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Addresses As New List(Of CustomerOrderAddress)

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the items.</summary>
    ''' <value>The items.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Items As New List(Of CustomerOrderItem)

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier.</summary>
    ''' <value>The identifier.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property ID As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the tender type.</summary>
    ''' <value>The tender type.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property tendertype As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the comment.</summary>
    ''' <value>The comment.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property comment As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the shipping charge.</summary>
    ''' <value>The shipping charge.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property shippingcharge As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether the order uses premium shipping.</summary>
    ''' <value>Whether the order uses premium shipping.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property premiumShipping As Boolean

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the channel type.</summary>
    ''' <value>The channel type.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property channeltype As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier of the third party transaction.</summary>
    ''' <value>The identifier of the third party transaction.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property thirdPartyTransactionID As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier of the third party order.</summary>
    ''' <value>The identifier of the third party order.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property thirdPartyOrderID As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the store client code.</summary>
    ''' <value>The store client code.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property storeClientCode As String

End Class
