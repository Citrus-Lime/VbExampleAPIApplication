'---------------------------------------------------------------------------------------------------
' copyright file="Customer.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------

'''-------------------------------------------------------------------------------------------------
''' <summary>A customer object.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class Customer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the UID.</summary>
    ''' <value>The UID.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property uid As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the account number.</summary>
    ''' <value>The account number.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property AccountNumber As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier of the account type.</summary>
    ''' <value>The identifier of the account type.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property AccountTypeID As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the address 2.</summary>
    ''' <value>The address 2.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Address2 As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the company.</summary>
    ''' <value>The company.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Company As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the country.</summary>
    ''' <value>The country.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Country As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the last updated date.</summary>
    ''' <value>The last updated date.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property LastUpdated As DateTime? = Nothing

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the identifier of the primary ship to address.</summary>
    ''' <value>The identifier of the primary ship to address.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PrimaryShipToID As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the state / county.</summary>
    ''' <value>The state / county.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property State As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether the customer is an employee.</summary>
    ''' <value>Whether the customer is an employee.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Employee As Boolean

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the customer's first name.</summary>
    ''' <value>The customer's first name.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property FirstName As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the customer's last name.</summary>
    ''' <value>The customer's last name.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property LastName As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the address.</summary>
    ''' <value>The address.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Address As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the city.</summary>
    ''' <value>The city.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property City As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the postcode.</summary>
    ''' <value>The postcode.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Postcode As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the credit limit.</summary>
    ''' <value>The credit limit.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property CreditLimit As Double

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the total sales value.</summary>
    ''' <value>The total sales value.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property TotalSales As Double

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the date the account opened.</summary>
    ''' <value>The date the account opened.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property AccountOpened As DateTime? = Nothing

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the last visited date.</summary>
    ''' <value>The last visited date.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property LastVisit As DateTime

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the total number of visits.</summary>
    ''' <value>The total number of visits.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property TotalVisits As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the total savings.</summary>
    ''' <value>The total savings.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property TotalSavings As Double

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the current discount.</summary>
    ''' <value>The current discount.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property CurrentDiscount As Double

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the price level.</summary>
    ''' <value>The price level.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PriceLevel As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether the customer is tax exempt.</summary>
    ''' <value>Whether the customer is tax exempt.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property TaxExempt As Boolean

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the notes.</summary>
    ''' <value>The notes.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Notes As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the title.</summary>
    ''' <value>The title.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Title As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the email address.</summary>
    ''' <value>The email address.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property EmailAddress As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the tax number.</summary>
    ''' <value>The tax number.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property TaxNumber As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the mobile number.</summary>
    ''' <value>The mobile number.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property MobileNumber As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the phone number.</summary>
    ''' <value>The phone number.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PhoneNumber As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the fax number.</summary>
    ''' <value>The fax number.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property FaxNumber As String = String.Empty

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the gender.</summary>
    ''' <value>The gender.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property Gender As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the date of birth.</summary>
    ''' <value>The date of birth.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property DateOfBirth As DateTime? = Nothing

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the contact preference.</summary>
    ''' <value>The contact preference.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property ContactPreference As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the last email statement.</summary>
    ''' <value>The last email statement.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property LastEmailStatement As DateTime? = Nothing

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets whether the customer has opted into emails.</summary>
    ''' <value>Whether the customer has opted into emails.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property EmailOptIn As Boolean

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the email opt in date.</summary>
    ''' <value>The email opt in date.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property OptInDate As DateTime? = Nothing
End Class