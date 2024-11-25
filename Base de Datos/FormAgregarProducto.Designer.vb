<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarProducto
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
        BtnAgregarProdcuto = New Button()
        Panel1 = New Panel()
        txtCodigoBarra = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        txtCosto = New TextBox()
        Label2 = New Label()
        Panel3 = New Panel()
        txtDescripcion = New TextBox()
        Label3 = New Label()
        Panel4 = New Panel()
        txtITBMS = New TextBox()
        Label4 = New Label()
        Panel5 = New Panel()
        txtExistencia = New TextBox()
        Label5 = New Label()
        Panel6 = New Panel()
        txtPuntoDeReorden = New TextBox()
        Label6 = New Label()
        Panel7 = New Panel()
        rbInactivo = New CheckBox()
        rbActivo = New CheckBox()
        Label7 = New Label()
        Panel8 = New Panel()
        txtPrecio = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnAgregarProdcuto
        ' 
        BtnAgregarProdcuto.Location = New Point(325, 385)
        BtnAgregarProdcuto.Name = "BtnAgregarProdcuto"
        BtnAgregarProdcuto.Size = New Size(177, 29)
        BtnAgregarProdcuto.TabIndex = 0
        BtnAgregarProdcuto.Text = "Agregar Producto"
        BtnAgregarProdcuto.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtCodigoBarra)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(53, 78)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(345, 47)
        Panel1.TabIndex = 1
        ' 
        ' txtCodigoBarra
        ' 
        txtCodigoBarra.Location = New Point(146, 11)
        txtCodigoBarra.Name = "txtCodigoBarra"
        txtCodigoBarra.Size = New Size(182, 27)
        txtCodigoBarra.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 20)
        Label1.TabIndex = 0
        Label1.Text = "Codigo de Barra"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(txtCosto)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(53, 228)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(345, 47)
        Panel2.TabIndex = 2
        ' 
        ' txtCosto
        ' 
        txtCosto.Location = New Point(146, 11)
        txtCosto.Name = "txtCosto"
        txtCosto.Size = New Size(182, 27)
        txtCosto.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 20)
        Label2.TabIndex = 0
        Label2.Text = "Costo"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(txtDescripcion)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(53, 159)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(345, 47)
        Panel3.TabIndex = 3
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(146, 11)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(182, 27)
        txtDescripcion.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 0
        Label3.Text = "Descripcion"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(txtITBMS)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(433, 78)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(345, 47)
        Panel4.TabIndex = 4
        ' 
        ' txtITBMS
        ' 
        txtITBMS.Location = New Point(146, 11)
        txtITBMS.Name = "txtITBMS"
        txtITBMS.Size = New Size(182, 27)
        txtITBMS.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 0
        Label4.Text = "Itbms"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(txtExistencia)
        Panel5.Controls.Add(Label5)
        Panel5.Location = New Point(433, 159)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(345, 47)
        Panel5.TabIndex = 5
        ' 
        ' txtExistencia
        ' 
        txtExistencia.Location = New Point(146, 11)
        txtExistencia.Name = "txtExistencia"
        txtExistencia.Size = New Size(182, 27)
        txtExistencia.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 14)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 20)
        Label5.TabIndex = 0
        Label5.Text = "Existencia"
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(txtPuntoDeReorden)
        Panel6.Controls.Add(Label6)
        Panel6.Location = New Point(433, 228)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(345, 47)
        Panel6.TabIndex = 6
        ' 
        ' txtPuntoDeReorden
        ' 
        txtPuntoDeReorden.Location = New Point(146, 11)
        txtPuntoDeReorden.Name = "txtPuntoDeReorden"
        txtPuntoDeReorden.Size = New Size(182, 27)
        txtPuntoDeReorden.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 14)
        Label6.Name = "Label6"
        Label6.Size = New Size(128, 20)
        Label6.TabIndex = 0
        Label6.Text = "Punto de Reorden"
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(rbInactivo)
        Panel7.Controls.Add(rbActivo)
        Panel7.Controls.Add(Label7)
        Panel7.Location = New Point(433, 290)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(345, 47)
        Panel7.TabIndex = 8
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
        Panel8.Controls.Add(txtPrecio)
        Panel8.Controls.Add(Label8)
        Panel8.Location = New Point(53, 290)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(345, 47)
        Panel8.TabIndex = 7
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(146, 11)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(182, 27)
        txtPrecio.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(31, 11)
        Label8.Name = "Label8"
        Label8.Size = New Size(50, 20)
        Label8.TabIndex = 0
        Label8.Text = "Precio"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(292, 18)
        Label9.Name = "Label9"
        Label9.Size = New Size(244, 38)
        Label9.TabIndex = 9
        Label9.Text = "Ingresar Producto"
        ' 
        ' FormAgregarProducto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(827, 450)
        Controls.Add(Label9)
        Controls.Add(Panel7)
        Controls.Add(Panel8)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(BtnAgregarProdcuto)
        Name = "FormAgregarProducto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormAgregarProducto"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnAgregarProdcuto As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCodigoBarra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtITBMS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtExistencia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtPuntoDeReorden As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents rbInactivo As CheckBox
    Friend WithEvents rbActivo As CheckBox
End Class
