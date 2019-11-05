'---------------------------------------------------------------------------------------------------
' copyright file="CustomerService.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------
Imports CitrusLime.CloudPOS.Api.VBSampleApplication.Constants
Imports Newtonsoft.Json

'''-------------------------------------------------------------------------------------------------
''' <summary>A service for accessing customer information.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class CustomerService

    ''' <summary>The method to call on the API.</summary>
    Private apiMethod As String = "Customer"

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Saves an updated customer.</summary>
    ''' <param name="updatedCustomer">The updated customer.</param>
    ''' <returns>True if the customer is saved, false if it fails.</returns>
    '''-------------------------------------------------------------------------------------------------
    Public Function Save(updatedCustomer As Customer) As Boolean
        Dim customerAsJson As String = JsonConvert.SerializeObject(updatedCustomer)

        Dim results As CallResults = AJAX.CallAPI(apiMethod, enumRESTVerb.PUT, customerAsJson)

        If Not results.Success Then
            Throw (New Exception($"Error {Reflection.MethodBase.GetCurrentMethod().Name} the error is {results.ErrorMessage}"))
        End If

        Return results.Success
    End Function


    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Creates a new customer.</summary>
    ''' <param name="newCustomer">The new customer.</param>
    ''' <returns>The new customer ID.</returns>
    '''-------------------------------------------------------------------------------------------------
    Public Function Create(newCustomer As Customer) As Integer
        Dim customerAsJson As String = JsonConvert.SerializeObject(newCustomer)

        Dim customerId As Integer = 0

        Dim results As CallResults = AJAX.CallAPI(apiMethod, enumRESTVerb.POST, customerAsJson)

        Integer.TryParse(results.Json, customerId)

        If Not results.Success Then
            Throw (New Exception($"Error {Reflection.MethodBase.GetCurrentMethod().Name} the error is {results.ErrorMessage}"))
        End If

        Return customerId
    End Function

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets all customers.</summary>
    ''' <returns>A list of customers.</returns>
    '''-------------------------------------------------------------------------------------------------
    Public Function GetAll() As List(Of Customer)
        Dim results As CallResults = AJAX.CallAPI(apiMethod, enumRESTVerb.GET)

        Dim customers As List(Of Customer) = JsonConvert.DeserializeObject(Of List(Of Customer))(results.Json)

        If Not results.Success Then
            Throw (New Exception($"Error {Reflection.MethodBase.GetCurrentMethod().Name} the error is {results.ErrorMessage}"))
        End If

        Return customers
    End Function

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets a customer by email address.</summary>
    ''' <param name="email">The email address of the customer.</param>
    ''' <returns>The customer with the email address.</returns>
    '''-------------------------------------------------------------------------------------------------
    Public Function GetByEmail(email As String) As Customer

        ' The @ symbol must be replaced with the URL encoded equivalent
        email = email.Replace("@", "%40")

        Dim results As CallResults = AJAX.CallAPI($"{apiMethod}/{email}/", enumRESTVerb.GET)

        Dim customer As Customer = JsonConvert.DeserializeObject(Of Customer)(results.Json)

        If Not results.Success Then
            Throw (New Exception($"Error {Reflection.MethodBase.GetCurrentMethod().Name} the error is {results.ErrorMessage}"))
        End If

        Return customer
    End Function

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets a customer by id.</summary>
    ''' <param name="id">The id of the customer.</param>
    ''' <returns>The customer with the id.</returns>
    '''-------------------------------------------------------------------------------------------------
    Public Function GetByID(id As Integer) As Customer
        Dim results As CallResults = AJAX.CallAPI($"{apiMethod}/{id.ToString()}", enumRESTVerb.GET)

        Dim customer As Customer = JsonConvert.DeserializeObject(Of Customer)(results.Json)

        If Not results.Success Then
            Throw (New Exception($"Error {Reflection.MethodBase.GetCurrentMethod().Name} the error is {results.ErrorMessage}"))
        End If

        Return customer
    End Function

End Class



