Public Class Form1

    Private pl As Liconcomp.Player

    Private anzahlBanden As Integer = 5
    Private anzahlVideos As Integer = 5
    Private anzahlPlaylists As Integer = 0
    Private anzahlPlaylistElemente(100) As Integer

    Private myVideo(5, 5) As Liconcomp.VideoFile
    Private myVideoFilenames(100) As String

    Private myPlaylistFilenames(100) As String
    Private myPlaylistContents(100, 100) As String

    Private loc(5) As Liconcomp.VectorMovement
    Private vidWidth(5) As Long
    Private vidHeight(5) As Long

    Private vpactive(5) As Integer
    Private vplActive(5) As Integer
    Private vplVideo(5) As Integer

    Private plVideos(5) As Liconcomp.VideoFile

    Private lText(5) As Liconcomp.SimpleText
    Private locT(5) As Liconcomp.VectorMovement

    Private lTtext(5) As String

    Private controlLocation(5) As Boolean

    ' Gibt an, ob die Videos schon einmal aus dem 
    ' Verzeichnis eingelesen wurden. 
    Private videosGeladen As Boolean = False

    ' Gibt das Verzeichnis an, in dem die zu ladenden Video- 
    ' und Playlist-Dateien abgelegt sind.
    Private videoPfad

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Bedienfenster unten rechts auf dem Bildschirm positionieren
        Dim ra As Rectangle = My.Computer.Screen.WorkingArea
        Me.Left = ra.Width - Me.Width
        Me.Top = ra.Height - Me.Height

        ' Video-Pfad festlegen
        videoPfad = Application.StartupPath

        ' Verzeichnis "movies" auslesen
        If videoPfad.EndsWith("\") And videoPfad.Length > 3 Then
            videoPfad += "movie"
        Else
            videoPfad += "\movie"
        End If

        ' Player-Fenster starten/oeffnen
        Try
            initPlayer()
        Catch ex As Exception
            MsgBox("Der Player konnte nicht initialisiert werden. Sie koennen die Bedienoberflaeche ansehen, aber eine Darstellung von Videos / Texten ist nicht moeglich.")
        End Try
    End Sub

    Private Sub initPlayer()
        Try
            ' Ausgabefeld oeffnen / Player initialisieren
            pl = New Liconcomp.Player()

            vidWidth(1) = 768
            vidWidth(2) = 768
            vidWidth(3) = 768
            vidWidth(4) = 768
            vidWidth(5) = 768

            initTexts()
        Catch ex As Exception
            MsgBox("Fehler beim Initialisieren. Ist Liconcomp korrekt installiert? " + ex.ToString())
        End Try
    End Sub

    Private Sub initTexts()
        Try
            For i = 1 To anzahlBanden
                lText(i) = pl.CreateSimpleText
                lText(i).zIndex = 50
                locT(i) = New Liconcomp.VectorMovement
                lText(i).Movement = locT(i)
                lTtext(i) = ""
                lText(i).Text = lTtext(i)
            Next i
        Catch ex As Exception
            MsgBox("Fehler beim Initialisieren der Texte. " + ex.ToString())
        End Try
    End Sub

    Private Sub loadPlaylists()
        Dim oDir As New System.IO.DirectoryInfo(videoPfad)
        Dim oFiles As System.IO.FileInfo() = oDir.GetFiles()

        ' Datei-Array durchlaufen und in 
        ' ListBox übertragen
        Dim oFile As System.IO.FileInfo
        ListBox2.Items.Clear()
        Dim i As Integer = 0

        For Each oFile In oFiles
            If (i < 100) Then
                If oFile.Name.Length > 5 And oFile.Name.Substring(oFile.Name.Length - 3).ToLower = "txt" Then
                    i += 1
                    ListBox2.Items.Add(oFile.Name.Substring(0, oFile.Name.Length - 3))
                    myPlaylistFilenames(i) = New String(videoPfad + "\" + oFile.Name)
                End If
            End If
        Next
        anzahlPlaylists = i
        'ReDim Preserve myPlaylistContents(anzahlPlaylists, 100)
        Dim fs As System.IO.FileStream
        Dim r As IO.StreamReader
        Dim j As Integer = 1
        For i = 1 To anzahlPlaylists
            fs = New System.IO.FileStream(myPlaylistFilenames(i), IO.FileMode.OpenOrCreate, IO.FileAccess.Read)
            r = New IO.StreamReader(fs)
            r.BaseStream.Seek(0, IO.SeekOrigin.Begin)
            j = 0
            While r.Peek() > -1 And j < 100
                j += 1
                myPlaylistContents(i, j) = r.ReadLine()
            End While
            anzahlPlaylistElemente(i) = j

            ' --- Reader und Stream schließen
            r.Close()
            fs.Close()
        Next i
    End Sub

    Private Sub loadVideos()
        ' Die Videos aus dem Videoverzeichnis werden 
        ' vollständig vorgeladen.
        ' Vorteil: Alle Videos liegen fuer den Sofortstart bereit.
        ' Nachteil: Das Laden dauert recht lange.
        If videosGeladen = False Then
            ' Mauscursor in den Wartezustand versetzen
            Me.Cursor = Cursors.WaitCursor

            ' Fortschrittsanzeige anstelle des Startbuttons anzeigen
            Button8.Visible = False
            ProgressBar1.Visible = True

            ' Der Video-Ordner darf vom User ausgewaehlt werden.
            FolderBrowserDialog1.SelectedPath = videoPfad
            FolderBrowserDialog1.ShowDialog()
            videoPfad = FolderBrowserDialog1.SelectedPath

            Try

                Dim oDir As New System.IO.DirectoryInfo(videoPfad)
                Dim oFiles As System.IO.FileInfo() = oDir.GetFiles()

                ' Datei-Array durchlaufen und in 
                ' ListBox übertragen
                Dim oFile As System.IO.FileInfo
                ListBox1.Items.Clear()
                Dim i As Integer = 0

                For Each oFile In oFiles
                    If (i < 100) Then
                        If oFile.Name.Length > 5 And oFile.Name.Substring(oFile.Name.Length - 3).ToLower = "avi" Then
                            i += 1
                            ListBox1.Items.Add(oFile.Name)
                            myVideoFilenames(i) = New String(videoPfad + "\" + oFile.Name)
                        End If
                    End If
                Next
                anzahlVideos = i
                ReDim Preserve myVideo(anzahlBanden, anzahlVideos)


                For i = 1 To anzahlBanden
                    vidHeight(i) = 72
                Next

                ' Nachdem feststeht, um welche Videos es geht,
                ' werden diese auf jede Bandenflaeche einzeln 
                ' geladen. 
                Dim progress As Integer = 0
                Dim zaehler As Integer = 0
                For i = 1 To anzahlBanden
                    ' Positionieren der Anzeigeflaechen
                    loc(i) = New Liconcomp.VectorMovement
                    loc(i).SetX(My.Settings("Bande" + i.ToString + "Left"))
                    loc(i).SetY(My.Settings("Bande" + i.ToString + "Top"))

                    For j = 1 To anzahlVideos
                        zaehler += 1

                        ' Das Laden dauert je nach Anzahl der Videos ziemlich lange.
                        ' Deshalb Ladefortschritt anzeigen.
                        ProgressBar1.Value = zaehler / (anzahlVideos * anzahlBanden) * 100
                        Me.Update()

                        ' Videoobjekt erstellen
                        myVideo(i, j) = pl.CreateVideoFromFile(myVideoFilenames(j))
                        myVideo(i, j).Movement = loc(i)
                        myVideo(i, j).zIndex = 110 + j
                        myVideo(i, j).Visible = False
                    Next j
                Next i

                ' Timer aktivieren, der fuer die Wiederholung von Texten
                ' zustaendig ist
                Timer1.Enabled = True

                ' Verhindern, dass die Videos noch einmal
                ' geladen werden
                videosGeladen = True

            Catch ex As Exception
                MsgBox("Fehler beim Laden der Videos: " + ex.ToString)
            End Try

            ' Mauscursor wieder in den Normalzustand versetzen.
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        loadVideos()
    End Sub

    Private Sub startVideo(ByVal videonr As Integer)
        Try
            Dim einschalten As Integer = videonr
            Dim ausschalten As Integer = 0
            Dim sync As Liconcomp.Sync = New Liconcomp.Sync
            For i = 1 To anzahlBanden
                If controlLocation(i) = True Then
                    ausschalten = vpactive(i)
                    ' neue Videos starten
                    'myVideo(i, einschalten).Play()
                    sync.Add(myVideo(i, einschalten))
                    myVideo(i, einschalten).Visible = True

                    ' die anderen anhalten und verstecken
                    If ausschalten > 0 And ausschalten <> einschalten Then
                        myVideo(i, ausschalten).Visible = False
                        myVideo(i, ausschalten).Stop()
                    End If
                    vpactive(i) = einschalten
                End If
            Next i
            sync.Play()
        Catch ex As Exception
            MsgBox("Fehler beim Umschalten der Videos: " + ex.ToString)
        End Try
    End Sub

    Private Sub videoPlay()
        ' Startet die Videos auf allen selektierten Darstellungsflaechen
        Dim sync As Liconcomp.Sync = New Liconcomp.Sync
        For i = 1 To anzahlBanden
            If controlLocation(i) = True Then
                'myVideo(i, vpactive(i)).Play()
                sync.Add(myVideo(i, vpactive(i)))
            End If
        Next i
        sync.Play()
    End Sub

    Private Sub changeVideoWidth(ByVal newWidth As Long)
        ' Aendert die Breite aller selektierten Darstellungsflaechen
        For i = 1 To anzahlBanden
            If controlLocation(i) = True Then
                vidWidth(i) = newWidth
            End If
        Next i
    End Sub

    Private Sub changeVideoHeight(ByVal newHeight As Long)
        ' Aendert die Hoehe aller selektierten Darstellungsflaechen
        For i = 1 To anzahlBanden
            If controlLocation(i) = True Then
                vidHeight(i) = newHeight
            End If
        Next i
    End Sub

    Private Sub videoHide()
        ' Versteckt das Video auf allen selektierten Darstellungsflaechen
        For i = 1 To anzahlBanden
            If controlLocation(i) = True Then
                myVideo(i, vpactive(i)).Visible = False
                myVideo(i, vpactive(i)).Stop()
            End If
        Next i
    End Sub

    Private Sub videoStop()
        ' Haelt das Video auf allen selektierten Darstellungsflaechen an
        For i = 1 To anzahlBanden
            If controlLocation(i) = True Then
                myVideo(i, vpactive(i)).Stop()
            End If
        Next i
    End Sub

    Private Sub videoPause()
        ' Pausiert das Video auf allen selektierten Darstellungsflaechen
        For i = 1 To anzahlBanden
            If controlLocation(i) = True Then
                myVideo(i, vpactive(i)).Pause()
            End If
        Next i
    End Sub

    Private Sub changeVideoXPos(ByVal newpos As Long)
        ' Aendert die X-Position aller selektierten Darstellungsflaechen
        Try
            For i = 1 To anzahlBanden
                If controlLocation(i) = True Then
                    loc(i).SetX(newpos)
                    My.Settings("Bande" + i.ToString + "Left") = newpos
                End If
            Next i
        Catch ex As Exception
            MsgBox("Fehler beim Verschieben des Videos (X): " + ex.ToString)
        End Try
    End Sub

    Private Sub changeVideoYPos(ByVal newpos As Long)
        ' Aendert die Y-Position aller selektierten Darstellungsflaechen
        Try
            For i = 1 To anzahlBanden
                If controlLocation(i) = True Then
                    loc(i).SetY(newpos)
                    My.Settings("Bande" + i.ToString + "Top") = newpos
                End If
            Next i
        Catch ex As Exception
            MsgBox("Fehler beim Verschieben des Videos (Y): " + ex.ToString)
        End Try
    End Sub

    Private Sub changeVideoLinebreak(ByVal newpos As Long)
        Try
            For i = 1 To anzahlBanden
                If controlLocation(i) = True Then
                    For j = 1 To anzahlVideos
                        myVideo(i, j).LineBreak = newpos
                    Next j
                End If
            Next i
        Catch ex As Exception
            MsgBox("Fehler beim Ändern des Linebreaks: " + ex.ToString)
        End Try
    End Sub

    Private Sub changeVideoOverlap(ByVal newpos As Long)
        ' Aendert fuer alle Banden den Video-Overlap
        Try
            For i = 1 To anzahlBanden
                If controlLocation(i) = True Then
                    For j = 1 To anzahlVideos
                        myVideo(i, j).EndOfLineOverlap = newpos
                    Next j
                End If
            Next i
        Catch ex As Exception
            MsgBox("Fehler beim Ändern des Overlaps: " + ex.ToString)
        End Try
    End Sub

    Private Sub NumericUpDownLAXPos_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownLAXPos.ValueChanged
        changeVideoXPos(NumericUpDownLAXPos.Value)
    End Sub

    Private Sub NumericUpDownLAYpos_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownLAYpos.ValueChanged
        changeVideoYPos(NumericUpDownLAYpos.Value)
    End Sub

    Private Sub NumericUpDownLAbreak_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownLAbreak.ValueChanged
        changeVideoLinebreak(NumericUpDownLAbreak.Value)
    End Sub

    Private Sub NumericUpDownLAoverlap_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownLAoverlap.ValueChanged
        changeVideoOverlap(NumericUpDownLAoverlap.Value)
    End Sub

    Private Sub hideText(ByVal location As Integer)
        Try
            For i = 1 To anzahlBanden
                If controlLocation(i) = True Then
                    lText(i).Visible = False
                End If
            Next i
        Catch ex As Exception
            MsgBox("Fehler beim Verstecken der Texte: " + ex.ToString)
        End Try
    End Sub

    Private Sub changeText(ByVal newtext As String)
        Try
            For i = 1 To anzahlBanden
                If controlLocation(i) = True Then
                    lTtext(i) = newtext
                End If
            Next i
            renewText()
        Catch ex As Exception
            MsgBox("Fehler beim Ändern des Textes: " + ex.ToString)
        End Try
    End Sub

    Private Sub renewText()
        Try
            For i = 1 To anzahlBanden
                If controlLocation(i) = True Then
                    lText(i).Text = lTtext(i)
                    locT(i).SetY(loc(i).GetY + vidHeight(i) / 2 - lText(i).Height / 2)
                    If RadioButtonLAlinks.Checked = True Then
                        locT(i).SetX(loc(i).GetX + 20)
                        locT(i).SetDeltaX(0)
                    ElseIf RadioButtonLAmitte.Checked = True Then
                        locT(i).SetX(loc(i).GetX + vidWidth(i) / 2 - lText(i).Width / 2)
                        locT(i).SetDeltaX(0)
                    ElseIf RadioButtonLArechts.Checked = True Then
                        locT(i).SetX(loc(i).GetX + vidWidth(i) - lText(i).Width - 20)
                        locT(i).SetDeltaX(0)
                    ElseIf RadioButtonLAnrechts.Checked = True Then
                        locT(i).SetX(loc(i).GetX - lText(i).Width - 10)
                        locT(i).SetDeltaX(1)
                    ElseIf RadioButtonLAnlinks.Checked = True Then
                        locT(i).SetX(vidWidth(i) + 10)
                        locT(i).SetDeltaX(-1)
                    End If
                    lText(i).Visible = True

                End If
            Next i
        Catch ex As Exception
            MsgBox("Fehler beim Ändern des Textes: " + ex.ToString)
        End Try
    End Sub

    Private Sub ButtonLATon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLATon.Click
        changeText(TextBoxLAText.Text)
    End Sub

    Private Sub ButtonLAToff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLAToff.Click
        hideText(1)
    End Sub

    Private Sub ButtonLBToff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        hideText(2)
    End Sub

    Private Sub ButtonLLToff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        hideText(0)
    End Sub

    Private Sub setControlLocation(ByVal location As Integer, ByVal onoff As Boolean)
        controlLocation(location) = onoff
    End Sub

    Private Sub CheckBoxB1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxB1.CheckedChanged
        setControlLocation(1, CheckBoxB1.Checked)
    End Sub

    Private Sub CheckBoxB2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxB2.CheckedChanged
        setControlLocation(2, CheckBoxB2.Checked)
    End Sub

    Private Sub CheckBoxB3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxB3.CheckedChanged
        setControlLocation(3, CheckBoxB3.Checked)
    End Sub

    Private Sub CheckBoxB4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxB4.CheckedChanged
        setControlLocation(4, CheckBoxB4.Checked)
    End Sub

    Private Sub CheckBoxB5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxB5.CheckedChanged
        setControlLocation(5, CheckBoxB5.Checked)
    End Sub

    Private Sub BLLV1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        startVideo(1)
    End Sub

    Private Sub BLLpause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLLpause.Click
        videoPause()
    End Sub

    Private Sub BLLplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLLplay.Click
        videoPlay()
    End Sub

    Private Sub ButtonLLvoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLLvoff.Click
        videoHide()
    End Sub

    Private Sub NumericUpDownLAvideowidth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownLAvideowidth.ValueChanged
        changeVideoWidth(NumericUpDownLAvideowidth.Value)
    End Sub

    Private Sub NumericUpDownLAvideoheight_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownLAvideoheight.ValueChanged
        changeVideoHeight(NumericUpDownLAvideoheight.Value)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        startVideo(ListBox1.SelectedIndex + 1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CheckBoxB1.CheckState = CheckState.Checked
        CheckBoxB2.CheckState = CheckState.Checked
        CheckBoxB3.CheckState = CheckState.Checked
        CheckBoxB4.CheckState = CheckState.Checked
        CheckBoxB5.CheckState = CheckState.Checked
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CheckBoxB1.CheckState = CheckState.Unchecked
        CheckBoxB2.CheckState = CheckState.Unchecked
        CheckBoxB3.CheckState = CheckState.Unchecked
        CheckBoxB4.CheckState = CheckState.Unchecked
        CheckBoxB5.CheckState = CheckState.Unchecked
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CheckBoxB1.CheckState = CheckState.Checked
        CheckBoxB2.CheckState = CheckState.Unchecked
        CheckBoxB3.CheckState = CheckState.Unchecked
        CheckBoxB4.CheckState = CheckState.Unchecked
        CheckBoxB5.CheckState = CheckState.Checked
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CheckBoxB1.CheckState = CheckState.Unchecked
        CheckBoxB2.CheckState = CheckState.Checked
        CheckBoxB3.CheckState = CheckState.Checked
        CheckBoxB4.CheckState = CheckState.Checked
        CheckBoxB5.CheckState = CheckState.Unchecked
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            For i = 1 To anzahlBanden
                If locT(i).GetX < loc(i).GetX - 50 - lText(i).Width Then
                    ' links aus dem Bild gefahrene Texte nach rechts schieben
                    locT(i).SetX(loc(i).GetX + vidWidth(i) + 10)
                ElseIf locT(i).GetX > loc(i).GetX + vidWidth(i) + 50 Then
                    ' rechts aus dem Bild gefahrene Texte nach links schieben
                    locT(i).SetX(loc(i).GetX - lText(i).Width - 10)
                End If
            Next i
        Catch ex As Exception
            '            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        loadPlaylists()
    End Sub

    Private Sub startPlaylist(ByVal playlistid)
        Dim sync As Liconcomp.Sync = New Liconcomp.Sync

        For i = 1 To anzahlBanden
            If controlLocation(i) = True Then
                If plVideos(i) IsNot Nothing Then
                    plVideos(i).Remove()
                End If
                plVideos(i) = pl.CreateVideoFromFile(videoPfad + "\" + myPlaylistContents(playlistid, 1))
                plVideos(i).Movement = loc(i)
                plVideos(i).zIndex = 60
                plVideos(i).LoopCount = 1
                sync.Add(plVideos(i))
                plVideos(i).Visible = True
                vplActive(i) = playlistid
                vplVideo(i) = 1
                Select Case i
                    Case 1
                        AddHandler plVideos(i).OnLoopFinished, AddressOf vEnde1
                    Case 2
                        AddHandler plVideos(i).OnLoopFinished, AddressOf vEnde2
                    Case 3
                        AddHandler plVideos(i).OnLoopFinished, AddressOf vEnde3
                    Case 4
                        AddHandler plVideos(i).OnLoopFinished, AddressOf vEnde4
                    Case 5
                        AddHandler plVideos(i).OnLoopFinished, AddressOf vEnde5
                End Select
            End If
        Next
        sync.Play()
    End Sub

    Private Sub vEnde1()
        videozuEnde(1)
    End Sub

    Private Sub vEnde2()
        videozuEnde(2)
    End Sub
    Private Sub vEnde3()
        videozuEnde(3)
    End Sub
    Private Sub vEnde4()
        videozuEnde(4)
    End Sub
    Private Sub vEnde5()
        videozuEnde(5)
    End Sub

    Private Sub videozuEnde(ByVal locnr As Integer)
        Select Case locnr
            Case 1
                RemoveHandler plVideos(locnr).OnLoopFinished, AddressOf vEnde1
            Case 2
                RemoveHandler plVideos(locnr).OnLoopFinished, AddressOf vEnde2
            Case 3
                RemoveHandler plVideos(locnr).OnLoopFinished, AddressOf vEnde3
            Case 4
                RemoveHandler plVideos(locnr).OnLoopFinished, AddressOf vEnde4
            Case 5
                RemoveHandler plVideos(locnr).OnLoopFinished, AddressOf vEnde5
        End Select


        Dim newvideonumber As Integer = vplVideo(locnr) + 1
        If newvideonumber > anzahlPlaylistElemente(vplActive(locnr)) Then
            newvideonumber = 1
        End If

        Dim newfilename As String = videoPfad + "\" + myPlaylistContents(vplActive(locnr), newvideonumber)
        plVideos(locnr).Remove()
        plVideos(locnr) = pl.CreateVideoFromFile(newfilename)
        plVideos(locnr).Movement = loc(locnr)
        plVideos(locnr).zIndex = 60
        plVideos(locnr).LoopCount = 1
        plVideos(locnr).Play()
        plVideos(locnr).Visible = True
        vplVideo(locnr) = newvideonumber
        plVideos(locnr).Play()

        Select Case locnr
            Case 1
                AddHandler plVideos(locnr).OnLoopFinished, AddressOf vEnde1
            Case 2
                AddHandler plVideos(locnr).OnLoopFinished, AddressOf vEnde2
            Case 3
                AddHandler plVideos(locnr).OnLoopFinished, AddressOf vEnde3
            Case 4
                AddHandler plVideos(locnr).OnLoopFinished, AddressOf vEnde4
            Case 5
                AddHandler plVideos(locnr).OnLoopFinished, AddressOf vEnde5
        End Select

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        startPlaylist(ListBox2.SelectedIndex + 1)
    End Sub
End Class
