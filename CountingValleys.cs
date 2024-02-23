using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        int valleys = 0; // Contador de vales
        int high = 0;    // Representa a altitude do caminhante

        for (int i = 0; i < steps; i++) // Loop sobre os passos no caminho
        {
            if (path[i] == 'D') // Se o passo atual for para baixo ('D')
            {
                --high; // Decrementa a altitude
            }
            else // Se o passo atual for para cima ('U')
            {
                ++high; // Incrementa a altitude

                // Se a altitude voltou a ser 0, significa que o caminhante completou um vale
                if (high == 0)
                {
                    valleys++; // Incrementa o contador de vales
                }
            }
        }

        return valleys;
    }
    


}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
