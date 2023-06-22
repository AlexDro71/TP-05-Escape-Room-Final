using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult tutorial()
    {

        return View();
    }

        public IActionResult creditos()
    {

        return View();
    }
    public IActionResult Comenzar()
    {
        
        Escape.inicializarJuego();
        Console.WriteLine("Paso por aca");
        return View("sala" + (Escape.getEstadoJuego()));
        
    }

    
    public IActionResult Habitacion(int sala, string clave)
    {
        
if(sala!=Escape.getEstadoJuego()){
    Console.WriteLine("Paso por aca 2");
return View("sala"+Escape.getEstadoJuego());
}else if(!Escape.ResolverSala(sala, clave)){
    ViewBag.Error="El codigo no es correcto, vuelva a intentar";
return View("sala"+Escape.getEstadoJuego());
}else if(Escape.ResolverSala(sala, clave) && Escape.getEstadoJuego()==4){
return View("escapaste");
}else{
    return View("sala"+Escape.getEstadoJuego());
}

    }
}

