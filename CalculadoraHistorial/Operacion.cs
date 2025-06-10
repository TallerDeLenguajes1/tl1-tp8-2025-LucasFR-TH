namespace EspacioOperacion;

public enum TipoOperacion {Suma, Resta, Multiplicacion, Division, Limpiar} // Representa la acción de borrar el resultado actual o el historial

public class Operacion
{
    private double resultadoAnterior;

    private double nuevoValor;

    private TipoOperacion toperacion;

    public double Resultado;

    public double NuevoValor
    {
        get => nuevoValor;
        set => nuevoValor = value;
    }

    public double ResultadoAnterior
    {
        get => resultadoAnterior;
        set => resultadoAnterior = value;
    }

    public TipoOperacion Toperacion
    {
        get => toperacion;
        set => toperacion = value;
    }
}
