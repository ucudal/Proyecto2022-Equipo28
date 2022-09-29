namespace Library;
public class Trabajador
{
    public Trabajador(string informacion_contacto, string reputacion)
    {
        this.Info = informacion_contacto;
        this.Reputacion = reputacion;
    }
    public string Info {get ; set;}
    public string Reputacion {get ; set;}

    public void Registro()
    {
        //Iniciar sesión con su nombre, apellido, dirección, número de contacto 
    }
    public void Ofertar()
    {
        //Ofertar sus servicios, indicar a que categoria pertenecen, añadir una descripción del servicio y un precio
    }
    public void Calificar()
    {
        //Calificar a un empleador, si no se clasifica en un mes será neutral, conocer la reputacion del empeador
    }

}
