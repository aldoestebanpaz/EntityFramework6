Imports System
Imports System.Data.Entity
Imports System.Linq

Public Class $namespace$
    Inherits DbContext

	$ctorcomment$
	Public Sub New()
		MyBase.New("name=$safeitemname$")

		$dbsetcomment$

       ' Public Property MyEntities() As DbSet(Of MyEntity)

    End Sub

End Class

' Public Class MyEntity
'     Public Property Id() As Int
'	Public Property Name() As String
' End Class