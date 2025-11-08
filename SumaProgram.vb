Module Program
    Sub Main()
        Dim numero1 As Integer
        Dim numero2 As Integer 
        Dim suma As Integer
        Dim multiplicacion As Double

        Console.WriteLine("Ingrese el primer número:")
        numero1 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Ingrese el segundo número:")
        numero2 = Convert.ToDouble(Console.ReadLine())
        suma = numero1 + numero2
        multiplicacion = numero1 * numero2
        Console.WriteLine("La suma es: " & suma)
        Console.WriteLine("La multiplicación es: " & multiplicacion)
    End Sub

End Module
