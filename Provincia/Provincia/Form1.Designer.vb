<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ltbDatos = New System.Windows.Forms.ListBox()
        Me.ltbMayor = New System.Windows.Forms.ListBox()
        Me.ltbMenor = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCalMayor = New System.Windows.Forms.Button()
        Me.btnMenor = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtProv = New System.Windows.Forms.TextBox()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ltbDatos
        '
        Me.ltbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltbDatos.FormattingEnabled = True
        Me.ltbDatos.ItemHeight = 15
        Me.ltbDatos.Location = New System.Drawing.Point(60, 93)
        Me.ltbDatos.Name = "ltbDatos"
        Me.ltbDatos.Size = New System.Drawing.Size(213, 229)
        Me.ltbDatos.TabIndex = 0
        '
        'ltbMayor
        '
        Me.ltbMayor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltbMayor.FormattingEnabled = True
        Me.ltbMayor.ItemHeight = 15
        Me.ltbMayor.Location = New System.Drawing.Point(217, 93)
        Me.ltbMayor.Name = "ltbMayor"
        Me.ltbMayor.Size = New System.Drawing.Size(195, 229)
        Me.ltbMayor.TabIndex = 1
        '
        'ltbMenor
        '
        Me.ltbMenor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltbMenor.FormattingEnabled = True
        Me.ltbMenor.ItemHeight = 15
        Me.ltbMenor.Location = New System.Drawing.Point(374, 93)
        Me.ltbMenor.Name = "ltbMenor"
        Me.ltbMenor.Size = New System.Drawing.Size(194, 229)
        Me.ltbMenor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(507, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ORDENAR PROVINCIAS  CON MAYOR Y MENOR  HABITANTES "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Provincia : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(415, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mayor a Menor-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(214, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Menor a Mayor+"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Red
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(46, 353)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(95, 36)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnCalMayor
        '
        Me.btnCalMayor.BackColor = System.Drawing.Color.Red
        Me.btnCalMayor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCalMayor.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalMayor.Location = New System.Drawing.Point(215, 353)
        Me.btnCalMayor.Name = "btnCalMayor"
        Me.btnCalMayor.Size = New System.Drawing.Size(95, 36)
        Me.btnCalMayor.TabIndex = 9
        Me.btnCalMayor.Text = "Mayor"
        Me.btnCalMayor.UseVisualStyleBackColor = False
        '
        'btnMenor
        '
        Me.btnMenor.BackColor = System.Drawing.Color.Red
        Me.btnMenor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMenor.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenor.Location = New System.Drawing.Point(359, 353)
        Me.btnMenor.Name = "btnMenor"
        Me.btnMenor.Size = New System.Drawing.Size(95, 36)
        Me.btnMenor.TabIndex = 10
        Me.btnMenor.Text = "Menor"
        Me.btnMenor.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(485, 353)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(95, 36)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtProv
        '
        Me.txtProv.Location = New System.Drawing.Point(582, 58)
        Me.txtProv.Name = "txtProv"
        Me.txtProv.Size = New System.Drawing.Size(100, 20)
        Me.txtProv.TabIndex = 14
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(582, 118)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(100, 20)
        Me.txtCod.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Provincia.My.Resources.Resources._8IsqEx7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(708, 426)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.txtProv)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnMenor)
        Me.Controls.Add(Me.btnCalMayor)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ltbMenor)
        Me.Controls.Add(Me.ltbMayor)
        Me.Controls.Add(Me.ltbDatos)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ltbDatos As ListBox
    Friend WithEvents ltbMayor As ListBox
    Friend WithEvents ltbMenor As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCalMayor As Button
    Friend WithEvents btnMenor As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtProv As TextBox
    Friend WithEvents txtCod As TextBox
End Class
