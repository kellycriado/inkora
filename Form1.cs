using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;


namespace Claseservidor
{
    public partial class frmInicioSeccion : Form
    {
        // creo a conexion a mi base de daatos
        string conneccionString = "server=localhost;port=3306;user=root;password=;database=db_inkora_bibioteca";
        public frmInicioSeccion()
        {
            InitializeComponent();
            mostrarRol();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProbarBD_Click(object sender, EventArgs e)
        {
            // control o manejo de errores try catch(excepcion)

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conneccionString))
                {
                    conexion.Open();
                    MessageBox.Show("laa conexion a sido exitosa", "conectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Close();
                }

            }
            catch (Exception ex)

            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //metodo para mostrar enum en comboBox

        private void mostrarRol()
        {
            //sentencia query
            string query = "SHOW COLUMNS FROM tbl_usuario LIKE 'rol_usuario'";

            // listA para resivir el query

            List<string> listaRoles = new List<string>();

            // usar la conexion de la base de datos

            using (MySqlConnection conn = new MySqlConnection(conneccionString))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn)) //nueva conexión según query
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string type = reader["Type"].ToString();
                       // ejemplo: enum('Administrador','Secretaria')

                        // Extraer los valores usando Regex
                        MatchCollection matches = Regex.Matches(type, @"'([^']*)'");
                        foreach (Match match in matches)
                        {
                            listaRoles.Add(match.Groups[1].Value);
                        }
                    }
                }

            }// llenar el comboBox
            cboRolUsuario.DataSource = listaRoles;
        }
        

        private void btnInisiaSeccion_Click(object sender, EventArgs e)
        {
            string nombreUsuario =txtNombreUsuario.Text;
            string passwordUsuario =txtContraseña.Text;
            string rolUsuario = cboRolUsuario.Text;
            MessageBox.Show($"los datos seleccionados son: {nombreUsuario}, {passwordUsuario} y {rolUsuario}");

            using (MySqlConnection conn = new MySqlConnection(conneccionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM tbl_usuario WHERE nombre_usuario = @nombreUsuario " +
                                   "AND password_usuario = @passwordUsuario AND rol_usuario = @rolUsuario";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@passwordUsuario", passwordUsuario);
                    cmd.Parameters.AddWithValue("@rolUsuario", rolUsuario);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string rol = reader["rol_usuario"].ToString();
                        MessageBox.Show("Inicio de sesión exitoso. Rol: " + rol);
                        // Aquí puedes abrir otro formulario según el rol
                        //abrir el formulario
                        frmFormularioUsuario formularioUsuario = new frmFormularioUsuario();
                        formularioUsuario.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario, contraseña o rol incorrectos.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
    }


