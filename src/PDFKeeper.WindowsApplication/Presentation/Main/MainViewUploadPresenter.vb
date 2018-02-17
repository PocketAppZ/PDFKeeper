﻿'******************************************************************************
'* PDFKeeper -- Open Source PDF Document Storage Solution
'* Copyright (C) 2009-2018 Robert F. Frasca
'*
'* This file is part of PDFKeeper.
'*
'* PDFKeeper is free software: you can redistribute it and/or modify
'* it under the terms of the GNU General Public License as published by
'* the Free Software Foundation, either version 3 of the License, or
'* (at your option) any later version.
'*
'* PDFKeeper is distributed in the hope that it will be useful,
'* but WITHOUT ANY WARRANTY; without even the implied warranty of
'* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'* GNU General Public License for more details.
'*
'* You should have received a copy of the GNU General Public License
'* along with PDFKeeper.  If not, see <http://www.gnu.org/licenses/>.
'******************************************************************************
Public Class MainViewUploadPresenter
    Private view As IMainViewUpload

    Public Sub New(view As IMainViewUpload)
        Me.view = view
    End Sub

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", _
        "CA1822:MarkMembersAsStatic")> _
    Public Sub ShowUploadFoldersDialog()
        UploadController.SkipUpload = True
        Using uploadFoldersDialog As New UploadFoldersDialog
            uploadFoldersDialog.ShowDialog()
        End Using
        UploadController.SkipUpload = False
    End Sub

    Public Sub DoUpload()
        If UploadController.SkipUpload = False Then
            view.UploadSkippedVisible = False
            If DirectoryHelper.GetCountOfFiles(ApplicationDirectories.Upload, _
                                               SearchOption.AllDirectories) > 0 Then
                view.UploadRunningVisible = True
            End If
            If DirectoryHelper.GetCountOfFiles(ApplicationDirectories.UploadStaging, _
                                               SearchOption.AllDirectories) > 0 Then
                view.UploadRunningVisible = True
            End If
            Application.DoEvents()
            Dim command As ICommand = New UploadCommand
            command.Execute()
            view.UploadRunningVisible = False
            CheckForFilesNotUploaded()
            Application.DoEvents()
        Else
            view.UploadSkippedVisible = True
        End If
    End Sub

    Private Sub CheckForFilesNotUploaded()
        If DirectoryHelper.GetCountOfFiles(ApplicationDirectories.Upload, _
                                           SearchOption.AllDirectories) > 0 Then
            view.UploadFolderErrorVisible = True
        Else
            view.UploadFolderErrorVisible = False
        End If
        If DirectoryHelper.GetCountOfFiles(ApplicationDirectories.UploadStaging, _
                                           SearchOption.AllDirectories) > 0 Then
            view.UploadStagingFolderErrorVisible = True
        Else
            view.UploadStagingFolderErrorVisible = False
        End If
    End Sub
End Class
