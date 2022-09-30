namespace Library;
public class Empleador
{
    public Empleador(string informacion_contacto, string reputacion)
    {
        this.Info=informacion_contacto;
        this.Reputacion=reputacion;
    }
    public string Info { get; set; } //Informacion de contacto
    public string Reputacion { get; set; } //Reputacion del empleador
    public void Registro()
    {
        //Registrarme en la plataforma
        //Proveer informacion de contacto
    }
    public void Buscar_ofertas()
    {
        //Tener la capacidad de buscar ofertas
        //Tener la capacidad de filtrarlas por categoria
        //Tener la capacidad de filtrarlas por ubicacion
        //Tener la capacidad de filtrarlas por reputacion
    }
    public void Contactar_trabajador()
    {
        //Contactar a un trabajador
        //Poder enviarle un mensaje
        //Para tener los servicios determinados que necesito
    }
    public void Calificar_trabajador()
    {
        //Poder calificar a un trabajador
        //Despues de un mes deben calificar sino sera neutral
        //Conocer la reputacion del trabajador
    }

}
