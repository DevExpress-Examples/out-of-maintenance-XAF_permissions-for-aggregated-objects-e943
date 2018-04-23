Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security

Namespace AggregatedObjects.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal objectSpace As ObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()

			Dim myAddressPermissions As Role = ObjectSpace.FindObject(Of Role)(New BinaryOperator("Name", "AggregatedObjectPermissionsOnly"))
			If myAddressPermissions Is Nothing Then
				myAddressPermissions = ObjectSpace.CreateObject(Of Role)()
				myAddressPermissions.Name = "AggregatedObjectPermissionsOnly"
				myAddressPermissions.AddPermission(New ObjectAccessPermission(GetType(MyPerson), ObjectAccess.AllAccess, ObjectAccessModifier.Deny))
				myAddressPermissions.AddPermission(New ObjectAccessPermission(GetType(MyAddress), ObjectAccess.AllAccess, ObjectAccessModifier.Allow))
				myAddressPermissions.Save()
			End If

			Dim userSam As User = ObjectSpace.FindObject(Of User)(New BinaryOperator("UserName", "Sam"))
			If userSam Is Nothing Then
				userSam = ObjectSpace.CreateObject(Of User)()
				userSam.UserName = "Sam"
				userSam.FirstName = "Sam"
				userSam.Roles.Add(myAddressPermissions)
				userSam.Save()
			End If
		End Sub
	End Class
End Namespace
