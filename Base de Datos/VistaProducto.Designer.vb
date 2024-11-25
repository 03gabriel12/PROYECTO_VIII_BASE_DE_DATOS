<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VistaProducto
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        BtnListarProducto = New Button()
        BtnEliminarProducto = New Button()
        BtnModificarProducto = New Button()
        BtnAdiccionarProducto = New Button()
        BtnLimpiarProducto = New Button()
        BtnBuscarProducto = New Button()
        searchProducto = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        DataGridViewProducto = New DataGridView()
        GroupBox1 = New GroupBox()
        rbDescripcion = New RadioButton()
        rbCodigoBarra = New RadioButton()
        FlowLayoutPanel1.SuspendLayout()
        CType(DataGridViewProducto, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(BtnListarProducto)
        FlowLayoutPanel1.Controls.Add(BtnEliminarProducto)
        FlowLayoutPanel1.Controls.Add(BtnModificarProducto)
        FlowLayoutPanel1.Controls.Add(BtnAdiccionarProducto)
        FlowLayoutPanel1.Controls.Add(BtnLimpiarProducto)
        FlowLayoutPanel1.Controls.Add(BtnBuscarProducto)
        FlowLayoutPanel1.Location = New Point(80, 78)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(909, 48)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' BtnListarProducto
        ' 
        BtnListarProducto.Location = New Point(3, 3)
        BtnListarProducto.Name = "BtnListarProducto"
        BtnListarProducto.Size = New Size(150, 29)
        BtnListarProducto.TabIndex = 0
        BtnListarProducto.Text = "Listar Producto"
        BtnListarProducto.UseVisualStyleBackColor = True
        ' 
        ' BtnEliminarProducto
        ' 
        BtnEliminarProducto.Location = New Point(159, 3)
        BtnEliminarProducto.Name = "BtnEliminarProducto"
        BtnEliminarProducto.Size = New Size(157, 29)
        BtnEliminarProducto.TabIndex = 1
        BtnEliminarProducto.Text = "Eliminar Producto"
        BtnEliminarProducto.UseVisualStyleBackColor = True
        ' 
        ' BtnModificarProducto
        ' 
        BtnModificarProducto.Location = New Point(322, 3)
        BtnModificarProducto.Name = "BtnModificarProducto"
        BtnModificarProducto.Size = New Size(154, 29)
        BtnModificarProducto.TabIndex = 2
        BtnModificarProducto.Text = "ModificarProducto"
        BtnModificarProducto.UseVisualStyleBackColor = True
        ' 
        ' BtnAdiccionarProducto
        ' 
        BtnAdiccionarProducto.Location = New Point(482, 3)
        BtnAdiccionarProducto.Name = "BtnAdiccionarProducto"
        BtnAdiccionarProducto.Size = New Size(160, 29)
        BtnAdiccionarProducto.TabIndex = 3
        BtnAdiccionarProducto.Text = "Adiccionar Producto"
        BtnAdiccionarProducto.UseVisualStyleBackColor = True
        ' 
        ' BtnLimpiarProducto
        ' 
        BtnLimpiarProducto.Location = New Point(648, 3)
        BtnLimpiarProducto.Name = "BtnLimpiarProducto"
        BtnLimpiarProducto.Size = New Size(143, 29)
        BtnLimpiarProducto.TabIndex = 4
        BtnLimpiarProducto.Text = "Limpiar Salida"
        BtnLimpiarProducto.UseVisualStyleBackColor = True
        ' 
        ' BtnBuscarProducto
        ' 
        BtnBuscarProducto.Location = New Point(797, 3)
        BtnBuscarProducto.Name = "BtnBuscarProducto"
        BtnBuscarProducto.Size = New Size(94, 29)
        BtnBuscarProducto.TabIndex = 5
        BtnBuscarProducto.Text = "Buscar"
        BtnBuscarProducto.UseVisualStyleBackColor = True
        ' 
        ' searchProducto
        ' 
        searchProducto.Location = New Point(1069, 81)
        searchProducto.Name = "searchProducto"
        searchProducto.Size = New Size(185, 27)
        searchProducto.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(549, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 31)
        Label1.TabIndex = 2
        Label1.Text = "Vista Producto "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(1005, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 4
        Label2.Text = "Search"
        ' 
        ' DataGridViewProducto
        ' 
        DataGridViewProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewProducto.Location = New Point(64, 249)
        DataGridViewProducto.Name = "DataGridViewProducto"
        DataGridViewProducto.RowHeadersWidth = 51
        DataGridViewProducto.Size = New Size(1190, 270)
        DataGridViewProducto.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbDescripcion)
        GroupBox1.Controls.Add(rbCodigoBarra)
        GroupBox1.Location = New Point(80, 151)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(303, 78)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Order By "
        ' 
        ' rbDescripcion
        ' 
        rbDescripcion.AutoSize = True
        rbDescripcion.Location = New Point(165, 36)
        rbDescripcion.Name = "rbDescripcion"
        rbDescripcion.Size = New Size(108, 24)
        rbDescripcion.TabIndex = 1
        rbDescripcion.TabStop = True
        rbDescripcion.Text = "Descripcion"
        rbDescripcion.UseVisualStyleBackColor = True
        ' 
        ' rbCodigoBarra
        ' 
        rbCodigoBarra.AutoSize = True
        rbCodigoBarra.Location = New Point(21, 36)
        rbCodigoBarra.Name = "rbCodigoBarra"
        rbCodigoBarra.Size = New Size(118, 24)
        rbCodigoBarra.TabIndex = 0
        rbCodigoBarra.TabStop = True
        rbCodigoBarra.Text = "Codigo Barra"
        rbCodigoBarra.UseVisualStyleBackColor = True
        ' 
        ' VistaProducto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1368, 531)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridViewProducto)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(searchProducto)
        Controls.Add(FlowLayoutPanel1)
        Name = "VistaProducto"
        Text = "VistaProducto"
        FlowLayoutPanel1.ResumeLayout(False)
        CType(DataGridViewProducto, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BtnListarProducto As Button
    Friend WithEvents BtnEliminarProducto As Button
    Friend WithEvents BtnModificarProducto As Button
    Friend WithEvents BtnAdiccionarProducto As Button
    Friend WithEvents BtnLimpiarProducto As Button
    Friend WithEvents BtnBuscarProducto As Button
    Friend WithEvents searchProducto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewProducto As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbDescripcion As RadioButton
    Friend WithEvents rbCodigoBarra As RadioButton
End Class
