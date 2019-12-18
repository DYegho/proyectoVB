<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventana2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.listImage = New System.Windows.Forms.ImageList(Me.components)
        Me.ListPalabras = New System.Windows.Forms.ListBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbImages = New System.Windows.Forms.ComboBox()
        Me.btnTabla = New System.Windows.Forms.Button()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Palabra , Significado  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(213, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Imagen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 21)
        Me.Label4.TabIndex = 8
        '
        'listImage
        '
        Me.listImage.ImageStream = CType(resources.GetObject("listImage.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.listImage.TransparentColor = System.Drawing.Color.Transparent
        Me.listImage.Images.SetKeyName(0, "cd4c04d04a4315fdd3d987c6b2b5fbb8.jpg")
        Me.listImage.Images.SetKeyName(1, "computador.jpg")
        Me.listImage.Images.SetKeyName(2, "estadistica.jpg")
        Me.listImage.Images.SetKeyName(3, "estructura.jpg")
        Me.listImage.Images.SetKeyName(4, "redes.jpg")
        '
        'ListPalabras
        '
        Me.ListPalabras.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListPalabras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListPalabras.FormattingEnabled = True
        Me.ListPalabras.ItemHeight = 16
        Me.ListPalabras.Location = New System.Drawing.Point(134, 280)
        Me.ListPalabras.Name = "ListPalabras"
        Me.ListPalabras.Size = New System.Drawing.Size(461, 68)
        Me.ListPalabras.TabIndex = 15
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegresar.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Location = New System.Drawing.Point(145, 383)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(102, 45)
        Me.btnRegresar.TabIndex = 16
        Me.btnRegresar.Text = "&Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(503, 383)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(102, 45)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Tipo de Imágenes :"
        '
        'cmbImages
        '
        Me.cmbImages.BackColor = System.Drawing.Color.SteelBlue
        Me.cmbImages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbImages.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbImages.ForeColor = System.Drawing.Color.White
        Me.cmbImages.FormattingEnabled = True
        Me.cmbImages.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbImages.Location = New System.Drawing.Point(145, 76)
        Me.cmbImages.Name = "cmbImages"
        Me.cmbImages.Size = New System.Drawing.Size(121, 21)
        Me.cmbImages.TabIndex = 1
        '
        'btnTabla
        '
        Me.btnTabla.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTabla.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTabla.Location = New System.Drawing.Point(324, 383)
        Me.btnTabla.Name = "btnTabla"
        Me.btnTabla.Size = New System.Drawing.Size(102, 45)
        Me.btnTabla.TabIndex = 19
        Me.btnTabla.Text = "Tabla "
        Me.btnTabla.UseVisualStyleBackColor = False
        '
        'picImage
        '
        Me.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picImage.Location = New System.Drawing.Point(134, 66)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(448, 174)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 14
        Me.picImage.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Ventana2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Diccionario_Terminado.My.Resources.Resources.images__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(747, 461)
        Me.Controls.Add(Me.btnTabla)
        Me.Controls.Add(Me.cmbImages)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.ListPalabras)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventana2"
        Me.Text = "Ventana2"
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents listImage As ImageList
    Friend WithEvents picImage As PictureBox
    Friend WithEvents ListPalabras As ListBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbImages As ComboBox
    Friend WithEvents btnTabla As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
