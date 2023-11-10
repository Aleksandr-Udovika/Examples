// // 1 Вид методов - ничего не возвращают и ничего не принимают.
// void Method1() // void - метод, Method1() - название метода, () - аргументы.
// {                                                                               // Тело метода
//     System.Console.WriteLine("Автор ..."); // то, что в кавычках выведется на экран.
// }                                                                               // Тело метода




// // 2 вид методов - ничего не возвращают, но в тоже время могут принимать какие-то аргументы.
// void Method2(string msg) // метод, его название, какое-то коллчество аргументов
// {
//     Console.WriteLine(msg); // здесь мы может уже указывать какие-то операторы и использовать те аргументы которые были приняты
// }
// Method2("Текст сообщения"); // вызовем метод по его имени(идентификатору), напишем текст который нужно вывести.
// // Method2(msg:"Текст сообщения"); - именнованые аргументы, какому аргументу, 
// // какое значение мы хотим указать, впереди пишем ..(msg:...
// // Это бывает нужно, когда методы принимают какое-то колличество аргументов
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст", count: 4); // текст и сколько раз и порядок аргументов значения не имеет внутри скобок метода


// // 3 вид методов - что возвращают, но ничего не принимают. Если метод что-то возвращает, 
// // мы в обязательном порядке должны будем указать тип данных, значение которых мы ожидаем.

// int Method3() // - аргументы он никакие не принимает
// {
//     return DateTime.Now.Year; // обязательное использование оператора "return"
// }

// int year = Method3(); // придумываем переменную "year" кладём в неё "Method3();"
// Console.WriteLine(year);


// // 4 вид методов самый важный, они что-то принимают и что-то возвращают.

// string Method4(int count, string text)
// {
//     int i = 0; // индекс счётчика
//     string result = String.Empty; // - переменная куда кладётся результат конечный. 
//     // String.Empty - это пустая строка
//         while (i < count) // пока i меньше count
//         {
//             result = result + text;
//             i++;
//         }
//         return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);


//  for цикл со счётчиком, который всё в одном месте собирает, счётчик, условия

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);


// for (int i = 2; i <= 10; i++) // для этого внешнего цикла - оператором или телом цикла является внутренний
// // цикл for который идёт ниже(написан ниже).
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// ===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками, маленькие буквы "к" заменить большими
// "К", а большие "C" заменить маленькими "с".

// string text = "- Я думаю, - Сказал князь, улыбаяСь, - что, "
//             + "ежели бы ваС поСлали вмеСто нашего Винценгероде,"
//             + "вы бы взяли приСтупом СоглаСие пруССкого короля."
//             + "Вы так краСноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             012
// // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }    
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();


// Упорядочивание данных в массивах


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);