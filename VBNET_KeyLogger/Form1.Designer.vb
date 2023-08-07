<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnMostrarLog = New System.Windows.Forms.Button()
        Me.rtb1 = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnMostrarLog
        '
        Me.btnMostrarLog.Location = New System.Drawing.Point(12, 12)
        Me.btnMostrarLog.Name = "btnMostrarLog"
        Me.btnMostrarLog.Size = New System.Drawing.Size(438, 37)
        Me.btnMostrarLog.TabIndex = 0
        Me.btnMostrarLog.Text = "Mostrar Log"
        Me.btnMostrarLog.UseVisualStyleBackColor = True
        '
        'rtb1
        '
        Me.rtb1.Location = New System.Drawing.Point(12, 56)
        Me.rtb1.Name = "rtb1"
        Me.rtb1.Size = New System.Drawing.Size(438, 318)
        Me.rtb1.TabIndex = 1
        Me.rtb1.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 386)
        Me.Controls.Add(Me.rtb1)
        Me.Controls.Add(Me.btnMostrarLog)
        Me.Name = "frmEventos"
        Me.Text = "Registrador de Eventos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMostrarLog As System.Windows.Forms.Button
    Friend WithEvents rtb1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
