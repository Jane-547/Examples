string[,] array =
{
    {"Какие из перечисленных ниже программ являются антивирусными?", "MS Word", "Dr.Web", "Chrome", "PDFreader", "Dr.Web"},
    {"Какого типа графики не существует?", "Растровая", "Векторная", "Облачная", "Трехмерная", "Облачная"},
    {"Когда появился термин «информационные технологии» в современном значении?", "В 1893 году", "В 1990 году", "В 1958 году", "В 1902 году", "В 1958 году"},
    {"В каком году компанией IBM был выпущен первый в истории жесткий диск?", "В 1956 году", "В 1958 году", "В 1955 году", "В 1957 году", "В 1956 году"},
    {"Какая поисковая система была самой популярной в 2011 году?", "Yahoo!", "Google", "Bing", "Yandex", "Google"},
    {"Страна лидер по количеству суперкомпьютеров?", "Китай", "США", "Япония", "Россия", "Китай"},
    {"Какого Интернет-браузера не существует?", "MS PowerPoint", "Opera", "Google Chrome", "Internet Explorer", "MS PowerPoint"},
    {"Какие из клавиш клавиатуры относятся к группе функциональных?", "F1-F12", "CTRL, ALT, Shift", "Windows","Tab",  "F1-F12"},
    {"Какую скорость передачи данных может обеспечить широкополосная связь по ЛЭП?", "200 МБит/с", "1 МБит/с", "100 МБит/с", "10 МБит/с", "100 МБит/с"},
};

int count = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    System.Console.WriteLine(array[i, 0]);
    System.Console.WriteLine();
    for (int j = 1; j < array.GetLength(1) - 1; j++)
    {
        System.Console.WriteLine($"{j}) {array[i, j]};");

    }
    int answer = EnterAnswer("Введите ответ: ");
    if (Comparesment(answer, i)) count++;
    System.Console.WriteLine();
    System.Console.WriteLine();
    
}

System.Console.WriteLine($"Количество правильных ответов = {count}");


int EnterAnswer(string text) // функция для ввода целочисленного значения пользователем
{
    Console.Write($"{text}: ");
    int result;
    while (true)
    { 
        string enterNumber = Console.ReadLine();
        if (int.TryParse(enterNumber, out result) && result <= 4 && result > 0)
            return result;

        System.Console.WriteLine($"Error. {text}");
    }
    return 0;
}

bool Comparesment (int value, int index)
{
    return array[index, value] == array [index, array.GetLength(1)-1];
}
