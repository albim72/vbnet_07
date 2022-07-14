<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbWynik = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMiasto = New System.Windows.Forms.ComboBox()
        Me.btnZapytanie = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "zamówienia dla wybranych miast"
        '
        'tbWynik
        '
        Me.tbWynik.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbWynik.Location = New System.Drawing.Point(32, 72)
        Me.tbWynik.Multiline = True
        Me.tbWynik.Name = "tbWynik"
        Me.tbWynik.Size = New System.Drawing.Size(715, 191)
        Me.tbWynik.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "wybierz miasto"
        '
        'cbMiasto
        '
        Me.cbMiasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbMiasto.FormattingEnabled = True
        Me.cbMiasto.Location = New System.Drawing.Point(35, 331)
        Me.cbMiasto.Name = "cbMiasto"
        Me.cbMiasto.Size = New System.Drawing.Size(712, 24)
        Me.cbMiasto.TabIndex = 3
        '
        'btnZapytanie
        '
        Me.btnZapytanie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnZapytanie.Location = New System.Drawing.Point(35, 383)
        Me.btnZapytanie.Name = "btnZapytanie"
        Me.btnZapytanie.Size = New System.Drawing.Size(237, 43)
        Me.btnZapytanie.TabIndex = 4
        Me.btnZapytanie.Text = "zapytanie"
        Me.btnZapytanie.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnClear.Location = New System.Drawing.Point(510, 383)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(237, 43)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "czyść formularz"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnZapytanie)
        Me.Controls.Add(Me.cbMiasto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbWynik)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "zapytanie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbWynik As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbMiasto As ComboBox
    Friend WithEvents btnZapytanie As Button
    Friend WithEvents btnClear As Button
End Class
