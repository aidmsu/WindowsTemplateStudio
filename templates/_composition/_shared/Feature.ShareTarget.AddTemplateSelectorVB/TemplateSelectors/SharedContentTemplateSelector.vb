﻿Imports Windows.ApplicationModel.DataTransfer
Imports Param_ItemNamespace.ViewModels

Namespace TemplateSelectors
    Public Class SharedContentTemplateSelector
        Inherits DataTemplateSelector

        Public Property DefaultTemplate As DataTemplate

        Public Property StorageItemsTemplate As DataTemplate

        Public Property WebLinkTemplate As DataTemplate

        Public Sub New()
        End Sub

        Protected Overrides Function SelectTemplateCore(item As Object, container As DependencyObject) As DataTemplate
            Dim sharedData = TryCast(item, SharedDataViewModelBase)
            If sharedData IsNot Nothing Then
                If sharedData.DataFormat = StandardDataFormats.WebLink Then
                    Return WebLinkTemplate
                ElseIf sharedData.DataFormat = StandardDataFormats.StorageItems Then
                    Return StorageItemsTemplate
                End If
            End If

            Return DefaultTemplate
        End Function
    End Class
End Namespace
