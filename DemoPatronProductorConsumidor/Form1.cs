namespace DemoPatronProductorConsumidor
{
    public partial class Form1 : Form
    {
        private int contadorId = 1;
        private Cola<Usuario> colaUsuarios;
        private Productor productor;
        private Consumidor consumidor;
        public Form1()
        {
            InitializeComponent();
            colaUsuarios = new Cola<Usuario>(10);
            productor = new Productor(colaUsuarios);
            consumidor = new Consumidor(colaUsuarios);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario(
                contadorId++,
                TxtNombres.Text,
                TxtCorreo.Text
                );

            ThreadPool.QueueUserWorkItem(
                state =>
                {
                    colaUsuarios.Agregar(nuevoUsuario);
                }
                );
            TxtNombres.Clear();
            TxtCorreo.Clear();
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            Thread hiloConsumidor = new Thread(ProcesarUsuario);
            hiloConsumidor.Start();
        }
        private void ProcesarUsuario()
        {
            Usuario usuario = colaUsuarios.Extraer();
            AgregarUsuarioADataGrid(usuario);
        }

        private void AgregarUsuarioADataGrid(Usuario usuario)
        {
            if (DgvUsuarios.InvokeRequired)
            {
                DgvUsuarios.Invoke(new Action(() =>
                {
                    DgvUsuarios.Rows.Add(
                        usuario.Id,
                        usuario.Nombre,
                        usuario.CorreoElectronico,
                        usuario.FechaCreacion
                        );
                })
                );
            }
            else
            {
                DgvUsuarios.Rows.Add(
                        usuario.Id,
                        usuario.Nombre,
                        usuario.CorreoElectronico,
                        usuario.FechaCreacion
                        );
            }
        }
    }
}
