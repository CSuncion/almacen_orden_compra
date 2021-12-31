using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Heredados;
using WinControles;
using WinControles.ControlesWindows;
using Entidades;
using Negocio;
using Entidades.Adicionales;
using Comun;
using Presentacion.Principal;
using System.Collections;
using Presentacion.Maestros;
using Heredados.VentanasPersonalizadas;
using System.Reflection;
using Presentacion.FuncionesGenericas;
using Presentacion.Impresiones;
using System.Net.Mail;

namespace Presentacion.ProcesosCompras
{
    public partial class wSolicitudPedido : Heredados.MiForm8
    {
        public wSolicitudPedido()
        {
            InitializeComponent();
        }

        //Atributos
        string eNombreColumnaDgvMovCab = SolicitudPedidoCabeEN.NumMovCab;
        string eEncabezadoColumnaDgvMovCab = "Numero";
        public string eClaveDgvMovCab = string.Empty;
        Dgv.Franja eFranjaDgvMovCab = Dgv.Franja.PorIndice;
        public List<SolicitudPedidoCabeEN> eLisMovCab = new List<SolicitudPedidoCabeEN>();
        int eVaBD = 1;//0 : no , 1 : si
        public string eTitulo = "Solicitud de Pedido";

        #region General


        public void NuevaVentana()
        {
            this.Show();
            this.MostrarPersistencia();
        }

        public void ActualizarVentana()
        {
            this.ActualizarListaSolicitudPedidoCabesDeBaseDatos();
            this.ActualizarDgvMovCab();
            Dgv.HabilitarDesplazadores(this.DgvMovCab, this.tsbPrimero, this.tsbAnterior, this.tsbSiguiente, this.tsbUltimo);
            this.HabilitarAcciones();
            Dgv.ActualizarBarraEstado(this.DgvMovCab, this.sst1);
            this.AccionBuscar();
        }

        public void AccionBuscar()
        {
            //this.tstBuscar.Clear();
            this.tstBuscar.ToolTipText = "Ingrese " + this.eEncabezadoColumnaDgvMovCab;
            this.tstBuscar.Focus();
        }

        public void ActualizarDgvMovCab()
        {
            //asignar parametros
            DataGridView iGrilla = this.DgvMovCab;
            List<SolicitudPedidoCabeEN> iFuenteDatos = this.ObtenerDatosParaGrilla();
            Dgv.Franja iCondicionFranja = eFranjaDgvMovCab;
            string iClaveBusqueda = eClaveDgvMovCab;
            string iColumnaPintura = eNombreColumnaDgvMovCab;
            List<DataGridViewColumn> iListaColumnas = this.ListarColumnasDgvMovCab();

            //ejecutar metodo
            Dgv.RefrescarGrilla(iGrilla, iFuenteDatos, iCondicionFranja, iClaveBusqueda, iColumnaPintura, iListaColumnas);
        }

        public List<DataGridViewColumn> ListarColumnasDgvMovCab()
        {
            //lista resultado
            List<DataGridViewColumn> iLisRes = new List<DataGridViewColumn>();

            //agregando las columnas
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(SolicitudPedidoCabeEN.NumMovCab, "Numero", 70));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(SolicitudPedidoCabeEN.FecMovCab, "Fecha", 70));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(SolicitudPedidoCabeEN.PerMovCab, "Periodo", 62));
            //iLisRes.Add(Dgv.NuevaColumnaTextCadena(SolicitudPedidoCabeEN.CodTipOpe, "T.O", 50));
            //iLisRes.Add(Dgv.NuevaColumnaTextCadena(SolicitudPedidoCabeEN.DesTipOpe, "Descripción T.O", 180));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(SolicitudPedidoCabeEN.DesAlm, "Almacen", 180));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(SolicitudPedidoCabeEN.DesAux, "Proveedor", 250));
            iLisRes.Add(Dgv.NuevaColumnaTextNumerico(SolicitudPedidoCabeEN.CosFleMovCab, "Flete", 90, 2));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(SolicitudPedidoCabeEN.NomPer, "Personal", 160));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(SolicitudPedidoCabeEN.GloMovCab, "Glosa", 180));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(SolicitudPedidoCabeEN.NOriVenCre, "Origen", 90));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(SolicitudPedidoCabeEN.NEstMovCab, "Estado", 90));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(SolicitudPedidoCabeEN.NCodMon, "Moneda", 90));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(SolicitudPedidoCabeEN.ClaObj, "Clave", 50, false));

            //devolver
            return iLisRes;
        }

        public void ActualizarListaSolicitudPedidoCabesDeBaseDatos()
        {
            //validar si es acto ir a la bd
            if (tstBuscar.Text.Trim() != string.Empty && eVaBD == 0) { return; }

            //ir a la bd
            SolicitudPedidoCabeEN iCuoEN = new SolicitudPedidoCabeEN();
            iCuoEN.PeriodoSolicitudPedidoCabe = lblPeriodo.Text;
            //iCuoEN.CClaseTipoOperacion = "1";//ingreso
            iCuoEN.Adicionales.CampoOrden = eNombreColumnaDgvMovCab;
            this.eLisMovCab = SolicitudPedidoCabeRN.ListarSolicitudPedidoCabesXPeriodoYClaseOperacion(iCuoEN);
        }

        public List<SolicitudPedidoCabeEN> ObtenerDatosParaGrilla()
        {
            //asignar parametros
            string iValorBusqueda = tstBuscar.Text.Trim();
            string iCampoBusqueda = eNombreColumnaDgvMovCab;
            List<SolicitudPedidoCabeEN> iListaSolicitudPedidoCabes = eLisMovCab;

            //ejecutar y retornar
            return SolicitudPedidoCabeRN.ListarDatosParaGrillaPrincipal(iValorBusqueda, iCampoBusqueda, iListaSolicitudPedidoCabes);
        }

        public void HabilitarAcciones()
        {
            //asignar parametros
            ToolStrip iTs1 = tsPrincipal;
            ToolStrip iTs2 = tsSecundario;
            Hashtable iLisPer = PermisoUsuarioRN.ListarPermisosParaVentana("013", DgvMovCab.Rows.Count);

            //ejecutar metodo
            Tst.HabilitarItems(iTs1, iTs2, iLisPer);
        }

        public void AsignarSolicitudPedidoCabe(SolicitudPedidoCabeEN pIng)
        {
            pIng.ClaveSolicitudPedidoCabe = Dgv.ObtenerValorCelda(this.DgvMovCab, SolicitudPedidoCabeEN.ClaObj);
            pIng.PeriodoSolicitudPedidoCabe = lblPeriodo.Text;
            pIng.COrigenVentanaCreacion = "1";//ingreso      
        }

        public void AccionAdicionar()
        {
            //validar
            SolicitudPedidoCabeEN iIngEN = this.EsActoAdicionarSolicitudPedidoCabe();
            if (iIngEN.Adicionales.EsVerdad == false) { return; }

            //instanciar
            wEditSolicitudPedido win = new wEditSolicitudPedido();
            win.wSol = this;
            win.eOperacion = Universal.Opera.Adicionar;
            this.eFranjaDgvMovCab = Dgv.Franja.PorValor;
            TabCtrl.InsertarVentana(this, win);
            win.VentanaAdicionar();
        }

        public void AccionModificar()
        {
            //preguntar si el registro seleccionado existe
            SolicitudPedidoCabeEN iIngEN = this.EsActoModificarSolicitudPedidoCabe();
            if (iIngEN.Adicionales.EsVerdad == false) { return; }

            //si existe
            wEditSolicitudPedido win = new wEditSolicitudPedido();
            win.wSol = this;
            win.eOperacion = Universal.Opera.Modificar;
            this.eFranjaDgvMovCab = Dgv.Franja.PorValor;
            TabCtrl.InsertarVentana(this, win);
            win.VentanaModificar(iIngEN);
        }

        public void AccionGenerarVariasSolicitudes()
        {
            //preguntar si el registro seleccionado existe
            SolicitudPedidoCabeEN iIngEN = this.EsActoAgregarVariasSolicitudPedidoCabe();
            if (iIngEN.Adicionales.EsVerdad == false) { return; }

            //si existe
            wSelAux win = new wSelAux();
            win.wSol = this;
            win.eTituloVentana = "Proveedores";
            win.eOperacion = Universal.Opera.AgregarVarios;
            this.eFranjaDgvMovCab = Dgv.Franja.PorValor;
            TabCtrl.InsertarVentana(this, win);
            if (!iIngEN.MasivoSolicitudPedidoCabe)
            {
                Mensaje.OperacionSatisfactoria("La solicitud de pedido no es masivo.", this.eTitulo);
                return;
            }
            else
                win.VentanaAgregarVarios(iIngEN);
        }

        public SolicitudPedidoCabeEN EsActoAgregarVariasSolicitudPedidoCabe()
        {
            SolicitudPedidoCabeEN iIngEN = new SolicitudPedidoCabeEN();
            this.AsignarSolicitudPedidoCabe(iIngEN);
            iIngEN = SolicitudPedidoCabeRN.EsActoAgregarVariasSolicitudPedidoCabe(iIngEN);
            if (iIngEN.Adicionales.EsVerdad == false)
            {
                Mensaje.OperacionDenegada(iIngEN.Adicionales.Mensaje, this.eTitulo);
            }
            return iIngEN;
        }

        public void AccionModificarAlHacerDobleClick(int pColumna, int pFila)
        {
            //no debe pasar cuando la fila o columna sea -1
            if (pColumna == -1 || pFila == -1) { return; }

            //preguntar si este usuario tiene acceso a la accion modificar
            //basta con ver si el boton modificar esta habilitado o no
            if (tsbModificar.Enabled == false)
            {
                Mensaje.OperacionDenegada("Tu usuario no tiene permiso para modificar este registro", "Modificar");
            }
            else
            {
                this.AccionModificar();
            }
        }

        public void AccionEliminar()
        {
            //preguntar si el registro seleccionado existe
            SolicitudPedidoCabeEN iCuoEN = this.EsActoEliminarSolicitudPedidoCabe();
            if (iCuoEN.Adicionales.EsVerdad == false) { return; }

            //si existe
            wEditSolicitudPedido win = new wEditSolicitudPedido();
            win.wSol = this;
            win.eOperacion = Universal.Opera.Eliminar;
            this.eFranjaDgvMovCab = Dgv.Franja.PorIndice;
            TabCtrl.InsertarVentana(this, win);
            win.VentanaEliminar(iCuoEN);
        }

        public void AccionVisualizar()
        {
            //preguntar si el registro seleccionado existe
            SolicitudPedidoCabeEN iCuoEN = this.EsSolicitudPedidoCabeExistente();
            if (iCuoEN.Adicionales.EsVerdad == false) { return; }

            //si existe
            wEditSolicitudPedido win = new wEditSolicitudPedido();
            win.wSol = this;
            win.eOperacion = Universal.Opera.Visualizar;
            TabCtrl.InsertarVentana(this, win);
            win.VentanaVisualizar(iCuoEN);
        }

        //public void AccionImportarExcel()
        //{
        //    //instanciar
        //    wImportarSolicitudPedidosIngresos win = new wImportarSolicitudPedidosIngresos();
        //    win.wIng = this;
        //    TabCtrl.InsertarVentana(this, win);
        //    win.NuevaVentana();
        //}

        public void AccionEliminarImportarExcel()
        {
            //validar
            SolicitudPedidoCabeEN iMovCabEN = this.EsActoEliminarImportacionSolicitudPedidoCabes();
            if (iMovCabEN.Adicionales.EsVerdad == false) { return; }

            //desea realizar la operacion
            if (Mensaje.DeseasRealizarOperacion("Eliminar importacion") == false) { return; }

            //eliminar copia
            SolicitudPedidoCabeRN.EliminarAntesDeImportarIngreso(this.lblPeriodo.Text);

            //mensaje satisfactorio
            Mensaje.OperacionSatisfactoria("Se elimino la importacion", this.eTitulo);

            //actualizar ventana
            this.ActualizarVentana();
        }

        public void AccionImprimirNota()
        {
            //preguntar si el registro seleccionado existe
            SolicitudPedidoCabeEN iSalEN = this.EsSolicitudPedidoCabeExistente();
            if (iSalEN.Adicionales.EsVerdad == false) { return; }

            //si existe
            wImpSolicitudPedido win = new wImpSolicitudPedido();
            win.wSol = this;
            win.eVentana = wImpSolicitudPedido.Ventana.wSolicitudPedido;
            //win.NuevaVentana(iSalEN);
        }

        public void AccionSeleccionarPeriodo()
        {
            vSeleccionarPeriodo win = new vSeleccionarPeriodo();
            win.eVentanaInvoca = this;
            win.eControlDevuelveValor = lblPeriodo;
            win.ePeriodoActual = lblPeriodo.Text;
            TabCtrl.InsertarVentana(this, win);
            win.NuevaVentana();
        }

        public SolicitudPedidoCabeEN EsSolicitudPedidoCabeExistente()
        {
            SolicitudPedidoCabeEN iCuoEN = new SolicitudPedidoCabeEN();
            this.AsignarSolicitudPedidoCabe(iCuoEN);
            iCuoEN = SolicitudPedidoCabeRN.EsSolicitudPedidoCabeExistente(iCuoEN);
            if (iCuoEN.Adicionales.EsVerdad == false)
            {
                Mensaje.OperacionDenegada(iCuoEN.Adicionales.Mensaje, this.eTitulo);
            }
            return iCuoEN;
        }

        public SolicitudPedidoCabeEN EsActoAdicionarSolicitudPedidoCabe()
        {
            SolicitudPedidoCabeEN iIngEN = new SolicitudPedidoCabeEN();
            this.AsignarSolicitudPedidoCabe(iIngEN);
            iIngEN = SolicitudPedidoCabeRN.EsActoAdicionarSolicitudPedidoCabe(iIngEN);
            if (iIngEN.Adicionales.EsVerdad == false)
            {
                Mensaje.OperacionDenegada(iIngEN.Adicionales.Mensaje, this.eTitulo);
            }

            return iIngEN;
        }

        public SolicitudPedidoCabeEN EsActoModificarSolicitudPedidoCabe()
        {
            SolicitudPedidoCabeEN iIngEN = new SolicitudPedidoCabeEN();
            this.AsignarSolicitudPedidoCabe(iIngEN);
            iIngEN = SolicitudPedidoCabeRN.EsActoModificarSolicitudPedidoCabe(iIngEN);
            if (iIngEN.Adicionales.EsVerdad == false)
            {
                Mensaje.OperacionDenegada(iIngEN.Adicionales.Mensaje, this.eTitulo);
            }
            return iIngEN;
        }

        public SolicitudPedidoCabeEN EsActoEliminarSolicitudPedidoCabe()
        {
            SolicitudPedidoCabeEN iIngEN = new SolicitudPedidoCabeEN();
            this.AsignarSolicitudPedidoCabe(iIngEN);
            iIngEN = SolicitudPedidoCabeRN.EsActoEliminarSolicitudPedidoCabe(iIngEN);
            if (iIngEN.Adicionales.EsVerdad == false)
            {
                Mensaje.OperacionDenegada(iIngEN.Adicionales.Mensaje, this.eTitulo);
            }
            return iIngEN;
        }

        public SolicitudPedidoCabeEN EsActoEliminarImportacionSolicitudPedidoCabes()
        {
            SolicitudPedidoCabeEN iIngEN = new SolicitudPedidoCabeEN();
            this.AsignarSolicitudPedidoCabe(iIngEN);
            iIngEN = SolicitudPedidoCabeRN.EsActoEliminarImportacionSolicitudPedidoCabeIngreso(iIngEN);
            if (iIngEN.Adicionales.EsVerdad == false)
            {
                Mensaje.OperacionDenegada(iIngEN.Adicionales.Mensaje, this.eTitulo);
            }
            return iIngEN;
        }

        public void AccionCambiaPeriodo()
        {
            //poner la descripcion del mes
            lblDescripcionPeriodo.Text = AñoMes.ObtenerDescripcionPeriodo(lblPeriodo.Text);

            //MessageBox.Show(lblDescripcionPeriodo.Text);

            //guardar el nuevo periodo
            Properties.Settings.Default.GuardarPeriodoIngresos = TsL.ModificarValor(Properties.Settings.Default.GuardarPeriodoIngresos, Universal.gCodigoEmpresa, lblPeriodo);
            Properties.Settings.Default.Save();

            //actualizar ventana
            this.ActualizarVentana();
        }

        public void MostrarPersistencia()
        {
            TsL.MostrarValor(lblPeriodo, Properties.Settings.Default.GuardarPeriodoIngresos, Universal.gCodigoEmpresa);
        }

        public void Cerrar()
        {
            //obtener al wMenu
            wMenu wMen = (wMenu)this.ParentForm;
            wMen.CerrarVentanaHijo(this, wMen.iteSolicitudPedido, null);
        }

        public void OrdenarPorColumna(int pColumna)
        {
            this.eFranjaDgvMovCab = Dgv.Franja.PorIndice;
            this.eNombreColumnaDgvMovCab = this.DgvMovCab.Columns[pColumna].Name;
            this.eEncabezadoColumnaDgvMovCab = this.DgvMovCab.Columns[pColumna].HeaderText;
            this.ActualizarVentana();
        }

        public void ActualizarVentanaAlBuscarValor(KeyEventArgs pE)
        {
            //verificar que tecla pulso el usuario
            switch (pE.KeyCode)
            {
                case Keys.Up:
                    {
                        Dgv.SeleccionarRegistroXDesplazamiento(this.DgvMovCab, WinControles.ControlesWindows.Dgv.Desplazar.Anterior);
                        Txt.CursorAlUltimo(this.tstBuscar); break;
                    }
                case Keys.Down:
                    {
                        Dgv.SeleccionarRegistroXDesplazamiento(this.DgvMovCab, WinControles.ControlesWindows.Dgv.Desplazar.Siguiente);
                        Txt.CursorAlUltimo(this.tstBuscar); break;
                    }
                case Keys.Left:
                case Keys.Right:
                    {
                        break;
                    }
                default:
                    {
                        if (this.tstBuscar.Text != string.Empty) { eVaBD = 0; }
                        this.ActualizarVentana();
                        eVaBD = 1;
                        break;
                    }
            }
        }


        #endregion


        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
            this.AccionAdicionar();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            this.AccionModificar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            this.AccionEliminar();
        }

        private void tsbVisualizar_Click(object sender, EventArgs e)
        {
            this.AccionVisualizar();
        }

        private void tsbActualizarTabla_Click(object sender, EventArgs e)
        {
            this.eFranjaDgvMovCab = Dgv.Franja.PorIndice;
            this.ActualizarVentana();
        }

        private void DgvMovCab_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Dgv.HabilitarDesplazadores(this.DgvMovCab, this.tsbPrimero, this.tsbAnterior, this.tsbSiguiente, this.tsbUltimo);
            Dgv.ActualizarBarraEstado(this.DgvMovCab, this.sst1);
        }

        private void tsbPrimero_Click(object sender, EventArgs e)
        {
            Dgv.SeleccionarRegistroXDesplazamiento(this.DgvMovCab, Dgv.Desplazar.Primero);
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            Dgv.SeleccionarRegistroXDesplazamiento(this.DgvMovCab, Dgv.Desplazar.Anterior);
        }

        private void tsbSiguiente_Click(object sender, EventArgs e)
        {
            Dgv.SeleccionarRegistroXDesplazamiento(this.DgvMovCab, Dgv.Desplazar.Siguiente);
        }

        private void tsbUltimo_Click(object sender, EventArgs e)
        {
            Dgv.SeleccionarRegistroXDesplazamiento(this.DgvMovCab, Dgv.Desplazar.Ultimo);
        }

        private void DgvMovCab_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.OrdenarPorColumna(e.ColumnIndex);
        }

        private void DgvMovCab_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.AccionModificarAlHacerDobleClick(e.ColumnIndex, e.RowIndex);
        }

        private void tstBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            this.ActualizarVentanaAlBuscarValor(e);
        }

        private void btnPeriodo_Click(object sender, EventArgs e)
        {
            this.AccionSeleccionarPeriodo();
        }

        private void lblPeriodo_TextChanged(object sender, EventArgs e)
        {
            this.AccionCambiaPeriodo();
        }

        private void tsbImprimirNota_Click(object sender, EventArgs e)
        {
            this.AccionImprimirNota();
        }

        private void IteImportarAdicionar_Click(object sender, EventArgs e)
        {
            //this.AccionImportarExcel();
        }

        private void IteImportarEliminar_Click(object sender, EventArgs e)
        {
            this.AccionEliminarImportarExcel();
        }

        private void wSolicitudPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cerrar();
        }

        private void tsbCopiar_Click(object sender, EventArgs e)
        {
            this.AccionGenerarVariasSolicitudes();
        }

        private void tsbEnviar_Click(object sender, EventArgs e)
        {

        }
    }
}
