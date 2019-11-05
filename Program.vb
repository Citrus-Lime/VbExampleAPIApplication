'---------------------------------------------------------------------------------------------------
' copyright file="Program.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------

'''-------------------------------------------------------------------------------------------------
''' <summary>The Citrus Lime CloudPOS API VB sample program.</summary>
'''-------------------------------------------------------------------------------------------------
Module Program

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets the current time as a string.</summary>
    ''' <remarks>This returns YYYYMMDDHHMMSS rather than the System implementation which returns YYYY/MM/DD HH:MM:SS.</remarks>
    ''' <value>The current time as a string.</value>
    '''-------------------------------------------------------------------------------------------------
    Private ReadOnly Property CurrentTimeAsString As String
        Get
            Return $"{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}"
        End Get
    End Property

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' The main entry-point for this application.
    ''' 
    ''' There is a dependency on Newtonsoft.JSON. You can install the package through NuGet.
    ''' 
    ''' Before running, make sure to do some setup in Constants.vb:
    '''  1. API_KEY         Replace "YOUR API KEY HERE" with your API key
    '''  2. CUSTOMER_ID     Replace 0 with a customer id in your CloudPOS group
    '''  3. APP_NAME        (Optional) Replace "My App" with a more memorable name
    ''' 
    ''' </summary>
    '''-------------------------------------------------------------------------------------------------
    Sub Main()

        '' Create services to get information from the API
        Dim customerService As New CustomerService

        Dim customerOrderService As New CustomerOrderService

        Console.WriteLine("Getting all customers. Please wait.")

        '' Get all the customers from the API using the customer service
        Dim listOfCustomers As List(Of Customer) = customerService.GetAll()

        '' Display information for all the customers that were found
        DisplayInfoForAllCustomers(listOfCustomers)

        '' Gets a customer based on id from the API
        Dim customer As Customer = customerService.GetByID(Constants.CUSTOMER_ID)

        Console.WriteLine($"Getting customer by id of {Constants.CUSTOMER_ID}")

        '' Display information for the customer from the API
        DisplayInfoForCustomer(customer)

        '' Create a new customer and display success / failure
        Dim newCustomer = CreateNewCustomerAndShowResponse(customerService)

        '' Update a customer and display success / failure
        UpdateCustomerAndShowResponse(customerService, listOfCustomers(0))

        '' Gets and displays information for all customer orders
        GetAndDisplayInfoForAllOrders(customerOrderService)

        '' Creates a new customer order and displays the response
        CreateNewCustomerOrderAndShowResponse(customerOrderService, newCustomer)

        Console.ReadLine()
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Displays information for all customers.</summary>
    ''' <remarks>Shows the name, email address and id.</remarks>
    ''' <param name="listOfCustomers">A list of customers.</param>
    '''-------------------------------------------------------------------------------------------------
    Sub DisplayInfoForAllCustomers(listOfCustomers As List(Of Customer))
        For Each customer As Customer In listOfCustomers
            DisplayInfoForCustomer(customer)
        Next
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Displays information for a customer.</summary>
    ''' <param name="customer">The customer.</param>
    '''-------------------------------------------------------------------------------------------------
    Sub DisplayInfoForCustomer(customer As Customer)
        Console.WriteLine($"Name:  {customer.FirstName} {customer.LastName}  Email: {customer.EmailAddress}  ID: {customer.Uid.ToString()}")
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Creates a new customer and shows the response.</summary>
    ''' <param name="customerService">The customer service.</param>
    ''' <returns>The new customer.</returns>
    '''-------------------------------------------------------------------------------------------------
    Function CreateNewCustomerAndShowResponse(customerService As CustomerService) As Customer
        Dim random As New Random()

        '' Set up the new customer locally
        Dim newCustomer As New Customer With {
            .AccountNumber = $"{Constants.APP_NAME}{CurrentTimeAsString}", ' required  must be unique 
            .FirstName = "Bilbo",
            .LastName = "Baggins", ' required  
            .EmailAddress = $"bilbo{random.Next(1000000) }@citruslime.com", ' not required, but must be unique
            .Address = "The Lantern House",
            .City = "Ulverston",
            .Postcode = "LA12 0AA",
            .Country = "GB"
        }

        Dim newCustomerId As Integer = 0

        Try
            '' Send the customer to the API through the customer service to create it on CloudPOS
            newCustomerId = customerService.Create(newCustomer)

            Console.WriteLine($"Created Customer ID {newCustomerId}, with email {newCustomer.EmailAddress}")
        Catch exception As Exception
            Console.WriteLine($"New Customer Failed - {exception.Message}")
        End Try

        Return newCustomer

    End Function

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Updates a customer and shows a response.</summary>
    ''' <param name="customerService">The customer service.</param>
    ''' <param name="customer">The customer to update.</param>
    '''-------------------------------------------------------------------------------------------------
    Sub UpdateCustomerAndShowResponse(customerService As CustomerService, customer As Customer)
        customer.Notes += "1234567890"

        If customerService.Save(customer) Then
            Console.WriteLine($"Saved {customer.FirstName} {customer.LastName}")
        Else
            Console.WriteLine("Save Customer Failed")
        End If

    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets and displays information for all orders.</summary>
    ''' <param name="customerOrderService">The customer order service.</param>
    '''-------------------------------------------------------------------------------------------------
    Sub GetAndDisplayInfoForAllOrders(customerOrderService As CustomerOrderService)
        Dim orders As List(Of CustomerOrder) = customerOrderService.GetAllHeaders()

        For Each order As CustomerOrder In orders
            Dim status As String = IIf(order.Closed, "CLOSED", "OPEN")

            Dim itemCount As Integer = 0

            Console.WriteLine($"Order #{order.uid} is '{ status }'. Sub total { order.Total.ToString("C") }, for which a deposit of {order.Deposit.ToString("C")} has been taken in payment.")

            Dim orderDetail As CustomerOrder = customerOrderService.GetOrderGetByID(order.uid)

            For Each orderLine In orderDetail.orderlines
                Console.WriteLine($"{vbTab} {orderLine.Description} {vbTab} Quantity Still Outstanding { orderLine.QuantityOnOrder} {vbTab} Quantity Picked Up {orderLine.QuantityRTD}.")
            Next
        Next

    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Creates a new customer order and shows response.</summary>
    ''' <param name="customerOrderService">The customer order service.</param>
    ''' <param name="customer">The customer.</param>
    '''-------------------------------------------------------------------------------------------------
    Sub CreateNewCustomerOrderAndShowResponse(customerOrderService As CustomerOrderService, customer As Customer)

        Console.WriteLine("Getting all items.")

        Dim itemService As New ItemService

        Dim items As List(Of Item) = itemService.GetAll()

        Console.WriteLine("Getting all stores.")

        Dim storeServices As New StoresService

        Dim stores As List(Of Store) = storeServices.GetAll()

        Dim neworder As NewCustomerOrder = NewCustomerOrderBuilder.Build(Constants.APP_NAME & CurrentTimeAsString,
                                                                         customer,
                                                                         stores.FirstOrDefault.StoreClientCode,
                                                                         "API VB Sample Order Comment")

        neworder.Items.Add(New CustomerOrderItem With {.code = items.Last.ItemLookupCode, .quantity = 2, .unitprice = 9.99})

        Try
            Console.WriteLine("Creating an order.")

            Dim orderId = customerOrderService.Create(neworder)

            Console.WriteLine($"New order ID: {orderId}")
        Catch ex As Exception

            Console.WriteLine($"New Order Failed - {ex.Message}")

        End Try

    End Sub

End Module



