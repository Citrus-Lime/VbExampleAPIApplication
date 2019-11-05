'---------------------------------------------------------------------------------------------------
' copyright file="CustomerOrderAddress.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------
'''-------------------------------------------------------------------------------------------------
''' <summary>A customer order address.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class CustomerOrderAddress

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the type of address.</summary>
    ''' <remarks>0 for billing, 1 for shipping.</remarks>
    ''' <value>The type of address.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property type As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the first name of the recipient at the address.</summary>
    ''' <value>The first name of the recipient at the address.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property firstname As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the last name of the recipient at the address.</summary>
    ''' <value>The last name of the recipient at the address.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property lastname As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the first line of the address.</summary>
    ''' <value>The first line of the address.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property address1 As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the second line of the address.</summary>
    ''' <value>The second line of the address.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property address2 As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the city.</summary>
    ''' <value>The city.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property city As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the state / county.</summary>
    ''' <value>The state / county.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property state As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the postcode.</summary>
    ''' <value>The postcode.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property postcode As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the country.</summary>
    ''' <value>The country.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property country As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the phone number.</summary>
    ''' <value>The phone number.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property phone As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the email address.</summary>
    ''' <value>The email address.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property email As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the company.</summary>
    ''' <value>The company.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property company As String

End Class
