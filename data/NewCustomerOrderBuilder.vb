'---------------------------------------------------------------------------------------------------
' copyright file="NewCustomerOrderBuilder.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------
'''-------------------------------------------------------------------------------------------------
''' <summary>A new customer order builder.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class NewCustomerOrderBuilder

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Builds a new customer order.</summary>
    ''' <param name="uniqueReference">The unique reference.</param>
    ''' <param name="customerToUse">The customer to use.</param>
    ''' <param name="storeCode">The store code.</param>
    ''' <param name="comment">The comment.</param>
    ''' <returns>A CustomerOrder.</returns>
    '''-------------------------------------------------------------------------------------------------
    Public Shared Function Build(uniqueReference As String,
                                 customerToUse As Customer,
                                 storeCode As String,
                                 comment As String) As NewCustomerOrder

        Dim order As New NewCustomerOrder With {
            .ID = uniqueReference,
            .channeltype = "None",
            .storeClientCode = storeCode,
            .comment = comment,
            .premiumShipping = False
        }

        order.Addresses.Add(CustomerOrderAddressBuilder.GenerateBillingAddressFromCustomer(customerToUse))
        order.Addresses.Add(CustomerOrderAddressBuilder.GenerateShippingAddressFromCustomer(customerToUse))

        Return order
    End Function

End Class