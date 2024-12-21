Imports System.Data.OleDb

Public Class Productos
    ' Definiendo la cadena de conexion.
    Dim connectionString As String = VentanaInicio.connectionString
    Dim Id_producto As String

    ' Creamos una instancia del temporizador
    Private WithEvents Timer1 As New Timer()
    Public Sub New()
        InitializeComponent()
        ' Configurar el temporizador
        Timer1.Interval = 5000 '3600000 ' Establecemos el intervalo en milisegundos (3600000 ms = 1 hora)
        Timer1.Start() ' Iniciar el temporizador
    End Sub

    ' Este evento se ejecutará cada vez que el temporizador se active
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim targetDate As DateTime
        Dim connection As New OleDbConnection(connectionString)
        Dim query As String = "SELECT ID, NOMBRE, DESCRIPCION, STOCKACTUAL, FECHA_CADUCIDAD FROM PRODUCTO"
        Dim adapter As New OleDbDataAdapter(query, connection)
        Dim dt As New DataTable()
        Dim unidad As Integer

        Try
            connection.Open()
            adapter.Fill(dt)

            For Each row As DataRow In dt.Rows
                targetDate = row("Fecha_caducidad")
                unidad = row("STOCKACTUAL")
                ' Verificamos si la fecha actual es mayor o igual a la fecha objetivo
                If DateTime.Now >= targetDate And unidad > 0 Then
                    MessageBox.Show("El producto: " & row("NOMBRE") & " tiene fecha de caducidad " & row("FECHA_CADUCIDAD") & " para " & row("STOCKACTUAL") & " unidades.")
                    Timer1.Stop() ' Detenemos el temporizador después de la verificación
                Else
                    ' Si aún no ha llegado la fecha, mostramos la fecha actual
                    Console.WriteLine("Fecha actual: " & DateTime.Now)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If bguardar.Text = "Guardar" Then
            guardar()
            limpiar_controles()
            cargarInfo()
        Else
            actualizar()
            limpiar_controles()
            cargarInfo()
        End If
    End Sub

    Private Sub bBuscador_Click(sender As Object, e As EventArgs) Handles bBuscador.Click
        Dim connection As New OleDbConnection(connectionString)
        Try
            connection.Open()
            Dim query = "SELECT ID, NOMBRE, DESCRIPCION, STOCKACTUAL FROM PRODUCTO WHERE NOMBRE LIKE @PARAMETRO OR DESCRIPCION LIKE @PARAMETRO;"
            Dim cmd As New OleDbCommand(query, connection)
            Dim dt As New DataTable

            cmd.Parameters.Add("@PARAMETRO", OleDbType.VarWChar).Value = tbBuscador.Text

            Dim adapter As New OleDbDataAdapter(cmd)


            adapter.Fill(dt)
            dgvVisor.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub dgvVisor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVisor.CellClick
        Dim connection As New OleDbConnection(connectionString)
        Try
            Id_producto = dgvVisor.CurrentRow.Cells("ID").Value.ToString
            If Id_producto <> "" Then
                connection.Open()
                Dim query = "SELECT * FROM PRODUCTO WHERE ID=" + Id_producto
                Dim command As New OleDbCommand(query, connection)
                Dim reader = command.ExecuteReader


                While reader.Read
                    tb_nombre.Text = reader("NOMBRE").ToString
                    tbDescripcion.Text = reader("DESCRIPCION").ToString
                    tbCodigodebarras.Text = reader("CODIGO_BARRAS").ToString
                    tb_precioin.Text = reader("PRECIO_IN").ToString
                    tbPrecio_out.Text = reader("PRECIO_OUT").ToString
                    tb_categoria.Text = reader("CATEGORIA").ToString
                    tb_marca.Text = reader("MARCA").ToString
                    tb_um.Text = reader("UM").ToString
                    dtp_fechacaducidad.Text = reader("FECHA_CADUCIDAD").ToString
                    tb_proveedor.Text = reader("ID_PROVEEDOR").ToString
                    tb_stockmin.Text = reader("STOCKMINIMO").ToString
                    tb_stockact.Text = reader("STOCKACTUAL").ToString
                    tb_stockmax.Text = reader("STOCKMAXIMO").ToString
                End While
                bguardar.Text = "Actualizar"
                reader.Close()
            Else
                MessageBox.Show("Error: Registro no encontrado")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub cargarInfo()
        Dim connection As New OleDbConnection(connectionString)
        Try
            connection.Open()
            Dim query As String = "SELECT ID, NOMBRE, DESCRIPCION, STOCKACTUAL, FECHA_CADUCIDAD FROM PRODUCTO"
            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvVisor.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub limpiar_controles()
        tb_nombre.Clear()
        tbDescripcion.Clear()
        tbCodigodebarras.Clear()
        tb_precioin.Clear()
        tbPrecio_out.Clear()
        tb_categoria.Clear()
        tb_marca.Clear()
        tb_um.Clear()
        dtp_fechacaducidad.Text = "11/20/2024"
        tb_proveedor.Clear()
        tb_stockmin.Clear()
        tb_stockact.Clear()
        tb_stockmax.Clear()
        bguardar.Text = "Guardar"
    End Sub

    Private Sub blimpiar_Click(sender As Object, e As EventArgs) Handles blimpiar.Click
        limpiar_controles()
    End Sub

    Private Sub actualizar()
        Dim connection As New OleDbConnection(connectionString)
        Try
            Dim query As String = "UPDATE PRODUCTO SET Nombre = @newNombre, Descripcion = @newDescripcion, Codigo_barras = @newCodigoBarras, Precio_in = @newPrecioin, Precio_out = @newPrecioOut,Categoria = @newCategoria, Marca = @newMarca, Um = @newUM, Fecha_caducidad = @newFechacaducidad, id_Proveedor = @newProveedor, Stockminimo = @newStockMin, Stockactual = @newStockact, Stockmaximo = @newStockMax WHERE ID = @ID;"

            Dim cmd = New OleDbCommand(query, connection)

            cmd.Parameters.Add("@newNombre", OleDbType.VarWChar).Value = tb_nombre.Text
            cmd.Parameters.Add("@newDescripcion", OleDbType.VarWChar).Value = tbDescripcion.Text
            cmd.Parameters.Add("@newCodigoBarras", OleDbType.VarWChar).Value = tbCodigodebarras.Text
            cmd.Parameters.Add("@newPrecioin", OleDbType.Currency).Value = Convert.ToDecimal(tb_precioin.Text)
            cmd.Parameters.Add("@newPrecioOut", OleDbType.Currency).Value = Convert.ToDecimal(tbPrecio_out.Text)
            cmd.Parameters.Add("@newCategoria", OleDbType.Integer).Value = Convert.ToInt32(tb_categoria.Text)
            cmd.Parameters.Add("@newMarca", OleDbType.VarWChar).Value = tb_marca.Text
            cmd.Parameters.Add("@newUM", OleDbType.VarWChar).Value = tb_um.Text
            cmd.Parameters.Add("@newFechacaducidad", OleDbType.Date).Value = Convert.ToDateTime(dtp_fechacaducidad.Text)
            cmd.Parameters.Add("@newProveedor", OleDbType.Integer).Value = Convert.ToInt32(tb_proveedor.Text)
            cmd.Parameters.Add("@newStockMin", OleDbType.Integer).Value = Convert.ToInt32(tb_stockmin.Text)
            cmd.Parameters.Add("@newStockact", OleDbType.Integer).Value = Convert.ToInt32(tb_stockact.Text)
            cmd.Parameters.Add("@newStockMax", OleDbType.Integer).Value = Convert.ToInt32(tb_stockmax.Text)
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = Convert.ToInt32(Id_producto)

            connection.Open()

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Registro actualizado correctamente.")
            Else
                MessageBox.Show("No se encontró el registro a actualizar")
            End If

        Catch ex As Exception
            MessageBox.Show("Un error ocurrió: " & ex.Message)
        Finally
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub guardar()
        Dim connection As New OleDbConnection(connectionString)

        Try
            Dim query As String = "INSERT INTO PRODUCTO (Nombre, Descripcion, Codigo_barras, Precio_in, Precio_out, Categoria, Marca, UM, Fecha_caducidad, Id_Proveedor, Stockminimo, StockActual, StockMaximo) VALUES (@newNombre, @newDescripcion, @newCodigoBarras, @newPrecioin, @newPrecioOut, @newCategoria, @newMarca, @newUM, @newFechacaducidad, @newProveedor, @newStockMin, @newStockact, @newStockMax);"

            Dim cmd = New OleDbCommand(query, connection)

            cmd.Parameters.Add("@newNombre", OleDbType.VarWChar).Value = tb_nombre.Text
            cmd.Parameters.Add("@newDescripcion", OleDbType.VarWChar).Value = tbDescripcion.Text
            cmd.Parameters.Add("@newCodigoBarras", OleDbType.VarWChar).Value = tbCodigodebarras.Text
            cmd.Parameters.Add("@newPrecioin", OleDbType.Currency).Value = Convert.ToDecimal(tb_precioin.Text)
            cmd.Parameters.Add("@newPrecioOut", OleDbType.Currency).Value = Convert.ToDecimal(tbPrecio_out.Text)
            cmd.Parameters.Add("@newCategoria", OleDbType.Integer).Value = Convert.ToInt32(tb_categoria.Text)
            cmd.Parameters.Add("@newMarca", OleDbType.VarWChar).Value = tb_marca.Text
            cmd.Parameters.Add("@newUM", OleDbType.VarWChar).Value = tb_um.Text
            cmd.Parameters.Add("@newFechacaducidad", OleDbType.Date).Value = Convert.ToDateTime(dtp_fechacaducidad.Text)
            cmd.Parameters.Add("@newProveedor", OleDbType.Integer).Value = Convert.ToInt32(tb_proveedor.Text)
            cmd.Parameters.Add("@newStockMin", OleDbType.Integer).Value = Convert.ToInt32(tb_stockmin.Text)
            cmd.Parameters.Add("@newStockact", OleDbType.Integer).Value = Convert.ToInt32(tb_stockact.Text)
            cmd.Parameters.Add("@newStockMax", OleDbType.Integer).Value = Convert.ToInt32(tb_stockmax.Text)

            connection.Open()

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Registro guardado correctamente.")
            End If

        Catch ex As Exception
            MessageBox.Show("Un error ocurrió: " & ex.Message)
        Finally
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If (Id_producto <> "") Then
            Dim connection As New OleDbConnection(connectionString)
            Try
                Dim query = "DELETE FROM PRODUCTO WHERE ID = @ID;"
                Dim cmd = New OleDbCommand(query, connection)

                cmd.Parameters.Add("@ID", OleDbType.Integer).Value = Convert.ToInt32(Id_producto)

                connection.Open()

                Dim rowsAffected = cmd.ExecuteNonQuery

                If rowsAffected > 0 Then
                    MessageBox.Show("Registro eliminado correctamente.")
                    limpiar_controles()
                    cargarInfo()
                End If

            Catch ex As Exception
                MessageBox.Show("Un error ocurrió: " & ex.Message)
            Finally
                If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End If
    End Sub
End Class