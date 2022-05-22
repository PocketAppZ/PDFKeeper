﻿'******************************************************************************
'* PDFKeeper -- Open Source PDF Document Management
'* Copyright (C) 2009-2022 Robert F. Frasca
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
Imports PDFKeeper.Domain
Imports PDFKeeper.Infrastructure

Public Class SubjectListService
    Implements ISubjectListService
    Private ReadOnly repository As IDocumentRepository

    Public Sub New(ByVal repository As IDocumentRepository)
        Me.repository = repository
    End Sub

    Public Function ListSubjects() As DataTable Implements ISubjectListService.ListSubjects
        Return repository.ListSubjects
    End Function

    Public Function ListSubjects(author As String) As DataTable Implements ISubjectListService.ListSubjects
        Return repository.ListSubjects(author)
    End Function

    Public Function ListSubjects(filter As SubjectFilterModel) As DataTable Implements ISubjectListService.ListSubjects
        Return repository.ListSubjects(filter)
    End Function
End Class