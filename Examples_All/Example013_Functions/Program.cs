void Metod1()
{
Console.WriteLine("Автор …");
}

Metod1();




void Metod2(string msg) // где void ключевое слово, дальше идентификатор, в скобках указаны какие-то аргументы.
{
Console.WriteLine(msg); // оператор, в скобках указан принятый аргумент.
}

Metod2(“Текст сообщения”);


//

void Metod21(string msg, int count)
{
int i = 0;
while (i < count)
{
Console.WriteLine(msg); // где переменная count отображает на экране определённое количество сообщений msg.
i++; 
}
}
Metod21(“Текст”, 4);

//

int Metod3() // не принимает никакие аргументы
{
return DataTime.Now.Year; // обязательное использование оператора return,
}
int year = Metod3(); // вызываем метод, в левой части используем идентификатор переменной (year) и через оператор присваивания (=) кладём нужное значение
Console.WriteLine(year);

//

string Metod4(int count, string text)
{
int i = 0;
string result = String.Empty;
while (i<count)
{
	result = result + text;
i++;
	}
	return result;
}
string res = Metod4(10, “asdf”);
Console.WriteLine(res);


//

string Metod4(int count, string text)
{
string result = String.Empty;
for (int i = 0; i<count; i++) // вначале ключевое слово, затем инициализация счетчика, после проверка условия и инкремент (увеличение счетчика).
{
	result = result + text;
}
return result;
}
string res = Metod4(10, “asdf”);
Console.WriteLine(res);

//

for (int i = 2; i <= 10; i++)
{
for (int j = 2; j <= 10; j++)
{
Console.WriteLine($”{i} * {j} = {i * j}”);
}
Console.WriteLine();
}


//

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PtintArray(int[] array)
{
int count = array.Length
for (int i = 0; i < count; i++)
{
Console.Write($”{array[i]}”);
}
Console.WriteLine();
}
void selectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
int minPosition = i;
for (int j = i+1; j < array.Length; j++)
{
if(array[j] < array[minPosition]) minPosition = j;
{
minPosition = j
}
}
int temporary = array[i]
array[i] = array[minPosition];
array[minPosition] = temporary;
}
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
