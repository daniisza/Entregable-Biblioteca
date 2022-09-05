using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;



namespace biblioteca



{
    public partial class Form1 : Form
    
    {
  //en esta muestra los datos en el datagriv de lo que tiene la base de datos
       

        SqlConnection conn = new SqlConnection("server = DESKTOP-2OGVSD8\\SQLEXPRESS;database = datoslibros; integrated security= true");
        string libro, autor, ubicacion, cantidad, codigo;

        public Form1()
        {

            try
            {
               
            }
            catch (Exception ex) 

            {
                conn.Close();
                MessageBox.Show(ex.Message);
    
               
            }
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filas = this.dataGridViewVista.Rows[e.RowIndex];
            if (e.RowIndex >= 0)

            {

                libro = filas.Cells[0].Value.ToString();
                autor = filas.Cells[1].Value.ToString();
                ubicacion = filas.Cells[2].Value.ToString();
                cantidad = filas.Cells[3].Value.ToString();
                codigo = filas.Cells[4].Value.ToString();
            }
            txtLibro.Text = libro;
            txtAutor.Text = autor;
            txtUbicacion.Text = ubicacion;
            txtCantidad.Text = cantidad;
            txtCodigo.Text = codigo;
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
                string consulta = $"SELECT * FROM tbllibros1 WHERE nomlibro LIKE '%{txtconsulta.Text}%' or nomautor LIKE '%{txtconsulta.Text}%'";
                SqlCommand comando = new SqlCommand(consulta, conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                dataGridViewVista.DataSource = resultado;
                conn.Close();


            }
            catch (Exception ex)

            {
                conn.Close();
                MessageBox.Show(ex.Message);


            }

        }
        public void Info_base_datos()
        {
            try
            {
                conn.Open();
                string consulta = "select * from tbllibros1 ";
                SqlCommand comando = new SqlCommand(consulta, conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                dataGridViewVista.DataSource = resultado;
                conn.Close();


            }
            catch (Exception ex)

            {
                conn.Close();
                MessageBox.Show(ex.Message);




            }
        }
        public void Limpiar()
        {
            txtLibro.Clear();
            txtAutor.Clear();
            txtUbicacion.Clear();
            txtCantidad.Clear();
            txtCodigo.Clear();


        }
        public void Eliminar()
        {
            String dato = codigo;
            conn.Open();
            String consulta = $" DELETE FROM tbllibros1 WHERE Codigo = @P1";
            SqlCommand comando = new SqlCommand(consulta, conn);
            comando.Parameters.AddWithValue("P1", dato);
            comando.ExecuteNonQuery();
            conn.Close();

        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            Info_base_datos();
        }

        private void txtconsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string consulta = $" update tbllibros1 set nomlibro = @P1, nomautor = @P2, Ubicación = @P3, Cantidad = @P4, Codigo = @P5 where Codigo = '{txtCodigo.Text}' ";
                SqlCommand comando = new SqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("P1", txtLibro.Text);
                comando.Parameters.AddWithValue("P2", txtAutor.Text);
                comando.Parameters.AddWithValue("P3", txtUbicacion.Text);
                comando.Parameters.AddWithValue("P4", Convert.ToInt32(txtCantidad.Text));
                comando.Parameters.AddWithValue("P5", txtCodigo.Text);
                comando.ExecuteNonQuery();
                conn.Close();

                Info_base_datos();


            }
            catch (Exception ex)

            {
                conn.Close();
                MessageBox.Show(ex.Message);


            }
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
           
            Eliminar();
            Info_base_datos();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string consulta = "INSERT INTO tbllibros1 VALUES  (@P1, @P2, @P3, @P4, @P5) ";
                SqlCommand comando = new SqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("P1", txtLibro.Text);
                comando.Parameters.AddWithValue("P2", txtAutor.Text);
                comando.Parameters.AddWithValue("P3", txtUbicacion.Text);
                comando.Parameters.AddWithValue("P4",Convert.ToInt32(txtCantidad.Text));
                comando.Parameters.AddWithValue("P5", txtCodigo.Text);
                comando.ExecuteNonQuery();  
                conn.Close();

                Info_base_datos();
                Limpiar();
            }
            catch (Exception ex)

            {
                conn.Close();
                MessageBox.Show(ex.Message);


            }
        }
    }
}