// See https://aka.ms/new-console-template for more information
using EspacioTarea;
using System;
using System.Collections.Generic;

Tarea tareas = new Tarea();

string[] descripciones = { "Sacar basura", "Realizar mesa", "Pintar pieza", "Contar dinero", "Activar maquina"};

int numeroTareas = 5;
List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();

for (int i=0; i<numeroTareas; i++) {
    tareasPendientes.Add(new Tarea(i, descripciones[i], 50));
}

Console.WriteLine("--------------------------------------");
Console.WriteLine("..........REGISTRO DE TAREAS..........");
Console.WriteLine("--------------------------------------");
Console.WriteLine();
int opern = 1;
while (opern != 0) {
    Console.WriteLine("Que desea realizar?");
    Console.WriteLine("1 - Mostrar tareas pendientes.");
    Console.WriteLine("2 - Mostrar tareas realizadas.");
    Console.WriteLine("3 - Busque una tarea por descripcion.");
    Console.WriteLine("4 - Marcar una tarea como realizada.");

    string oper = Console.ReadLine();

    if (int.TryParse(oper, out opern)) {
        if (opern != 0) {
            switch (opern)
            {
                case 1:
                    Console.WriteLine("..........TAREAS PENDIENTES...........");
                    Console.WriteLine();
                    // muestro la lista de tareas
                    foreach (Tarea tarea in tareasPendientes) {
                        Console.WriteLine($"ID de tarea: {tarea.TareaID}");
                        Console.WriteLine($"Descripcion: {tarea.Descripcion}");
                        Console.WriteLine($"Duracion: {tarea.Duracion}");
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("..........TAREAS REALIZADA...........");
                    Console.WriteLine();
                    // muestro la lista de tareas
                    foreach (Tarea tarea in tareasRealizadas) {
                        Console.WriteLine($"ID de tarea: {tarea.TareaID}");
                        Console.WriteLine($"Descripcion: {tarea.Descripcion}");
                        Console.WriteLine($"Duracion: {tarea.Duracion}");
                        Console.WriteLine();
                    }
                case 3:
                    Console.WriteLine("Ingrese la tarea que desea encontrar:");
                    string tareaBuscada = Console.ReadLine();
                    // muestro la lista de tareas coincidnetes
                    foreach (Tarea tarea in tareasPendientes) {
                        if (tareas.Descripcion == tareaBuscada) {
                            Console.WriteLine($"ID de tarea: {tarea.TareaID}");
                            Console.WriteLine($"Descripcion: {tarea.Descripcion}");
                            Console.WriteLine($"Duracion: {tarea.Duracion}");
                            Console.WriteLine();
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Indique el ID de la tarea a marcar como realizada:");
                    string tareaCambiar = Console.ReadLine();
                    int NtareaCambiar;
                    if (int.TryParse(tareaCambiar, out NtareaCambiar)) {
                        for (int i = tareasPendientes.Count - 1; i >= 0; i--) {
                            if (tareas.TareaID == NtareaCambiar) {
                                tareasRealizadas.Add(new Tarea(tareas.TareaID, tareas.Descripcion, tareas.Duracion));
                                tareas.RemoveAt(i);
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}










