#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>

int main(int argc, char *argv[])
{
	int sock_conn, sock_listen, ret;
	MYSQL *conn;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// escucharemos en el port 9050
	serv_adr.sin_port = htons(9050);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 4) < 0)
		printf("Error en el Listen");
	for(;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexi?n\n");
		int acabado=0;
		
		while (acabado==0)
		{
			
			// Ahora recibimos su peticion
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf ("Recibida una petici￯﾿ﾽn\n");
			// Tenemos que a?adirle la marca de fin de string 
			// para que no escriba lo que hay despues en el buffer
			peticion[ret]='\0';
			//Escribimos la peticion en la consola
			
			printf ("La petici￯﾿ﾽn es: %s\n",peticion);
			char *p = strtok(peticion, "/");
			int codigo =  atoi (p);
			
			
			char usuario [20];
			char password[20];
			if (codigo==1 || codigo==2)
			{
				p = strtok(NULL, "/");
				strcpy (usuario, p);
				
				p=strtok(NULL, "/");
				strcpy(password,p);
				printf ("Codigo: %d, Nombre: %s Contrase￱a: %s \n", codigo, usuario,password);
			}
			if (codigo ==1) //piden la longitd del nombre
			{
				conn = mysql_init(NULL);
				if (conn==NULL) {
					printf ("Error al crear la conexi￯﾿ﾳn: %u %s\n",mysql_errno(conn), mysql_error(conn));
					exit (1);
				}
				//inicializar la conexin
				conn = mysql_real_connect (conn, "localhost","root", "mysql", "geometry_wars",0, NULL, 0);
				if (conn==NULL) {
					printf ("Error al inicializar la conexion: %u %s\n",mysql_errno(conn), mysql_error(conn));
					exit (1);
				}
				
				char consulta [80];
				strcpy (consulta,"select jugador.id from jugador where jugador.username='");
				strcat(consulta,usuario);
				strcat(consulta,"'and jugador.password='");
				strcat(consulta, password);
				strcat(consulta, "';");
				
				err=mysql_query (conn, consulta);
				if (err!=0) {
					printf ("Error al consultar datos de la base %u %s\n",mysql_errno(conn), mysql_error(conn));
					exit (1);
				}
				resultado = mysql_store_result (conn);

				row = mysql_fetch_row (resultado);
				
				if (row == NULL)
				{
					printf ("No se han obtenido datos en la consulta\n");
					strcpy(respuesta,"NO"); //No se ha encontrado nadie con esos paramatros
				}
				else
				{
					printf ("Se ha encontrado al jugador \n");
					strcpy(respuesta,"SI");//Si se ha encontrado al jugador
					printf(respuesta);
				}
				mysql_close (conn);
				exit(0);
			}
			
			if(codigo==2)
				// quieren saber si el nombre es bonito
				if((usuario[0]=='M') || (usuario[0]=='S'))
				strcpy (respuesta,"SI");
				else
					strcpy (respuesta,"NO");
				else
				{
					float altura;
					p=strtok(NULL,"/");
					altura=atof(p);
					if (altura>1.7)
						strcpy(respuesta, "ERES ALTO");
					else
						strcpy(respuesta, "NO ERES ALTO");
				}
				
				
				// Enviamos la respuesta
			write (sock_conn,respuesta, strlen(respuesta));
				
				// Se acabo el servicio para este cliente
				
		}
		close(sock_conn); 
	}
}
