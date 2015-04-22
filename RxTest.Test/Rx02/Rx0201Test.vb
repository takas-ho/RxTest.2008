Imports System.Reactive.Linq
Imports NUnit.Framework

Namespace Rx02
    Public Class Rx0201Test

        Private Class Piyo(Of T)
            Public ReadOnly List As New List(Of T)
            Public Sub Compute(ByVal x As T)
                List.Add(x)
            End Sub
        End Class

        <Test()> Public Sub ObservableによるRx的コード()
            Dim a As New Piyo(Of Integer)

            Observable.Range(1, 5).Subscribe(AddressOf a.Compute)

            Assert.That(a.List.Count, [Is].EqualTo(5))
            Assert.That(Join(a.List.ConvertAll(Function(x) x.ToString).ToArray, ","), [Is].EqualTo("1,2,3,4,5"))
        End Sub

    End Class
End Namespace