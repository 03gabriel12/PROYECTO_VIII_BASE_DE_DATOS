Imports System.Data.SqlClient ' Importa el espacio de nombres necesario para trabajar con SQL Server

Public Class BD
    '   DataGridViewProducto
    ' Cadena de conexión a la base de datos
    Private connectionString As String = "Server=GABRIELRK12\SQLEXPRESS01;Database=Empresa;Integrated Security=True;"

    ' Método para obtener la conexión a la base de datos
    Public Function GetConnection() As SqlConnection
        ' Retorna una nueva instancia de SqlConnection utilizando la cadena de conexión
        Return New SqlConnection(connectionString)
    End Function

    ' Método para ejecutar procedimientos almacenados sin parámetros
    Public Sub ExecuteProcedure(procedureName As String)
        ' Se utiliza el bloque Using para asegurar que la conexión se cierre automáticamente
        Using conn As SqlConnection = GetConnection()
            conn.Open() ' Abre la conexión a la base de datos
            Using cmd As New SqlCommand(procedureName, conn)
                cmd.CommandType = CommandType.StoredProcedure ' Especifica que se está ejecutando un procedimiento almacenado
                cmd.ExecuteNonQuery() ' Ejecuta el procedimiento almacenado sin esperar resultados
            End Using
        End Using
    End Sub

    ' Método para ejecutar procedimientos almacenados con parámetros
    Public Sub ExecuteProcedureWithParams(procedureName As String, parameters As Dictionary(Of String, Object))
        Using conn As SqlConnection = GetConnection()
            conn.Open() ' Abre la conexión a la base de datos
            Using cmd As New SqlCommand(procedureName, conn)
                cmd.CommandType = CommandType.StoredProcedure ' Especifica que se está ejecutando un procedimiento almacenado
                ' Agrega cada parámetro al comando
                For Each param In parameters
                    cmd.Parameters.AddWithValue(param.Key, param.Value) ' Agrega el parámetro al comando
                Next
                cmd.ExecuteNonQuery() ' Ejecuta el procedimiento almacenado
            End Using
        End Using
    End Sub

    ' Método para obtener resultados de procedimientos con parámetros
    Public Function ExecuteProcedureWithResult(procedureName As String, parameters As Dictionary(Of String, Object)) As DataTable
        Dim result As New DataTable() ' Crea un nuevo DataTable para almacenar los resultados
        Using conn As SqlConnection = GetConnection()
            conn.Open() ' Abre la conexión a la base de datos
            Using cmd As New SqlCommand(procedureName, conn)
                cmd.CommandType = CommandType.StoredProcedure ' Especifica que se está ejecutando un procedimiento almacenado
                ' Agrega cada parámetro al comando
                For Each param In parameters
                    cmd.Parameters.AddWithValue(param.Key, param.Value) ' Agrega el parámetro al comando
                Next
                ' Ejecuta el comando y carga los resultados en el DataTable
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    result.Load(reader) ' Carga los resultados del lector en el DataTable
                End Using
            End Using
        End Using
        Return result ' Retorna el DataTable con los resultados
    End Function
End Class

