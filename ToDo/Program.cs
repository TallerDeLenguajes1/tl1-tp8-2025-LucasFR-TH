// See https://aka.ms/new-console-template for more information
using EspacioTarea;

Tarea tareas = new Tarea();

string descripciones[] = {"Sacar basura"; "Realizar mesa"; "Pintar pieza"; "Contar dinero"; "Activar maquina"};

Console.WriteLine("--------------------------------------");
Console.WriteLine("..........REGISTRO DE TAREAS..........");
Console.WriteLine("--------------------------------------");

int numeroTareas = random.Next(11);
List<tareas> tareasPendientes = new List<tareas>();

for (int i=0; i<numeroTareas; i++) {
    tareasPendientes.add(new Tarea(i, descripciones[random.next(5)], random.next(100)));
}

// muestro la lista de tareas
foreach (Tarea tarea in tareasPendientes) {
    Console.WriteLine($"ID de tarea: {tareas.TareaID}");
    Console.WriteLine($"Descripcion: {tareas.Descripcion}");
    Console.WriteLine($"Duracion: {tareas.Duracion}");
    Console.WriteLine();
}

List<tareas> tareasRealizadas = new List<tareas>();


