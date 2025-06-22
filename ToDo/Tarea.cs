namespace EspacioTarea;

public class Tarea
{ // IMPLICITAMENTE HAY UN COSNTRUTOR VACIO
    public int TareaID { get; set; } // CAMPOS DEFINIDOS IMPLICITAMENTE EN LAS PROPIEDADES
    public string? Descripcion { get; set; } // CAMPOS DEFINIDOS IMPLICITAMENTE EN LAS PROPIEDADES
    public int Duracion { get; set; } // validar que s eencunetre entre 10 y 100
    
        // Constructor necesario
    public Tarea (int id, string desc, int dur)
    {
        TareaID = id;
        Descripcion = desc;
        Duracion = dur; // Validación
    }
}