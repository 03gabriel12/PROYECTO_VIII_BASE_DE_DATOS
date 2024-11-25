<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label9 = New Label()
        Panel7 = New Panel()
        rbInactivo = New CheckBox()
        rbActivo = New CheckBox()
        Label7 = New Label()
        Panel8 = New Panel()
        txtDireccion = New TextBox()
        Label8 = New Label()
        Panel5 = New Panel()
        txtCorreo = New TextBox()
        Label5 = New Label()
        Panel4 = New Panel()
        txtCelular = New TextBox()
        Label4 = New Label()
        Panel3 = New Panel()
        txtNombre = New TextBox()
        Label3 = New Label()
        Panel2 = New Panel()
        txtApellido = New TextBox()
        Label2 = New Label()
        Panel1 = New Panel()
        txtCedula = New TextBox()
        Label1 = New Label()
        BtnAgregarCliente = New Button()
        Panel6 = New Panel()
        rbMasculino = New CheckBox()
        rbFemenino = New CheckBox()
        Label6 = New Label()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(277, 27)
        Label9.Name = "Label9"
        Label9.Size = New Size(215, 38)
        Label9.TabIndex = 19
        Label9.Text = "Ingresar Cliente"
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(rbInactivo)
        Panel7.Controls.Add(rbActivo)
        Panel7.Controls.Add(Label7)
        Panel7.Location = New Point(418, 299)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(345, 47)
        Panel7.TabIndex = 18
        ' 
        ' rbInactivo
        ' 
        rbInactivo.AutoSize = True
        rbInactivo.Location = New Point(209, 14)
        rbInactivo.Name = "rbInactivo"
        rbInactivo.Size = New Size(83, 24)
        rbInactivo.TabIndex = 2
        rbInactivo.Text = "Inactivo"
        rbInactivo.UseVisualStyleBackColor = True
        ' 
        ' rbActivo
        ' 
        rbActivo.AutoSize = True
        rbActivo.Location = New Point(91, 14)
        rbActivo.Name = "rbActivo"
        rbActivo.Size = New Size(73, 24)
        rbActivo.TabIndex = 1
        rbActivo.Text = "Activo"
        rbActivo.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(14, 14)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 20)
        Label7.TabIndex = 0
        Label7.Text = "Estatus"
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(txtDireccion)
        Panel8.Controls.Add(Label8)
        Panel8.Location = New Point(38, 299)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(345, 47)
        Panel8.TabIndex = 17
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(146, 11)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(182, 27)
        txtDireccion.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(15, 14)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 20)
        Label8.TabIndex = 0
        Label8.Text = "Direccion"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(txtCorreo)
        Panel5.Controls.Add(Label5)
        Panel5.Location = New Point(418, 169)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(345, 47)
        Panel5.TabIndex = 15
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(146, 11)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(182, 27)
        txtCorreo.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 14)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 20)
        Label5.TabIndex = 0
        Label5.Text = "Correo"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(txtCelular)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(418, 87)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(345, 47)
        Panel4.TabIndex = 14
        ' 
        ' txtCelular
        ' 
        txtCelular.Location = New Point(146, 11)
        txtCelular.Name = "txtCelular"
        txtCelular.Size = New Size(182, 27)
        txtCelular.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 20)
        Label4.TabIndex = 0
        Label4.Text = "Celular"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(txtNombre)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(38, 169)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(345, 47)
        Panel3.TabIndex = 13
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(146, 11)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(182, 27)
        txtNombre.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 0
        Label3.Text = "Nombre"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(txtApellido)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(38, 237)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(345, 47)
        Panel2.TabIndex = 12
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(146, 11)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(182, 27)
        txtApellido.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 20)
        Label2.TabIndex = 0
        Label2.Text = "Apellido"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtCedula)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(38, 87)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(345, 47)
        Panel1.TabIndex = 11
        ' 
        ' txtCedula
        ' 
        txtCedula.Location = New Point(146, 11)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(182, 27)
        txtCedula.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 0
        Label1.Text = "Cedula"
        ' 
        ' BtnAgregarCliente
        ' 
        BtnAgregarCliente.Location = New Point(309, 397)
        BtnAgregarCliente.Name = "BtnAgregarCliente"
        BtnAgregarCliente.Size = New Size(177, 29)
        BtnAgregarCliente.TabIndex = 10
        BtnAgregarCliente.Text = "Agregar Cliente"
        BtnAgregarCliente.UseVisualStyleBackColor = True
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(rbMasculino)
        Panel6.Controls.Add(rbFemenino)
        Panel6.Controls.Add(Label6)
        Panel6.Location = New Point(418, 237)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(345, 47)
        Panel6.TabIndex = 20
        ' 
        ' rbMasculino
        ' 
        rbMasculino.AutoSize = True
        rbMasculino.Location = New Point(209, 14)
        rbMasculino.Name = "rbMasculino"
        rbMasculino.Size = New Size(98, 24)
        rbMasculino.TabIndex = 2
        rbMasculino.Text = "Masculino"
        rbMasculino.UseVisualStyleBackColor = True
        ' 
        ' rbFemenino
        ' 
        rbFemenino.AutoSize = True
        rbFemenino.Location = New Point(91, 14)
        rbFemenino.Name = "rbFemenino"
        rbFemenino.Size = New Size(96, 24)
        rbFemenino.TabIndex = 1
        rbFemenino.Text = "Femenino"
        rbFemenino.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 14)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 20)
        Label6.TabIndex = 0
        Label6.Text = "Sexo"
        ' 
        ' FormAgregarCliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel6)
        Controls.Add(Label9)
        Controls.Add(Panel7)
        Controls.Add(Panel8)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(BtnAgregarCliente)
        Name = "FormAgregarCliente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormAgregarCliente"
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents rbInactivo As CheckBox
    Friend WithEvents rbActivo As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAgregarCliente As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents rbMasculino As CheckBox
    Friend WithEvents rbFemenino As CheckBox
    Friend WithEvents Label6 As Label
End Class
