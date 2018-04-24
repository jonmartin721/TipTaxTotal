<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblTip = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.bttnCalculate = New System.Windows.Forms.Button()
        Me.bttnClear = New System.Windows.Forms.Button()
        Me.bttnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblTipCalculation = New System.Windows.Forms.Label()
        Me.lblTaxCalcutions = New System.Windows.Forms.Label()
        Me.lblTotalCalculations = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(85, 45)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(100, 29)
        Me.lblAmount.TabIndex = 0
        Me.lblAmount.Text = "Amount:"
        '
        'lblTip
        '
        Me.lblTip.AutoSize = True
        Me.lblTip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTip.Location = New System.Drawing.Point(130, 87)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(55, 29)
        Me.lblTip.TabIndex = 1
        Me.lblTip.Text = "Tip:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(126, 138)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(59, 29)
        Me.lblTax.TabIndex = 2
        Me.lblTax.Text = "Tax:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(111, 193)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(74, 29)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total:"
        '
        'bttnCalculate
        '
        Me.bttnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCalculate.Location = New System.Drawing.Point(14, 284)
        Me.bttnCalculate.Name = "bttnCalculate"
        Me.bttnCalculate.Size = New System.Drawing.Size(143, 54)
        Me.bttnCalculate.TabIndex = 4
        Me.bttnCalculate.Text = "Calculate"
        Me.bttnCalculate.UseVisualStyleBackColor = True
        '
        'bttnClear
        '
        Me.bttnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnClear.Location = New System.Drawing.Point(163, 284)
        Me.bttnClear.Name = "bttnClear"
        Me.bttnClear.Size = New System.Drawing.Size(143, 54)
        Me.bttnClear.TabIndex = 5
        Me.bttnClear.Text = "Clear"
        Me.bttnClear.UseVisualStyleBackColor = True
        '
        'bttnExit
        '
        Me.bttnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnExit.Location = New System.Drawing.Point(312, 285)
        Me.bttnExit.Name = "bttnExit"
        Me.bttnExit.Size = New System.Drawing.Size(143, 54)
        Me.bttnExit.TabIndex = 6
        Me.bttnExit.Text = "Exit"
        Me.bttnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 378)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(476, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statusLabel
        '
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(191, 42)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(193, 35)
        Me.txtAmount.TabIndex = 8
        '
        'lblTipCalculation
        '
        Me.lblTipCalculation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTipCalculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipCalculation.Location = New System.Drawing.Point(191, 86)
        Me.lblTipCalculation.Name = "lblTipCalculation"
        Me.lblTipCalculation.Size = New System.Drawing.Size(193, 42)
        Me.lblTipCalculation.TabIndex = 9
        '
        'lblTaxCalcutions
        '
        Me.lblTaxCalcutions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTaxCalcutions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxCalcutions.Location = New System.Drawing.Point(191, 139)
        Me.lblTaxCalcutions.Name = "lblTaxCalcutions"
        Me.lblTaxCalcutions.Size = New System.Drawing.Size(193, 42)
        Me.lblTaxCalcutions.TabIndex = 10
        '
        'lblTotalCalculations
        '
        Me.lblTotalCalculations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCalculations.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCalculations.Location = New System.Drawing.Point(191, 192)
        Me.lblTotalCalculations.Name = "lblTotalCalculations"
        Me.lblTotalCalculations.Size = New System.Drawing.Size(193, 42)
        Me.lblTotalCalculations.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 400)
        Me.Controls.Add(Me.lblTotalCalculations)
        Me.Controls.Add(Me.lblTaxCalcutions)
        Me.Controls.Add(Me.lblTipCalculation)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.bttnExit)
        Me.Controls.Add(Me.bttnClear)
        Me.Controls.Add(Me.bttnCalculate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.lblAmount)
        Me.Name = "Form1"
        Me.Text = "Tip, Tax, and Total Calculator"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAmount As Label
    Friend WithEvents lblTip As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents bttnCalculate As Button
    Friend WithEvents bttnClear As Button
    Friend WithEvents bttnExit As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statusLabel As ToolStripStatusLabel
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblTipCalculation As Label
    Friend WithEvents lblTaxCalcutions As Label
    Friend WithEvents lblTotalCalculations As Label
End Class
