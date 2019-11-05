'---------------------------------------------------------------------------------------------------
' copyright file="Store.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------

'''-------------------------------------------------------------------------------------------------
''' <summary>A store.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class Store

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the UID.</summary>
    ''' <value>The UID.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property uid As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the name of the store.</summary>
    ''' <value>The name of the store.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Store_Name As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the first line of the address.</summary>
    ''' <value>The first line of the address.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Street1 As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the second line of the address.</summary>
    ''' <value>The second line of the address.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Street2 As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the city.</summary>
    ''' <value>The city.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property City As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the postcode.</summary>
    ''' <value>The postcode.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Postcode As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the VAT number.</summary>
    ''' <value>The VAT number.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property VAT_Number As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the company number.</summary>
    ''' <value>The company number.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Company_Number As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the phone number.</summary>
    ''' <value>The phone number.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Phone_Number As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the customer services email.</summary>
    ''' <value>The customer services email.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Customer_Services_Email As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the filename of the logo file.</summary>
    ''' <value>The filename of the logo file.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Logo_FileName As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the state / county.</summary>
    ''' <value>The state / county.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property State As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the country.</summary>
    ''' <value>The country.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Country As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the first comment on the A4 receipt.</summary>
    ''' <value>The first comment on the A4 receipt.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property A4ReceiptComment1 As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the second comment on the A4 receipt.</summary>
    ''' <value>The second comment on the A4 receipt.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property A4ReceiptComment2 As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the third comment on the A4 receipt.</summary>
    ''' <value>The third comment on the A4 receipt.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property A4ReceiptComment3 As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the title of the first comment on the A4 receipt.</summary>
    ''' <value>The title of the first comment on the A4 receipt.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property A4ReceiptCommentTitle1 As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the title of the second comment on the A4 receipt.</summary>
    ''' <value>The title of the second comment on the A4 receipt.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property A4ReceiptCommentTitle2 As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the title of the third comment on the A4 receipt.</summary>
    ''' <value>The title of the third comment on the A4 receipt.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property A4ReceiptCommentTitle3 As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the web address.</summary>
    ''' <value>The web address.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property WebAddress As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the Google map link.</summary>
    ''' <value>The Google map link.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property GoogleMapLink As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether Amazon integration is enabled.</summary>
    ''' <value>Whether Amazon integration is enabled.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property AmazonIntegrationEnabled As Boolean

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether eBay integration is enabled.</summary>
    ''' <value>Whether eBay integration is enabled.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property eBayIntegrationEnabled As Boolean

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the client reference.</summary>
    ''' <value>The client reference.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property ClientRef As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the store client code.</summary>
    ''' <value>The store client code.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property StoreClientCode As String

End Class