'---------------------------------------------------------------------------------------------------
' copyright file="AJAX.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports System.Threading
Imports CitrusLime.CloudPOS.Api.VBSampleApplication.Constants
Imports Newtonsoft.Json

'''-------------------------------------------------------------------------------------------------
''' <summary>An ajax wrapper.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class AJAX

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Call the Cloud POS API.</summary>
    ''' <param name="apiMethod">The method to call on the api.</param>
    ''' <param name="action">The action to perform.</param>
    ''' <param name="jsonToSend">The JSON to send.</param>
    ''' <returns>The CallResults.</returns>
    '''-------------------------------------------------------------------------------------------------
    Public Shared Function CallAPI(apiMethod As String, action As enumRESTVerb, Optional jsonToSend As String = "") As CallResults

        Dim uri = $"https://cloudposapi.citruslime.com/api/{apiMethod}"

        Dim results As New CallResults
        Dim appendOrQueryString = IIf(apiMethod.Contains("?"), "&", "?")
        Dim pagedUrl = $"{uri}{appendOrQueryString}pageNumber="
        Dim nextUrl As String = uri

        Do
            Using client As New HttpClient

                client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue(Constants.API_KEY)

                Dim content As StringContent = New StringContent(jsonToSend, Encoding.UTF8, "application/json")

                Dim response As HttpResponseMessage = GetResponseFromAPI(client, nextUrl, action, content)

                Dim data As String = response.Content.ReadAsStringAsync().Result

                If response.IsSuccessStatusCode Then
                    nextUrl = HandlePaging(response, pagedUrl)
                    results.JsonBuilder.Append(data)
                Else
                    results.ErrorMessage = data

                    HandleBadResponse(response, nextUrl, results)
                End If

            End Using
        Loop While nextUrl <> String.Empty

        results.JsonBuilder.Replace("][", ",")

        Return results

    End Function

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets a response from the API.</summary>
    ''' <param name="client">The client.</param>
    ''' <param name="uri">The uri to call.</param>
    ''' <param name="action">The action to perform.</param>
    ''' <param name="content">The content to post.</param>
    ''' <returns>The response.</returns>
    '''-------------------------------------------------------------------------------------------------
    Private Shared Function GetResponseFromAPI(client As HttpClient, uri As String, action As enumRESTVerb, content As StringContent) As HttpResponseMessage

        Dim response As New HttpResponseMessage

        Select Case action
            Case enumRESTVerb.GET
                response = client.GetAsync(uri).Result

            Case enumRESTVerb.POST
                response = client.PostAsync(uri, content).Result

            Case enumRESTVerb.PUT
                response = client.PutAsync(uri, content).Result
        End Select

        Return response

    End Function

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Handles the bad response.</summary>
    ''' <param name="response">The response.</param>
    ''' <param name="nextUri">[in,out] The next uri to call.</param>
    ''' <param name="results">[in,out] The results.</param>
    '''-------------------------------------------------------------------------------------------------
    Private Shared Sub HandleBadResponse(response As HttpResponseMessage, ByRef nextUri As String, ByRef results As CallResults)

        Select Case response.StatusCode
            Case HttpStatusCode.NotFound
                nextUri = String.Empty
                results.Status = enumApiCallStatus.NOT_FOUND

            Case 429
                Thread.Sleep(1000)

            Case HttpStatusCode.Unauthorized
                nextUri = String.Empty
                results.Status = enumApiCallStatus.NOT_AUTHENICATED

            Case Else
                nextUri = String.Empty
                results.Status = enumApiCallStatus.SERVER_ERROR

        End Select

    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Handles the paging.</summary>
    ''' <param name="response">The response.</param>
    ''' <param name="baseUrl">The base url.</param>
    ''' <returns>A string containing the uri and the next page to get.</returns>
    '''-------------------------------------------------------------------------------------------------
    Private Shared Function HandlePaging(response As HttpResponseMessage, baseUrl As String) As String


        Dim nextURL = String.Empty
        If response.Headers.TryGetValues("paging-headers", Nothing) Then

            Dim pagingHeaders As String = response.Headers.GetValues("paging-headers").First
            Dim paging As Paging = JsonConvert.DeserializeObject(Of Paging)(pagingHeaders)

            If paging.TotalPages <> paging.CurrentPage Then
                nextURL = $"{baseUrl}{paging.CurrentPage + 1}"
            End If

        End If
        Return nextURL

    End Function


End Class
