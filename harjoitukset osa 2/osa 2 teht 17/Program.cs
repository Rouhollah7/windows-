﻿using System;

class Ohjelma
{
    static void Main()
    {
        TulostaKolmellaJaollisetLuvut();
    }

    static void TulostaKolmellaJaollisetLuvut()
    {
        for (int i = 3; i <= 99; i += 3)
        {
            Console.WriteLine(i);
        }
    }
}
