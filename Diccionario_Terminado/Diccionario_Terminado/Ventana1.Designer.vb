<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSgnificado = New System.Windows.Forms.TextBox()
        Me.txtPalabra = New System.Windows.Forms.TextBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Palabra :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Significado :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ubicación Imagen :"
        '
        'txtSgnificado
        '
        Me.txtSgnificado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSgnificado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSgnificado.Location = New System.Drawing.Point(224, 62)
        Me.txtSgnificado.Name = "txtSgnificado"
        Me.txtSgnificado.Size = New System.Drawing.Size(197, 26)
        Me.txtSgnificado.TabIndex = 4
        '
        'txtPalabra
        '
        Me.txtPalabra.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPalabra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPalabra.Location = New System.Drawing.Point(224, 24)
        Me.txtPalabra.Name = "txtPalabra"
        Me.txtPalabra.Size = New System.Drawing.Size(197, 26)
        Me.txtPalabra.TabIndex = 3
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.Color.Aqua
        Me.btnCargar.Location = New System.Drawing.Point(465, 118)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(116, 23)
        Me.btnCargar.TabIndex = 5
        Me.btnCargar.Text = "Examinar"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Aqua
        Me.btnAgregar.Location = New System.Drawing.Point(121, 197)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 23)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Aqua
        Me.btnLimpiar.Location = New System.Drawing.Point(260, 197)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(116, 23)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "&Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Aqua
        Me.btnSalir.Location = New System.Drawing.Point(410, 197)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(116, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(224, 115)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(197, 26)
        Me.txtPath.TabIndex = 10
        '
        'Ventana1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Diccionario_Terminado.My.Resources.Resources.GLOSARIO_TERMINOS_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 268)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.txtSgnificado)
        Me.Controls.Add(Me.txtPalabra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventana1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BIENVENIDA DICCIONARIO "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSgnificado As TextBox
    Friend WithEvents txtPalabra As TextBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtPath As TextBox
End Class
