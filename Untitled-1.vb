Dim myCommand As New OleDb.OleDbCommand("Update check_preautorises set nom = @description, date_paiement = @date_paiement, un = @un, deux = @deux, trois = @trois, quatre = @quatre, cinq = @cinq, six = @six WHERE numero = @numero", myConnection)

Dim myCommand As New OleDb.OleDbCommand("Update check_preautorises set nom = @description, date_paiement = @date_paiement, un = @un, deux = @deux, trois = @trois, quatre = @quatre, cinq = @cinq, six = @six WHERE numero = @numero", myConnection)
                myCommand.Parameters.AddWithValue("@description", ComboBox1.SelectedValue)
                myCommand.Parameters.AddWithValue("@date_paiement", DateTimePicker1.Value.ToString())

                'TODO modifier la six (update)
                Select Case nbr
                    Case 1 To 6
                        myCommand.Parameters.AddWithValue("@un", TextBox3.Text)
                        myCommand.Parameters.AddWithValue("@deux", 0)
                        myCommand.Parameters.AddWithValue("@trois", 0)
                        myCommand.Parameters.AddWithValue("@quatre", 0)
                        myCommand.Parameters.AddWithValue("@cinq", 0)
                        myCommand.Parameters.AddWithValue("@six", 0)
                    Case 7 To 13
                        myCommand.Parameters.AddWithValue("@un", 0)
                        myCommand.Parameters.AddWithValue("@deux", TextBox3.Text)
                        myCommand.Parameters.AddWithValue("@trois", 0)
                        myCommand.Parameters.AddWithValue("@quatre", 0)
                        myCommand.Parameters.AddWithValue("@cinq", 0)
                        myCommand.Parameters.AddWithValue("@six", 0)
                    Case 14 To 20
                        myCommand.Parameters.AddWithValue("@un", 0)
                        myCommand.Parameters.AddWithValue("@deux", 0)
                        myCommand.Parameters.AddWithValue("@trois", TextBox3.Text)
                        myCommand.Parameters.AddWithValue("@quatre", 0)
                        myCommand.Parameters.AddWithValue("@cinq", 0)
                        myCommand.Parameters.AddWithValue("@six", 0)
                    Case 21 To 27
                        myCommand.Parameters.AddWithValue("@un", 0)
                        myCommand.Parameters.AddWithValue("@deux", 0)
                        myCommand.Parameters.AddWithValue("@trois", 0)
                        myCommand.Parameters.AddWithValue("@quatre", TextBox3.Text)
                        myCommand.Parameters.AddWithValue("@cinq", 0)
                        myCommand.Parameters.AddWithValue("@six", 0)
                    Case 28 To 30
                        myCommand.Parameters.AddWithValue("@un", 0)
                        myCommand.Parameters.AddWithValue("@deux", 0)
                        myCommand.Parameters.AddWithValue("@trois", 0)
                        myCommand.Parameters.AddWithValue("@quatre", 0)
                        myCommand.Parameters.AddWithValue("@cinq", TextBox3.Text)
                        myCommand.Parameters.AddWithValue("@six", 0)
                    Case Else
                        myCommand.Parameters.AddWithValue("@un", 0)
                        myCommand.Parameters.AddWithValue("@deux", 0)
                        myCommand.Parameters.AddWithValue("@trois", 0)
                        myCommand.Parameters.AddWithValue("@quatre", 0)
                        myCommand.Parameters.AddWithValue("@cinq", 0)
                        myCommand.Parameters.AddWithValue("@six", TextBox3.Text)

                End Select

                Dim newValueConverted As Integer = Val(num_preautorise)

                myCommand.Parameters.AddWithValue("@numero", newValueConverted)

                myCommand.ExecuteNonQuery()

                myCommand.Dispose()
                myConnection.Close()
