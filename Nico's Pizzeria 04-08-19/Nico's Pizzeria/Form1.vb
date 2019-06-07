Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim danasQty As Integer
        Dim nicosQty As Integer
        Dim veggieQty As Integer
        Dim danasGfQty As Integer
        Dim nicosGfQty As Integer
        Dim veggiesGfQty As Integer
        Dim danasPrice As Double
        Dim nicosPrice As Double
        Dim veggiePrice As Double
        Dim danasTot As Double
        Dim nicosTot As Double
        Dim veggieTot As Double
        Dim totPizzas As Double
        Dim discount As Double
        Dim totTaxes As Double
        Dim subTot As Double
        danasPrice = 11.99
        nicosPrice = 12.99
        veggiePrice = 9.99
        discount = 3.0
        danasQty = 0
        nicosQty = 0
        veggieQty = 0
        danasGfQty = 0
        nicosGfQty = 0
        veggiesGfQty = 0
        Integer.TryParse(TextBox5.Text, danasQty)
        Integer.TryParse(TextBox6.Text, nicosQty)
        Integer.TryParse(TextBox7.Text, veggieQty)
        Integer.TryParse(TextBox8.Text, danasGfQty)
        Integer.TryParse(TextBox9.Text, nicosGfQty)
        Integer.TryParse(TextBox10.Text, veggiesGfQty)
        danasTot = (danasQty * danasPrice)
        nicosTot = (nicosQty * nicosPrice)
        veggieTot = (veggieQty * veggiePrice)
        Select Case True
            Case danasGfQty > 0, nicosGfQty > 0, veggiesGfQty > 0
                danasTot = (danasQty * danasPrice) + ((danasGfQty * 2) + (danasGfQty * danasPrice))
                nicosTot = (nicosQty * nicosPrice) + ((nicosGfQty * 2) + (nicosGfQty * nicosPrice))
                veggieTot = (veggieQty * veggiePrice) + ((veggiesGfQty * 2) + (veggiesGfQty * veggiePrice))
            Case danasGfQty > 0, nicosGfQty > 0
                danasTot = (danasQty * danasPrice) + ((danasGfQty * 2) + (danasGfQty * danasPrice))
                nicosTot = (nicosQty * nicosPrice) + ((nicosGfQty * 2) + (nicosGfQty * nicosPrice))
            Case nicosGfQty > 0, veggiesGfQty > 0
                nicosTot = (nicosQty * nicosPrice) + ((nicosGfQty * 2) + (nicosGfQty * nicosPrice))
                veggieTot = (veggieQty * veggiePrice) + ((veggiesGfQty * 2) + (veggiesGfQty * veggiePrice))
            Case danasGfQty > 0, veggiesGfQty > 0
                danasTot = (danasQty * danasPrice) + ((danasGfQty * 2) + (danasGfQty * danasPrice))
                veggieTot = (veggieQty * veggiePrice) + ((veggiesGfQty * 2) + (veggiesGfQty * veggiePrice))
            Case danasGfQty > 0
                danasTot = (danasQty * danasPrice) + ((danasGfQty * 2) + (danasGfQty * danasPrice))
            Case nicosGfQty > 0
                nicosTot = (nicosQty * nicosPrice) + ((nicosGfQty * 2) + (nicosGfQty * nicosPrice))
            Case veggiesGfQty > 0
                veggieTot = (veggieQty * veggiePrice) + ((veggiesGfQty * 2) + (veggiesGfQty * veggiePrice))
        End Select
        totPizzas = danasTot + nicosTot + veggieTot
        Select Case True
            Case CheckBox5.Checked
                totPizzas = totPizzas - discount
                TextBox1.Text = Format(discount, "$#,###.##")
            Case Else
                TextBox1.Text = Format(0, "$#,###.##")
        End Select
        totTaxes = (totPizzas * 6) / 100
        subTot = totPizzas + totTaxes
        TextBox4.Text = Format(totPizzas, "$#,###.##")
        TextBox2.Text = Format(totTaxes, "$#,###.##")
        TextBox3.Text = Format(subTot, "$#,###.##")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        CheckBox5.Checked = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

End Class
