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
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnMultiplicacion = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'num1
        '
        Me.num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num1.Location = New System.Drawing.Point(334, 41)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(300, 45)
        Me.num1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Primer Numero"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(637, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 65)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Accion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(581, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "0"
        '
        'num2
        '
        Me.num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num2.Location = New System.Drawing.Point(334, 103)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(300, 45)
        Me.num2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(284, 39)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Segundo Numero"
        '
        'btnSuma
        '
        Me.btnSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.Location = New System.Drawing.Point(34, 184)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(240, 50)
        Me.btnSuma.TabIndex = 6
        Me.btnSuma.Text = "Suma"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.Location = New System.Drawing.Point(34, 254)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(240, 49)
        Me.btnResta.TabIndex = 7
        Me.btnResta.Text = "Resta"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(514, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 39)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Resultado:"
        '
        'btnMultiplicacion
        '
        Me.btnMultiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicacion.Location = New System.Drawing.Point(34, 318)
        Me.btnMultiplicacion.Name = "btnMultiplicacion"
        Me.btnMultiplicacion.Size = New System.Drawing.Size(240, 49)
        Me.btnMultiplicacion.TabIndex = 9
        Me.btnMultiplicacion.Text = "Multiplicacion"
        Me.btnMultiplicacion.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.Location = New System.Drawing.Point(34, 381)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(240, 47)
        Me.btnDivision.TabIndex = 10
        Me.btnDivision.Text = "Division"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnMultiplicacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.num1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents num1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents num2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnMultiplicacion As Button
    Friend WithEvents btnDivision As Button
End Class
