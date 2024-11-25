Public Class FormAgregarProducto
    Private producto As New Producto() ' Instancia de la clase Producto

    Private Sub BtnAgregarProdcuto_Click(sender As Object, e As EventArgs) Handles BtnAgregarProdcuto.Click
        ' Validar los datos ingresados
        If String.IsNullOrWhiteSpace(txtCodigoBarra.Text) OrElse txtCodigoBarra.Text.Length <> 12 Then
            MessageBox.Show("El código de barra debe tener 12 dígitos y no puede estar vacío.")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtDescripcion.Text) OrElse txtDescripcion.Text.Length > 50 Then
            MessageBox.Show("La descripción no puede estar vacía y debe tener un máximo de 50 caracteres.")
            Return
        End If

        Dim costo As Decimal
        If Not Decimal.TryParse(txtCosto.Text, costo) OrElse costo < 0 Then
            MessageBox.Show("El costo debe ser un número decimal positivo.")
            Return
        End If

        Dim precio As Decimal
        If Not Decimal.TryParse(txtPrecio.Text, precio) OrElse precio < 0 Then
            MessageBox.Show("El precio debe ser un número decimal positivo.")
            Return
        End If

        Dim itbms As Integer
        If Not Integer.TryParse(txtITBMS.Text, itbms) OrElse itbms < 0 Then
            MessageBox.Show("El ITBMS debe ser un número entero positivo.")
            Return
        End If

        Dim existencia As Integer
        If Not Integer.TryParse(txtExistencia.Text, existencia) OrElse existencia < 0 Then
            MessageBox.Show("La existencia debe ser un número entero positivo.")
            Return
        End If

        Dim puntoDeReorden As Integer
        If Not Integer.TryParse(txtPuntoDeReorden.Text, puntoDeReorden) OrElse puntoDeReorden < 0 Then
            MessageBox.Show("El punto de reorden debe ser un número entero positivo.")
            Return
        End If

        Dim estatus As Char
        If rbActivo.Checked Then
            estatus = "A" ' Activo
        ElseIf rbInactivo.Checked Then
            estatus = "I" ' Inactivo
        Else
            MessageBox.Show("Debes seleccionar el estatus (Activo/Inactivo).")
            Return
        End If

        ' Aquí puedes llamar a tu método para agregar el producto a la base de datos
        Try
            ' Ejemplo de método para agregar el producto

            producto.CodigoBarra = txtCodigoBarra.Text
            producto.Descripcion = txtDescripcion.Text
            producto.Costo = costo
            producto.Precio = precio
            producto.Itbms = itbms
            producto.Existencia = existencia
            producto.PuntoDeReorden = 10
            producto.Estatus = estatus
            producto.AgregarProducto()
            MessageBox.Show("Producto agregado exitosamente.")

            ' Opcional: Limpiar los campos después de agregar
            LimpiarCampos()
            ' Regresar al formulario principal
            'CType(Me.Parent, VistaProducto).MostrarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Error al agregar el producto: " & ex.Message)
        End Try

    End Sub

    Private Sub LimpiarCampos()
        txtCodigoBarra.Clear()
        txtDescripcion.Clear()
        txtCosto.Clear()
        txtPrecio.Clear()
        txtITBMS.Clear()
        txtExistencia.Clear()
        txtPuntoDeReorden.Clear()
        rbActivo.Checked = False
        rbInactivo.Checked = False
    End Sub


End Class