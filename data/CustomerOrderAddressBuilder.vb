'---------------------------------------------------------------------------------------------------
' copyright file="CustomerOrderAddressBuilder.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------

'''-------------------------------------------------------------------------------------------------
''' <summary>A customer order address builder.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class CustomerOrderAddressBuilder

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Generates a billing address from a customer.</summary>
    ''' <param name="customerToMapFrom">The customer to map the address from.</param>
    ''' <returns>A billing address.</returns>
    '''-------------------------------------------------------------------------------------------------
    Public Shared Function GenerateBillingAddressFromCustomer(customerToMapFrom As Customer) As CustomerOrderAddress
        Dim orderAddress = MapAddressFromCustomer(customerToMapFrom, "BILL")

        Return orderAddress
    End Function

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Generates a shipping address from a customer.</summary>
    ''' <param name="customerToMapFrom">The customer to map the address from.</param>
    ''' <returns>A shipping address.</returns>
    '''-------------------------------------------------------------------------------------------------
    Public Shared Function GenerateShippingAddressFromCustomer(customerToMapFrom As Customer) As CustomerOrderAddress
        Dim orderAddress = MapAddressFromCustomer(customerToMapFrom, "SHIP")

        Return orderAddress
    End Function

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Map an address from a customer to a customer order address.</summary>
    ''' <param name="customerToMapFrom">The customer to map from.</param>
    ''' <param name="type">The type of address.</param>
    ''' <returns>A customer order address mapped from a customer.</returns>
    '''-------------------------------------------------------------------------------------------------
    Private Shared Function MapAddressFromCustomer(customerToMapFrom As Customer, type As String)
        Dim orderAddress As New CustomerOrderAddress With {
            .address1 = customerToMapFrom.Address,
            .address2 = customerToMapFrom.Address2,
            .city = customerToMapFrom.City,
            .company = customerToMapFrom.Company,
            .country = customerToMapFrom.Country,
            .firstname = customerToMapFrom.FirstName,
            .state = customerToMapFrom.State,
            .lastname = customerToMapFrom.LastName,
            .phone = customerToMapFrom.PhoneNumber,
            .postcode = customerToMapFrom.Postcode,
            .email = customerToMapFrom.EmailAddress,
            .type = type
        }

        Return orderAddress
    End Function

End Class