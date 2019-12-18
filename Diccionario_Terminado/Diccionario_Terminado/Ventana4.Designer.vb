<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana4
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.txtPalabra = New System.Windows.Forms.TextBox()
        Me.txtSignificado = New System.Windows.Forms.TextBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListView1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(345, 73)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(527, 275)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.GreenYellow
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Font = New System.Drawing.Font("Wide Latin", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Location = New System.Drawing.Point(67, 377)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(131, 38)
        Me.btnRegresar.TabIndex = 1
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.GreenYellow
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Wide Latin", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Location = New System.Drawing.Point(309, 377)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(131, 38)
        Me.btnExportar.TabIndex = 2
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'btnImportar
        '
        Me.btnImportar.BackColor = System.Drawing.Color.GreenYellow
        Me.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportar.Font = New System.Drawing.Font("Wide Latin", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.Location = New System.Drawing.Point(521, 377)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(131, 38)
        Me.btnImportar.TabIndex = 3
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.GreenYellow
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Wide Latin", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(741, 377)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(131, 38)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Suspender"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Código :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Palabra :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Significado :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Path :"
        '
        'txtCod
        '
        Me.txtCod.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCod.Location = New System.Drawing.Point(130, 73)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(100, 20)
        Me.txtCod.TabIndex = 9
        '
        'txtPalabra
        '
        Me.txtPalabra.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPalabra.Location = New System.Drawing.Point(130, 104)
        Me.txtPalabra.Name = "txtPalabra"
        Me.txtPalabra.Size = New System.Drawing.Size(100, 20)
        Me.txtPalabra.TabIndex = 10
        '
        'txtSignificado
        '
        Me.txtSignificado.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSignificado.Location = New System.Drawing.Point(130, 161)
        Me.txtSignificado.Multiline = True
        Me.txtSignificado.Name = "txtSignificado"
        Me.txtSignificado.Size = New System.Drawing.Size(198, 82)
        Me.txtSignificado.TabIndex = 11
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPath.Location = New System.Drawing.Point(130, 265)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(209, 20)
        Me.txtPath.TabIndex = 12
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Wide Latin", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(356, 21)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(127, 35)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Wide Latin", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(539, 21)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(127, 35)
        Me.btnActualizar.TabIndex = 14
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Wide Latin", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(722, 21)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(127, 35)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Ventana4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Diccionario_Terminado.My.Resources.Resources.images
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(933, 436)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.txtSignificado)
        Me.Controls.Add(Me.txtPalabra)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventana4"
        Me.Text = "Ventana4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnImportar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCod As TextBox
    Friend WithEvents txtPalabra As TextBox
    Friend WithEvents txtSignificado As TextBox
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
End Class
