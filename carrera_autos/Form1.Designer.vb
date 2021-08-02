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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.amarillo = New System.Windows.Forms.PictureBox()
        Me.rosa = New System.Windows.Forms.PictureBox()
        Me.verde = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.btncarrera = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.amarillo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'amarillo
        '
        Me.amarillo.Image = CType(resources.GetObject("amarillo.Image"), System.Drawing.Image)
        Me.amarillo.Location = New System.Drawing.Point(0, 72)
        Me.amarillo.Name = "amarillo"
        Me.amarillo.Size = New System.Drawing.Size(113, 78)
        Me.amarillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.amarillo.TabIndex = 0
        Me.amarillo.TabStop = False
        '
        'rosa
        '
        Me.rosa.Image = CType(resources.GetObject("rosa.Image"), System.Drawing.Image)
        Me.rosa.Location = New System.Drawing.Point(0, 212)
        Me.rosa.Name = "rosa"
        Me.rosa.Size = New System.Drawing.Size(113, 66)
        Me.rosa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rosa.TabIndex = 1
        Me.rosa.TabStop = False
        '
        'verde
        '
        Me.verde.Image = CType(resources.GetObject("verde.Image"), System.Drawing.Image)
        Me.verde.Location = New System.Drawing.Point(0, 329)
        Me.verde.Name = "verde"
        Me.verde.Size = New System.Drawing.Size(113, 65)
        Me.verde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.verde.TabIndex = 2
        Me.verde.TabStop = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'btncarrera
        '
        Me.btncarrera.BackColor = System.Drawing.SystemColors.Highlight
        Me.btncarrera.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncarrera.Location = New System.Drawing.Point(264, 13)
        Me.btncarrera.Name = "btncarrera"
        Me.btncarrera.Size = New System.Drawing.Size(180, 42)
        Me.btncarrera.TabIndex = 3
        Me.btncarrera.Text = "Iniciar carrera"
        Me.btncarrera.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(642, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(20, 322)
        Me.Panel1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btncarrera)
        Me.Controls.Add(Me.verde)
        Me.Controls.Add(Me.rosa)
        Me.Controls.Add(Me.amarillo)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.amarillo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents amarillo As PictureBox
    Friend WithEvents rosa As PictureBox
    Friend WithEvents verde As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents btncarrera As Button
    Friend WithEvents Panel1 As Panel
End Class
