﻿Imports Param_ItemNamespace.Views
Namespace ViewModels
    Public Class ShellViewModel
        Inherits Observable
        Private Sub PopulateNavItems()
//^^
            _secondaryItems.Add(ShellNavigationItem.FromType(Of wts.ItemNamePage)("Shell_wts.ItemName".GetLocalized(), Symbol.Setting))
        End Sub
    End Class
End Namespace
