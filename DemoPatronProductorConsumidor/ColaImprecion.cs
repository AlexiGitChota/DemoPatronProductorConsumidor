namespace DemoPatronProductorConsumidor
{

    public partial class Cola_de_Imprecion : Form
    {

        private int contadorId = 1;
        private Cola<Usuario> colaUsuarios;
        private Productor productor;
        private Consumidor consumidor;

        public Cola_de_Imprecion()
        {
            InitializeComponent();
            colaUsuarios = new Cola<Usuario>(10);
            productor = new Productor(colaUsuarios);
            consumidor = new Consumidor(colaUsuarios);
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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
            if (DgvPagina.InvokeRequired)
            {
                DgvPagina.Invoke(new Action(() =>
                {
                    DgvPagina.Rows.Add(
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
                DgvPagina.Rows.Add(
                        usuario.Id,
                        usuario.Nombre,
                        usuario.CorreoElectronico,
                        usuario.FechaCreacion
                        );
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
