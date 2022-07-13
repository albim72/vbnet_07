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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbOdl = New System.Windows.Forms.TextBox()
        Me.tbCena = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbDiesel = New System.Windows.Forms.RadioButton()
        Me.rbBenzyna = New System.Windows.Forms.RadioButton()
        Me.rbElektryk = New System.Windows.Forms.RadioButton()
        Me.btnPolicz = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbWynik = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Koszty przejazdu samochodem"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "podaj odległość w km"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "podaj cenę za jedn. paliwa(litr, kWh)"
        '
        'tbOdl
        '
        Me.tbOdl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbOdl.Location = New System.Drawing.Point(334, 94)
        Me.tbOdl.Name = "tbOdl"
        Me.tbOdl.Size = New System.Drawing.Size(383, 26)
        Me.tbOdl.TabIndex = 3
        '
        'tbCena
        '
        Me.tbCena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbCena.Location = New System.Drawing.Point(334, 144)
        Me.tbCena.Name = "tbCena"
        Me.tbCena.Size = New System.Drawing.Size(383, 26)
        Me.tbCena.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbElektryk)
        Me.GroupBox1.Controls.Add(Me.rbBenzyna)
        Me.GroupBox1.Controls.Add(Me.rbDiesel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(56, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(661, 171)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "wybierz sinik"
        '
        'rbDiesel
        '
        Me.rbDiesel.AutoSize = True
        Me.rbDiesel.Location = New System.Drawing.Point(45, 43)
        Me.rbDiesel.Name = "rbDiesel"
        Me.rbDiesel.Size = New System.Drawing.Size(94, 24)
        Me.rbDiesel.TabIndex = 0
        Me.rbDiesel.TabStop = True
        Me.rbDiesel.Text = "diesel 1,9"
        Me.rbDiesel.UseVisualStyleBackColor = True
        '
        'rbBenzyna
        '
        Me.rbBenzyna.AutoSize = True
        Me.rbBenzyna.Location = New System.Drawing.Point(45, 86)
        Me.rbBenzyna.Name = "rbBenzyna"
        Me.rbBenzyna.Size = New System.Drawing.Size(113, 24)
        Me.rbBenzyna.TabIndex = 1
        Me.rbBenzyna.TabStop = True
        Me.rbBenzyna.Text = "benzyna 2,0"
        Me.rbBenzyna.UseVisualStyleBackColor = True
        '
        'rbElektryk
        '
        Me.rbElektryk.AutoSize = True
        Me.rbElektryk.Location = New System.Drawing.Point(45, 129)
        Me.rbElektryk.Name = "rbElektryk"
        Me.rbElektryk.Size = New System.Drawing.Size(163, 24)
        Me.rbElektryk.TabIndex = 2
        Me.rbElektryk.TabStop = True
        Me.rbElektryk.Text = "elektryczny 120 kW"
        Me.rbElektryk.UseVisualStyleBackColor = True
        '
        'btnPolicz
        '
        Me.btnPolicz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnPolicz.Location = New System.Drawing.Point(56, 435)
        Me.btnPolicz.Name = "btnPolicz"
        Me.btnPolicz.Size = New System.Drawing.Size(661, 53)
        Me.btnPolicz.TabIndex = 6
        Me.btnPolicz.Text = "policz koszt przejazdu"
        Me.btnPolicz.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 517)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "koszt przejazdu"
        '
        'tbWynik
        '
        Me.tbWynik.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbWynik.Location = New System.Drawing.Point(334, 511)
        Me.tbWynik.Name = "tbWynik"
        Me.tbWynik.Size = New System.Drawing.Size(383, 26)
        Me.tbWynik.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 616)
        Me.Controls.Add(Me.tbWynik)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnPolicz)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbCena)
        Me.Controls.Add(Me.tbOdl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "wypożyczania samochodów"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbOdl As TextBox
    Friend WithEvents tbCena As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbElektryk As RadioButton
    Friend WithEvents rbBenzyna As RadioButton
    Friend WithEvents rbDiesel As RadioButton
    Friend WithEvents btnPolicz As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tbWynik As TextBox
End Class
