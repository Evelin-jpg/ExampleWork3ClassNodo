using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleWork3ClassNodo
{
    public partial class Form1 : Form
    {
        Lista miLista;
        public Form1()
        {
            InitializeComponent();
            miLista = new Lista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            Nodo n = new Nodo(numero, nombre, telefono);

            miLista.Agregar(n);
            txtNumero.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtNumero.Focus();
            miLista.Mostrar(lstDatos);
            //MessageBox.Show(miLista+"");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            miLista.Eliminar(numero);
            txtNumero.Clear();
            txtNumero.Focus();
            miLista.Mostrar(lstDatos);
            //MessageBox.Show(miLista + "");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            if (miLista.Buscar(numero))
            {
                //MessageBox.Show("Existe");
            }
            else
            {
                MessageBox.Show("NO Existe");
            }
            txtNumero.Focus();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Nodo h = head;
            Lista.Items.Clear();
            while (h != null)
            {
                Lista.Items.Add(h.ToString());
                h = h.Siguiente;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
