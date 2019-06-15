<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.CBcam = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NudALL = New System.Windows.Forms.NumericUpDown()
        Me.NudAn = New System.Windows.Forms.NumericUpDown()
        Me.NudAl = New System.Windows.Forms.NumericUpDown()
        Me.NudDist = New System.Windows.Forms.NumericUpDown()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.LimpiarCamposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnAcercaDe = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.NudALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudAn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudAl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudDist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBcam
        '
        Me.CBcam.BackColor = System.Drawing.Color.Green
        Me.CBcam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBcam.ForeColor = System.Drawing.Color.White
        Me.CBcam.FormattingEnabled = True
        Me.CBcam.Location = New System.Drawing.Point(273, 93)
        Me.CBcam.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CBcam.Name = "CBcam"
        Me.CBcam.Size = New System.Drawing.Size(250, 26)
        Me.CBcam.TabIndex = 0
        Me.CBcam.Text = "Seleccione una cámara"
        Me.ToolTip1.SetToolTip(Me.CBcam, "Elija una cámara para calcular" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la distancia a laque debe ser" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ubicada y capturar" &
        " un plano " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de proyección a partir de su" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ancho o alto.")
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        '
        'NudALL
        '
        Me.NudALL.BackColor = System.Drawing.Color.Green
        Me.NudALL.DecimalPlaces = 4
        Me.NudALL.ForeColor = System.Drawing.Color.White
        Me.NudALL.Location = New System.Drawing.Point(172, 93)
        Me.NudALL.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NudALL.Name = "NudALL"
        Me.NudALL.Size = New System.Drawing.Size(91, 26)
        Me.NudALL.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.NudALL, "Altura desde la base de la " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cámara o del soporte donde" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "se ubica la cámara hasta" &
        " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aproximadamente el centro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del lente de la cámara.")
        '
        'NudAn
        '
        Me.NudAn.BackColor = System.Drawing.Color.Green
        Me.NudAn.DecimalPlaces = 4
        Me.NudAn.ForeColor = System.Drawing.Color.White
        Me.NudAn.Location = New System.Drawing.Point(83, 137)
        Me.NudAn.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NudAn.Name = "NudAn"
        Me.NudAn.Size = New System.Drawing.Size(91, 26)
        Me.NudAn.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.NudAn, "Altura desde la base de la " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cámara o del soporte donde" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "se ubica la cámara hasta" &
        " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aproximadamente el centro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del lente de la cámara.")
        '
        'NudAl
        '
        Me.NudAl.BackColor = System.Drawing.Color.Green
        Me.NudAl.DecimalPlaces = 4
        Me.NudAl.ForeColor = System.Drawing.Color.White
        Me.NudAl.Location = New System.Drawing.Point(234, 137)
        Me.NudAl.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NudAl.Name = "NudAl"
        Me.NudAl.Size = New System.Drawing.Size(91, 26)
        Me.NudAl.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.NudAl, "Altura desde la base de la " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cámara o del soporte donde" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "se ubica la cámara hasta" &
        " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aproximadamente el centro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del lente de la cámara.")
        '
        'NudDist
        '
        Me.NudDist.BackColor = System.Drawing.Color.Green
        Me.NudDist.DecimalPlaces = 4
        Me.NudDist.ForeColor = System.Drawing.Color.White
        Me.NudDist.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NudDist.Location = New System.Drawing.Point(421, 137)
        Me.NudDist.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NudDist.Name = "NudDist"
        Me.NudDist.ReadOnly = True
        Me.NudDist.Size = New System.Drawing.Size(91, 26)
        Me.NudDist.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.NudDist, "Altura desde la base de la " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cámara o del soporte donde" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "se ubica la cámara hasta" &
        " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aproximadamente el centro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del lente de la cámara.")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.ToolStripSeparator1, Me.BtnHelp, Me.ToolStripSeparator2, Me.BtnAcercaDe})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(536, 27)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarCamposToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = Global.CamDist.My.Resources.Resources.list_2389219_640
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(86, 24)
        Me.ToolStripSplitButton1.Text = "Archivo"
        Me.ToolStripSplitButton1.ToolTipText = "Opciones del programa"
        '
        'LimpiarCamposToolStripMenuItem
        '
        Me.LimpiarCamposToolStripMenuItem.Image = Global.CamDist.My.Resources.Resources.garbage
        Me.LimpiarCamposToolStripMenuItem.Name = "LimpiarCamposToolStripMenuItem"
        Me.LimpiarCamposToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.LimpiarCamposToolStripMenuItem.Text = "Limpiar Campos"
        Me.LimpiarCamposToolStripMenuItem.ToolTipText = "Elimina el texto escrito en" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "las cajas de texto y reinicia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "los controles a su es" &
    "tado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "inicial."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.CamDist.My.Resources.Resources.close
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        Me.SalirToolStripMenuItem.ToolTipText = "Cierra el programa."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BtnHelp
        '
        Me.BtnHelp.Image = Global.CamDist.My.Resources.Resources.help
        Me.BtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Size = New System.Drawing.Size(67, 24)
        Me.BtnHelp.Text = "Ayuda"
        Me.BtnHelp.ToolTipText = "Información de elementos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a tener en cuenta."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BtnAcercaDe
        '
        Me.BtnAcercaDe.Image = Global.CamDist.My.Resources.Resources.information_1294813_640
        Me.BtnAcercaDe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAcercaDe.Name = "BtnAcercaDe"
        Me.BtnAcercaDe.Size = New System.Drawing.Size(91, 24)
        Me.BtnAcercaDe.Text = "Acerca de"
        Me.BtnAcercaDe.ToolTipText = "Datos sobre el desarrollador" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y la versión del programa."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingrese la altura o ancho a cubrir, la altura del lente y seleccione una de las " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cámaras disponibles para realizar el cálculo de la distancia para ubicarla."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Altura del lente en cm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(25, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ancho"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(193, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Alto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(341, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Distancia"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(536, 178)
        Me.Controls.Add(Me.NudDist)
        Me.Controls.Add(Me.NudAl)
        Me.Controls.Add(Me.NudAn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NudALL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.CBcam)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CamDist"
        CType(Me.NudALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudAn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudAl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudDist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBcam As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BtnAcercaDe As ToolStripButton
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents LimpiarCamposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BtnHelp As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents NudALL As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NudAn As NumericUpDown
    Friend WithEvents NudAl As NumericUpDown
    Friend WithEvents NudDist As NumericUpDown
End Class
