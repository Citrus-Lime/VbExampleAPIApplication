'---------------------------------------------------------------------------------------------------
' copyright file="StoresService.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------
Imports CitrusLime.CloudPOS.Api.VBSampleApplication.Constants
Imports Newtonsoft.Json

'''-------------------------------------------------------------------------------------------------
''' <summary>A service for accessing stores information.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class StoresService

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets all stores.</summary>
    ''' <returns>A list of stores.</returns>
    '''-------------------------------------------------------------------------------------------------
    Public Function GetAll() As List(Of Store)
        Dim results As CallResults = AJAX.CallAPI("Store", enumRESTVerb.GET)

        Dim stores As List(Of Store) = JsonConvert.DeserializeObject(Of List(Of Store))(results.Json)

        If Not results.Success Then
            Throw (New Exception($"Error {Reflection.MethodBase.GetCurrentMethod().Name} the error is {results.ErrorMessage}"))
        End If

        Return stores

    End Function

End Class
