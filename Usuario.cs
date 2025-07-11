using System;

public class Usuario
{
	public int idUsuario { get; set; }
	public string nameUsuario { get; set; }
	public string emailUsuario { get; set; }
	public string rolUsuario { get; set; }
	public string passwordUsuario { get; set; }

//constructor vacido

	public Usuario() { }
//constructor de atributos
	public Usuario(int idUsuario, string nameUsuario, string emailUsuario, string rolUsuario, string passwordUsuario) 
	{ 
		this.idUsuario = idUsuario;
		this.nameUsuario = nameUsuario;
		this.emailUsuario = emailUsuario;
		this.rolUsuario = rolUsuario;
		this.passwordUsuario = passwordUsuario;
	}


}
