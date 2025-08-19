Module m_set

    Sub set_hinichi_cbx(frm_no As Integer)

        Dim nen = ""
        Dim tsuki = ""

        Select Case frm_no
            Case 0
                Dim frm = frmnouhinsho_rireki
                frm.cbx_hi.Items.Clear()
                nen = frm.cbx_nen.Text
                tsuki = frm.cbx_tsuki.Text
            Case 1
                Dim frm = frmseikyuusho_hakkou_insatsu
                frm.cbx_hi.Items.Clear()
                nen = frm.cbx_nen.Text
                tsuki = frm.cbx_tsuki.Text
            Case Else
                msg_go("フォームNoが不正です。")
                Exit Sub
        End Select

        If nen = "" Or tsuki = "" Then
            Exit Sub
        End If

        Dim nissuu = get_tsuki_saishuubi(nen, tsuki)
        For i = 1 To CInt(nissuu)
            Select Case frm_no
                Case 0
                    frmnouhinsho_rireki.cbx_hi.Items.Add(i.ToString("D2"))
                Case 1
                    frmseikyuusho_hakkou_insatsu.cbx_hi.Items.Add(i.ToString("D2"))
            End Select

        Next

    End Sub

End Module
