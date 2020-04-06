﻿'******************************************************************************
'* PDFKeeper -- Open Source PDF Document Storage and Management
'* Copyright (C) 2009-2020  Robert F. Frasca
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
Namespace Enums
    ''' <summary>
    ''' Operations that can be performed on all Search Results. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum SelectionState
        SelectAll
        DeselectAll
    End Enum

    ''' <summary>
    ''' Operations that can be performed on all selected Search Results items.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum SelectedDocumentsFunction
        SetClearCategory
        Delete
        Export
    End Enum
End Namespace
