Module Module1

    Sub Main()
        Dim type As String = Nothing
        Dim repeat As String = "YES"

        Do Until repeat = "NO"
            Do Until type = "1" Or type = "2" Or type = "3" Or type = "4" Or type = "5" Or type = "6" Or type = "7" Or type = "8" Or type = "9"
                menu()
                type = Console.ReadLine
            Loop
            MenuOption(type)
            type = Nothing
            Console.WriteLine("Do you want to use another feature. (Yes/No).")
            repeat = Console.ReadLine.ToUpper
            Console.Clear()
        Loop
    End Sub
    Sub menu()
        Console.WriteLine("Please chose your option:")
        Console.WriteLine("1) Calculate a length using to other lengths.")
        Console.WriteLine("2) Calculate a length using a length and a angle.")
        Console.WriteLine("3) Calculate the area using base and height.")
        Console.WriteLine("4) Calculate a angle using two lengths.")
        Console.WriteLine("5) Calculate the area when you dont have the height.")
        Console.WriteLine("6) Calculate a length using the sine rule.")
        Console.WriteLine("7) Calculate a angle using the sine rule.")
        Console.WriteLine("8) Calculate a length using the cosine rule.")
        Console.WriteLine("9) Calculate a angle using the cosine rule.")
    End Sub
    Sub MenuOption(ByVal type As String)
        Dim z As Single

        If type = "1" Then
            length(z)
            Console.WriteLine("The length is: " & z)
        ElseIf type = "2" Then
            length2(z)
            Console.WriteLine("The length is: " & z)
        ElseIf type = "3" Then
            area(z)
            Console.WriteLine("Your area is: " & z)
        ElseIf type = "4" Then
            angle(z)
            Console.WriteLine("Your angle is: " & z)
        ElseIf type = "5" Then
            area2(z)
            Console.WriteLine("Your area is: " & z)
        ElseIf type = "6" Then
            sine(z)
            Console.WriteLine("The length is: " & z)
        ElseIf type = "7" Then
            sine2(z)
            Console.WriteLine("Your angle is: " & z)
        ElseIf type = "8" Then
            cosine(z)
            Console.WriteLine("The length is: " & z)
        ElseIf type = "9" Then
            cosine2(z)
            Console.WriteLine("Your angle is: " & z)
        End If
    End Sub
    Function length(ByRef z As Single)
        Dim pythagoras As String = Nothing
        Dim x As Single = Nothing
        Dim y As Single = Nothing

        Do Until pythagoras = "hypotenuse" Or pythagoras = "adjacent" Or pythagoras = "opposite"
            Console.WriteLine("What length are you working out, hypotenuse, opposite or adjacent.")
            pythagoras = Console.ReadLine.ToLower
        Loop
        If pythagoras = "hypotenuse" Then
            Console.WriteLine("Input your first length")
            x = Console.ReadLine
            Console.WriteLine("Input your second length")
            y = Console.ReadLine
            z = Math.Sqrt(x ^ 2 + y ^ 2)
        ElseIf pythagoras = "adjacent" Or pythagoras = "opposite" Then
            Console.WriteLine("Input the lenght of the hypotenuse")
            x = Console.ReadLine
            Console.WriteLine("Input your second length")
            y = Console.ReadLine
            z = Math.Sqrt(x ^ 2 - y ^ 2)
        End If
        Return z
    End Function
    Function length2(ByRef z As Single)
        Dim x As Single = Nothing
        Dim A As Single = Nothing
        Dim sohcahtoa As String = Nothing
        Dim sohcahtoa1 As String = Nothing

        Console.WriteLine("What angle size do you have?")
        A = Console.ReadLine
        A = A * (Math.PI / 180)
        Console.WriteLine("What length do you have?")
        x = Console.ReadLine
        Do Until sohcahtoa = "hypotanuse" Or sohcahtoa = "opposite" Or sohcahtoa = "adjacent"
            Console.WriteLine("Is it adjacent, opposite or hypotenuse that is being worked out.")
            sohcahtoa = Console.ReadLine.ToLower
        Loop
        Do Until sohcahtoa1 = "hypotanuse" Or sohcahtoa1 = "opposite" Or sohcahtoa1 = "adjacent"
            Console.WriteLine("What Length are we using adjacent, opposite or hypotenuse")
            sohcahtoa1 = Console.ReadLine.ToLower
        Loop
        If sohcahtoa = "hypotenuse" And sohcahtoa1 = "opposite" Then
            z = Math.Sin(A) / x
        ElseIf sohcahtoa = "hypotenuse" And sohcahtoa1 = "Adjacent" Then
            z = Math.Cos(A) / x
        ElseIf sohcahtoa = "adjacent" And sohcahtoa1 = "opposite" Then
            z = Math.Tan(A) / x
        ElseIf sohcahtoa = "adjacent" And sohcahtoa1 = "hypotenuse" Then
            z = x * Math.Cos(A)
        ElseIf sohcahtoa = "opposite" And sohcahtoa1 = "hypotenuse" Then
            z = x * Math.Sin(A)
        ElseIf sohcahtoa = "adjacent" And sohcahtoa1 = "opposite" Then
            z = x * Math.Tan(A)
        End If
        Return z
    End Function
    Function area(ByRef z As Single)
        Dim x As Single = Nothing
        Dim y As Single = Nothing

        Console.WriteLine("What height do you have?")
        x = Console.ReadLine
        Console.WriteLine("What base do you have?")
        y = Console.ReadLine
        z = 0.5 * x * y

        Return z
    End Function
    Function angle(ByRef z As Single)
        Dim x As Single = Nothing
        Dim y As Single = Nothing
        Dim sohcahtoa As String = Nothing
        Dim sohcahtoa1 As String = Nothing

        Console.WriteLine("What length do you have? (this must be the shorter of the two)")
        y = Console.ReadLine
        Console.WriteLine("What length do you have?(this must be the longer of the two)")
        x = Console.ReadLine
        Console.WriteLine("What is the first length that you have. (adjacent, opposite or hypotenuse)")
        Do Until sohcahtoa = "hypotanuse" Or sohcahtoa = "opposite" Or sohcahtoa = "adjacent"
            sohcahtoa = Console.ReadLine.ToLower
        Loop
        Do Until sohcahtoa1 = "hypotanuse" Or sohcahtoa1 = "opposite" Or sohcahtoa1 = "adjacent"
            Console.WriteLine("What is the second Length are we using adjacent, opposite or hypotenuse")
            sohcahtoa1 = Console.ReadLine.ToLower
        Loop
        If sohcahtoa = "hypotenuse" And sohcahtoa1 = "opposite" Or sohcahtoa = "opposite" And sohcahtoa1 = "hypotenuse" Then
            z = Math.Sinh(y / x)
        ElseIf sohcahtoa = "hypotenuse" And sohcahtoa1 = "adjacent" Or sohcahtoa = "adjacent" And sohcahtoa1 = "hypotenuse" Then
            z = Math.Cosh(y / x)
        ElseIf sohcahtoa = "adjacent" And sohcahtoa1 = "opposite" Or sohcahtoa = "opposite" And sohcahtoa1 = "adjacent" Then
            z = Math.Tanh(y / x)
        End If
        z = z * (180 / Math.PI)
        z = Math.Round(z, 0)
        Return z
    End Function
    Function area2(ByRef z As Single)
        Dim x As Single = Nothing
        Dim C As Single = Nothing
        Dim b As Single = Nothing
        Dim deg As Single = Nothing

        Console.WriteLine("Please enter the length of the hypotenuse.")
        x = Console.ReadLine
        Console.WriteLine("Please enter the length of the base")
        b = Console.ReadLine
        Console.WriteLine("Please enter the size of the angle.")
        C = Console.ReadLine
        C = C * (Math.PI / 180)
        deg = Math.Sin(C)
        z = 0.5 * b * x * deg
        Return z
    End Function
    Function sine(ByRef z As Single)
        Dim x As Single = Nothing
        Dim A As Single = Nothing
        Dim B As Single = Nothing

        Console.WriteLine("Enter the length that  you have.")
        x = Console.ReadLine
        Console.WriteLine("Enter the angle opposite to this length.")
        A = Console.ReadLine
        A = A * (Math.PI / 180)
        Console.WriteLine("Enter the 2nd angle that you have.")
        B = Console.ReadLine
        B = B * (Math.PI / 180)
        z = (x * Math.Sin(B)) / Math.Sin(A)
        Return z
    End Function
    Function sine2(ByRef z As Single)
        Dim x As Single = Nothing
        Dim y As Single = Nothing
        Dim A As Single = Nothing

        Console.WriteLine("Enter the length opposite to the angle that you want working out.")
        y = Console.ReadLine
        Console.WriteLine("Enter the length opposit to the angle that you have.")
        x = Console.ReadLine
        Console.WriteLine("Enter the size of the angle that you have.")
        A = Console.ReadLine
        A = A * (Math.PI / 180)
        z = Math.Sinh((y * Math.Sin(A)) / x)
        z = z * (180 / Math.PI)
        z = Math.Round(z, 0)
        Return z
    End Function
    Function cosine(ByRef z As Single)
        Dim x As Single = Nothing
        Dim y As Single = Nothing
        Dim C As Single = Nothing

        Console.WriteLine("Enter the angle that is opposite to length you want to work out.")
        C = Console.ReadLine
        C = C * (Math.PI / 180)
        Console.WriteLine("Enter one of the lengths you have.")
        x = Console.ReadLine
        Console.WriteLine("Enter the other length you have.")
        y = Console.ReadLine
        z = Math.Sqrt(x ^ 2 + y ^ 2 - (2 * x * y * Math.Cos(C)))
        z = Math.Round(z, 3)
        Return z
    End Function
    Function cosine2(ByRef z As Single)
        Dim x As Single = Nothing
        Dim y As Single = Nothing
        Dim a As Single = Nothing
        Dim b As Single = Nothing

        Console.WriteLine("Enter the length opposite to the length you would like to work out.")
        x = Console.ReadLine
        Console.WriteLine("Enter the first of the other two lengths.")
        y = Console.ReadLine
        Console.WriteLine("Enter the last length.")
        a = Console.ReadLine
        z = a ^ 2 + y ^ 2 - x ^ 2
        b = 2 * (y * a)
        z = z / b
        z = Math.Cosh(z)
        z = z * (180 / Math.PI)
        z = Math.Round(z, 0)
        Return z
    End Function
End Module
