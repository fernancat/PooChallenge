namespace Notificaciones{
    public interface Inotificable{
    public void notificar();
}



public class NotificacionEmail:Inotificable{
    public string direccionCorreo;

    public NotificacionEmail(string direccionCorreo){
        this.direccionCorreo = direccionCorreo;
        notificar();
    }


    public void notificar(){
        Console.WriteLine("Se ha notificado a tu correo");
    }
}


public class NotificacionWhatsapp:Inotificable{
    public int numeroTelefonico;

    public NotificacionWhatsapp(int numeroTelefonico){
        this.numeroTelefonico = numeroTelefonico;
        notificar();
    }



    public void notificar(){
        Console.WriteLine("Se ha enviado un mensaje a tu whatsapp");
    }
}


public class notificacionSMS:Inotificable{
    public int numeroTelefonico;

    public notificacionSMS(int numeroTelefonico){
        this.numeroTelefonico = numeroTelefonico;
        notificar();
    }

    public void notificar(){
        Console.WriteLine("Se te ha enviado un SMS");
    }
}
}
