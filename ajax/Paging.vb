﻿'---------------------------------------------------------------------------------------------------
' copyright file="Paging.vb" company="CitrusLime Ltd"
' Copyright (c) CitrusLime Ltd. All rights reserved.
' copyright
'---------------------------------------------------------------------------------------------------

'''-------------------------------------------------------------------------------------------------
''' <summary>Paging.</summary>
'''-------------------------------------------------------------------------------------------------
Public Class Paging

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the total count.</summary>
    ''' <value>The total count.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property TotalCount As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the page size.</summary>
    ''' <value>The size of the page.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PageSize As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the current page.</summary>
    ''' <value>The current page.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property CurrentPage As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the total number of pages.</summary>
    ''' <value>The total number of pages.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property TotalPages As Integer

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the previous page.</summary>
    ''' <value>The previous page.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property PreviousPage As String

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>Gets or sets the next page.</summary>
    ''' <value>The next page.</value>
    '''-------------------------------------------------------------------------------------------------
    Public Property NextPage As String
End Class