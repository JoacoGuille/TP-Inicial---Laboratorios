using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=== TP Parte A ===");
            Console.WriteLine("1: Sumar dos valores");
            Console.WriteLine("2: Comparar dos valores");
            Console.WriteLine("3: Calcular sueldo");
            Console.WriteLine("4: Comparar dos valores y ver cuál es menor");
            Console.WriteLine("5: Sumar 4 números");
            Console.WriteLine("6: Sueldos de empleados con promedio");
            Console.WriteLine("7: Sueldos por categoría (legajo = 0 para terminar)");
            Console.WriteLine("8: Resumen por categoría");
            Console.WriteLine("9: Matriz de horas trabajadas");
            Console.WriteLine("10: Pizzería");
            Console.WriteLine("0: Salir");
            Console.Write("\nElegí una opción: ");

            opcion = PedirInt("Opción: ");

            Console.Clear();

            switch (opcion)
            {
                case 1:
                    int a1 = PedirInt("Primer número: ");
                    float b1 = PedirFloat("Segundo número: ");
                    float c1 = a1 + b1;
                    Console.WriteLine($"{a1}+{b1}={c1}");
                    Console.ReadKey();
                    break;

                case 2:
                    int a2 = PedirInt("Primer número: ");
                    int b2 = PedirInt("Segundo número: ");
                    Console.WriteLine(a2 == b2 ? "son iguales" : "son distintos");
                    Console.ReadKey();
                    break;

                case 3:
                    float valorHora = PedirFloat("ingrese el valor de la hora: ");
                    float horas = PedirFloat("ingrese el tiempo trabajado: ");
                    Console.WriteLine($"el sueldo es {valorHora * horas}");
                    Console.ReadKey();
                    break;

                case 4:
                    int a4 = PedirInt("ingrese un valor: ");
                    int b4 = PedirInt("ingrese otro valor: ");
                    if (a4 == b4)
                        Console.WriteLine("son iguales");
                    else
                    {
                        Console.WriteLine("son distintos");
                        Console.WriteLine(a4 < b4 ? "el primero es menor al segundo" : "el segundo es menor al primero");
                    }
                    Console.ReadKey();
                    break;

                case 5:
                    int tot = 0;
                    for (int i = 1; i <= 4; i++)
                        tot += PedirInt($"ingrese un valor ({i}): ");
                    Console.WriteLine($"el total de la suma es {tot}");
                    Console.ReadKey();
                    break;

                case 6:
                    int cont = 0;
                    float totalSueldos = 0;
                    while (true)
                    {
                        int leg = PedirInt("ingrese el legajo (0 para terminar): ");
                        if (leg == 0) break;
                        float sdo = PedirFloat("igrese el sueldo: ");
                        totalSueldos += sdo;
                        cont++;
                    }
                    if (cont > 0)
                    {
                        float promedio = totalSueldos / cont;
                        Console.WriteLine($"el total pagado es {totalSueldos}");
                        Console.WriteLine($"el sueldo promedio es {promedio:F2}");
                    }
                    else Console.WriteLine("No se ingresaron empleados.");
                    Console.ReadKey();
                    break;

                case 7:
                    int[] valorHoraCat = new int[5];
                    for (int i = 1; i <= 4; i++)
                        valorHoraCat[i] = PedirInt($"ingrese el valor de la hs de la categoria {i}: ");

                    int leg7 = PedirInt("ingrese el nro de legajo (0 para terminar): ");
                    int total7 = 0;
                    while (leg7 != 0)
                    {
                        int cat;
                        do
                        {
                            cat = PedirInt("ingrese el nro de categoria (1 a 4): ");
                            if (cat < 1 || cat > 4)
                                Console.WriteLine("Categoría inválida, ingresá un valor entre 1 y 4.");
                        } while (cat < 1 || cat > 4);

                        int hs = PedirInt("ingrese el nro de hs trabajadas: ");
                        int sdo = hs * valorHoraCat[cat];
                        Console.WriteLine($"el legajo {leg7} cobrara {sdo}");
                        total7 += sdo;

                        leg7 = PedirInt("ingrese el nro de legajo (0 para terminar): ");
                    }
                    Console.WriteLine($"el total a pagar por sueldos es {total7}");
                    Console.ReadKey();
                    break;

                case 8:
                    int[] valorCat = new int[5];
                    int[] cantCat = new int[5];
                    for (int i = 1; i <= 4; i++)
                        valorCat[i] = PedirInt($"ingrese el valor de la hs de la categoria {i}: ");

                    int leg8 = PedirInt("ingrese el nro de legajo (0 para terminar): ");
                    int total8 = 0;
                    while (leg8 != 0)
                    {
                        int cat;
                        do
                        {
                            cat = PedirInt("ingrese el nro de categoria (1 a 4): ");
                            if (cat < 1 || cat > 4)
                                Console.WriteLine("Categoría inválida, ingresá un valor entre 1 y 4.");
                        } while (cat < 1 || cat > 4);

                        int hs = PedirInt("ingrese el nro de hs trabajadas: ");
                        int sdo = hs * valorCat[cat];
                        Console.WriteLine($"el legajo {leg8} cobrara {sdo}");
                        total8 += sdo;
                        cantCat[cat]++;

                        leg8 = PedirInt("ingrese el nro de legajo (0 para terminar): ");
                    }
                    for (int i = 1; i <= 4; i++)
                        Console.WriteLine($"de la categoria {i} hay {cantCat[i]} empleados");
                    Console.WriteLine($"el total a pagar por sueldos es {total8}");
                    Console.ReadKey();
                    break;

                case 9:
                    int[,] matriz = new int[5, 5];
                    for (int i = 1; i <= 4; i++)
                    {
                        int valCat = PedirInt($"ingrese el valor de la hs de la categoria {i}: ");
                        for (int j = 1; j <= 4; j++)
                        {
                            int dep;
                            do
                            {
                                dep = PedirInt("ingrese el nro de departamento (1 a 4): ");
                                if (dep < 1 || dep > 4)
                                    Console.WriteLine("Departamento inválido, ingrese entre 1 y 4.");
                            } while (dep < 1 || dep > 4);

                            int hs = PedirInt("ingrese el nro de hs trabajadas: ");
                            matriz[i, dep] += hs;
                        }
                    }
                    for (int i = 1; i <= 4; i++)
                        for (int j = 1; j <= 4; j++)
                            Console.WriteLine($"categoria {i} depto {j} horas {matriz[i, j]}");
                    Console.ReadKey();
                    break;

                case 10:
                    int[] PRECIO = new int[7] { 0, 10, 20, 30, 4, 5, 6 };
                    int MONTOTOTAL = 0;
                    int tkmax = 0, montomax = 0, motomax = 0;
                    int A = 0;
                    int[] M = new int[5]; 
                    int tk = PedirInt("INGRESE EL NRO DE TICKET (0 para terminar): ");

                    while (tk != 0)
                    {
                        int cat;
                        do
                        {
                            cat = PedirInt("ingrese la categoria de pizza (1 a 6): ");
                            if (cat < 1 || cat > 6)
                                Console.WriteLine("Categoría inválida, ingresá un valor entre 1 y 6.");
                        } while (cat < 1 || cat > 6);

                        int cant = PedirInt("ingrese la cantidad: ");

                        int moto;
                        do
                        {
                            moto = PedirInt("ingrese la moto (1 a 4): ");
                            if (moto < 1 || moto > 4)
                                Console.WriteLine("Moto inválida, ingresá un valor entre 1 y 4.");
                        } while (moto < 1 || moto > 4);

                        int monto = cant * PRECIO[cat];

                        if (tkmax == 0 || monto > montomax)
                        {
                            tkmax = tk;
                            motomax = moto;
                            montomax = monto;
                        }

                        M[moto]++;
                        MONTOTOTAL += monto;
                        M[0]++;

                        if (cat == 1) A++;

                        tk = PedirInt("INGRESE EL NRO DE TICKET (0 para terminar): ");
                    }

                    int motomin = 1;
                    for (int i = 1; i <= 4; i++)
                        if (M[i] < M[motomin]) motomin = i;

                    double prom = MONTOTOTAL / (double)M[0];
                    double porA = (double)A / M[0] * 100;

                    Console.WriteLine($"el ticket {tkmax} de valor: {montomax} es el de mayor importe");
                    Console.WriteLine($"la moto {motomin} es la que hizo menos viajes");
                    Console.WriteLine($"el valor promedio de los viajes es {prom:F2}");
                    Console.WriteLine($"el porcentaje de pedidos de pizzas categoria A es {porA:F2}%");
                    Console.WriteLine($"la facturacion total del negocio es {MONTOTOTAL}");
                    Console.ReadKey();
                    break;

                case 0:
                    Console.WriteLine("Chau, nos vemos!");
                    break;

                default:
                    Console.WriteLine("Esa opción no existe, probá otra.");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != 0);
    }

    static int PedirInt(string mensaje)
    {
        int valor;
        string input;
        do
        {
            Console.Write(mensaje);
            input = Console.ReadLine();
        } while (!int.TryParse(input, out valor));
        return valor;
    }

    static float PedirFloat(string mensaje)
    {
        float valor;
        string input;
        do
        {
            Console.Write(mensaje);
            input = Console.ReadLine();
        } while (!float.TryParse(input, out valor));
        return valor;
    }
}
