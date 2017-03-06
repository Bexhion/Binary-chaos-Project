Public Class ItemCLBColors

    'Border style
    Public Shared Border As SolidBrush = New SolidBrush(Color.FromArgb(90, 90, 90))

    'All priority state colors
    Public Shared HighPriority As SolidBrush = New SolidBrush(Color.FromArgb(142, 0, 0))
    Public Shared MediumPriority As SolidBrush = New SolidBrush(Color.FromArgb(196, 94, 18))
    Public Shared LowPriority As SolidBrush = New SolidBrush(Color.FromArgb(60, 92, 38))

    'Used for point counting (squares)
    Public Shared SpecialAdditions As SolidBrush = New SolidBrush(Color.FromArgb(0, 112, 192))
    Public Shared ColorFade As Color() = New Color() {Color.FromArgb(255, 0, 0, 0), Color.FromArgb(255, 90, 90, 90), Color.FromArgb(0, 90, 90, 90)}

    'Description
    Public Shared LightDescriptionBox As SolidBrush = New SolidBrush(Color.FromArgb(191, 191, 191))
    Public Shared DarkDescriptionBox As SolidBrush = New SolidBrush(Color.FromArgb(89, 89, 89))

    'Create a new Dictionary with keys of string and values of solidbrush
    Public Shared shapeBrushes As Dictionary(Of String, SolidBrush)
    Public Shared overlayBrushes As Dictionary(Of String, SolidBrush)
    Public Shared textColors As Dictionary(Of String, Color)

    Public Shared Sub CreateBrushes(isDarkMode As Boolean)
        Dim commonColor As New SolidBrush(Color.FromArgb(38, 38, 38))
        shapeBrushes = New Dictionary(Of String, SolidBrush)
        If isDarkMode Then
            shapeBrushes.Add("Background", commonColor) 'Background color
            shapeBrushes.Add("DateSection", commonColor) 'Background color for date section
            shapeBrushes.Add("PointSection", commonColor) 'Background color for point counter section
        Else
            shapeBrushes.Add("Background", New SolidBrush(Color.FromArgb(245, 245, 245))) 'Background color
            shapeBrushes.Add("DateSection", New SolidBrush(Color.FromArgb(245, 245, 245))) 'Background color for date section
            shapeBrushes.Add("PointSection", New SolidBrush(Color.FromArgb(0, 112, 192))) 'Background color for point counter section
            Border.Color = Color.FromArgb(190, 190, 190)
        End If
    End Sub

    Public Shared Sub CreateOverlayBrushes(isDarkMode As Boolean)
        overlayBrushes = New Dictionary(Of String, SolidBrush)
        If isDarkMode Then
            overlayBrushes.Add("Clicked", New SolidBrush(Color.FromArgb(63, 63, 63)))
            overlayBrushes.Add("DateSection_Hover", New SolidBrush(Color.FromArgb(75, 63, 63, 63)))
            overlayBrushes.Add("MainText_Hover", New SolidBrush(Color.White))
        Else
            overlayBrushes.Add("Clicked", New SolidBrush(Color.FromArgb(209, 209, 209)))
            overlayBrushes.Add("DateSection_Hover", New SolidBrush(Color.FromArgb(75, 209, 209, 209)))
            overlayBrushes.Add("MainText_Hover", New SolidBrush(Color.Black))
        End If
    End Sub

    Public Shared Sub CreateColors(isDarkMode As Boolean)
        textColors = New Dictionary(Of String, Color)
        If isDarkMode Then
            textColors.Add("DateText", Color.FromArgb(0, 112, 192)) 'Text color for date section
            textColors.Add("TitleText", Color.White) 'Text color for main section (title)
            textColors.Add("DescriptionText", Color.FromArgb(166, 166, 166)) 'Text color for main section (title)
        Else
            textColors.Add("DateText", Color.FromArgb(0, 112, 192)) 'Text color for date section
            textColors.Add("TitleText", Border.Color) 'Text color for main section (title)
            textColors.Add("DescriptionText", Color.FromArgb(166, 166, 166)) 'Text color for main section (title)
        End If
    End Sub
End Class