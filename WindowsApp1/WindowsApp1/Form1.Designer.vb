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
        Dim IDLabel As System.Windows.Forms.Label
        Dim FACTURALabel As System.Windows.Forms.Label
        Dim CLIENTELabel As System.Windows.Forms.Label
        Dim TRASPORTELabel As System.Windows.Forms.Label
        Dim PROCEDENCIALabel As System.Windows.Forms.Label
        Dim TERMINALLabel As System.Windows.Forms.Label
        Dim FECHALabel As System.Windows.Forms.Label
        Dim BULTOLabel As System.Windows.Forms.Label
        Dim PRECIOLabel As System.Windows.Forms.Label
        Dim DESTINOLabel As System.Windows.Forms.Label
        Dim DESTINOLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TRASPORTEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TRASPORTEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ButtonAGREGAR = New System.Windows.Forms.Button()
        Me.ButtonELIMINAR = New System.Windows.Forms.Button()
        Me.ButtonVER = New System.Windows.Forms.Button()
        Me.ButtonBUSCAR = New System.Windows.Forms.Button()
        Me.ButtonSALIR = New System.Windows.Forms.Button()
        Me.ButtonIMPRIMIR = New System.Windows.Forms.Button()
        Me.TRASPORTEDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.FACTURATextBox = New System.Windows.Forms.TextBox()
        Me.CLIENTETextBox = New System.Windows.Forms.TextBox()
        Me.TRASPORTEComboBox = New System.Windows.Forms.ComboBox()
        Me.PROCEDENCIAComboBox = New System.Windows.Forms.ComboBox()
        Me.TERMINALComboBox = New System.Windows.Forms.ComboBox()
        Me.FECHADateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BULTOTextBox = New System.Windows.Forms.TextBox()
        Me.PRECIOTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DESTINOTextBox1 = New System.Windows.Forms.TextBox()
        Me.Buttonlimpiar = New System.Windows.Forms.Button()
        Me.TRASPORTEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ELIADataSet = New WindowsApp1.ELIADataSet2()
        Me.TRASPORTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRASPORTETableAdapter = New WindowsApp1.ELIADataSet2TableAdapters.TRASPORTETableAdapter()
        Me.TableAdapterManager = New WindowsApp1.ELIADataSet2TableAdapters.TableAdapterManager()
        Me.ELIADataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDLabel = New System.Windows.Forms.Label()
        FACTURALabel = New System.Windows.Forms.Label()
        CLIENTELabel = New System.Windows.Forms.Label()
        TRASPORTELabel = New System.Windows.Forms.Label()
        PROCEDENCIALabel = New System.Windows.Forms.Label()
        TERMINALLabel = New System.Windows.Forms.Label()
        FECHALabel = New System.Windows.Forms.Label()
        BULTOLabel = New System.Windows.Forms.Label()
        PRECIOLabel = New System.Windows.Forms.Label()
        DESTINOLabel = New System.Windows.Forms.Label()
        DESTINOLabel1 = New System.Windows.Forms.Label()
        CType(Me.TRASPORTEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TRASPORTEBindingNavigator.SuspendLayout()
        CType(Me.TRASPORTEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRASPORTEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ELIADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRASPORTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ELIADataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        IDLabel.Location = New System.Drawing.Point(43, 95)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 26
        IDLabel.Text = "ID:"
        '
        'FACTURALabel
        '
        FACTURALabel.AutoSize = True
        FACTURALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FACTURALabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        FACTURALabel.Location = New System.Drawing.Point(22, 121)
        FACTURALabel.Name = "FACTURALabel"
        FACTURALabel.Size = New System.Drawing.Size(89, 20)
        FACTURALabel.TabIndex = 28
        FACTURALabel.Text = "FACTURA:"
        '
        'CLIENTELabel
        '
        CLIENTELabel.AutoSize = True
        CLIENTELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CLIENTELabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CLIENTELabel.Location = New System.Drawing.Point(22, 147)
        CLIENTELabel.Name = "CLIENTELabel"
        CLIENTELabel.Size = New System.Drawing.Size(80, 20)
        CLIENTELabel.TabIndex = 30
        CLIENTELabel.Text = "CLIENTE:"
        '
        'TRASPORTELabel
        '
        TRASPORTELabel.AutoSize = True
        TRASPORTELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TRASPORTELabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TRASPORTELabel.Location = New System.Drawing.Point(22, 173)
        TRASPORTELabel.Name = "TRASPORTELabel"
        TRASPORTELabel.Size = New System.Drawing.Size(110, 20)
        TRASPORTELabel.TabIndex = 32
        TRASPORTELabel.Text = "TRASPORTE:"
        '
        'PROCEDENCIALabel
        '
        PROCEDENCIALabel.AutoSize = True
        PROCEDENCIALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PROCEDENCIALabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        PROCEDENCIALabel.Location = New System.Drawing.Point(22, 200)
        PROCEDENCIALabel.Name = "PROCEDENCIALabel"
        PROCEDENCIALabel.Size = New System.Drawing.Size(130, 20)
        PROCEDENCIALabel.TabIndex = 34
        PROCEDENCIALabel.Text = "PROCEDENCIA:"
        '
        'TERMINALLabel
        '
        TERMINALLabel.AutoSize = True
        TERMINALLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TERMINALLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        TERMINALLabel.Location = New System.Drawing.Point(338, 96)
        TERMINALLabel.Name = "TERMINALLabel"
        TERMINALLabel.Size = New System.Drawing.Size(94, 20)
        TERMINALLabel.TabIndex = 36
        TERMINALLabel.Text = "TERMINAL:"
        '
        'FECHALabel
        '
        FECHALabel.AutoSize = True
        FECHALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FECHALabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        FECHALabel.Location = New System.Drawing.Point(338, 124)
        FECHALabel.Name = "FECHALabel"
        FECHALabel.Size = New System.Drawing.Size(68, 20)
        FECHALabel.TabIndex = 38
        FECHALabel.Text = "FECHA:"
        '
        'BULTOLabel
        '
        BULTOLabel.AutoSize = True
        BULTOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BULTOLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        BULTOLabel.Location = New System.Drawing.Point(338, 149)
        BULTOLabel.Name = "BULTOLabel"
        BULTOLabel.Size = New System.Drawing.Size(66, 20)
        BULTOLabel.TabIndex = 40
        BULTOLabel.Text = "BULTO:"
        '
        'PRECIOLabel
        '
        PRECIOLabel.AutoSize = True
        PRECIOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PRECIOLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        PRECIOLabel.Location = New System.Drawing.Point(338, 175)
        PRECIOLabel.Name = "PRECIOLabel"
        PRECIOLabel.Size = New System.Drawing.Size(74, 20)
        PRECIOLabel.TabIndex = 42
        PRECIOLabel.Text = "PRECIO:"
        '
        'DESTINOLabel
        '
        DESTINOLabel.AutoSize = True
        DESTINOLabel.Location = New System.Drawing.Point(518, 95)
        DESTINOLabel.Name = "DESTINOLabel"
        DESTINOLabel.Size = New System.Drawing.Size(58, 13)
        DESTINOLabel.TabIndex = 44
        DESTINOLabel.Text = "DESTINO:"
        '
        'DESTINOLabel1
        '
        DESTINOLabel1.AutoSize = True
        DESTINOLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DESTINOLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        DESTINOLabel1.Location = New System.Drawing.Point(338, 202)
        DESTINOLabel1.Name = "DESTINOLabel1"
        DESTINOLabel1.Size = New System.Drawing.Size(84, 20)
        DESTINOLabel1.TabIndex = 46
        DESTINOLabel1.Text = "DESTINO:"
        '
        'TRASPORTEBindingNavigator
        '
        Me.TRASPORTEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TRASPORTEBindingNavigator.BindingSource = Me.TRASPORTEBindingSource
        Me.TRASPORTEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TRASPORTEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TRASPORTEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TRASPORTEBindingNavigatorSaveItem})
        Me.TRASPORTEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TRASPORTEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TRASPORTEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TRASPORTEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TRASPORTEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TRASPORTEBindingNavigator.Name = "TRASPORTEBindingNavigator"
        Me.TRASPORTEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TRASPORTEBindingNavigator.Size = New System.Drawing.Size(921, 25)
        Me.TRASPORTEBindingNavigator.TabIndex = 0
        Me.TRASPORTEBindingNavigator.Text = "BindingNavigator1"
        Me.TRASPORTEBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TRASPORTEBindingNavigatorSaveItem
        '
        Me.TRASPORTEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TRASPORTEBindingNavigatorSaveItem.Image = CType(resources.GetObject("TRASPORTEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TRASPORTEBindingNavigatorSaveItem.Name = "TRASPORTEBindingNavigatorSaveItem"
        Me.TRASPORTEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TRASPORTEBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ButtonAGREGAR
        '
        Me.ButtonAGREGAR.Location = New System.Drawing.Point(626, 91)
        Me.ButtonAGREGAR.Name = "ButtonAGREGAR"
        Me.ButtonAGREGAR.Size = New System.Drawing.Size(111, 34)
        Me.ButtonAGREGAR.TabIndex = 20
        Me.ButtonAGREGAR.Text = "AGREGAR"
        Me.ButtonAGREGAR.UseVisualStyleBackColor = True
        '
        'ButtonELIMINAR
        '
        Me.ButtonELIMINAR.Location = New System.Drawing.Point(626, 135)
        Me.ButtonELIMINAR.Name = "ButtonELIMINAR"
        Me.ButtonELIMINAR.Size = New System.Drawing.Size(111, 33)
        Me.ButtonELIMINAR.TabIndex = 21
        Me.ButtonELIMINAR.Text = "ELIMINAR"
        Me.ButtonELIMINAR.UseVisualStyleBackColor = True
        '
        'ButtonVER
        '
        Me.ButtonVER.Location = New System.Drawing.Point(760, 128)
        Me.ButtonVER.Name = "ButtonVER"
        Me.ButtonVER.Size = New System.Drawing.Size(102, 39)
        Me.ButtonVER.TabIndex = 22
        Me.ButtonVER.Text = "MOSTRAR TODO"
        Me.ButtonVER.UseVisualStyleBackColor = True
        '
        'ButtonBUSCAR
        '
        Me.ButtonBUSCAR.Location = New System.Drawing.Point(626, 175)
        Me.ButtonBUSCAR.Name = "ButtonBUSCAR"
        Me.ButtonBUSCAR.Size = New System.Drawing.Size(111, 33)
        Me.ButtonBUSCAR.TabIndex = 23
        Me.ButtonBUSCAR.Text = "BUSCAR"
        Me.ButtonBUSCAR.UseVisualStyleBackColor = True
        '
        'ButtonSALIR
        '
        Me.ButtonSALIR.Location = New System.Drawing.Point(690, 214)
        Me.ButtonSALIR.Name = "ButtonSALIR"
        Me.ButtonSALIR.Size = New System.Drawing.Size(111, 36)
        Me.ButtonSALIR.TabIndex = 24
        Me.ButtonSALIR.Text = "SALIR"
        Me.ButtonSALIR.UseVisualStyleBackColor = True
        '
        'ButtonIMPRIMIR
        '
        Me.ButtonIMPRIMIR.Location = New System.Drawing.Point(760, 89)
        Me.ButtonIMPRIMIR.Name = "ButtonIMPRIMIR"
        Me.ButtonIMPRIMIR.Size = New System.Drawing.Size(102, 34)
        Me.ButtonIMPRIMIR.TabIndex = 25
        Me.ButtonIMPRIMIR.Text = "IMPRIMIR"
        Me.ButtonIMPRIMIR.UseVisualStyleBackColor = True
        '
        'TRASPORTEDataGridView
        '
        Me.TRASPORTEDataGridView.AutoGenerateColumns = False
        Me.TRASPORTEDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TRASPORTEDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.TRASPORTEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TRASPORTEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.TRASPORTEDataGridView.DataSource = Me.TRASPORTEBindingSource1
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TRASPORTEDataGridView.DefaultCellStyle = DataGridViewCellStyle11
        Me.TRASPORTEDataGridView.Enabled = False
        Me.TRASPORTEDataGridView.Location = New System.Drawing.Point(25, 278)
        Me.TRASPORTEDataGridView.Name = "TRASPORTEDataGridView"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TRASPORTEDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.TRASPORTEDataGridView.Size = New System.Drawing.Size(874, 220)
        Me.TRASPORTEDataGridView.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(236, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(626, 54)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "TRASPORTE MARIO LOPEZ"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRASPORTEBindingSource1, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(150, 96)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(156, 20)
        Me.IDTextBox.TabIndex = 27
        '
        'FACTURATextBox
        '
        Me.FACTURATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRASPORTEBindingSource1, "FACTURA", True))
        Me.FACTURATextBox.Location = New System.Drawing.Point(150, 122)
        Me.FACTURATextBox.Name = "FACTURATextBox"
        Me.FACTURATextBox.Size = New System.Drawing.Size(156, 20)
        Me.FACTURATextBox.TabIndex = 29
        '
        'CLIENTETextBox
        '
        Me.CLIENTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRASPORTEBindingSource1, "CLIENTE", True))
        Me.CLIENTETextBox.Location = New System.Drawing.Point(150, 148)
        Me.CLIENTETextBox.Name = "CLIENTETextBox"
        Me.CLIENTETextBox.Size = New System.Drawing.Size(156, 20)
        Me.CLIENTETextBox.TabIndex = 31
        '
        'TRASPORTEComboBox
        '
        Me.TRASPORTEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRASPORTEBindingSource1, "TRASPORTE", True))
        Me.TRASPORTEComboBox.FormattingEnabled = True
        Me.TRASPORTEComboBox.Items.AddRange(New Object() {"ARAGON", "CENTENO ", "DUNCAN", "INGRAG", "JIMENEZ GONZALEZ", "MARIO FLORES", "OROZCO LOPEZ", "PIOLIN", "RAPIDO FURIOSO", "ROBLETO", "ROMERO", "SANTA MONICA", "SHOW MENDEZ", "TANGA", "WENDELIN", "ZAMORA"})
        Me.TRASPORTEComboBox.Location = New System.Drawing.Point(150, 174)
        Me.TRASPORTEComboBox.Name = "TRASPORTEComboBox"
        Me.TRASPORTEComboBox.Size = New System.Drawing.Size(156, 21)
        Me.TRASPORTEComboBox.TabIndex = 33
        '
        'PROCEDENCIAComboBox
        '
        Me.PROCEDENCIAComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRASPORTEBindingSource1, "PROCEDENCIA", True))
        Me.PROCEDENCIAComboBox.FormattingEnabled = True
        Me.PROCEDENCIAComboBox.Items.AddRange(New Object() {"ORIENTAL", "NORTE", "TENDERI"})
        Me.PROCEDENCIAComboBox.Location = New System.Drawing.Point(150, 201)
        Me.PROCEDENCIAComboBox.Name = "PROCEDENCIAComboBox"
        Me.PROCEDENCIAComboBox.Size = New System.Drawing.Size(156, 21)
        Me.PROCEDENCIAComboBox.TabIndex = 35
        '
        'TERMINALComboBox
        '
        Me.TERMINALComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRASPORTEBindingSource1, "TERMINAL", True))
        Me.TERMINALComboBox.FormattingEnabled = True
        Me.TERMINALComboBox.Items.AddRange(New Object() {"IVAN MONTENEGRO", "EL MAYOREO", "ROBERTO HUEMBE", "ORIENTAL", "ISRAEL LEWITES", "MARIO FLORES"})
        Me.TERMINALComboBox.Location = New System.Drawing.Point(442, 95)
        Me.TERMINALComboBox.Name = "TERMINALComboBox"
        Me.TERMINALComboBox.Size = New System.Drawing.Size(152, 21)
        Me.TERMINALComboBox.TabIndex = 37
        '
        'FECHADateTimePicker
        '
        Me.FECHADateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TRASPORTEBindingSource1, "FECHA", True))
        Me.FECHADateTimePicker.Enabled = False
        Me.FECHADateTimePicker.Location = New System.Drawing.Point(442, 122)
        Me.FECHADateTimePicker.MinDate = New Date(2019, 2, 23, 0, 0, 0, 0)
        Me.FECHADateTimePicker.Name = "FECHADateTimePicker"
        Me.FECHADateTimePicker.Size = New System.Drawing.Size(152, 20)
        Me.FECHADateTimePicker.TabIndex = 39
        '
        'BULTOTextBox
        '
        Me.BULTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRASPORTEBindingSource1, "BULTO", True))
        Me.BULTOTextBox.Location = New System.Drawing.Point(442, 148)
        Me.BULTOTextBox.Name = "BULTOTextBox"
        Me.BULTOTextBox.Size = New System.Drawing.Size(152, 20)
        Me.BULTOTextBox.TabIndex = 41
        '
        'PRECIOTextBox
        '
        Me.PRECIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRASPORTEBindingSource1, "PRECIO", True))
        Me.PRECIOTextBox.Location = New System.Drawing.Point(442, 174)
        Me.PRECIOTextBox.Name = "PRECIOTextBox"
        Me.PRECIOTextBox.Size = New System.Drawing.Size(152, 20)
        Me.PRECIOTextBox.TabIndex = 43
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(113, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'DESTINOTextBox1
        '
        Me.DESTINOTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRASPORTEBindingSource1, "DESTINO", True))
        Me.DESTINOTextBox1.Location = New System.Drawing.Point(442, 206)
        Me.DESTINOTextBox1.Name = "DESTINOTextBox1"
        Me.DESTINOTextBox1.Size = New System.Drawing.Size(152, 20)
        Me.DESTINOTextBox1.TabIndex = 47
        '
        'Buttonlimpiar
        '
        Me.Buttonlimpiar.Location = New System.Drawing.Point(760, 174)
        Me.Buttonlimpiar.Name = "Buttonlimpiar"
        Me.Buttonlimpiar.Size = New System.Drawing.Size(102, 34)
        Me.Buttonlimpiar.TabIndex = 48
        Me.Buttonlimpiar.Text = "LIMPIAR TODO"
        Me.Buttonlimpiar.UseVisualStyleBackColor = True
        '
        'TRASPORTEBindingSource1
        '
        Me.TRASPORTEBindingSource1.DataMember = "TRASPORTE"
        Me.TRASPORTEBindingSource1.DataSource = Me.ELIADataSet
        '
        'ELIADataSet
        '
        Me.ELIADataSet.DataSetName = "ELIADataSet"
        Me.ELIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TRASPORTEBindingSource
        '
        Me.TRASPORTEBindingSource.DataMember = "TRASPORTE"
        Me.TRASPORTEBindingSource.DataSource = Me.ELIADataSet
        '
        'TRASPORTETableAdapter
        '
        Me.TRASPORTETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TRASPORTETableAdapter = Me.TRASPORTETableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.ELIADataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ELIADataSetBindingSource
        '
        Me.ELIADataSetBindingSource.DataSource = Me.ELIADataSet
        Me.ELIADataSetBindingSource.Position = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 43
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FACTURA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FACTURA"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 82
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CLIENTE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CLIENTE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 77
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TRASPORTE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TRASPORTE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 98
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PROCEDENCIA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PROCEDENCIA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 109
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TERMINAL"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TERMINAL"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 87
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FECHA"
        Me.DataGridViewTextBoxColumn7.HeaderText = "FECHA"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 67
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "BULTO"
        Me.DataGridViewTextBoxColumn8.HeaderText = "BULTO"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 68
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PRECIO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PRECIO"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 72
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DESTINO"
        Me.DataGridViewTextBoxColumn10.HeaderText = "DESTINO"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 80
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(932, 510)
        Me.Controls.Add(Me.Buttonlimpiar)
        Me.Controls.Add(DESTINOLabel1)
        Me.Controls.Add(Me.DESTINOTextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(FACTURALabel)
        Me.Controls.Add(Me.FACTURATextBox)
        Me.Controls.Add(CLIENTELabel)
        Me.Controls.Add(Me.CLIENTETextBox)
        Me.Controls.Add(TRASPORTELabel)
        Me.Controls.Add(Me.TRASPORTEComboBox)
        Me.Controls.Add(PROCEDENCIALabel)
        Me.Controls.Add(Me.PROCEDENCIAComboBox)
        Me.Controls.Add(TERMINALLabel)
        Me.Controls.Add(Me.TERMINALComboBox)
        Me.Controls.Add(FECHALabel)
        Me.Controls.Add(Me.FECHADateTimePicker)
        Me.Controls.Add(BULTOLabel)
        Me.Controls.Add(Me.BULTOTextBox)
        Me.Controls.Add(PRECIOLabel)
        Me.Controls.Add(Me.PRECIOTextBox)
        Me.Controls.Add(DESTINOLabel)
        Me.Controls.Add(Me.TRASPORTEDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonIMPRIMIR)
        Me.Controls.Add(Me.ButtonSALIR)
        Me.Controls.Add(Me.ButtonBUSCAR)
        Me.Controls.Add(Me.ButtonVER)
        Me.Controls.Add(Me.ButtonELIMINAR)
        Me.Controls.Add(Me.ButtonAGREGAR)
        Me.Controls.Add(Me.TRASPORTEBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "REGISTRO"
        CType(Me.TRASPORTEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TRASPORTEBindingNavigator.ResumeLayout(False)
        Me.TRASPORTEBindingNavigator.PerformLayout()
        CType(Me.TRASPORTEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRASPORTEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ELIADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRASPORTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ELIADataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ELIADataSet As ELIADataSet2
    Friend WithEvents TRASPORTEBindingSource As BindingSource
    Friend WithEvents TRASPORTETableAdapter As ELIADataSet2TableAdapters.TRASPORTETableAdapter
    Friend WithEvents TableAdapterManager As ELIADataSet2TableAdapters.TableAdapterManager
    Friend WithEvents TRASPORTEBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TRASPORTEBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ButtonAGREGAR As Button
    Friend WithEvents ButtonELIMINAR As Button
    Friend WithEvents ButtonVER As Button
    Friend WithEvents ButtonBUSCAR As Button
    Friend WithEvents ButtonSALIR As Button
    Friend WithEvents ButtonIMPRIMIR As Button
    Friend WithEvents TRASPORTEBindingSource1 As BindingSource
    Friend WithEvents ELIADataSetBindingSource As BindingSource
    Friend WithEvents TRASPORTEDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents FACTURATextBox As TextBox
    Friend WithEvents CLIENTETextBox As TextBox
    Friend WithEvents TRASPORTEComboBox As ComboBox
    Friend WithEvents PROCEDENCIAComboBox As ComboBox
    Friend WithEvents TERMINALComboBox As ComboBox
    Friend WithEvents FECHADateTimePicker As DateTimePicker
    Friend WithEvents BULTOTextBox As TextBox
    Friend WithEvents PRECIOTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DESTINOTextBox1 As TextBox
    Friend WithEvents Buttonlimpiar As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
