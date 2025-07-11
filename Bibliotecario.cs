using System;

public class Bibliotecario : Usuario
{
    public string TurnoLaboral { get; set; }

    public decimal Salario { get; set; }

    // constructor basido
    public Bibliotecario() { }


    public Bibliotecario(string TurnoLaboral, decimal Salario)
    {

        this.TurnoLaboral = TurnoLaboral;
        this.Salario = Salario;
    }
}
