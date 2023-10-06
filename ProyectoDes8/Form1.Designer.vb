<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn_operator_1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_operator_2 = New System.Windows.Forms.Button()
        Me.btn_operator_3 = New System.Windows.Forms.Button()
        Me.btn_operator_4 = New System.Windows.Forms.Button()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.lbl_operand_1 = New System.Windows.Forms.Label()
        Me.lbl_operator_1 = New System.Windows.Forms.Label()
        Me.lbl_operator_2 = New System.Windows.Forms.Label()
        Me.lbl_operand_2 = New System.Windows.Forms.Label()
        Me.lbl_answer = New System.Windows.Forms.Label()
        Me.lbl_operand_4 = New System.Windows.Forms.Label()
        Me.lbl_operator_3 = New System.Windows.Forms.Label()
        Me.lbl_operand_3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_inicio = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.btn_resolver = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_siguiente = New System.Windows.Forms.Button()
        Me.btn_borrar_todo = New System.Windows.Forms.Button()
        Me.lbl_user_answer = New System.Windows.Forms.Label()
        Me.btn_operand_4 = New System.Windows.Forms.Button()
        Me.btn_operand_2 = New System.Windows.Forms.Button()
        Me.btn_operand_1 = New System.Windows.Forms.Button()
        Me.btn_operand_3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_solved = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_operator_1
        '
        Me.btn_operator_1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_operator_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_operator_1.Location = New System.Drawing.Point(689, 390)
        Me.btn_operator_1.Name = "btn_operator_1"
        Me.btn_operator_1.Size = New System.Drawing.Size(50, 50)
        Me.btn_operator_1.TabIndex = 0
        Me.btn_operator_1.Tag = "Operator"
        Me.btn_operator_1.Text = "+"
        Me.btn_operator_1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(1134, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tiempo restante:"
        '
        'btn_operator_2
        '
        Me.btn_operator_2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_operator_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_operator_2.Location = New System.Drawing.Point(770, 390)
        Me.btn_operator_2.Name = "btn_operator_2"
        Me.btn_operator_2.Size = New System.Drawing.Size(50, 50)
        Me.btn_operator_2.TabIndex = 9
        Me.btn_operator_2.Tag = "Operator"
        Me.btn_operator_2.Text = "-"
        Me.btn_operator_2.UseVisualStyleBackColor = False
        '
        'btn_operator_3
        '
        Me.btn_operator_3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_operator_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_operator_3.Location = New System.Drawing.Point(851, 390)
        Me.btn_operator_3.Name = "btn_operator_3"
        Me.btn_operator_3.Size = New System.Drawing.Size(50, 50)
        Me.btn_operator_3.TabIndex = 10
        Me.btn_operator_3.Tag = "Operator"
        Me.btn_operator_3.Text = "*"
        Me.btn_operator_3.UseVisualStyleBackColor = False
        '
        'btn_operator_4
        '
        Me.btn_operator_4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_operator_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_operator_4.Location = New System.Drawing.Point(932, 390)
        Me.btn_operator_4.Name = "btn_operator_4"
        Me.btn_operator_4.Size = New System.Drawing.Size(50, 50)
        Me.btn_operator_4.TabIndex = 11
        Me.btn_operator_4.Tag = "Operator"
        Me.btn_operator_4.Text = "/"
        Me.btn_operator_4.UseVisualStyleBackColor = False
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbl_time.Location = New System.Drawing.Point(1274, 74)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(19, 20)
        Me.lbl_time.TabIndex = 16
        Me.lbl_time.Text = "0"
        '
        'lbl_operand_1
        '
        Me.lbl_operand_1.AutoSize = True
        Me.lbl_operand_1.BackColor = System.Drawing.Color.White
        Me.lbl_operand_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_operand_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_operand_1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_operand_1.Location = New System.Drawing.Point(658, 206)
        Me.lbl_operand_1.Name = "lbl_operand_1"
        Me.lbl_operand_1.Size = New System.Drawing.Size(40, 57)
        Me.lbl_operand_1.TabIndex = 17
        Me.lbl_operand_1.Text = " "
        '
        'lbl_operator_1
        '
        Me.lbl_operator_1.AutoSize = True
        Me.lbl_operator_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_operator_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_operator_1.Location = New System.Drawing.Point(720, 207)
        Me.lbl_operator_1.Name = "lbl_operator_1"
        Me.lbl_operator_1.Size = New System.Drawing.Size(40, 57)
        Me.lbl_operator_1.TabIndex = 19
        Me.lbl_operator_1.Text = " "
        '
        'lbl_operator_2
        '
        Me.lbl_operator_2.AutoSize = True
        Me.lbl_operator_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_operator_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_operator_2.Location = New System.Drawing.Point(840, 208)
        Me.lbl_operator_2.Name = "lbl_operator_2"
        Me.lbl_operator_2.Size = New System.Drawing.Size(40, 57)
        Me.lbl_operator_2.TabIndex = 23
        Me.lbl_operator_2.Text = " "
        '
        'lbl_operand_2
        '
        Me.lbl_operand_2.AutoSize = True
        Me.lbl_operand_2.BackColor = System.Drawing.Color.White
        Me.lbl_operand_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_operand_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_operand_2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_operand_2.Location = New System.Drawing.Point(780, 208)
        Me.lbl_operand_2.Name = "lbl_operand_2"
        Me.lbl_operand_2.Size = New System.Drawing.Size(40, 57)
        Me.lbl_operand_2.TabIndex = 21
        Me.lbl_operand_2.Text = " "
        '
        'lbl_answer
        '
        Me.lbl_answer.AutoSize = True
        Me.lbl_answer.BackColor = System.Drawing.Color.White
        Me.lbl_answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_answer.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbl_answer.Location = New System.Drawing.Point(1138, 205)
        Me.lbl_answer.Name = "lbl_answer"
        Me.lbl_answer.Size = New System.Drawing.Size(54, 57)
        Me.lbl_answer.TabIndex = 27
        Me.lbl_answer.Text = "5"
        '
        'lbl_operand_4
        '
        Me.lbl_operand_4.AutoSize = True
        Me.lbl_operand_4.BackColor = System.Drawing.Color.White
        Me.lbl_operand_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_operand_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_operand_4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_operand_4.Location = New System.Drawing.Point(1020, 208)
        Me.lbl_operand_4.Name = "lbl_operand_4"
        Me.lbl_operand_4.Size = New System.Drawing.Size(40, 57)
        Me.lbl_operand_4.TabIndex = 26
        Me.lbl_operand_4.Text = " "
        '
        'lbl_operator_3
        '
        Me.lbl_operator_3.AutoSize = True
        Me.lbl_operator_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_operator_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_operator_3.Location = New System.Drawing.Point(960, 208)
        Me.lbl_operator_3.Name = "lbl_operator_3"
        Me.lbl_operator_3.Size = New System.Drawing.Size(40, 57)
        Me.lbl_operator_3.TabIndex = 25
        Me.lbl_operator_3.Text = " "
        '
        'lbl_operand_3
        '
        Me.lbl_operand_3.AutoSize = True
        Me.lbl_operand_3.BackColor = System.Drawing.Color.White
        Me.lbl_operand_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_operand_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_operand_3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_operand_3.Location = New System.Drawing.Point(900, 208)
        Me.lbl_operand_3.Name = "lbl_operand_3"
        Me.lbl_operand_3.Size = New System.Drawing.Size(40, 57)
        Me.lbl_operand_3.TabIndex = 24
        Me.lbl_operand_3.Text = " "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1079, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 55)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "="
        '
        'btn_inicio
        '
        Me.btn_inicio.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inicio.Location = New System.Drawing.Point(1112, 480)
        Me.btn_inicio.Name = "btn_inicio"
        Me.btn_inicio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_inicio.Size = New System.Drawing.Size(108, 37)
        Me.btn_inicio.TabIndex = 29
        Me.btn_inicio.Tag = "Menu_btn"
        Me.btn_inicio.Text = "Inicio"
        Me.btn_inicio.UseVisualStyleBackColor = False
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'btn_resolver
        '
        Me.btn_resolver.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_resolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_resolver.Location = New System.Drawing.Point(1060, 416)
        Me.btn_resolver.Name = "btn_resolver"
        Me.btn_resolver.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_resolver.Size = New System.Drawing.Size(108, 37)
        Me.btn_resolver.TabIndex = 30
        Me.btn_resolver.Tag = "Menu_btn"
        Me.btn_resolver.Text = "Resolver"
        Me.btn_resolver.UseVisualStyleBackColor = False
        '
        'btn_borrar
        '
        Me.btn_borrar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_borrar.Location = New System.Drawing.Point(1112, 519)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_borrar.Size = New System.Drawing.Size(108, 37)
        Me.btn_borrar.TabIndex = 31
        Me.btn_borrar.Tag = "Menu_btn"
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.UseVisualStyleBackColor = False
        '
        'btn_siguiente
        '
        Me.btn_siguiente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_siguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_siguiente.Location = New System.Drawing.Point(1174, 416)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_siguiente.Size = New System.Drawing.Size(108, 37)
        Me.btn_siguiente.TabIndex = 32
        Me.btn_siguiente.Tag = "Menu_btn"
        Me.btn_siguiente.Text = "Siguiente"
        Me.btn_siguiente.UseVisualStyleBackColor = False
        '
        'btn_borrar_todo
        '
        Me.btn_borrar_todo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_borrar_todo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_borrar_todo.Location = New System.Drawing.Point(1112, 559)
        Me.btn_borrar_todo.Name = "btn_borrar_todo"
        Me.btn_borrar_todo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_borrar_todo.Size = New System.Drawing.Size(108, 37)
        Me.btn_borrar_todo.TabIndex = 33
        Me.btn_borrar_todo.Tag = "Menu_btn"
        Me.btn_borrar_todo.Text = "Borrar todo"
        Me.btn_borrar_todo.UseVisualStyleBackColor = False
        '
        'lbl_user_answer
        '
        Me.lbl_user_answer.AutoSize = True
        Me.lbl_user_answer.BackColor = System.Drawing.Color.White
        Me.lbl_user_answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_user_answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user_answer.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbl_user_answer.Location = New System.Drawing.Point(1138, 275)
        Me.lbl_user_answer.Name = "lbl_user_answer"
        Me.lbl_user_answer.Size = New System.Drawing.Size(54, 57)
        Me.lbl_user_answer.TabIndex = 35
        Me.lbl_user_answer.Text = "0"
        '
        'btn_operand_4
        '
        Me.btn_operand_4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_operand_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_operand_4.Location = New System.Drawing.Point(932, 317)
        Me.btn_operand_4.Name = "btn_operand_4"
        Me.btn_operand_4.Size = New System.Drawing.Size(50, 50)
        Me.btn_operand_4.TabIndex = 15
        Me.btn_operand_4.Tag = ""
        Me.btn_operand_4.UseVisualStyleBackColor = False
        '
        'btn_operand_2
        '
        Me.btn_operand_2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_operand_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_operand_2.Location = New System.Drawing.Point(770, 317)
        Me.btn_operand_2.Name = "btn_operand_2"
        Me.btn_operand_2.Size = New System.Drawing.Size(50, 50)
        Me.btn_operand_2.TabIndex = 13
        Me.btn_operand_2.Tag = ""
        Me.btn_operand_2.UseVisualStyleBackColor = False
        '
        'btn_operand_1
        '
        Me.btn_operand_1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_operand_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_operand_1.Location = New System.Drawing.Point(689, 317)
        Me.btn_operand_1.Name = "btn_operand_1"
        Me.btn_operand_1.Size = New System.Drawing.Size(50, 50)
        Me.btn_operand_1.TabIndex = 12
        Me.btn_operand_1.Tag = ""
        Me.btn_operand_1.UseVisualStyleBackColor = False
        '
        'btn_operand_3
        '
        Me.btn_operand_3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_operand_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_operand_3.Location = New System.Drawing.Point(851, 317)
        Me.btn_operand_3.Name = "btn_operand_3"
        Me.btn_operand_3.Size = New System.Drawing.Size(50, 50)
        Me.btn_operand_3.TabIndex = 14
        Me.btn_operand_3.Tag = ""
        Me.btn_operand_3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(425, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(353, 24)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Universidad Tecnológica de Panamá"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Nombre: Adán Serrano"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(415, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(370, 24)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Facultad de sistemas computacionales"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(116, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Cédula: 8-998-2426"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(116, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 16)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Profesor: Ricardo Chan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(116, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 16)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Grupo: 1LS231"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(883, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Problemas resueltos:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_solved
        '
        Me.lbl_solved.AutoSize = True
        Me.lbl_solved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_solved.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbl_solved.Location = New System.Drawing.Point(1056, 75)
        Me.lbl_solved.Name = "lbl_solved"
        Me.lbl_solved.Size = New System.Drawing.Size(19, 20)
        Me.lbl_solved.TabIndex = 42
        Me.lbl_solved.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 619)
        Me.Controls.Add(Me.lbl_solved)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_operator_3)
        Me.Controls.Add(Me.btn_operator_1)
        Me.Controls.Add(Me.btn_operand_3)
        Me.Controls.Add(Me.btn_operator_2)
        Me.Controls.Add(Me.btn_operand_1)
        Me.Controls.Add(Me.btn_operator_4)
        Me.Controls.Add(Me.btn_operand_2)
        Me.Controls.Add(Me.btn_operand_4)
        Me.Controls.Add(Me.lbl_user_answer)
        Me.Controls.Add(Me.btn_borrar_todo)
        Me.Controls.Add(Me.btn_siguiente)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_resolver)
        Me.Controls.Add(Me.btn_inicio)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_answer)
        Me.Controls.Add(Me.lbl_operand_4)
        Me.Controls.Add(Me.lbl_operator_3)
        Me.Controls.Add(Me.lbl_operand_3)
        Me.Controls.Add(Me.lbl_operator_2)
        Me.Controls.Add(Me.lbl_operand_2)
        Me.Controls.Add(Me.lbl_operator_1)
        Me.Controls.Add(Me.lbl_operand_1)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Proyecto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_operator_1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_operator_2 As Button
    Friend WithEvents btn_operator_3 As Button
    Friend WithEvents btn_operator_4 As Button
    Friend WithEvents lbl_time As Label
    Friend WithEvents lbl_operand_1 As Label
    Friend WithEvents lbl_operator_1 As Label
    Friend WithEvents lbl_operator_2 As Label
    Friend WithEvents lbl_operand_2 As Label
    Friend WithEvents lbl_answer As Label
    Friend WithEvents lbl_operand_4 As Label
    Friend WithEvents lbl_operator_3 As Label
    Friend WithEvents lbl_operand_3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_inicio As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents btn_resolver As Button
    Friend WithEvents btn_borrar As Button
    Friend WithEvents btn_siguiente As Button
    Friend WithEvents btn_borrar_todo As Button
    Friend WithEvents lbl_user_answer As Label
    Friend WithEvents btn_operand_4 As Button
    Friend WithEvents btn_operand_2 As Button
    Friend WithEvents btn_operand_1 As Button
    Friend WithEvents btn_operand_3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_solved As Label
End Class
