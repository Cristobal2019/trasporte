


Public Class Form1
    Private Sub TRASPORTEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TRASPORTEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TRASPORTEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ELIADataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ELIADataSet.TRASPORTE' Puede moverla o quitarla según sea necesario.
        Me.TRASPORTETableAdapter.Fill(Me.ELIADataSet.TRASPORTE)
        Clearfull()

    End Sub

    Private Sub ButtonAGREGAR_Click(sender As Object, e As EventArgs) Handles ButtonAGREGAR.Click
        Try
            Me.TRASPORTETableAdapter.InsertQuery(IDTextBox.Text, FACTURATextBox.Text, CLIENTETextBox.Text, TRASPORTEComboBox.SelectedItem, PROCEDENCIAComboBox.SelectedItem, TERMINALComboBox.SelectedItem, FECHADateTimePicker.Value, BULTOTextBox.Text, PRECIOTextBox.Text, DESTINOTextBox1.Text)
            Me.TRASPORTETableAdapter.Fill(Me.ELIADataSet.TRASPORTE)
            Clearfull()
        Catch ex As Exception
            MsgBox("Favor llenar todos los datos o su Factura esta registrada-")
        End Try

    End Sub

    Private Sub ButtonELIMINAR_Click(sender As Object, e As EventArgs) Handles ButtonELIMINAR.Click

        If FACTURATextBox.Text = "" Then
            MsgBox("Favor ingrese el numero de Factura")

        Else
            Select Case MsgBox("Desea Eliminar", MsgBoxStyle.YesNo, "HOLA")
                Case MsgBoxResult.Yes
                    Me.TRASPORTETableAdapter.DeleteQuery(FACTURATextBox.Text)
                    Me.TRASPORTETableAdapter.Fill(Me.ELIADataSet.TRASPORTE)
                    Clearfull()
                Case MsgBoxResult.No
            End Select


            Me.TRASPORTETableAdapter.DeleteQuery(FACTURATextBox.Text)
            Me.TRASPORTETableAdapter.Fill(Me.ELIADataSet.TRASPORTE)
            Clearfull()

        End If


    End Sub

    Private Sub ButtonVER_Click(sender As Object, e As EventArgs) Handles ButtonVER.Click
        Me.TRASPORTETableAdapter.Fill(Me.ELIADataSet.TRASPORTE)
    End Sub

    Private Sub ButtonBUSCAR_Click(sender As Object, e As EventArgs) Handles ButtonBUSCAR.Click
        If FACTURATextBox.Text = "" Then
            MsgBox("Favor ingresar la Factura")
        Else
            Me.TRASPORTETableAdapter.SEARCH(ELIADataSet.TRASPORTE, FACTURATextBox.Text)
            Clearfull()
        End If
    End Sub

    Private Sub PRECIOTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Favor ingresar Numero")
        End If


    End Sub

    Private Sub BULTOTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Favor ingresar Numero")
        End If
    End Sub

    Private Sub FACTURATextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("favor ingresa numero")
        End If
    End Sub

    Private Sub ButtonIMPRIMIR_Click(sender As Object, e As EventArgs) Handles ButtonIMPRIMIR.Click
        Form2.Show()
    End Sub
    Private Function Clearfull() As String
        IDTextBox.Text = ""
        FACTURATextBox.Text = ""
        PRECIOTextBox.Text = ""
        BULTOTextBox.Text = ""
        TRASPORTEComboBox.SelectedIndex = -1
        PROCEDENCIAComboBox.SelectedIndex = -1
        TERMINALComboBox.SelectedIndex = -1
        CLIENTETextBox.Text = ""
        DESTINOTextBox1.Text = ""

        Return IDTextBox.Text = ""
    End Function

    Private Sub Buttonlimpiar_Click(sender As Object, e As EventArgs) Handles Buttonlimpiar.Click
        Clearfull()
    End Sub

    Private Sub ButtonSALIR_Click(sender As Object, e As EventArgs) Handles ButtonSALIR.Click
        Close()
    End Sub
End Class
