Module Program
    Sub Main()
        Dim numero1 As Double
        Dim numero2 As Double
        Dim suma As Double
        Dim resta As Double
        Dim multiplicacion As Double
        Dim division As Double
        Dim opcion As Integer

        Console.WriteLine("¿Qué operación desea realizar?")
        Console.WriteLine("1: Suma")
        Console.WriteLine("2: Resta")
        Console.WriteLine("3: Multiplicación")
        Console.WriteLine("4: División")
        opcion = Convert.ToInt32(Console.ReadLine())
        
        Console.WriteLine("Ingrese el primer número:")
        numero1 = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Ingrese el segundo número:")
        numero2 = Convert.ToDouble(Console.ReadLine())

        If opcion = 1 Then
            suma = numero1 + numero2
            Console.WriteLine("La suma es: " & suma)
        ElseIf opcion = 2 Then
            resta = numero1 - numero2
            Console.WriteLine("La resta es: " & resta)
         ElseIf opcion = 3 Then
            multiplicacion = numero1 * numero2
            Console.WriteLine("La multiplicación es: " & multiplicacion)
        ElseIf opcion = 4 Then
            If numero2 = 0 Then
                Console.WriteLine("Error: División por cero no permitida.")
            Else
                division = numero1 / numero2
                Console.WriteLine("La división es: " & division)
            End If
        Else
            Console.WriteLine("Opción no válida")
        End If
        
        Console.ReadKey()
        
    End Sub
End Module
