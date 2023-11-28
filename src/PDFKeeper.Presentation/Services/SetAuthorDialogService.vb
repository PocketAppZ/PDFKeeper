﻿' *****************************************************************************
' * PDFKeeper -- Open Source PDF Document Management
' * Copyright (C) 2009-2023 Robert F. Frasca
' *
' * This file is part of PDFKeeper.
' *
' * PDFKeeper is free software: you can redistribute it and/or modify it
' * under the terms of the GNU General Public License as published by the
' * Free Software Foundation, either version 3 of the License, or (at your
' * option) any later version.
' *
' * PDFKeeper is distributed in the hope that it will be useful, but WITHOUT
' * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
' * FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for
' * more details.
' *
' * You should have received a copy of the GNU General Public License along
' * with PDFKeeper. If not, see <https://www.gnu.org/licenses/>.
' *****************************************************************************

Imports PDFKeeper.Core.Services

Public Class SetAuthorDialogService
    Implements IDialogService

    Public Sub ShowDialog(arg As String) Implements IDialogService.ShowDialog
        Throw New NotImplementedException()
    End Sub

    Public Function ShowDialog() As String Implements IDialogService.ShowDialog
        Using dialog = New SetAuthorView
            dialog.ShowDialog()
            If dialog.DialogResult.Equals(DialogResult.OK) Then
                If dialog.AuthorUserControl.Author.Length > 0 Then
                    Return dialog.AuthorUserControl.Author
                Else
                    Dim messageBoxService = New MessageBoxService
                    messageBoxService.ShowMessage(My.Resources.AuthorCannotBeBlank, True)
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Using
    End Function
End Class
