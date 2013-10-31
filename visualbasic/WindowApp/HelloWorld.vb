Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsFormsApplication

    Public Class HelloWorld 
        Inherits Form
    
        Friend WithEvents btnClickMe As System.Windows.Forms.Button
        Friend lblHello As System.Windows.Forms.Label
        
        Public Sub New()
            ' Setup the Form
            InitializeComponent()
        End Sub
        
        Private Sub btnClickMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClickMe.Click
            lblHello.Text = "Hello World from Compilr!"
        End Sub

        ''' <summary>
        ''' TODO: Setup all Form children here. Or do these things directly in the constructor.
        ''' </summary>
        Private Sub InitializeComponent()
            ' Initialize form objects here like:
            btnClickMe = new System.Windows.Forms.Button()
            lblHello = new System.Windows.Forms.Label()
            
            me.SuspendLayout()
            ' Set the properties of the form elements, such as Size and Location
            ' 
            ' btnClickMe
            ' 
            btnClickMe.Location = new System.Drawing.Point(52, 36)
            btnClickMe.Name = "btnClickMe"
            btnClickMe.Size = new System.Drawing.Size(75, 23)
            btnClickMe.TabIndex = 0
            btnClickMe.Text = "Button"
            btnClickMe.UseVisualStyleBackColor = true
            ' 
            ' lblHello
            ' 
            lblHello.AutoSize = true
            lblHello.Location = new System.Drawing.Point(12, 9)
            lblHello.Name = "lblHello"
            lblHello.Size = new System.Drawing.Size(84, 13)
            lblHello.TabIndex = 1
            lblHello.Text = "Click the button."
            ' 
            ' HelloWorld Form
            ' 
            me.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F)
            me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            me.ClientSize = new System.Drawing.Size(183, 71)
            me.Controls.Add(lblHello)
            me.Controls.Add(btnClickMe)
            me.Name = "HelloWorld"
            me.Text = "Hello World"
            
            ' Finally Resume and preform the Layout process as described by the properties we set above
            me.ResumeLayout(false)
            me.PerformLayout()
        End Sub
        
    End Class
    
End Namespace