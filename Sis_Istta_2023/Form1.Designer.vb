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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb_cerrar = New System.Windows.Forms.PictureBox()
        Me.pb_minimizar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 269)
        Me.Panel1.TabIndex = 0
        '
        'pb_cerrar
        '
        Me.pb_cerrar.Image = CType(resources.GetObject("pb_cerrar.Image"), System.Drawing.Image)
        Me.pb_cerrar.Location = New System.Drawing.Point(745, 0)
        Me.pb_cerrar.Name = "pb_cerrar"
        Me.pb_cerrar.Size = New System.Drawing.Size(22, 21)
        Me.pb_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_cerrar.TabIndex = 10
        Me.pb_cerrar.TabStop = False
        '
        'pb_minimizar
        '
        Me.pb_minimizar.Image = CType(resources.GetObject("pb_minimizar.Image"), System.Drawing.Image)
        Me.pb_minimizar.Location = New System.Drawing.Point(718, 0)
        Me.pb_minimizar.Name = "pb_minimizar"
        Me.pb_minimizar.Size = New System.Drawing.Size(24, 21)
        Me.pb_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_minimizar.TabIndex = 9
        Me.pb_minimizar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sis_Istta_2023.My.Resources.Resources.logo_istta
        Me.PictureBox1.Location = New System.Drawing.Point(38, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 178)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(779, 269)
        Me.Controls.Add(Me.pb_cerrar)
        Me.Controls.Add(Me.pb_minimizar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Private WithEvents pb_cerrar As PictureBox
    Private WithEvents pb_minimizar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
