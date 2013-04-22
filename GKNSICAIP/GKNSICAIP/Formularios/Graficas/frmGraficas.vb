Imports CapaNegocios
Public Class frmGraficas    

    Private Sub Graficas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'oGraficas.Obtener_IdEquipo(vIdEquipo)
        'cbxEquipo.DataSource = oGraficas.Obtener_Nombre_Equipo_Usuarios(vIdEquipo)
        'cbxLinea.DataSource = oGraficas.Obtener_Lineas_Equipo(vIdEquipo)
        'cbxArea.DataSource = oGraficas.Obtener_Area_Usuarios(vIdEquipo)
        'cbxUN.DataSource = oGraficas.Obtener_CadenaValor_Usuarios(vIdEquipo)


        'llena_colores()
        cbxUN.Enabled = True
        cbxArea.Enabled = True
        cbxLinea.Enabled = True
        cbxEquipo.Enabled = True

        ''dtpDesde.Value = New DateTime(2013, 1, 1)
        ''dtpDesde.Value = Today
        dtpDesde.Value = DateSerial(Now.Year, Now.Month, 1) ''Muestra el primer dia del mes actual
        dtpHasta.Value = Today
        ''MsgBox("Load")
        cmdGraficar.Enabled = False
        rbtDia.Checked = True
        rbtOEE.Checked = True
        rbtLineas.Checked = True
        'banderacbx = 0
        ''banderaArea = 0
        'banderaCheck = 0
        'banderaDate = 0
        'bandera_load = True
    End Sub
End Class