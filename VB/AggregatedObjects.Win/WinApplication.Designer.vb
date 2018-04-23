Imports Microsoft.VisualBasic
Imports System

Partial Public Class AggregatedObjectsWindowsFormsApplication
	''' <summary> 
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (Not components Is Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

#Region "Component Designer generated code"

	''' <summary> 
	''' Required method for Designer support - do not modify 
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule
        Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
        Me.module3 = New AggregatedObjects.[Module].AggregatedObjectsModule
        Me.module4 = New AggregatedObjects.[Module].Win.AggregatedObjectsWindowsFormsModule
        Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule
        Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
        Me.module7 = New DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
        Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SecurityComplex1 = New DevExpress.ExpressApp.Security.SecurityComplex
        Me.AuthenticationStandard1 = New DevExpress.ExpressApp.Security.AuthenticationStandard
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'module5
        '
        Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResult))
        Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResultItem))
        Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RulePropertyValueProperties))
        Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleRequiredFieldProperties))
        Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleFromBoolPropertyProperties))
        Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleRangeProperties))
        Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleValueComparisonProperties))
        Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleStringComparisonProperties))
        Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleRegularExpressionProperties))
        Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleCriteriaProperties))
        Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleSearchObjectProperties))
        Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleObjectExistsProperties))
        Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleUniqueValueProperties))
        Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleIsReferencedProperties))
        '
        'sqlConnection1
        '
        Me.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=AggregatedObjects;Integrated Security=SSPI;Po" & _
            "oling=false"
        Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SecurityComplex1
        '
        Me.SecurityComplex1.Authentication = Me.AuthenticationStandard1
        Me.SecurityComplex1.IsGrantedForNonExistentPermission = False
        Me.SecurityComplex1.RoleType = GetType(DevExpress.Persistent.BaseImpl.Role)
        Me.SecurityComplex1.UserType = GetType(DevExpress.Persistent.BaseImpl.User)
        '
        'AuthenticationStandard1
        '
        Me.AuthenticationStandard1.LogonParametersType = GetType(DevExpress.ExpressApp.Security.AuthenticationStandardLogonParameters)
        Me.AuthenticationStandard1.UserType = GetType(DevExpress.Persistent.BaseImpl.User)
        '
        'AggregatedObjectsWindowsFormsApplication
        '
        Me.ApplicationName = "AggregatedObjects"
        Me.Connection = Me.sqlConnection1
        Me.Modules.Add(Me.module1)
        Me.Modules.Add(Me.module2)
        Me.Modules.Add(Me.module6)
        Me.Modules.Add(Me.module3)
        Me.Modules.Add(Me.module4)
        Me.Modules.Add(Me.module5)
        Me.Modules.Add(Me.module7)
        Me.Modules.Add(Me.securityModule1)
        Me.Security = Me.SecurityComplex1
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

	Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
    Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
	Private module3 As Global.AggregatedObjects.Module.AggregatedObjectsModule
	Private module4 As Global.AggregatedObjects.Module.Win.AggregatedObjectsWindowsFormsModule
	Private module5 As DevExpress.ExpressApp.Validation.ValidationModule
    Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
    Private module7 As DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
    Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule

    Private sqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SecurityComplex1 As DevExpress.ExpressApp.Security.SecurityComplex
    Friend WithEvents AuthenticationStandard1 As DevExpress.ExpressApp.Security.AuthenticationStandard
End Class
