Module CollisionModule

    Public Function Collision(ByVal Obj1 As Object, ByVal Obj2 As Object,
    Optional ByVal HorizTolerance1 As Integer = 0, Optional ByVal VertTolerance1 As Integer = 0,
    Optional ByVal HorizTolerance2 As Integer = 0, Optional ByVal VertTolerance2 As Integer = 0) As Boolean
        Return (Obj1.Top + Obj1.Height - VertTolerance1 >= Obj2.Top + VertTolerance2) _
        And (Obj2.Top + Obj2.Height - VertTolerance2 >= Obj1.Top + VertTolerance1) _
        And (Obj1.Left + Obj1.Width - HorizTolerance1 >= Obj2.Left + HorizTolerance2) _
        And (Obj2.Left + Obj2.Width - HorizTolerance2 >= Obj1.Left + HorizTolerance1) _
        And Obj1.Visible And Obj2.Visible
    End Function

    Public Function Collision(ByVal Rect As Rectangle, ByVal Obj As Object,
    Optional ByVal HorizToleranceRect As Integer = 0, Optional ByVal VertToleranceRect As Integer = 0,
    Optional ByVal HorizToleranceObj As Integer = 0, Optional ByVal VertToleranceObj As Integer = 0) As Boolean
        Return (Rect.Top + Rect.Height - VertToleranceRect >= Obj.Top + VertToleranceObj) _
        And (Obj.Top + Obj.Height - VertToleranceObj >= Rect.Top + VertToleranceRect) _
        And (Rect.Left + Rect.Width - HorizToleranceRect >= Obj.Left + HorizToleranceObj) _
        And (Obj.Left + Obj.Width - HorizToleranceObj >= Rect.Left + HorizToleranceRect) _
        And Obj.Visible
    End Function

    Public Function Collision(ByVal Rect1 As Rectangle, ByVal Rect2 As Rectangle,
    Optional ByVal HorizTolerance1 As Integer = 0, Optional ByVal VertTolerance1 As Integer = 0,
    Optional ByVal HorizTolerance2 As Integer = 0, Optional ByVal VertTolerance2 As Integer = 0) As Boolean
        Return (Rect1.Top + Rect1.Height - VertTolerance1 >= Rect2.Top + VertTolerance2) _
        And (Rect2.Top + Rect2.Height - VertTolerance2 >= Rect1.Top + VertTolerance1) _
        And (Rect1.Left + Rect1.Width - HorizTolerance1 >= Rect2.Left + HorizTolerance2) _
        And (Rect2.Left + Rect2.Width - HorizTolerance2 >= Rect1.Left + HorizTolerance1)
    End Function

    Public Function Collision(ByVal Loc As Point, ByVal Obj As Object,
    Optional ByVal HorizTolerance As Integer = 0, Optional ByVal VertTolerance As Integer = 0) As Boolean
        Return Loc.X >= Obj.Left + HorizTolerance And Loc.X <= Obj.Left + Obj.Width - HorizTolerance _
        And Loc.Y >= Obj.Top + VertTolerance And Loc.Y <= Obj.Top + Obj.Height - VertTolerance _
        And Obj.Visible
    End Function

    Public Function Collision(ByVal Loc As Point, ByVal Rect As Rectangle,
    Optional ByVal HorizTolerance As Integer = 0, Optional ByVal VertTolerance As Integer = 0) As Boolean
        Return Loc.X >= Rect.Left + HorizTolerance And Loc.X <= Rect.Left + Rect.Width - HorizTolerance _
        And Loc.Y >= Rect.Top + VertTolerance And Loc.Y <= Rect.Top + Rect.Height - VertTolerance
    End Function

End Module
