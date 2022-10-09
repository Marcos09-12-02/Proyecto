using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Cliente
{
    public partial class Geometry_wars : Form
    {
        Socket server;
        public Geometry_wars()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            IPAddress direc = IPAddress.Parse("192.168.56.101");
            IPEndPoint ipep = new IPEndPoint(direc, 9050);


            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            if (usuario.TextLength == 0)
                MessageBox.Show("Introduce tu usuario");
            else if (contraseña.TextLength == 0)
                MessageBox.Show("Introduce tu contraseña");
            else 
            {
                try
                {
                    server.Connect(ipep);//Intentamos conectar el socket
                                         // Quiere saber la longitud
                    string mensaje = "1/" + usuario.Text+"/"+contraseña.Text;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show(mensaje);
                    if (mensaje == "SI")
                    {
                        MessageBox.Show("Bienvenido");
                        usuario.Visible = false;
                        contraseña.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        login.Visible = false;
                        registration.Visible = false;
                        label1.Visible = true;
                        consulta1.Visible = true;
                        consulta2.Visible = true;
                        consulta3.Visible = true;
                    }
                    else
                        MessageBox.Show("No se ha encontrado el usuario,revisa tu contraseña o registrate");
                }

                catch (SocketException)
                {
                    //Si hay excepcion imprimimos error y salimos del programa con return 
                    MessageBox.Show("No he podido conectar con el servidor");
                    return;
                }
            }
            
        }

        private void registration_Click(object sender, EventArgs e)
        {
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9050);


            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            if (usuario.TextLength == 0)
                MessageBox.Show("Introduce el usuario que quieres crear");
            else if (contraseña.TextLength == 0)
                MessageBox.Show("Introduce tu contraseña");
            else
            {
                try
                {
                    server.Connect(ipep);//Intentamos conectar el socket
                                         // Quiere saber la longitud
                    string mensaje = "2/" + usuario.Text + "/" + contraseña.Text;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];

                    MessageBox.Show("La longitud de tu nombre es: " + mensaje);
                }

                catch (SocketException)
                {
                    //Si hay excepcion imprimimos error y salimos del programa con return 
                    MessageBox.Show("No he podido conectar con el servidor");
                    return;
                }
            }

        }
    }
}
