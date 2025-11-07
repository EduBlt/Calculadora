Module Program
    Sub Main()
        Dim numero1 As Double
        Dim numero2 As Double
        Dim suma As Double
        Dim resta As Double
        Dim opcion As Integer

        Console.WriteLine("¿Qué operación desea realizar?")
        Console.WriteLine("1: Suma")
        Console.WriteLine("2: Resta")
        opcion = Convert.ToInt32(Console.ReadLine())
        
        Console.WriteLine("Ingrese el primer número:")
        numero1 = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Ingrese el segundo número:")
        numero2 = Convert.ToDouble(Console.ReadLine())

        If opcion = 1 Then
            suma = numero1 + numero2
            Console.WriteLine("La suma es: " & suma)
        Elseif opcion = 2 Then
            resta = numero1 - numero2
            Console.WriteLine("La resta es: " & resta)
        Else
            Console.WriteLine("Opción no válida")
        End If
        
        Console.ReadKey()
        
    End Sub
End Module
