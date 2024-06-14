using System;

class Program
{
    static void Main()
    {
        // Creamos una matriz para las tarifas
        int[,] tarifas = new int[,]
        {
            { 0, 1000, 1500, 2300 },
            { 1000, 0, 1500, 2300 },
            { 1500, 1500, 0, 1300 },
            { 2300, 2300, 1300, 0 }
        };

        // Datos de usuarios que suben y bajan en cada punto
        int[] suben = { 1000, 1031, 1047, 1187 };
        int[] bajan = { 1000, 1002, 1012, 1187 };

        // Contadores de ingresos y salidas en cada punto
        int[] entrada = new int[4];
        int[] salida = new int[4];

        // Inicializamos los contadores de entrada y salida
        entrada[0] = suben[0];
        salida[0] = bajan[0];

        for (int i = 1; i < 4; i++)
        {
            entrada[i] = entrada[i - 1] + suben[i];
            salida[i] = salida[i - 1] + bajan[i];
        }

        // Facturación total en cada punto
        int[] facturacionPorPunto = new int[4];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i != j)
                {
                    int pasajeros = (entrada[i] - salida[i]) - (entrada[j] - salida[j]);
                    if (pasajeros > 0)
                    {
                        facturacionPorPunto[i] += pasajeros * tarifas[i, j];
                    }
                }
            }
        }

        // Facturación total en el Punto 4
        int facturacionTotalPunto4 = 0;
        for (int i = 0; i < 4; i++)
        {
            if (i != 3)
            {
                int pasajeros = entrada[i] - salida[i];
                facturacionTotalPunto4 += pasajeros * tarifas[i, 3];
            }
        }
        //Salidaa
        Console.WriteLine("Facturación total en cada punto:");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Punto {i + 1}: {facturacionPorPunto[i]}");
        }
        Console.WriteLine($"Facturación total en el Punto 4: {facturacionTotalPunto4}");
    }
}
