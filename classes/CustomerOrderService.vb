'---------------------------------------------------------------------------------------------------
' copyright file="CustomerOrderService.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------
Imports CitrusLime.CloudPOS.Api.VBSampleApplication.Constants
Imports Newtonsoft.Json

'''-------------------------------------------------------------------------------------------------
''' <summary>A service for accessing customer orders information.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class CustomerOrderService

    ''' <summary>The method to call on the API.</summary>
    Private apiMethod As String = "CustomerOrder"

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets all the customer orders, excluding the line items on the order.</summary>
    ''' <returns>A list of customer orders.</returns>
    '''-------------------------------------------------------------------------------------------------
    Public Function GetAllHeaders() As List(Of CustomerOrder)
        Dim results As CallResults = AJAX.CallAPI(apiMethod, enumRESTVerb.GET)

        Dim customerOrders As List(Of CustomerOrder) = JsonConvert.DeserializeObject(Of List(Of CustomerOrder))(results.Json)

        If Not results.Success Then
            Throw (New Exception($"Error {Reflection.MethodBase.GetCurrentMethod().Name} the error is {results.ErrorMessage}"))
        End If

        Return customerOrders
    End Function


    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets a customer order by order id, including all the line items on the order.</summary>
    ''' <returns>A single customer order including order details.</returns>
    '''-------------------------------------------------------------------------------------------------
    Public Function GetOrderGetByID(orderID As Integer) As CustomerOrder
        Dim results As CallResults = AJAX.CallAPI($"{apiMethod}/{orderID.ToString()}", enumRESTVerb.GET)

        Dim customerOrder As CustomerOrder = JsonConvert.DeserializeObject(Of CustomerOrder)(results.Json)

        If Not results.Success Then
            Throw (New Exception($"Error {Reflection.MethodBase.GetCurrentMethod().Name} the error is {results.ErrorMessage}"))
        End If

        Return customerOrder
    End Function

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Creates a new customer order.</summary>
    ''' <param name="newOrder">The new order.</param>
    ''' <returns>The new order id.</returns>
    '''-------------------------------------------------------------------------------------------------
    Public Function Create(newOrder As NewCustomerOrder) As Integer
        Dim orderAsJson As String = JsonConvert.SerializeObject(newOrder)

        Dim orderID As Integer = 0

        Dim results As CallResults = AJAX.CallAPI(apiMethod, enumRESTVerb.POST, orderAsJson)

        If Not results.Success Then
            Throw (New Exception($"Error {Reflection.MethodBase.GetCurrentMethod().Name} the error is {results.ErrorMessage}"))
        End If

        Integer.TryParse(results.Json, orderID)

        Return orderID
    End Function

End Class
