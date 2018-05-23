Imports Microsoft.VisualBasic
Imports System

Partial Public Class HowToSetMaskForCustomWinPropertyEdtiorWindowsFormsApplication
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
		Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
        Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
		Me.module3 = New Global.HowToSetMaskForCustomWinPropertyEdtior.Module.HowToSetMaskForCustomWinPropertyEdtiorModule()
		Me.module4 = New Global.HowToSetMaskForCustomWinPropertyEdtior.Module.Win.HowToSetMaskForCustomWinPropertyEdtiorWindowsFormsModule()
		Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
        Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
        Me.module7 = New DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule()
        Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
		Me.securitySimple1 = New DevExpress.ExpressApp.Security.SecuritySimple()
		Me.authenticationActiveDirectory1 = New DevExpress.ExpressApp.Security.AuthenticationActiveDirectory()
		Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()

		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' securitySimple1
		' 
		Me.securitySimple1.Authentication = Me.authenticationActiveDirectory1
		Me.securitySimple1.UserType = GetType(DevExpress.Persistent.BaseImpl.BasicUser)
		' 
		' authenticationActiveDirectory1
		' 
		Me.authenticationActiveDirectory1.CreateUserAutomatically = True
		Me.authenticationActiveDirectory1.UserType = GetType(DevExpress.Persistent.BaseImpl.BasicUser)
		' 
		' sqlConnection1
		' 
		Me.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=HowToSetMaskForCustomWinPropertyEdtior;Integrated Security=SSPI;Pooling=false"
		Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
		' 
		' HowToSetMaskForCustomWinPropertyEdtiorWindowsFormsApplication
		' 
		Me.ApplicationName = "HowToSetMaskForCustomWinPropertyEdtior"
		Me.Connection = Me.sqlConnection1
		Me.Modules.Add(Me.module1)
		Me.Modules.Add(Me.module2)
		Me.Modules.Add(Me.module3)
		Me.Modules.Add(Me.module4)
		Me.Modules.Add(Me.module5)
        Me.Modules.Add(Me.module6)
        Me.Modules.Add(Me.module7)
        Me.Modules.Add(Me.securityModule1)

		Me.Security = Me.securitySimple1
		AddHandler Me.DatabaseVersionMismatch, AddressOf HowToSetMaskForCustomWinPropertyEdtiorWindowsFormsApplication_DatabaseVersionMismatch

		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

#End Region

	Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
    Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
	Private module3 As Global.HowToSetMaskForCustomWinPropertyEdtior.Module.HowToSetMaskForCustomWinPropertyEdtiorModule
	Private module4 As Global.HowToSetMaskForCustomWinPropertyEdtior.Module.Win.HowToSetMaskForCustomWinPropertyEdtiorWindowsFormsModule
	Private module5 As DevExpress.ExpressApp.Validation.ValidationModule
    Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
    Private module7 As DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
    Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule

	Private securitySimple1 As DevExpress.ExpressApp.Security.SecuritySimple
	Private authenticationActiveDirectory1 As DevExpress.ExpressApp.Security.AuthenticationActiveDirectory
	Private sqlConnection1 As System.Data.SqlClient.SqlConnection
End Class
