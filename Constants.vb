'---------------------------------------------------------------------------------------------------
' copyright file="Constants.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------

'''-------------------------------------------------------------------------------------------------
''' <summary>Constants.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class Constants

    ''' <summary>The API key.</summary>
    ''' <remarks>It is recommended you use the API key from your demo group so you
    ''' don't affect live data.</remarks>
    Public Const API_KEY As String = "YOUR API KEY HERE"

    ''' <summary>Identifier for the customer.</summary>
    ''' <remarks>Set this as the ID of a customer from your demo group.</remarks>
    Public Const CUSTOMER_ID As Integer = 0

    ''' <summary>The name of the application.</summary>
    ''' <remarks>This must be fewer than 6 characters</remarks>
    Friend Shared ReadOnly APP_NAME As String = "My App"

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Values that represent REST verbs.</summary>
    '''-------------------------------------------------------------------------------------------------
    Enum enumRESTVerb

        ''' <summary>An enum constant representing the get option.</summary>
        [GET] = 0

        ''' <summary>An enum constant representing the put option.</summary>
        PUT = 1

        ''' <summary>An enum constant representing the post option.</summary>
        POST = 2
    End Enum

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Values that represent API call status.</summary>
    '''-------------------------------------------------------------------------------------------------
    Enum enumApiCallStatus

        ''' <summary>An enum constant representing the success option.</summary>
        SUCCESS = 0

        ''' <summary>An enum constant representing the server error option.</summary>
        SERVER_ERROR = 1

        ''' <summary>An enum constant representing the not found option.</summary>
        NOT_FOUND = 2

        ''' <summary>An enum constant representing the not authenicated option.</summary>
        NOT_AUTHENICATED = 3
    End Enum

End Class
