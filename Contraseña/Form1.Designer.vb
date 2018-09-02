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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.MostrarCheckBox = New System.Windows.Forms.CheckBox()
        Me.ValidarButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(49, 24)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(136, 20)
        Me.ContraseñaTextBox.TabIndex = 0
        Me.ContraseñaTextBox.UseSystemPasswordChar = True
        '
        'MostrarCheckBox
        '
        Me.MostrarCheckBox.AutoSize = True
        Me.MostrarCheckBox.Location = New System.Drawing.Point(49, 50)
        Me.MostrarCheckBox.Name = "MostrarCheckBox"
        Me.MostrarCheckBox.Size = New System.Drawing.Size(61, 17)
        Me.MostrarCheckBox.TabIndex = 1
        Me.MostrarCheckBox.Text = "Mostrar"
        Me.MostrarCheckBox.UseVisualStyleBackColor = True
        '
        'ValidarButton
        '
        Me.ValidarButton.Location = New System.Drawing.Point(80, 99)
        Me.ValidarButton.Name = "ValidarButton"
        Me.ValidarButton.Size = New System.Drawing.Size(75, 23)
        Me.ValidarButton.TabIndex = 2
        Me.ValidarButton.Text = "Validar"
        Me.ValidarButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 134)
        Me.Controls.Add(Me.ValidarButton)
        Me.Controls.Add(Me.MostrarCheckBox)
        Me.Controls.Add(Me.ContraseñaTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents MostrarCheckBox As CheckBox
    Friend WithEvents ValidarButton As Button
End Class
