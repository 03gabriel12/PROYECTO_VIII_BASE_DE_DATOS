Public Class Producto
    ' Propiedad que representa el código de barras del producto
    Public Property CodigoBarra As String

    ' Propiedad que representa la descripción del producto
    Public Property Descripcion As String

    ' Propiedad que representa el costo del producto
    Public Property Costo As Decimal

    ' Propiedad que representa el precio del producto
    Public Property Precio As Decimal

    ' Propiedad que representa el ITBMS (Impuesto sobre la Transferencia de Bienes Muebles y Servicios)
    Public Property Itbms As Integer

    ' Propiedad que representa la cantidad de existencia del producto
    Public Property Existencia As Integer

    ' Propiedad que representa el punto de reorden del producto
    Public Property PuntoDeReorden As Integer

    ' Propiedad que representa el estatus del producto (por ejemplo, activo o inactivo)
    Public Property Estatus As Char

    ' Instancia de la clase BD para realizar operaciones en la base de datos
    Private db As New BD()

    ' Método para buscar un producto por código de barra
    Public Function BuscarProducto() As DataTable
        ' Crear un diccionario de parámetros para el procedimiento almacenado
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@CodigoBarra", CodigoBarra} ' Agregar el código de barra como parámetro
        }
        ' Ejecutar el procedimiento almacenado y devolver el resultado
        Return db.ExecuteProcedureWithResult("BuscarProducto", parameters)
    End Function

    ' Método para agregar un producto a la base de datos
    Public Sub AgregarProducto()
        ' Crear un diccionario de parámetros para el procedimiento almacenado
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@CodigoBarra", CodigoBarra},
            {"@Descripcion", Descripcion},
            {"@Costo", Costo},
            {"@Precio", Precio},
            {"@Itbms", Itbms},
            {"@Existencia", Existencia},
            {"@PuntoReorden", PuntoDeReorden},
            {"@Estatus", Estatus}
        }
        ' Ejecutar el procedimiento almacenado para agregar el producto
        db.ExecuteProcedureWithParams("AgregarProducto", parameters)
    End Sub

    ' Método para modificar un producto existente en la base de datos
    Public Sub ModificarProducto()
        ' Crear un diccionario de parámetros para el procedimiento almacenado
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@CodigoBarra", CodigoBarra},
            {"@Descripcion", Descripcion},
            {"@Costo", Costo},
            {"@Precio", Precio},
            {"@Itbms", Itbms},
            {"@Existencia", Existencia},
            {"@PuntoReorden", PuntoDeReorden},
            {"@Estatus", Estatus}
        }
        ' Ejecutar el procedimiento almacenado para modificar el producto
        db.ExecuteProcedureWithParams("ModificarProducto", parameters)
    End Sub

    ' Método para eliminar un producto de la base de datos
    Public Sub EliminarProducto()
        ' Crear un diccionario de parámetros para el procedimiento almacenado
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@CodigoBarra", CodigoBarra} ' Agregar el código de barra como parámetro
        }
        ' Ejecutar el procedimiento almacenado para eliminar el producto
        db.ExecuteProcedureWithParams("EliminarProducto", parameters)
    End Sub

    ' Método para listar productos, permitiendo ordenar por un criterio específico
    Public Function ListarProductos(ordenarPor As String) As DataTable
        ' Crear un diccionario de parámetros para el procedimiento almacenado
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@OrdenarPor", ordenarPor} ' Agregar el criterio de ordenamiento como parámetro
        }
        ' Ejecutar el procedimiento almacenado y devolver el resultado
        Return db.ExecuteProcedureWithResult("ListarProductos", parameters)
    End Function
End Class