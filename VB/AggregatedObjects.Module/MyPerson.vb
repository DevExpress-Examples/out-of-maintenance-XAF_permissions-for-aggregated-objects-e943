Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace AggregatedObjects.Module
	<DefaultClassOptions> _
	Public Class MyPerson
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Public Property Name() As String
			Get
				Return GetPropertyValue(Of String)("Name")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Name", value)
			End Set
		End Property

		<Association("Person-Addresses"), Aggregated> _
		Public ReadOnly Property Addresses() As XPCollection(Of MyAddress)
			Get
				Return GetCollection(Of MyAddress)("Addresses")
			End Get
		End Property
	End Class

	<DefaultClassOptions> _
	Public Class MyAddress
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Public Property FullAddress() As String
			Get
				Return GetPropertyValue(Of String)("FullAddress")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("FullAddress", value)
			End Set
		End Property

		<Association("Person-Addresses")> _
		Public Property Owner() As MyPerson
			Get
				Return GetPropertyValue(Of MyPerson)("Owner")
			End Get
			Set(ByVal value As MyPerson)
				SetPropertyValue(Of MyPerson)("Owner", value)
			End Set
		End Property
	End Class
End Namespace
