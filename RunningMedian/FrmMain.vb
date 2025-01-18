Imports System.Text.RegularExpressions

Public Class FrmMain


    Dim dpivalue As Double

    Dim sourceList As New List(Of Double)
    Dim medianList As New List(Of Double)

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        ListBox1.Items.Add(Val(TextBox1.Text))
        TextBox1.Text = String.Empty
        lblCnt1.Text = "Count : " & ListBox1.Items.Count
    End Sub

    Sub FillTestData()
        Dim r As New Random
        Dim rCount As Integer = 0
        Do Until rCount = 5000
            sourceList.Add(r.Next(0, 250))
            rCount += 1
        Loop

        ListBox1.BeginUpdate()
        For Each value As Double In sourceList
            ListBox1.Items.Add(value)
        Next
        ListBox1.EndUpdate()
    End Sub

    Sub MiddleMedian()
        medianList.Add(sourceList(0))
        medianList.Add(sourceList(1))

        Dim tempList(4) As Double
        For i As Double = 2 To sourceList.Count - 3
            Dim k As Integer = 0
            For j As Double = i - 2 To i + 2
                tempList(k) = sourceList(j)
                k += 1
            Next
            Quicksort(tempList, 0, 4)
            medianList.Add(tempList(2))
        Next

        medianList.Add(sourceList(sourceList.Count - 2))
        medianList.Add(sourceList(sourceList.Count - 1))
    End Sub

    Sub AllMedian()
        Dim tempList(4) As Double
        Dim iMin As Integer
        Dim iMax As Integer

        For i As Integer = 0 To sourceList.Count - 1
            iMin = IIf(i < 2, 0, i - 2)
            iMax = IIf(i > sourceList.Count - 3, sourceList.Count - 1, i + 2)

            Dim k As Integer = 0
            For j As Integer = iMin To iMax
                tempList(k) = sourceList(j)
                k += 1
            Next
            Quicksort(tempList, 0, 4)
            medianList.Add(tempList(2))
        Next
    End Sub

    Public Sub Quicksort(ByVal list() As Double, ByVal min As Integer, ByVal max As Integer)
        Dim random_number As New Random
        Dim med_value As Double
        Dim hi As Integer
        Dim lo As Integer
        Dim i As Integer

        If min >= max Then Exit Sub

        i = random_number.Next(min, max + 1)
        med_value = list(i)

        list(i) = list(min)

        lo = min
        hi = max
        Do
            Do While list(hi) >= med_value
                hi = hi - 1
                If hi <= lo Then Exit Do
            Loop
            If hi <= lo Then
                list(lo) = med_value
                Exit Do
            End If

            list(lo) = list(hi)

            lo = lo + 1
            Do While list(lo) < med_value
                lo = lo + 1
                If lo >= hi Then Exit Do
            Loop
            If lo >= hi Then
                lo = hi
                list(hi) = med_value
                Exit Do
            End If

            list(hi) = list(lo)
        Loop

        Quicksort(list, min, lo - 1)
        Quicksort(list, lo + 1, max)
    End Sub

    Sub DisplayResults()
        ListBox2.BeginUpdate()
        For Each value As Double In medianList
            ListBox2.Items.Add(value)
        Next
        ListBox2.EndUpdate()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        medianList.Clear()
        ListBox2.Items.Clear()


        If sourceList.Count = 0 Then
            Dim tInt As Double
            For Each item As String In ListBox1.Items
                If Double.TryParse(item, tInt) = True Then
                    sourceList.Add(tInt)
                End If
            Next
        End If

        If ListBox1.Items.Count > 0 Then
            If RadioButton1.Checked Then
                MiddleMedian()
            Else
                AllMedian()
            End If
        Else
            Exit Sub
        End If

        DisplayResults()
        sourceList.Clear()
        lblCnt1.Text = "Count : " & ListBox1.Items.Count
        lblCnt2.Text = "Count : " & ListBox2.Items.Count
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            ListBox1.Items.Add(Val(TextBox1.Text))
            TextBox1.Text = String.Empty
            e.SuppressKeyPress = True
        End If

        lblCnt1.Text = "Count : " & ListBox1.Items.Count
    End Sub

    Private Sub copyButton1_Click(sender As Object, e As EventArgs) Handles copyButton1.Click
        Clipboard.SetText(String.Join(Environment.NewLine, ListBox1.SelectedItems.Cast(Of Double).ToArray))
    End Sub

    Private Sub copyButton2_Click(sender As Object, e As EventArgs) Handles copyButton2.Click
        Clipboard.SetText(String.Join(Environment.NewLine, ListBox2.SelectedItems.Cast(Of Double).ToArray))
    End Sub

    Private Sub clearButton1_Click(sender As Object, e As EventArgs) Handles clearButton1.Click
        ListBox1.Items.Clear()
        copyButton1.Enabled = False
        lblCnt1.Text = "Count : " & ListBox1.Items.Count
    End Sub

    Private Sub clearButton2_Click(sender As Object, e As EventArgs) Handles clearButton2.Click
        ListBox2.Items.Clear()
        copyButton2.Enabled = False

        lblCnt1.Text = "Count : " & ListBox1.Items.Count
        lblCnt2.Text = "Count : " & ListBox2.Items.Count
    End Sub

    Private Sub deleteButton2_Click(sender As Object, e As EventArgs)
        Dim en As IEnumerator = ListBox1.SelectedIndices.GetEnumerator()
        Dim DeletedItems2 As Integer
        DeletedItems2 = ListBox2.SelectedItems.Count

        If ListBox2.SelectedItems.Count = 0 Then
            copyButton1.Enabled = False
            Exit Sub
        End If

        Do While en.MoveNext()
            ListBox1.Items.RemoveAt(en.Current)
            en = ListBox2.SelectedIndices.GetEnumerator()
        Loop

        lblCnt2.Text = "Count : " & ListBox2.Items.Count
    End Sub

    Private Sub deleteButton1_Click(sender As Object, e As EventArgs) Handles deleteButton1.Click
        Dim en As IEnumerator = ListBox1.SelectedIndices.GetEnumerator()
        Dim DeletedItems1 As Integer

        If ListBox1.SelectedItems.Count = 0 Then
            copyButton1.Enabled = False
            Exit Sub
        End If

        DeletedItems1 = ListBox1.SelectedItems.Count

        Do While en.MoveNext()
            ListBox1.Items.RemoveAt(en.Current)
            en = ListBox1.SelectedIndices.GetEnumerator()
        Loop

        lblCnt1.Text = "Count : " & ListBox1.Items.Count
    End Sub

    Private Sub ListBox1_DragDrop(sender As Object, e As DragEventArgs) Handles ListBox1.DragDrop

        Dim patternFindNumbers As String = "[+-]?(\d+(,\d{3})*|(?=\.\d))((\.\d+([eE][+-]\d+)?)|)"
        Dim patternHtmlParse As String = "(?<=>.*)[+-]?" & patternFindNumbers & "(?=[^>]*<)"
        Dim foundNumbers As MatchCollection

        If e.Data.GetDataPresent("HTML Format") Then
            Dim dataHtmlFormat As String = e.Data.GetData("HTML Format").ToString()
            If Regex.Match(dataHtmlFormat, "(?<=<html).*?(?=>)", RegexOptions.Singleline).Value.Contains("urn:schemas-microsoft-com:office:word") Then
                dataHtmlFormat = dataHtmlFormat.Remove(0, dataHtmlFormat.IndexOf("<body"))
                Dim matchesP, matchesSpan As MatchCollection
                matchesP = Regex.Matches(dataHtmlFormat, "<p.*?</p>", RegexOptions.Singleline) ' each line

                If matchesP.Count > 0 Then
                    dataHtmlFormat = String.Empty
                    For Each matchP As Match In matchesP
                        matchesSpan = Regex.Matches(matchP.Value, "(?<=>)[^<>]+(?=<)")
                        For Each matchSpan As Match In matchesSpan
                            dataHtmlFormat &= matchSpan.Value
                        Next
                        dataHtmlFormat &= vbCrLf
                    Next
                Else
                    matchesSpan = Regex.Matches(dataHtmlFormat, "(?<=>)[^<>]+(?=<)")
                    dataHtmlFormat = String.Empty
                    For Each matchSpan As Match In matchesSpan
                        dataHtmlFormat &= matchSpan.Value
                    Next
                    dataHtmlFormat &= vbCrLf
                End If
                foundNumbers = Regex.Matches(dataHtmlFormat, patternFindNumbers)
            Else
                foundNumbers = Regex.Matches(e.Data.GetData("Text").ToString(), patternFindNumbers)
            End If
        Else
            foundNumbers = Regex.Matches(e.Data.GetData("Text").ToString(), patternFindNumbers)
        End If

        Dim listBoxStartCount As Integer = ListBox1.Items.Count

        For Each item As Match In foundNumbers
            ListBox1.Items.Add(CDbl(item.Value))
            ListBox1.TopIndex = ListBox1.Items.Count - 1
        Next

        lblCnt1.Text = "Count : " & ListBox1.Items.Count
    End Sub

    Private Sub ListBox1_DragEnter(sender As Object, e As DragEventArgs) Handles ListBox1.DragEnter
        'this list contains all of the available formats of data you can retrieve from the dragging object
        Dim availableFormats As String() = e.Data.GetFormats()

        'check to see if a desired format is contained in the drag object
        If (e.Data.GetDataPresent("Text")) Then
            'if it is then set the mode to "Copy", which will leave the data in the excel sheet
            e.Effect = DragDropEffects.Copy
        Else
            'if not, then prevent the drop, changing the cursor to the "not allowed" version
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pasteButton_Click(sender As Object, e As EventArgs) Handles pasteButton.Click
        Dim patternFindNumbers As String = "[+-]?(\d+(,\d{3})*|(?=\.\d))((\.\d+([eE][+-]\d+)?)|)"
        Dim foundNumbers As MatchCollection
        foundNumbers = Regex.Matches(My.Computer.Clipboard.GetText().ToString(), patternFindNumbers)


        Dim listBoxStartCount As Integer = ListBox1.Items.Count

        For Each item As Match In foundNumbers
            ListBox1.Items.Add(Val(item.Value))
            ListBox1.TopIndex = ListBox1.Items.Count - 1
        Next

        lblCnt1.Text = "Count : " & ListBox1.Items.Count
    End Sub

    Private Sub selectAll1_Click(sender As Object, e As EventArgs) Handles selectAll1.Click
        Dim i As Integer
        For i = 0 To ListBox1.Items.Count - 1
            If Not ListBox1.SelectedIndices.Contains(i) Then
                ListBox1.SelectedIndices.Add(i)
            End If
        Next

        ListBox1.Select()
    End Sub

    Private Sub selectAll2_Click(sender As Object, e As EventArgs) Handles selectAll2.Click
        Dim i As Integer
        For i = 0 To ListBox2.Items.Count - 1
            If Not ListBox2.SelectedIndices.Contains(i) Then
                ListBox2.SelectedIndices.Add(i)
            End If
        Next

        ListBox2.Select()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedItems.Count = 0 Then
            copyButton2.Enabled = False
        Else
            copyButton2.Enabled = True
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItems.Count = 0 Then
            copyButton1.Enabled = False
        Else
            copyButton1.Enabled = True
        End If
    End Sub

    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyData = Keys.Delete Then
            deleteButton1.PerformClick()
        End If

        If (e.Modifiers And Keys.Control) = Keys.Control AndAlso e.KeyCode = Keys.Delete Then
            clearButton1.PerformClick()
        End If

        If (e.Modifiers And Keys.Control) = Keys.Control AndAlso e.KeyCode = Keys.C Then
            copyButton1.PerformClick()
        End If

        If (e.Modifiers And Keys.Control) = Keys.Control AndAlso e.KeyCode = Keys.V Then
            pasteButton.PerformClick()
        End If

        If (e.Modifiers And Keys.Control) = Keys.Control AndAlso e.KeyCode = Keys.A Then
            selectAll1.PerformClick()
        End If

        If e.KeyData = Keys.Escape Then
            sClrButton1.PerformClick()
        End If

        lblCnt1.Text = "Count : " & ListBox1.Items.Count
    End Sub


    Private Sub ListBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox2.KeyDown

        If (e.Modifiers And Keys.Control) = Keys.Control AndAlso e.KeyCode = Keys.C Then
            e.Handled = True
            copyButton2.PerformClick()
        End If

        If (e.Modifiers And Keys.Control) = Keys.Control AndAlso e.KeyCode = Keys.A Then
            e.Handled = True
            selectAll2.PerformClick()
        End If

        If (e.Modifiers And Keys.Control) = Keys.Control AndAlso e.KeyCode = Keys.Delete Then
            clearButton2.PerformClick()
        End If

        If e.KeyData = Keys.Escape Then
            sClrButton2.PerformClick()
        End If

        lblCnt2.Text = "Count : " & ListBox2.Items.Count
    End Sub

    Private Sub sClrButton1_Click(sender As Object, e As EventArgs) Handles sClrButton1.Click
        Dim i As Integer
        For i = 0 To ListBox1.Items.Count - 1
            If ListBox1.SelectedIndices.Contains(i) Then
                ListBox1.SelectedIndices.Remove(i)
            End If
        Next

        ListBox1.Select()
        lblCnt1.Text = "Count : " & ListBox1.Items.Count
    End Sub

    Private Sub sClrButton2_Click(sender As Object, e As EventArgs) Handles sClrButton2.Click
        Dim i As Integer
        For i = 0 To ListBox2.Items.Count - 1
            If ListBox2.SelectedIndices.Contains(i) Then
                ListBox2.SelectedIndices.Remove(i)
            End If
        Next

        ListBox1.Select()
        lblCnt2.Text = "Count : " & ListBox2.Items.Count
    End Sub

    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dpivalue = dpicalc(Me, 100)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        addButton.Enabled = CBool(TextBox1.TextLength) AndAlso CBool(IsNumeric(TextBox1.Text))
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
