' *****************************************************************************
' * PDFKeeper -- Open Source PDF Document Management
' * Copyright (C) 2009-2024 Robert F. Frasca
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

Imports PDFKeeper.Core.DataAccess

Public Class OptionsDialog
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HelpProvider.HelpNamespace = New HelpFile().FileName
        If DatabaseSession.PlatformName.Equals(
            DatabaseSession.CompatiblePlatformName.Sqlite) = False Then
            ShowAllDocumentsOnStartupCheckBox.Visible = False
        End If
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Close()
    End Sub

    Private Sub FindFlaggedDocumentsOnStartupCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles FindFlaggedDocumentsOnStartupCheckBox.CheckStateChanged
        If FindFlaggedDocumentsOnStartupCheckBox.Checked Then
            ShowAllDocumentsOnStartupCheckBox.Checked = False
        End If
    End Sub

    Private Sub ShowAllDocumentsOnStartupCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles ShowAllDocumentsOnStartupCheckBox.CheckStateChanged
        If ShowAllDocumentsOnStartupCheckBox.Checked Then
            FindFlaggedDocumentsOnStartupCheckBox.Checked = False
        End If
    End Sub
End Class
