Public Class Cliente
    Public Property Cedula As String
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Direccion As String
    Public Property Celular As String
    Public Property Correo As String
    Public Property Sexo As Char
    Public Property Estatus As Char

    Private db As New BD()

    ' Método para buscar un cliente por cédula
    Public Function BuscarCliente() As DataTable
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@Cedula", Cedula}
        }
        Return db.ExecuteProcedureWithResult("BuscarCliente", parameters)
    End Function

    ' Método para agregar un cliente
    Public Sub AgregarCliente()
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@Cedula", Cedula},
            {"@Nombre", Nombre},
            {"@Apellido", Apellido},
            {"@Direccion", Direccion},
            {"@Celular", Celular},
            {"@Correo", Correo},
            {"@Sexo", Sexo},
            {"@Estatus", Estatus}
        }
        db.ExecuteProcedureWithParams("AgregarCliente", parameters)
    End Sub

    ' Método para modificar un cliente
    Public Sub ModificarCliente()
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@Cedula", Cedula},
            {"@Nombre", Nombre},
            {"@Apellido", Apellido},
            {"@Direccion", Direccion},
            {"@Celular", Celular},
            {"@Correo", Correo},
            {"@Sexo", Sexo},
            {"@Estatus", Estatus}
        }
        db.ExecuteProcedureWithParams("ModificarCliente", parameters)
    End Sub

    ' Método para eliminar un cliente
    Public Sub EliminarCliente()
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@Cedula", Cedula}
        }
        db.ExecuteProcedureWithParams("EliminarCliente", parameters)
    End Sub

    ' Método para listar clientes
    Public Function ListarClientes(ordenarPor As String) As DataTable
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@OrdenarPor", ordenarPor}
        }
        Return db.ExecuteProcedureWithResult("ListarClientes", parameters)
    End Function
End Class

