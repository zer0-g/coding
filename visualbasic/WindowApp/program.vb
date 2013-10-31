Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace WindowsFormsApplication

    Module Program
    
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(false)
            Application.Run(New HelloWorld())
        End Sub
    
    End Module
    
End Namespace
