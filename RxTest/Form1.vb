Imports System.Reactive.Linq

Public Class Form1

    Public Sub New()

        ' この呼び出しは、Windows フォーム デザイナで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Dim plus = Observable.FromEventPattern(Of EventArgs)(btnPlus, "Click").Select(Function(e) 1)
        Dim minus = Observable.FromEventPattern(Of EventArgs)(btnMinus, "Click").Select(Function(e) -1)
        Dim both = plus.Merge(minus)
        Dim current As IObservable(Of Integer) = both.Scan(Function(x, y) x + y)

        current.Subscribe(AddressOf Hoge)
    End Sub

    Private Sub Hoge(ByVal z As Integer)
        txtResult.Text = z.ToString
    End Sub

End Class
