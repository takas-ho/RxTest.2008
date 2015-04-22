Imports System.Reactive.Linq
Imports NUnit.Framework

Namespace Rx02
    Public Class Rx0201Test

        <Test()> Public Sub Hoge()
            Dim foo As Func(Of Integer, Object) = Function(x As Integer) New Object
            Observable.Range(1, 5).Subscribe(New Action(Of Integer)( sub(x) console.write(x)))
        End Sub

        Private Shared Function ToAction(Of T)(ByVal arg1 As T, ByVal x As Func(Of T, Object)) As Action(Of T)
            x.Invoke()

        End Function

        Private Shared Function ToFunc(Of T1, T2)(ByVal arg1 As T1, ByVal x As Action(Of T1)) As Func(Of T1, T2)
            x.Invoke(arg1)
            Return Nothing
        End Function

        Public Class Piyo(Of T)
            Private ReadOnly fx As Func(Of T, Object)
            Public Sub New(ByVal fx As Func(Of T, Object))
                Me.fx = fx
            End Sub

            Public Sub Compute(ByVal x As T)
                fx.
            End Sub
        End Class

    End Class
End Namespace