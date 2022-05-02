<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gauss
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Coeficientes = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.b3 = New System.Windows.Forms.TextBox()
        Me.b2 = New System.Windows.Forms.TextBox()
        Me.a31 = New System.Windows.Forms.TextBox()
        Me.a32 = New System.Windows.Forms.TextBox()
        Me.a33 = New System.Windows.Forms.TextBox()
        Me.b1 = New System.Windows.Forms.TextBox()
        Me.a13 = New System.Windows.Forms.TextBox()
        Me.a11 = New System.Windows.Forms.TextBox()
        Me.a12 = New System.Windows.Forms.TextBox()
        Me.a23 = New System.Windows.Forms.TextBox()
        Me.a22 = New System.Windows.Forms.TextBox()
        Me.a21 = New System.Windows.Forms.TextBox()
        Me.Inicio = New System.Windows.Forms.Button()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.LavenderBlush
        Me.TextBox3.Location = New System.Drawing.Point(888, 153)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 85
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.LavenderBlush
        Me.TextBox2.Location = New System.Drawing.Point(888, 118)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 84
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LavenderBlush
        Me.TextBox1.Location = New System.Drawing.Point(888, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 83
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(845, 118)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 15)
        Me.Label13.TabIndex = 82
        Me.Label13.Text = "y ="
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(846, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 15)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "z ="
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(845, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 15)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "x ="
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.LightGray
        Me.Salir.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.ForeColor = System.Drawing.Color.SteelBlue
        Me.Salir.Location = New System.Drawing.Point(724, 177)
        Me.Salir.Margin = New System.Windows.Forms.Padding(2)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(81, 30)
        Me.Salir.TabIndex = 79
        Me.Salir.Text = "Salir"
        Me.Salir.UseMnemonic = False
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Limpiar
        '
        Me.Limpiar.BackColor = System.Drawing.Color.LightGray
        Me.Limpiar.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpiar.ForeColor = System.Drawing.Color.SteelBlue
        Me.Limpiar.Location = New System.Drawing.Point(724, 143)
        Me.Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(81, 30)
        Me.Limpiar.TabIndex = 78
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseMnemonic = False
        Me.Limpiar.UseVisualStyleBackColor = False
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.Color.LightGray
        Me.Calcular.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calcular.ForeColor = System.Drawing.Color.SteelBlue
        Me.Calcular.Location = New System.Drawing.Point(724, 103)
        Me.Calcular.Margin = New System.Windows.Forms.Padding(2)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(81, 30)
        Me.Calcular.TabIndex = 77
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseMnemonic = False
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'Coeficientes
        '
        Me.Coeficientes.BackColor = System.Drawing.Color.LightGray
        Me.Coeficientes.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coeficientes.ForeColor = System.Drawing.Color.SteelBlue
        Me.Coeficientes.Location = New System.Drawing.Point(724, 69)
        Me.Coeficientes.Margin = New System.Windows.Forms.Padding(2)
        Me.Coeficientes.Name = "Coeficientes"
        Me.Coeficientes.Size = New System.Drawing.Size(81, 30)
        Me.Coeficientes.TabIndex = 76
        Me.Coeficientes.Text = "Coeficientes"
        Me.Coeficientes.UseMnemonic = False
        Me.Coeficientes.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(549, 174)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 17)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "z  ="
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(549, 127)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 17)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "z  ="
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(549, 77)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 17)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "z  ="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(399, 174)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 17)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "y +"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(399, 126)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 17)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "y +"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(399, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 17)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "y +"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(263, 125)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 17)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "x +"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(263, 174)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "x +"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(263, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "x +"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(529, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 17)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Dame cifras significativas"
        '
        'tc
        '
        Me.tc.BackColor = System.Drawing.Color.LavenderBlush
        Me.tc.Location = New System.Drawing.Point(701, 25)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(114, 20)
        Me.tc.TabIndex = 65
        '
        'b3
        '
        Me.b3.BackColor = System.Drawing.Color.LavenderBlush
        Me.b3.Location = New System.Drawing.Point(588, 175)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(100, 20)
        Me.b3.TabIndex = 64
        '
        'b2
        '
        Me.b2.BackColor = System.Drawing.Color.LavenderBlush
        Me.b2.Location = New System.Drawing.Point(588, 126)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(100, 20)
        Me.b2.TabIndex = 63
        '
        'a31
        '
        Me.a31.BackColor = System.Drawing.Color.LavenderBlush
        Me.a31.Location = New System.Drawing.Point(159, 175)
        Me.a31.Name = "a31"
        Me.a31.Size = New System.Drawing.Size(100, 20)
        Me.a31.TabIndex = 62
        '
        'a32
        '
        Me.a32.BackColor = System.Drawing.Color.LavenderBlush
        Me.a32.Location = New System.Drawing.Point(296, 175)
        Me.a32.Name = "a32"
        Me.a32.Size = New System.Drawing.Size(100, 20)
        Me.a32.TabIndex = 61
        '
        'a33
        '
        Me.a33.BackColor = System.Drawing.Color.LavenderBlush
        Me.a33.Location = New System.Drawing.Point(436, 175)
        Me.a33.Name = "a33"
        Me.a33.Size = New System.Drawing.Size(100, 20)
        Me.a33.TabIndex = 60
        '
        'b1
        '
        Me.b1.BackColor = System.Drawing.Color.LavenderBlush
        Me.b1.Location = New System.Drawing.Point(588, 76)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(100, 20)
        Me.b1.TabIndex = 59
        '
        'a13
        '
        Me.a13.BackColor = System.Drawing.Color.LavenderBlush
        Me.a13.Location = New System.Drawing.Point(436, 76)
        Me.a13.Name = "a13"
        Me.a13.Size = New System.Drawing.Size(100, 20)
        Me.a13.TabIndex = 58
        '
        'a11
        '
        Me.a11.BackColor = System.Drawing.Color.LavenderBlush
        Me.a11.Location = New System.Drawing.Point(159, 76)
        Me.a11.Name = "a11"
        Me.a11.Size = New System.Drawing.Size(100, 20)
        Me.a11.TabIndex = 57
        '
        'a12
        '
        Me.a12.BackColor = System.Drawing.Color.LavenderBlush
        Me.a12.Location = New System.Drawing.Point(296, 76)
        Me.a12.Name = "a12"
        Me.a12.Size = New System.Drawing.Size(100, 20)
        Me.a12.TabIndex = 56
        '
        'a23
        '
        Me.a23.BackColor = System.Drawing.Color.LavenderBlush
        Me.a23.Location = New System.Drawing.Point(436, 126)
        Me.a23.Name = "a23"
        Me.a23.Size = New System.Drawing.Size(100, 20)
        Me.a23.TabIndex = 55
        '
        'a22
        '
        Me.a22.BackColor = System.Drawing.Color.LavenderBlush
        Me.a22.Location = New System.Drawing.Point(296, 126)
        Me.a22.Name = "a22"
        Me.a22.Size = New System.Drawing.Size(100, 20)
        Me.a22.TabIndex = 54
        '
        'a21
        '
        Me.a21.BackColor = System.Drawing.Color.LavenderBlush
        Me.a21.Location = New System.Drawing.Point(159, 126)
        Me.a21.Name = "a21"
        Me.a21.Size = New System.Drawing.Size(100, 20)
        Me.a21.TabIndex = 53
        '
        'Inicio
        '
        Me.Inicio.BackColor = System.Drawing.Color.LightGray
        Me.Inicio.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inicio.ForeColor = System.Drawing.Color.SteelBlue
        Me.Inicio.Location = New System.Drawing.Point(23, 38)
        Me.Inicio.Margin = New System.Windows.Forms.Padding(2)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(81, 30)
        Me.Inicio.TabIndex = 52
        Me.Inicio.Text = "Inicio"
        Me.Inicio.UseMnemonic = False
        Me.Inicio.UseVisualStyleBackColor = False
        '
        'Salida
        '
        Me.Salida.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.column4, Me.Column5, Me.Column6, Me.Column7})
        Me.Salida.Location = New System.Drawing.Point(23, 232)
        Me.Salida.Name = "Salida"
        Me.Salida.RowHeadersWidth = 62
        Me.Salida.Size = New System.Drawing.Size(1071, 193)
        Me.Salida.TabIndex = 51
        '
        'Column1
        '
        Me.Column1.HeaderText = "Índice "
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "x(i)"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "y(i)"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'column4
        '
        Me.column4.HeaderText = "z(i)"
        Me.column4.MinimumWidth = 8
        Me.column4.Name = "column4"
        Me.column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "ex"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "ey"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "ez"
        Me.Column7.MinimumWidth = 8
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'Gauss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1117, 450)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Coeficientes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.a31)
        Me.Controls.Add(Me.a32)
        Me.Controls.Add(Me.a33)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.a13)
        Me.Controls.Add(Me.a11)
        Me.Controls.Add(Me.a12)
        Me.Controls.Add(Me.a23)
        Me.Controls.Add(Me.a22)
        Me.Controls.Add(Me.a21)
        Me.Controls.Add(Me.Inicio)
        Me.Controls.Add(Me.Salida)
        Me.Name = "Gauss"
        Me.Text = "Gauss"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Salir As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Calcular As Button
    Friend WithEvents Coeficientes As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tc As TextBox
    Friend WithEvents b3 As TextBox
    Friend WithEvents b2 As TextBox
    Friend WithEvents a31 As TextBox
    Friend WithEvents a32 As TextBox
    Friend WithEvents a33 As TextBox
    Friend WithEvents b1 As TextBox
    Friend WithEvents a13 As TextBox
    Friend WithEvents a11 As TextBox
    Friend WithEvents a12 As TextBox
    Friend WithEvents a23 As TextBox
    Friend WithEvents a22 As TextBox
    Friend WithEvents a21 As TextBox
    Friend WithEvents Inicio As Button
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
