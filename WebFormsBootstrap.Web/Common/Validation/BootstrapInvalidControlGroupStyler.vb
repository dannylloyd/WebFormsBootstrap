﻿Imports WebFormsBootstrap.Web.Controls.Bootstrap

Namespace Common.Validation
    Public Class BootstrapInvalidControlGroupStyler

        Public Shared Sub StyleInvalidControls(formState As FormState)
            For Each formError In formState.Errors
                Dim controlGroup = formError.Control
                ' traverse up control tree looking for the first ControlGroup
                While controlGroup IsNot Nothing AndAlso Not TypeOf controlGroup Is ControlGroup
                    controlGroup = controlGroup.Parent
                End While

                If controlGroup IsNot Nothing AndAlso TypeOf controlGroup Is ControlGroup Then
                    DirectCast(controlGroup, ControlGroup).ValidationStatus = ValidationState.Error
                End If
            Next
        End Sub

    End Class
End Namespace