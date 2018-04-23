Imports System
Imports System.Security.Principal

Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Base.Security
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class Updater
	Inherits DevExpress.ExpressApp.Updating.ModuleUpdater

	Public Sub New(ByVal session As Session, ByVal currentDBVersion As Version)
		MyBase.New(session, currentDBVersion)
	End Sub

    Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
        MyBase.UpdateDatabaseAfterUpdateSchema()

        Dim myAddressPermissions As Role = Session.FindObject(Of Role)(New BinaryOperator("Name", _
        "AggregatedObjectPermissionsOnly"))
        If myAddressPermissions Is Nothing Then
            myAddressPermissions = New Role(Session)
            myAddressPermissions.Name = "AggregatedObjectPermissionsOnly"
            myAddressPermissions.AddPermission(New ObjectAccessPermission(GetType(MyPerson), _
            ObjectAccess.AllAccess, ObjectAccessModifier.Deny))
            myAddressPermissions.AddPermission(New ObjectAccessPermission(GetType(MyAddress), _
            ObjectAccess.AllAccess, ObjectAccessModifier.Allow))
            myAddressPermissions.Save()
        End If

        Dim userSam As User = Session.FindObject(Of User)(New BinaryOperator("UserName", "Sam"))
        If userSam Is Nothing Then
            userSam = New User(Session)
            userSam.UserName = "Sam"
            userSam.FirstName = "Sam"
            userSam.Roles.Add(myAddressPermissions)
            userSam.Save()
        End If
    End Sub

End Class
