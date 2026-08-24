<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ListBox1 = New ListBox()
        ProgressBar1 = New ProgressBar()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.White
        ListBox1.ForeColor = Color.Red
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(13, 79)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(795, 184)
        ListBox1.TabIndex = 0
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(14, 282)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(794, 45)
        ProgressBar1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(26, 383)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 61)
        Button1.TabIndex = 2
        Button1.Text = "Scan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(324, 383)
        Button2.Name = "Button2"
        Button2.Size = New Size(154, 61)
        Button2.TabIndex = 3
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(623, 383)
        Button3.Name = "Button3"
        Button3.Size = New Size(154, 61)
        Button3.TabIndex = 4
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Lime
        Label2.Location = New Point(482, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 6
        Label2.Text = "Label2"
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        ClientSize = New Size(820, 498)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ProgressBar1)
        Controls.Add(ListBox1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "B2D Antivirus Security"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer

End Class
