'---------------------------------------------------------------------------------------------------
' copyright file="CallResults.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------
Imports System.Text
Imports CitrusLime.CloudPOS.Api.VBSampleApplication.Constants

'''-------------------------------------------------------------------------------------------------
''' <summary>API call results.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class CallResults

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets the status of the API call.</summary>
    ''' <value>The status of the API call.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Status As enumApiCallStatus

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets the JSON builder.</summary>
    ''' <value>The JSON builder.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property JsonBuilder As New StringBuilder()

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets the JSON from the JSON builder.</summary>
    ''' <value>The JSON from the JSON builder.</value>
    '''-------------------------------------------------------------------------------------------------
    Public ReadOnly Property Json As String
        Get
            Return JsonBuilder.ToString()
        End Get
    End Property

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets the error message.</summary>
    ''' <value>The error message.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property ErrorMessage As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets a value indicating whether the API call was successful.</summary>
    ''' <value>True if the API call was successful, false if not.</value>
    '''-------------------------------------------------------------------------------------------------
    Public ReadOnly Property Success As Boolean
        Get
            If Status = enumApiCallStatus.SUCCESS Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

End Class




