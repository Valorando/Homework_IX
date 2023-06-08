/*Задание 1:
 Создайте класс Пьеса. Класс должен хранить такую информацию:
- Название пьесы.
-ФИО автора.
-Жанр.
-Год выпуска.

 Реализуйте в классе методы и свойства необходимые для функционирования класса.
Добавьте в класс деструктор. Напишите код для тестирования функциональности класса.
Напишите код для вызова деструктора.

 Задание 2:
Создайте класс Магазин. Класс должен хранить такую информацию:
- Название магазина.
- Адрес магазина.
- Тип магазина.
   * Продовольственный
   * Хозяйственный
   * Одежда
   * Обувь
 Реализуйте в классе методы и свойства необходимые для функционирования класса.
Класс должен реализовывать интерфейс IDisposable. Напишите код для тестирования функциональности класса.
Напишите код для вызова метода Dispose.

Задание 3:
Добавьте к первому заданию реализацию интерфейса IDisposable
Добавьте ко второму заданию реализацию деструктора.
Напишите код для тестирования новых возможностей.
 */




Realisation_Piece();
GC.Collect();

Realisation_Shop();
GC.Collect();


void Realisation_Piece()
{
    using(Piece piece = new Piece("Ревизор", "Николай Гоголь", "Комедия", "1836"))
    {
        piece.Piece_Info();
        
    }
}

void Realisation_Shop()
{
    using(Shop shop = new Shop("АТБ", "бульвар Строителей 18", "Продовольственный"), shop1 = new Shop("Хозяин", "проспект Конституции 27-31", "Хозяйственный"), shop2 = new Shop("Индиго", "проспект Свободы 45", "Одежда"), shop3 = new Shop("Mida", "проспект Cвободы 59", "Обувь"))
    {
        shop.Shop_Info();
        shop1.Shop_Info();
        shop2.Shop_Info();
        shop3.Shop_Info();
       
    }
}





class Piece : IDisposable
{
    private string Piece_Name { get; set; }
    private string FIO_Author { get; set; }
    private string Genre { get; set; }
    private string Year { get; set; }

    public Piece(string piece_Name, string fIO_Author, string genre, string year)
    {
        Piece_Name = piece_Name;
        FIO_Author = fIO_Author;
        Genre = genre;
        Year = year;
    }

    public void Piece_Info()
    {
        Console.WriteLine($"Название пьесы: {Piece_Name}.\n Автор: {FIO_Author}.\n Жанр: {Genre}.\n Год выпуска: {Year}.");
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    ~Piece()
    {

    }
}



class Shop : IDisposable
{
    private string Name_Shop { get; set; }
    private string Adress { get; set; }
    private string Type { get; set; }

    public Shop(string name_Shop, string adress, string type)
    {
        Name_Shop = name_Shop;
        Adress = adress;
        Type = type;
    }

    public void Shop_Info()
    {
        Console.WriteLine();
        Console.WriteLine($" Название: {Name_Shop}.\n Адрес: {Adress}.\n Тип: {Type}.");
        Console.WriteLine();
    }

    public void Dispose()
    {
      
        GC.SuppressFinalize(this);
    }

    ~Shop()
    {

    }
}