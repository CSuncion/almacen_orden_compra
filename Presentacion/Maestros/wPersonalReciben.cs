﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Heredados;
using WinControles;
using WinControles.ControlesWindows;
using Entidades.Adicionales;
using Comun;
using Entidades;
using Negocio;
using Presentacion.Principal;
using System.Collections;

namespace Presentacion.Maestros
{
    public partial class wPersonalReciben : Heredados.MiForm8
    {
        public wPersonalReciben()
        {
            InitializeComponent();
        }

        #region Atributos

        string eNombreColumnaDgvPer = PersonalRecibenEN.CodPerRec;
        string eEncabezadoColumnaDvgPer = "Codigo";
        public string eClaveDgvPer = string.Empty;
        Dgv.Franja eFranjaDgvPer = Dgv.Franja.PorIndice;
        public List<PersonalRecibenEN> eLisPer = new List<PersonalRecibenEN>();
        int eVaBD = 1;//0 : no , 1 : si
        public string eTitulo = "Personal Reciben";

        #endregion
           
        #region General


        public void NuevaVentana()
        {
            this.Show();       
            this.ActualizarVentana();          
        }
        
        public void ActualizarVentana()
        {
            this.ActualizarListaPersonalesDeBaseDatos();
            this.ActualizarDgvPer();
            Dgv.HabilitarDesplazadores(this.DgvPer, this.tsbPrimero, this.tsbAnterior, this.tsbSiguiente, this.tsbUltimo);
            this.HabilitarAcciones();
            Dgv.ActualizarBarraEstado(this.DgvPer, this.sst1);         
        }
        
        public void ActualizarDgvPer()
        {
            //asignar parametros
            DataGridView iGrilla = this.DgvPer;
            List<PersonalRecibenEN> iFuenteDatos = this.ObtenerDatosParaGrilla();
            Dgv.Franja iCondicionFranja = eFranjaDgvPer;
            string iClaveBusqueda = eClaveDgvPer;
            string iColumnaPintura = eNombreColumnaDgvPer;
            List<DataGridViewColumn> iListaColumnas = this.ListarColumnasDgvPer();

            //ejecutar metodo
            Dgv.RefrescarGrilla(iGrilla, iFuenteDatos, iCondicionFranja, iClaveBusqueda, iColumnaPintura, iListaColumnas);
        }
        
        public List<DataGridViewColumn> ListarColumnasDgvPer()
        {
            //lista resultado
            List<DataGridViewColumn> iLisRes = new List<DataGridViewColumn>();

            //agregando las columnas
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(PersonalRecibenEN.CodPerRec, "Codigo", 45));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(PersonalRecibenEN.NomPerRec, "Nombre", 276));
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(PersonalRecibenEN.NEstPerRec, "Estado", 70));           
            iLisRes.Add(Dgv.NuevaColumnaTextCadena(PersonalRecibenEN.ClaObj, "Clave", 90, false));

            //devolver
            return iLisRes;
        }

        public void ActualizarListaPersonalesDeBaseDatos()
        {
            //validar si es acto ir a la bd
            if (tstBuscar.Text.Trim() != string.Empty && eVaBD == 0) { return; }

            //ir a la bd
            PersonalRecibenEN iPerEN = new PersonalRecibenEN();
            iPerEN.Adicionales.CampoOrden = eNombreColumnaDgvPer;
            this.eLisPer = PersonalRecibenRN.ListarPersonales(iPerEN);
        }

        public List<PersonalRecibenEN> ObtenerDatosParaGrilla()
        {
            //asignar parametros
            string iValorBusqueda = tstBuscar.Text.Trim();
            string iCampoBusqueda = eNombreColumnaDgvPer;
            List<PersonalRecibenEN> iLisPer = eLisPer;

            //ejecutar y retornar
            return PersonalRecibenRN.ListarDatosParaGrillaPrincipal(iValorBusqueda, iCampoBusqueda, iLisPer);
        }

        public void HabilitarAcciones()
        {
            //asignar parametros
            ToolStrip iTs1 = tsPrincipal;
            ToolStrip iTs2 = tsSecundario;
            Hashtable iLisPer = PermisoUsuarioRN.ListarPermisosParaVentana("008", DgvPer.Rows.Count);

            //ejecutar metodo
            Tst.HabilitarItems(iTs1, iTs2, iLisPer);
        }
             
        public void AsignarPersonal(PersonalRecibenEN pObj)
        {
            pObj.CodigoPersonalRecibe = Dgv.ObtenerValorCelda(this.DgvPer, PersonalRecibenEN.CodPerRec);
        }
        
        public void AccionAdicionar()
        {
            wEditPersonalReciben win = new wEditPersonalReciben();
            win.wPerRec = this;
            win.eOperacion = Universal.Opera.Adicionar;
            this.eFranjaDgvPer = Dgv.Franja.PorValor;
            TabCtrl.InsertarVentana(this, win);
            win.VentanaAdicionar();
        }
        
        public void AccionModificar()
        {
            //preguntar si el registro seleccionado existe
            PersonalRecibenEN iPerEN = this.EsActoModificarPersonal();
            if (iPerEN.Adicionales.EsVerdad == false) { return; }

            //si existe
            wEditPersonalReciben win = new wEditPersonalReciben();
            win.wPerRec = this;
            win.eOperacion = Universal.Opera.Modificar;
            this.eFranjaDgvPer = Dgv.Franja.PorValor;
            TabCtrl.InsertarVentana(this, win);
            win.VentanaModificar(iPerEN);            
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
            PersonalRecibenEN iPerEN = this.EsActoEliminarPersonal();
            if (iPerEN.Adicionales.EsVerdad == false) { return; }

            //si existe
            wEditPersonalReciben win = new wEditPersonalReciben();
            win.wPerRec = this;
            win.eOperacion = Universal.Opera.Eliminar;
            this.eFranjaDgvPer = Dgv.Franja.PorIndice;
            TabCtrl.InsertarVentana(this, win);
            win.VentanaEliminar(iPerEN);    
        }
        
        public void AccionVisualizar()
        {
            //preguntar si el registro seleccionado existe
            PersonalRecibenEN iPerEN = this.EsPersonalExistente();
            if (iPerEN.Adicionales.EsVerdad == false) { return; }

            //si existe
            wEditPersonalReciben win = new wEditPersonalReciben();
            win.wPerRec = this;
            win.eOperacion = Universal.Opera.Visualizar;            
            TabCtrl.InsertarVentana(this, win);
            win.VentanaVisualizar(iPerEN);               
        }

        public PersonalRecibenEN EsPersonalExistente()
        {
            PersonalRecibenEN iPerEN = new PersonalRecibenEN();
            this.AsignarPersonal(iPerEN);
            iPerEN = PersonalRecibenRN.EsPersonalExistente(iPerEN);
            if (iPerEN.Adicionales.EsVerdad == false)
            {
                Mensaje.OperacionDenegada(iPerEN.Adicionales.Mensaje, eTitulo);
            }
            return iPerEN;
        }

        public PersonalRecibenEN EsActoModificarPersonal()
        {
            PersonalRecibenEN iPerEN = new PersonalRecibenEN();
            this.AsignarPersonal(iPerEN);
            iPerEN = PersonalRecibenRN.EsActoModificarPersonal(iPerEN);
            if (iPerEN.Adicionales.EsVerdad == false)
            {
                Mensaje.OperacionDenegada(iPerEN.Adicionales.Mensaje, eTitulo);
            }
            return iPerEN;
        }

        public PersonalRecibenEN EsActoEliminarPersonal()
        {
            PersonalRecibenEN iPerEN = new PersonalRecibenEN();
            this.AsignarPersonal(iPerEN);
            iPerEN = PersonalRecibenRN.EsActoEliminarPersonal(iPerEN);
            if (iPerEN.Adicionales.EsVerdad == false)
            {
                Mensaje.OperacionDenegada(iPerEN.Adicionales.Mensaje, eTitulo);
            }
            return iPerEN;
        }

        public void Cerrar()
        {
            //obtener al wMenu
            wMenu wMen = (wMenu)this.ParentForm;
            wMen.CerrarVentanaHijo(this, wMen.ItePersonalReciben, null);        
        }

        public void OrdenarPorColumna(int pColumna)
        {
            this.eFranjaDgvPer = Dgv.Franja.PorIndice;
            this.eNombreColumnaDgvPer = this.DgvPer.Columns[pColumna].Name;
            this.eEncabezadoColumnaDvgPer = this.DgvPer.Columns[pColumna].HeaderText;
            this.ActualizarVentana();     
        }

        public void ActualizarVentanaAlBuscarValor(KeyEventArgs pE)
        {
            //verificar que tecla pulso el usuario
            switch (pE.KeyCode)
            {

                case Keys.Up:
                    {
                        Dgv.SeleccionarRegistroXDesplazamiento(this.DgvPer, WinControles.ControlesWindows.Dgv.Desplazar.Anterior);
                        Txt.CursorAlUltimo(this.tstBuscar); break;
                    }
                case Keys.Down:
                    {
                        Dgv.SeleccionarRegistroXDesplazamiento(this.DgvPer, WinControles.ControlesWindows.Dgv.Desplazar.Siguiente);
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
             
        private void wPersonal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cerrar();
        }

        private void tsbActualizarTabla_Click(object sender, EventArgs e)
        {
            this.eFranjaDgvPer = Dgv.Franja.PorIndice;
            this.ActualizarVentana();
        }

        private void DgvPer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Dgv.HabilitarDesplazadores(this.DgvPer, this.tsbPrimero, this.tsbAnterior, this.tsbSiguiente, this.tsbUltimo);
            Dgv.ActualizarBarraEstado(this.DgvPer, this.sst1);
        }

        private void tsbPrimero_Click(object sender, EventArgs e)
        {
            Dgv.SeleccionarRegistroXDesplazamiento(this.DgvPer, Dgv.Desplazar.Primero);
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            Dgv.SeleccionarRegistroXDesplazamiento(this.DgvPer, Dgv.Desplazar.Anterior);
        }

        private void tsbSiguiente_Click(object sender, EventArgs e)
        {
            Dgv.SeleccionarRegistroXDesplazamiento(this.DgvPer, Dgv.Desplazar.Siguiente);
        }

        private void tsbUltimo_Click(object sender, EventArgs e)
        {
            Dgv.SeleccionarRegistroXDesplazamiento(this.DgvPer, Dgv.Desplazar.Ultimo);
        }

        private void DgvPer_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.OrdenarPorColumna(e.ColumnIndex);
        }

        private void DgvPer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.AccionModificarAlHacerDobleClick(e.ColumnIndex, e.RowIndex);
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
        
        private void tstBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            this.ActualizarVentanaAlBuscarValor(e);
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
