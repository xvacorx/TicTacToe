char[] TaTeTi = new char[9];

bool Fin = false;

Console.ForegroundColor = ConsoleColor.Magenta;

while (!Fin)
{
    Array.Clear(TaTeTi, 0, TaTeTi.Length);
    bool Empate = false;
    char Jugador = 'X';
    int Contador = 0;

    while (!Fin)
    {
        Console.WriteLine("Jugador {0}:", Jugador);
        Console.WriteLine("Elija Casilla (1-9)");
        Tablero();
        int Casillero = int.Parse(Console.ReadLine());

        while (TaTeTi[Casillero - 1] == 'X' || TaTeTi[Casillero - 1] == 'O') //Verificcación de casilla (Anti-Cheat)
        {
            Console.WriteLine("La casilla está ocupada. Por favor elija otra");
            Casillero = int.Parse(Console.ReadLine());
        }

        TaTeTi[Casillero - 1] = Jugador;

        Resultado(Jugador);

        Contador++; if (Contador == 9 && Fin == false) { Empate = true; Fin = true; }
        if (Jugador == 'X' && Fin == false) { Jugador = 'O'; }
        else if (Jugador == 'O' && Fin == false) { Jugador = 'X'; }

        Console.Clear();
    }

    if (Empate) { Console.WriteLine("Empate!"); }
    else { Console.WriteLine("EL ganador es el jugador {0}!", Jugador); }
    Console.WriteLine();
    Tablero();

    Console.ReadLine();

    Console.Clear();
    Console.WriteLine("Jugar de nuevo? 1 - Si | 0 - No");
    int JugarDeNuevo = int.Parse(Console.ReadLine());
    if (JugarDeNuevo != 0 && JugarDeNuevo != 1)
    {
        Console.WriteLine("Ingrese opción válida");
        JugarDeNuevo = int.Parse(Console.ReadLine());
    }
    if (JugarDeNuevo == 1) { Fin = false; }
    Console.Clear();
}

void Tablero()
{
    Console.WriteLine("| {0} | {1} | {2} |", TaTeTi[0], TaTeTi[1], TaTeTi[2]); //1 | 2 | 3
    Console.WriteLine("----------");
    Console.WriteLine("| {0} | {1} | {2} |", TaTeTi[3], TaTeTi[4], TaTeTi[5]); //4 | 5 | 6
    Console.WriteLine("----------");
    Console.WriteLine("| {0} | {1} | {2} |", TaTeTi[6], TaTeTi[7], TaTeTi[8]); //7 | 8 | 9
}
void Resultado(char a)
{
    if (TaTeTi[6] == a && TaTeTi[7] == a && TaTeTi[8] == a) { Fin = true; } //7 | 8 | 9 | Horizontales
    if (TaTeTi[3] == a && TaTeTi[4] == a && TaTeTi[5] == a) { Fin = true; } //4 | 5 | 6
    if (TaTeTi[0] == a && TaTeTi[1] == a && TaTeTi[2] == a) { Fin = true; } //1 | 2 | 3
    if (TaTeTi[6] == a && TaTeTi[3] == a && TaTeTi[0] == a) { Fin = true; } //1 | 4 | 7 | Verticales
    if (TaTeTi[7] == a && TaTeTi[4] == a && TaTeTi[1] == a) { Fin = true; } //2 | 5 | 8
    if (TaTeTi[8] == a && TaTeTi[5] == a && TaTeTi[2] == a) { Fin = true; } //3 | 6 | 9
    if (TaTeTi[0] == a && TaTeTi[4] == a && TaTeTi[8] == a) { Fin = true; } //1 | 5 | 9 | Diagonales
    if (TaTeTi[6] == a && TaTeTi[4] == a && TaTeTi[2] == a) { Fin = true; } //7 | 5 | 3
}//revisión de resultado