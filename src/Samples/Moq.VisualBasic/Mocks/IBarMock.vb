﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Imports Moq.VisualBasic
Imports System.Threading
Imports Moq.Sdk
Imports System
Imports System.Collections.ObjectModel
Imports System.Reflection
Imports Stunts
Imports System.Runtime.CompilerServices

Namespace Global.Mocks

    Public Partial Class IBarMock
        Implements IBar, IStunt, IMocked

        ReadOnly pipeline As BehaviorPipeline = New BehaviorPipeline()
        Dim _mock As IMock

        <CompilerGenerated>
        ReadOnly Property Behaviors As ObservableCollection(Of IStuntBehavior) Implements IStunt.Behaviors
            Get
                Return pipeline.Behaviors
            End Get
        End Property

        ReadOnly Property Mock As IMock Implements IMocked.Mock
            Get
                Return LazyInitializer.EnsureInitialized(_mock, (Function() New DefaultMock(Me)))
            End Get
        End Property

        <CompilerGenerated>
        Public Sub DoBar() Implements IBar.DoBar
            pipeline.Execute(New MethodInvocation(Me, MethodBase.GetCurrentMethod()))
        End Sub

        <CompilerGenerated>
        Public Overrides Function ToString() As String
            Return pipeline.Execute(Of String
            )(New MethodInvocation(Me, MethodBase.GetCurrentMethod()))
        End Function

        <CompilerGenerated>
        Public Overrides Function Equals(obj As Object) As Boolean
            Return pipeline.Execute(Of Boolean
            )(New MethodInvocation(Me, MethodBase.GetCurrentMethod(), obj))
        End Function

        <CompilerGenerated>
        Public Overrides Function GetHashCode() As Integer
            Return pipeline.Execute(Of Integer
            )(New MethodInvocation(Me, MethodBase.GetCurrentMethod()))
        End Function
    End Class
End Namespace
