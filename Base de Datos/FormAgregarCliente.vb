Public Class FormAgregarCliente
    Private cliente As New Cliente() ' Instancia de la clase Cliente

    Private Sub BtnAgregarCliente_Click(sender As Object, e As EventArgs) Handles BtnAgregarCliente.Click
        ' Validar los datos ingresados

        ' Validaciones para la cédula
        If String.IsNullOrWhiteSpace(txtCedula.Text) OrElse txtCedula.Text.Length > 15 Then
            MessageBox.Show("La cédula no puede estar vacía y debe tener un máximo de 15 caracteres.")
            Return
        End If

        ' Validaciones para el nombre
        If String.IsNullOrWhiteSpace(txtNombre.Text) OrElse txtNombre.Text.Length > 30 Then
            MessageBox.Show("El nombre no puede estar vacío y debe tener un máximo de 30 caracteres.")
            Return
        End If

        ' Validaciones para el apellido
        If String.IsNullOrWhiteSpace(txtApellido.Text) OrElse txtApellido.Text.Length > 30 Then
            MessageBox.Show("El apellido no puede estar vacío y debe tener un máximo de 30 caracteres.")
            Return
        End If

        ' Validaciones para la dirección
        If String.IsNullOrWhiteSpace(txtDireccion.Text) OrElse txtDireccion.Text.Length > 50 Then
            MessageBox.Show("La dirección no puede estar vacía y debe tener un máximo de 50 caracteres.")
            Return
        End If

        ' Validaciones para el celular
        If String.IsNullOrWhiteSpace(txtCelular.Text) OrElse txtCelular.Text.Length <> 9 Then
            MessageBox.Show("El celular debe tener 9 dígitos y no puede estar vacío.")
            Return
        End If

        ' Validaciones para el correo
        If String.IsNullOrWhiteSpace(txtCorreo.Text) OrElse txtCorreo.Text.Length > 50 OrElse Not txtCorreo.Text.Contains("@") Then
            MessageBox.Show("El correo no puede estar vacío, debe tener un máximo de 50 caracteres y debe ser un correo válido.")
            Return
        End If

        ' Validación del sexo
        Dim sexo As Char
        If rbMasculino.Checked Then
            sexo = "M" ' Masculino
        ElseIf rbFemenino.Checked Then
            sexo = "F" ' Femenino
        Else
            MessageBox.Show("Debes seleccionar el sexo (Masculino/Femenino).")
            Return
        End If

        ' Validación del estatus
        Dim estatus As Char
        If rbActivo.Checked Then
            estatus = "A" ' Activo
        ElseIf rbInactivo.Checked Then
            estatus = "I" ' Inactivo
        Else
            MessageBox.Show("Debes seleccionar el estatus (Activo/Inactivo).")
            Return
        End If

        ' Asignar valores a la instancia de cliente
        cliente.Cedula = txtCedula.Text
        cliente.Nombre = txtNombre.Text
        cliente.Apellido = txtApellido.Text
        cliente.Direccion = txtDireccion.Text
        cliente.Celular = txtCelular.Text
        cliente.Correo = txtCorreo.Text
        cliente.Sexo = sexo
        cliente.Estatus = estatus

        ' Lógica para agregar el cliente
        Try
            cliente.AgregarCliente() ' Asegúrate de que este método esté implementado en tu clase cliente
            MessageBox.Show("Cliente agregado exitosamente.")

            ' Opcional: Limpiar los campos después de agregar
            LimpiarCampos()

            ' Regresar al formulario principal
            'CType(Me.Parent, VistaCliente).MostrarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Error al agregar el cliente: " & ex.Message)
        End Try


    End Sub

    Private Sub LimpiarCampos()
        txtCedula.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDireccion.Clear()
        txtCelular.Clear()
        txtCorreo.Clear()
        rbMasculino.Checked = False
        rbFemenino.Checked = False
        rbActivo.Checked = False
        rbInactivo.Checked = False
    End Sub

End Class