using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication3
{
    public partial class MenuPrincipal : Form
    {
        int ValidarAdminin = 0;
        public MenuPrincipal(int Administrador = 1)
        {
            InitializeComponent();
            ValidarAdminin = Administrador;
            persolanizarDiseño();
            csConexion conect = new csConexion();
            conect.LeerMES();

        }
        private void persolanizarDiseño()
            {
            panelSubMenuAportes.Visible=false;
            panelSubMenuTrabajadores.Visible=false;
            panelConvenios.Visible = false;
            panelSubMenuBanco.Visible = false;
            panelSubMenuCargos.Visible = false;
 panel_analitycs.Visible = false;

        }
        private void ocualtarSubMenu()
        {
            if (panelSubMenuAportes.Visible==true) 
            {
                panelSubMenuAportes.Visible = false;
            }
            if (panelSubMenuTrabajadores.Visible == true)
            {
                panelSubMenuTrabajadores.Visible = false;
            }
        }
        private void verSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocualtarSubMenu();
                subMenu.Visible = true;
            }
            else { subMenu.Visible = false; }
        }

        private void btnAportes_Click(object sender, EventArgs e)
        {
            verSubmenu(panelSubMenuAportes);
      
        }

        private void btnIngresarAporte_Click(object sender, EventArgs e)
        {
            csConexion comprobarconfig = new csConexion();
            comprobarconfig.EscribirFC();
            comprobarconfig.LeerFC();
            int com = comprobarconfig.bloque0;
            if (com == 1)
            {
                MessageBox.Show("NO PUEDE REALIZAR ESTA ACCION PORQUE SE HA CERRADO EL MES");
            }
            else
            {
                AbrirFormulario(new frmIngresarAporteDiario());
                ocualtarSubMenu();
            }
        }

        private void btnVerListaAportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmListaDeAportesDiarios());
            ocualtarSubMenu();
        }

        private void btnHistorialAportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmListaDeBauches());
            ocualtarSubMenu();
        }

        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            if (ValidarAdminin == 0)
            {
                DialogResult opcionadmin = new DialogResult();
                frmUsuarioAdministrador admin = new frmUsuarioAdministrador();
                opcionadmin = admin.ShowDialog();
                if (opcionadmin == DialogResult.OK)
                {
                    verSubmenu(panelSubMenuTrabajadores);
                }
            }
            else
            {
                verSubmenu(panelSubMenuTrabajadores);
            }
            
        }

        private void btnRegistrarTrabajador_Click(object sender, EventArgs e)
        {
            
                DialogResult opcion = new DialogResult();
                MessgaeAgregarTrabajador AggTrabajador = new MessgaeAgregarTrabajador();
                opcion = AggTrabajador.ShowDialog();
                if (opcion == DialogResult.OK )
                { AbrirFormulario(new frmRegistrarTaxista()); }
                else if (opcion == DialogResult.Cancel)
                { AbrirFormulario(new frmRegistrarOtroTipoTrabajador()); } 
                else
                { }
            ocualtarSubMenu();
        }

        private void btnListaTrabajador_Click(object sender, EventArgs e)
        {
            DialogResult opcion = new DialogResult();
            MessgaeAgregarTrabajador AggTrabajador = new MessgaeAgregarTrabajador();
            opcion = AggTrabajador.ShowDialog();
            if (opcion == DialogResult.OK)
            { AbrirFormulario(new frmVerTxista()); }  //new frmListaTaxistas());
            else if (opcion == DialogResult.Cancel)
            { AbrirFormulario(new frmVerTrabajador()); }  //AbrirFormulario(new frmListaDeOtrosTrabajadores());
            else
            { }
            ocualtarSubMenu();
        }

        private void btnTaxis_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRegistrarTaxi());
            ocualtarSubMenu();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private Form formularioActivo = null;


        public void AbrirFormulario(Form nuevoFormulario)
        {
            if (formularioActivo!=null)
            {
                formularioActivo.Close();
            }
                formularioActivo = nuevoFormulario;
                nuevoFormulario.TopLevel = false;
                nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
                nuevoFormulario.Dock = DockStyle.Fill;
                panelOPCIONES.Controls.Add(nuevoFormulario);
                panelOPCIONES.Tag = nuevoFormulario;
                nuevoFormulario.BringToFront();
                nuevoFormulario.Show();
            
        }

        private void btnFacturarMes_Click(object sender, EventArgs e)
        {
            if (ValidarAdminin == 0)
            {
                DialogResult opcionadmin = new DialogResult();
                frmUsuarioAdministrador admin = new frmUsuarioAdministrador();
                opcionadmin = admin.ShowDialog();
                if (opcionadmin == DialogResult.OK)
                {
                    AbrirFormulario(new frmFacturarMes());
                    ocualtarSubMenu();
                }
            }
            else
            {
                AbrirFormulario(new frmFacturarMes());
                ocualtarSubMenu();
            }
            
           
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            if (ValidarAdminin == 0)
            {
                DialogResult opcionadmin = new DialogResult();
                frmUsuarioAdministrador admin = new frmUsuarioAdministrador();
                opcionadmin = admin.ShowDialog();
                if (opcionadmin == DialogResult.OK)
                {

                    DialogResult opcion2 = new DialogResult();
                    frmOpcionesCaja caja = new frmOpcionesCaja();
                    opcion2 = caja.ShowDialog();
                    if (opcion2 == DialogResult.OK)
                    { AbrirFormulario(new frmCaja()); }
                    else if (opcion2 == DialogResult.Cancel)
                    { AbrirFormulario(new frmRetirarCaja()); }
                    else if (opcion2 == DialogResult.Abort)
                    { AbrirFormulario(new frmHistorialCaja()); }
                    else
                    { }
                }
            }
            else
            {

                DialogResult opcion2 = new DialogResult();
                frmOpcionesCaja caja = new frmOpcionesCaja();
                opcion2 = caja.ShowDialog();
                if (opcion2 == DialogResult.OK)
                { AbrirFormulario(new frmCaja()); }
                else if (opcion2 == DialogResult.Cancel)
                { AbrirFormulario(new frmRetirarCaja()); }
                else if (opcion2 == DialogResult.Abort)
                { AbrirFormulario(new frmHistorialCaja()); }
                else
                { }

            }
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {

        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            DialogResult opcionadmin = new DialogResult();
            frmUsuarioAdministrador admin = new frmUsuarioAdministrador();
            opcionadmin = admin.ShowDialog();
            if (opcionadmin == DialogResult.OK)
            {
                AbrirFormulario(new frmAJUSTES());
                ocualtarSubMenu();
            }
        }

        private void btnListaTaxis_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmListadeTaxis());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult opcionadmin = new DialogResult();
            frmUsuarioAdministrador admin = new frmUsuarioAdministrador();
            opcionadmin = admin.ShowDialog();
            if (opcionadmin == DialogResult.OK)
            {
                AbrirFormulario(new frmAJUSTES());
                ocualtarSubMenu();
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            csConexion comprobarconfig = new csConexion();
            comprobarconfig.LeerConfig("11");
            int validar = comprobarconfig.Pasar;
            if (validar == 0)
            { frmPrimerIngreso ingreso = new frmPrimerIngreso(); ingreso.ShowDialog(); }
            csEmpresa nombre = new csEmpresa();
            nombre.listarEmpresa();
            lblEMPRESA.Text=nombre.Nom_Empresa;
            comprobarconfig.EscribirFC();
            comprobarconfig.LeerFC();
            int com = comprobarconfig.bloque0;
            if (com == 1)
            {
                btnIngresarAporte.Enabled = false; button4.Enabled = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAJUSTES());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDatos_de_la_empresa(1));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;
            MessageBox.Show(fecha.Day.ToString());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmListaMes mes = new frmListaMes();
            mes.Show();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
           DateTime fecha = DateTime.UtcNow.Date;

            frmListaMes mes = new frmListaMes();
            mes.fecha = fecha;
            mes.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDIARIOREPORT diario = new frmDIARIOREPORT();
            DateTime fecha= DateTime.UtcNow.Date;
            diario.FECHA_DIARIA= fecha;
            diario.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ValidarAdminin == 0)
            {
                DialogResult opcionadmin = new DialogResult();
                frmUsuarioAdministrador admin = new frmUsuarioAdministrador();
                opcionadmin = admin.ShowDialog();
                if (opcionadmin == DialogResult.OK)
                {
                    verSubmenu(panelConvenios);
                }
            }
            else
            {
                verSubmenu(panelConvenios);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmREGISTRAR_CONVENIO());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmConvenios());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ValidarAdminin == 0)
            {
                DialogResult opcionadmin = new DialogResult();
                frmUsuarioAdministrador admin = new frmUsuarioAdministrador();
                opcionadmin = admin.ShowDialog();
                if (opcionadmin == DialogResult.OK)
                {
                    verSubmenu(panelSubMenuBanco);
                }
            }
            else
            {
                verSubmenu(panelSubMenuBanco);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ValidarAdminin == 0)
            {
                DialogResult opcionadmin = new DialogResult();
                frmUsuarioAdministrador admin = new frmUsuarioAdministrador();
                opcionadmin = admin.ShowDialog();
                if (opcionadmin == DialogResult.OK)
                {
                    verSubmenu(panelSubMenuCargos);
                }
            }
            else
            {
                verSubmenu(panelSubMenuCargos);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmLibretaDeAhorros());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmTRANSFERENCIAS_BANCARIAS());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCargo());
        }

        private void panelOPCIONES_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDECLARACIONCUENTA());
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmTRANSFERENCIA_A_OTRA_CUENTA());
        }

        private void btnReporte1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new frmReporteVoucheDiario());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            csConexion comprobarconfig = new csConexion();
            comprobarconfig.EscribirFC();
            comprobarconfig.LeerFC();
            int com = comprobarconfig.bloque0;
            if (com == 1)
            {
                MessageBox.Show("NO PUEDE REALIZAR ESTA ACCION PORQUE SE HA CERRADO EL MES");
            }
            else
            {
                AbrirFormulario(new frmVOUCHER());
            }
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRESUMEN_BANCARIO_CRUZADO());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmReporteVoucheDiario());

        }

        private void button17_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRESUMEN_BANCARIO_CRUZADO());

        }

        private void button13_Click(object sender, EventArgs e)
        {
            verSubmenu(panel_analitycs);

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            verSubmenu(panel_analitycs);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmReporteVoucheDiario());

        }

        private void button23_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRESUMEN_BANCARIO_CRUZADO());

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCMmfsPNWz7DTYMKw7lgIyDA");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/Sotax__");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/profile.php?id=100072296601424");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/sotax__/?hl=es");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmHISTORIAL_AP_TAXISTAS());
        }

        private void btnResumenTotal_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmResumenTotalAños());
        }

        private void btnResumen_VoucherEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmResumenTotalVoucherEmpresa());
        }

        private void button21_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAporteVoucherTaxista());
        }

        private void btnAportes_MouseEnter(object sender, EventArgs e)
        {
            Animacion_ENTER(btnAportes);
        }

        private void btnAportes_MouseLeave(object sender, EventArgs e)
        {
            Animacion_LEAVE(btnAportes);

        }
        private void Animacion_ENTER(Button btn)
        {
            btn.ForeColor = Color.Black;
            btn.Padding = new Padding(29, 0, 0, 0);
            btn.Font = new Font("Microsoft JhengHei UI", 16, FontStyle.Bold);
        }
        private void Sub_Menu_ENTER(Button btn2) //TRABJANDO EN ESTE 
        {
            btn2.ForeColor = Color.Black;
            btn2.Padding = new Padding(55, 0, 0, 0);
            btn2.Font = new Font("Microsoft Tai Le", 11);
        }
        private void Sub_Menu_LEAVE(Button btn2)
        {
            btn2.ForeColor = Color.White;
            btn2.Padding = new Padding(45, 0, 0, 0);
            btn2.Font = new Font("Microsoft Tai Le", 8);
        }
        private void Animacion_LEAVE(Button btn)
        {
            btn.ForeColor = Color.White;
            btn.Padding = new Padding(0, 0, 0, 0);
            btn.Font = new Font("Microsoft JhengHei UI", 11, FontStyle.Bold);
        }

        private void btnTrabajadores_MouseEnter(object sender, EventArgs e)
        {
            btnTrabajadores.ForeColor = Color.Black;
            btnTrabajadores.Padding = new Padding(29, 0, 0, 0);
            btnTrabajadores.Font = new Font("Microsoft JhengHei UI", 13, FontStyle.Bold);
        }

        private void btnTrabajadores_MouseLeave(object sender, EventArgs e)
        {
            Animacion_LEAVE(btnTrabajadores);
        }

        private void btnFacturarMes_Enter(object sender, EventArgs e)
        {
            Animacion_ENTER(btnFacturarMes);
        }

        private void btnFacturarMes_MouseEnter(object sender, EventArgs e)
        {
            Animacion_ENTER(btnFacturarMes);

        }

        private void btnFacturarMes_MouseLeave(object sender, EventArgs e)
        {
            Animacion_LEAVE(btnFacturarMes);
        }

        private void btnCaja_MouseEnter(object sender, EventArgs e)
        {
            Animacion_ENTER(btnCaja);
        }

        private void btnCaja_MouseLeave(object sender, EventArgs e)
        {
            Animacion_LEAVE(btnCaja);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Animacion_ENTER(button1);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Animacion_LEAVE(button1);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            Animacion_ENTER(button5);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            Animacion_LEAVE(button5);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            Animacion_ENTER(button6);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            Animacion_LEAVE(button6);
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            Animacion_ENTER(button7);
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            Animacion_LEAVE(button7);
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            Animacion_ENTER(button13);
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            Animacion_LEAVE(button13);
        }

        private void panellogo_MouseEnter(object sender, EventArgs e)
        {
            picSotax1.BringToFront();
        }

        private void panellogo_MouseLeave(object sender, EventArgs e)
        {
          
            picSOTAX2.BringToFront();
        }

        private void picSotax1_MouseEnter(object sender, EventArgs e)
        {
            picSOTAX2.BringToFront();

        }

        private void picSOTAX2_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void picSOTAX2_MouseLeave(object sender, EventArgs e)
        {
            picSotax1.BringToFront();
        }

        private void btnIngresarAporte_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(btnIngresarAporte);
        }

        private void btnIngresarAporte_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(btnIngresarAporte);
        }

        private void btnVerListaAportes_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(btnVerListaAportes);
        }

        private void btnVerListaAportes_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(btnVerListaAportes);
        }

        private void btnHistorialAportes_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(btnHistorialAportes);
        }

        private void btnHistorialAportes_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(btnHistorialAportes);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(button2);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(button2);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(button3);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(button3);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(button4);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(button4);
        }

        private void btnRegistrarTrabajador_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(btnRegistrarTrabajador);
        }

        private void btnRegistrarTrabajador_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(btnRegistrarTrabajador);
        }

        private void btnListaTrabajador_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(btnListaTrabajador);
        }

        private void btnListaTrabajador_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(btnListaTrabajador);
        }

        private void btnRegistrarTaxis_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(btnRegistrarTaxis);
        }

        private void btnRegistrarTaxis_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(btnRegistrarTaxis);
        }

        private void btnListaTaxis_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(btnListaTaxis);
        }

        private void btnListaTaxis_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(btnListaTaxis);
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(button9);
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(button9);
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(button8);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(button8);
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(button11);
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(button11);
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(button10);
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(button10);
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(button12);
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(button12);
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(button18);
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(button18);
        }

        private void btnCargo_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(btnCargo);
        }

        private void btnCargo_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(btnCargo);
        }

        private void button24_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(button24);
        }

        private void button24_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(button24);
        }

        private void button23_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(button23);
        }

        private void button23_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(button23);
        }

        private void button22_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(button22);
        }

        private void button22_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(button22);
        }

        private void button21_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(button21);
        }

        private void button21_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(button21);
        }

        private void button20_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(button20);
        }

        private void button20_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(button20);
        }

        private void btnResumenTotal_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new frmResumenTotalAños());
        }

        private void btnResumenTotal_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(btnResumenTotal);
        }

        private void btnResumen_VoucherEmpresa_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new frmResumenTotalVoucherEmpresa());
        }

        private void btnResumen_VoucherEmpresa_MouseLeave(object sender, EventArgs e)
        {
            Sub_Menu_LEAVE(btnResumen_VoucherEmpresa);
        }

        private void btnResumenTotal_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(btnResumenTotal);
        }

        private void btnResumen_VoucherEmpresa_MouseEnter(object sender, EventArgs e)
        {
            Sub_Menu_ENTER(btnResumen_VoucherEmpresa);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMensual2 m = new frmMensual2();
            DateTime fecha = DateTime.UtcNow.Date;
            m.fecha=fecha;
            m.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            frmExamen_XD x = new frmExamen_XD();
            x.Show();
        }
    }
}
