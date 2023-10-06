Public Class Form1
    Dim time As Integer = 60
    Dim random As Random = New Random()
    Dim clickedButtons As ArrayList = New ArrayList()
    Dim currentEntry As Integer = 0
    Dim currentOperator As Integer = 0
    Dim currentOperand As Integer = 0
    Dim operands As ArrayList = New ArrayList() 'Operand label trackers
    Dim operators As ArrayList = New ArrayList() 'Operator label trackers
    Dim answerOperands As ArrayList = New ArrayList()
    Dim answerOperators As ArrayList = New ArrayList()
    Dim answerTotal As Integer = 0
    Dim userTotal As Integer = 0
    Dim operandBtns As ArrayList = New ArrayList()
    Dim operatorBtns As ArrayList = New ArrayList()
    Dim userScore As Integer = 0

    'Initialize control states
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_time.Text = time

        operands.Add(lbl_operand_1)
        operands.Add(lbl_operand_2)
        operands.Add(lbl_operand_3)
        operands.Add(lbl_operand_4)

        operators.Add(lbl_operator_1)
        operators.Add(lbl_operator_2)
        operators.Add(lbl_operator_3)

        operandBtns.Add(btn_operand_1)
        operandBtns.Add(btn_operand_2)
        operandBtns.Add(btn_operand_3)
        operandBtns.Add(btn_operand_4)

        operatorBtns.Add(btn_operator_1)
        operatorBtns.Add(btn_operator_2)
        operatorBtns.Add(btn_operator_3)
        operatorBtns.Add(btn_operator_4)

        'Disable menu buttons
        btn_borrar.Enabled = False
        btn_borrar_todo.Enabled = False
        btn_siguiente.Enabled = False
        btn_resolver.Enabled = False

        disableInputButtons()

        calculateCpuAnswer()

    End Sub

    'Start game
    Private Sub btn_empezar_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        startGame()
        btn_borrar.Enabled = True
        btn_borrar_todo.Enabled = True
        btn_siguiente.Enabled = False
        btn_resolver.Enabled = True
        Timer.Start()
    End Sub

    'Add time if the user answers correctly
    Private Sub addTime()
        time += 15 ' +15 seconds by default
    End Sub

    'Change remaining time color depending on how much time is left
    Private Sub changeTimeColor()
        If (time > 30) Then
            lbl_time.ForeColor = Color.FromName("Green")
        ElseIf (time <= 30 And time > 10) Then
            lbl_time.ForeColor = Color.FromArgb(255, 128, 0)
        ElseIf (time <= 10) Then
            lbl_time.ForeColor = Color.FromName("Red")
        End If
    End Sub

    'Countdown timer, starts at 60 by default
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        checkControls()
        If (time > 0) Then
            time -= 1
            lbl_time.Text = time
            changeTimeColor()
        End If
    End Sub

    Private Sub btn_resolver_Click(sender As Object, e As EventArgs) Handles btn_resolver.Click
        verifyUserAnswer()
    End Sub

    'Sets up a new game
    Private Sub startGame()
        checkControls()
    End Sub

    'Get all buttons in the form
    Private Function getAllControls(control As Control) As IEnumerable(Of Control)
        Dim controls = control.Controls.Cast(Of Control)()
        Return controls.SelectMany(Function(ctrl) getAllControls(ctrl)).Concat(controls)
    End Function

    'Check which buttons have been clicked and disable them. Toggles operands/operators
    Private Sub checkControls()
        Dim buttons = Me.getAllControls(Me).OfType(Of Button)().ToList()
        If currentEntry Mod 2 = 0 And Not currentEntry >= 7 Then
            disableOperators()
            enableOperands()
        Else
            enableOperators()
            disableOperands()
        End If
    End Sub

    'Track which operand button is clicked and disable it
    Private Sub recordOperandAnswer(button As Button)
        button.Tag = "Clicked"
        recordAction(button)
        checkControls()
    End Sub

    Private Sub recordOperatorAnswer(button As Button)
        recordAction(button)
        checkControls()
    End Sub

    'Record clicked buttons to be able to undo actions
    Private Sub recordAction(control As Control)
        clickedButtons.Add(control)
    End Sub

    'Delete the last input  
    Private Sub delete(sender As Object, e As EventArgs) Handles btn_borrar.Click
        If (clickedButtons.Count > 0) Then
            If (currentEntry Mod 2 = 1) Then 'If last input was operand delete it

                operands.Item(currentOperand - 1).Text = " " 'Delete the last operand

                If currentOperand > 0 Then
                    currentOperand -= 1
                End If

                clickedButtons.Item(clickedButtons.Count - 1).Tag = " "
                clickedButtons.RemoveAt(clickedButtons.Count - 1)
                checkControls()
            Else
                operators.Item(currentOperator - 1).Text = " " 'Delete the last operator

                If currentOperator > 0 Then
                    currentOperator -= 1
                End If

                clickedButtons.RemoveAt(clickedButtons.Count - 1)

            End If
        End If

        If currentEntry > 0 Then
            currentEntry -= 1 'Go back to the last entry position
        End If

        calculateUserInput()
        checkControls()
    End Sub

    'Delete all inputs
    Private Sub deleteAll() Handles btn_borrar_todo.Click
        Dim buttons = Me.getAllControls(Me).OfType(Of Button)().ToList()
        If (clickedButtons.Count > 0) Then
            clickedButtons.Clear()
            For Each button As Button In buttons
                If button.Tag.Equals("Clicked") Then
                    button.Tag = ""
                End If
            Next
        End If
        currentOperand = 0
        currentOperator = 0
        currentEntry = 0

        For Each operand As Label In operands
            operand.Text = " "
        Next

        For Each oper As Label In operators
            oper.Text = " "
        Next

        calculateUserInput()
        checkControls()
    End Sub

    Private Sub disableButtons()
        ' Deshabilita los botones de operandos
        For Each btn In operandBtns
            btn.Enabled = False
        Next

        ' Deshabilita los botones de operadores
        For Each btn In operatorBtns
            btn.Enabled = False
        Next

    End Sub

    'Track the answers the users give, load operator or operand arrays respectively
    Private Sub inputEntry(sender As Button)
        If currentEntry Mod 2 = 0 And currentEntry < 7 Then ' Si currentEntry es par, se están respondiendo operandos
            If currentOperand < operands.Count Then
                operands(currentOperand).Text = sender.Text
                currentOperand += 1
            End If
        Else
            If currentOperator < operators.Count Then
                operators(currentOperator).Text = sender.Text
                currentOperator += 1
            End If
        End If

        If currentEntry < 7 Then
            currentEntry += 1
            checkControls()
        End If

        If currentEntry < 7 Then
            disableInputButtons()
            ' Deshabilita los botones aquí cuando se llenan todos los espacios de los labels.
            disableButtons() ' Implementa esta función según tu necesidad.
        End If

        calculateUserInput()
    End Sub

    'Record operator answers
    Private Sub AnswerOperator(sender As Object, e As EventArgs) Handles btn_operator_1.Click, btn_operator_2.Click, btn_operator_3.Click, btn_operator_4.Click
        recordOperatorAnswer(sender)
        inputEntry(sender)
    End Sub

    'Record operand answers
    Private Sub AnswerOperand(sender As Object, e As EventArgs) Handles btn_operand_1.Click, btn_operand_2.Click, btn_operand_3.Click, btn_operand_4.Click
        recordOperandAnswer(sender)
        inputEntry(sender)
    End Sub

    'Disables all user input buttons
    Private Sub disableInputButtons()
        Dim buttons = Me.getAllControls(Me).OfType(Of Button)().ToList()
        For Each button As Button In buttons
            If Not button.Tag.Equals("Menu_btn") Then
                button.Enabled = False
            End If
        Next
    End Sub

    'Disables all operators
    Private Sub disableOperators()
        Dim buttons = Me.getAllControls(Me).OfType(Of Button)().ToList()
        For Each button As Button In buttons
            If button.Tag.Equals("Operator") Then
                button.Enabled = False
            End If
        Next
    End Sub

    'Enables all operators
    Private Sub enableOperators()
        Dim buttons = Me.getAllControls(Me).OfType(Of Button)().ToList()
        For Each button As Button In buttons
            If button.Tag.Equals("Operator") Then
                button.Enabled = True
            End If
        Next
    End Sub

    'Disables all operands
    Private Sub disableOperands()
        btn_operand_1.Enabled = False
        btn_operand_2.Enabled = False
        btn_operand_3.Enabled = False
        btn_operand_4.Enabled = False
    End Sub

    'Enables operands that haven't been clicked
    Private Sub enableOperands()
        If Not btn_operand_1.Tag = "Clicked" Then
            btn_operand_1.Enabled = True
        End If

        If Not btn_operand_2.Tag = "Clicked" Then
            btn_operand_2.Enabled = True
        End If

        If Not btn_operand_3.Tag = "Clicked" Then
            btn_operand_3.Enabled = True
        End If

        If Not btn_operand_4.Tag = "Clicked" Then
            btn_operand_4.Enabled = True
        End If
    End Sub

    'Calculates the real answer
    Private Sub calculateCpuAnswer()
        Dim total As Integer = 0

        'Loads the answer operands array
        For index = 1 To 4 Step 1
            Dim operand As Integer = random.Next(1, 9)
            answerOperands.Add(operand)
        Next

        'Loads the answer operators arrays
        For index = 1 To 3 Step 1
            Dim o = random.Next(1, 4)
            Dim operat As String = ""

            Select Case o
                Case 1
                    operat = "+"
                Case 2
                    operat = "-"
                Case 3
                    operat = "*"
                Case 4
                    operat = "/"
            End Select
            answerOperators.Add(operat)
        Next

        For index = 0 To answerOperands.Count - 1 Step 1
            If index = 0 Then 'If positioned in first answer operand
                total = answerOperands.Item(index)
            End If

            If index < 3 Then 'Make sure the right operators are chosen
                Select Case answerOperators.Item(index) 'Perform operation with next operand in array
                    Case "+"
                        total += answerOperands.Item(index + 1)
                    Case "-"
                        total -= answerOperands.Item(index + 1)
                    Case "*"
                        total *= answerOperands.Item(index + 1)
                    Case "/"
                        total /= answerOperands.Item(index + 1)
                End Select
            End If
        Next

        answerTotal = total

        setLabelValues()

    End Sub

    'Sets random number values to operand btn text
    Private Sub setLabelValues()

        Dim loadedIndexes = New ArrayList()

        'Load operand button text with random answer numbers
        For Each button In operandBtns

            Dim randomIndex = random.Next(0, answerOperands.Count)

            While loadedIndexes.Contains(randomIndex)
                randomIndex = random.Next(0, answerOperands.Count)
            End While

            loadedIndexes.Add(randomIndex)
            Dim value = answerOperands.Item(randomIndex)
            button.Text = value
        Next

        lbl_answer.Text = answerTotal

    End Sub

    Private Sub btn_siguiente_Click(sender As Object, e As EventArgs) Handles btn_siguiente.Click
        resetGame()
    End Sub

    Private Sub resetGame()
        deleteAll()
        answerOperands.Clear()
        answerOperators.Clear()
        checkControls()
        operands.Clear()
        operators.Clear()
        calculateUserInput()
        calculateCpuAnswer()
    End Sub

    'Calculates the user's current answer
    Private Sub calculateUserInput()
        'Loads the answer operators arrays

        Dim answTotal As Integer = 0

        For index = 0 To operands.Count - 1 Step 1
            If index = 0 Then 'If positioned in first answer operand
                answTotal = Val(operands.Item(index).Text)
            End If

            If index < operators.Count Then 'Make sure the right operators are chosen
                Select Case operators.Item(index).Text 'Perform operation with next operand in array
                    Case "+"
                        answTotal += Val(operands.Item(index + 1).Text)
                    Case "-"
                        answTotal -= Val(operands.Item(index + 1).Text)
                    Case "*"
                        answTotal *= Val(operands.Item(index + 1).Text)
                    Case "/"
                        If Not Val(operands.Item(index + 1).Text) = 0 Then
                            answTotal /= Val(operands.Item(index + 1).Text)
                        End If
                End Select
            End If
        Next

        userTotal = answTotal
        lbl_user_answer.Text = answTotal
    End Sub

    Private Sub verifyUserAnswer()
        If userTotal = answerTotal Then
            btn_siguiente.Enabled = True
            addTime()
            userScore += 1
            lbl_solved.Text = userScore
        End If
    End Sub

End Class
