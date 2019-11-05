'---------------------------------------------------------------------------------------------------
' copyright file="ItemService.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------
Imports CitrusLime.CloudPOS.Api.VBSampleApplication.Constants
Imports Newtonsoft.Json

'''-------------------------------------------------------------------------------------------------
''' <summary>A service for accessing item information.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class ItemService

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets all items.</summary>
    ''' <returns>A list of items.</returns>
    '''-------------------------------------------------------------------------------------------------
    Public Function GetAll() As List(Of Item)
        Dim results As CallResults = AJAX.CallAPI("Item", enumRESTVerb.GET)

        Dim items As List(Of Item) = JsonConvert.DeserializeObject(Of List(Of Item))(results.Json)

        If Not results.Success Then
            Throw (New Exception($"Error {Reflection.MethodBase.GetCurrentMethod().Name} the error is {results.ErrorMessage}"))
        End If

        Return items
    End Function

End Class
