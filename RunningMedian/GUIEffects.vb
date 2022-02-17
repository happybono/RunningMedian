Imports System.Runtime.InteropServices
Imports System.Runtime.CompilerServices

Module GUIEffects
#Region "Aero 그림자 효과 (Vista이상)"
    Structure MARGINS
        Public Left, Right, Top, Bottom As Integer
    End Structure

    <DllImport("dwmapi.dll", PreserveSig:=True)>
    Private Function DwmSetWindowAttribute(hwnd As IntPtr, attr As Integer, ByRef attrValue As Integer, attrSize As Integer) As Integer
    End Function

    <DllImport("dwmapi.dll")>
    Private Function DwmExtendFrameIntoClientArea(hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
    End Function

    Public Function CreateDropShadow(form As Form) As Boolean
        Try
            Dim val As Integer = 2
            Dim ret1 As Integer = DwmSetWindowAttribute(form.Handle, 2, val, 4)

            If ret1 = 0 Then
                Dim m As MARGINS = New MARGINS() With {
                        .Left = 0,
                        .Right = 0,
                        .Top = 1,
                        .Bottom = 0
                    }

                Dim ret2 As Integer = DwmExtendFrameIntoClientArea(form.Handle, m)
                Return ret2 = 0
            Else
                Return False
            End If
        Catch ex As Exception
            'dwmapi.dll 없음
            Return False
        End Try
    End Function

#End Region

#Region "컨트롤 그리기 일시중지"
    <DllImport("user32.dll")>
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Boolean, ByVal lParam As IntPtr) As Integer
    End Function

    Private Const WM_SETREDRAW As Integer = 11

    <Extension()>
    Public Sub ResumeDrawing(ByVal Target As Control, ByVal Redraw As Boolean)
        SendMessage(Target.Handle, WM_SETREDRAW, True, 0)
        If Redraw Then
            Target.Refresh()
        End If
    End Sub

    <Extension()>
    Public Sub SuspendDrawing(ByVal Target As Control)
        SendMessage(Target.Handle, WM_SETREDRAW, False, 0)
    End Sub

    <Extension()>
    Public Sub ResumeDrawing(ByVal Target As Control)
        ResumeDrawing(Target, True)
    End Sub
#End Region

#Region "DPI 계산 (고해상도 디스플레이용)"
    Public Function dpicalc(targetform As Form, size As Integer)
        Dim g As Graphics = targetform.CreateGraphics
        Dim dpi = g.DpiX.ToString()

        Dim current = dpi / 96
        Dim expand = current * size
        ' MainForm.zoom(dpi / 96 * 100 * 2)
        Return expand
    End Function
#End Region

#Region "폰트 모듈"
    Public Sub ChangeToNativeFont(targetForm As Form)
        ChangeFontName(targetForm, New Font("맑은 고딕", 10))
    End Sub

    Public Sub ChangeFontName(ByVal aForm As Form, ByVal aFont As Font)

        For Each frm As Form In My.Application.OpenForms
            If frm.HasChildren = True Then
                For Each ctrl As Control In frm.Controls
                    ChangeFontName(ctrl, aFont)
                Next
            End If
        Next

        If aForm.IsMdiContainer = True Then
            For Each frm As Form In aForm.MdiChildren
                If frm.HasChildren = True Then
                    For Each ctrl As Control In frm.Controls
                        ChangeFontName(ctrl, aFont)
                    Next
                End If
            Next
        End If

    End Sub

    Public Sub ChangeFontName(ByVal aControl As Control, ByVal aFont As Font)

        If aControl.HasChildren = True Then
            For Each ctrl As Control In aControl.Controls
                ctrl.Font = New Font(aFont.Name, ctrl.Font.Size, ctrl.Font.Style, ctrl.Font.Unit, ctrl.Font.GdiCharSet, ctrl.Font.GdiVerticalFont)
                ChangeFontName(ctrl, aFont)
            Next
        End If

    End Sub

    Public Function GetStringSize(aControl As Control) As SizeF

        Return aControl.CreateGraphics.MeasureString(aControl.Text, aControl.Font)

    End Function
#End Region

#Region "멀티 모니터 관리"
    Public Function IsOnScreen(ByVal form As Form) As Boolean
        Dim screens() As Screen = Screen.AllScreens

        For Each scrn As Screen In screens
            Dim formRectangle As Rectangle = New Rectangle(form.Left, form.Top, form.Width, form.Height)

            If scrn.WorkingArea.Contains(formRectangle) Then
                Return True
            End If
        Next

        Return False
    End Function
#End Region
End Module


