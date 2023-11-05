using Pratice_5;

int cost = 0;
string str = " ";
string path = "D:\\Vyacheslav\\Study\\Project\\Visual C#\\Pratice 5\\Orders.txt";
void Menu()
{

    Console.WriteLine("  Заказ тортов");
    Console.WriteLine("  Форма");
    Console.WriteLine("  Размер");
    Console.WriteLine("  Вкус коржей");
    Console.WriteLine("  Количество коржей");
    Console.WriteLine("  Глазурь");
    Console.WriteLine("  Декорации");
    Console.WriteLine("  Конец заказа");
    Console.WriteLine("  ");
    Console.WriteLine("  Цена: " + cost);
    Console.WriteLine("  Ваш торт: " + str);
}

void start(int pos)
{

    if (pos == 1)
    {

        ConsoleKeyInfo key;


        Console.Clear();
        Console.WriteLine("  Круглый: 299 руб.");
        Console.WriteLine("  Квадратный: 349 руб.");
        Console.WriteLine("  Ромбик: 579 руб.");
        key = Console.ReadKey();
        Arrow arrow = new Arrow();
        int po = arrow.arrow();

        if (po == 0)
        {
            str = str + "\nКруглый \n\n";
            cost = cost + 299;
            File.AppendAllText(path, str + cost);
        }
        else if (po == 1)
        {
            str = str + "\nКвадратный \n\n";
            cost = cost + 349;
            File.AppendAllText(path, str + cost);
        }

        else if (po == 2)
        {
            str = str + "\nРомбик \n\n";
            cost = cost + 579;
            File.AppendAllText(path, str + cost);
        }
    }
    else if (pos == 2)
    {
        ConsoleKeyInfo key;
        Console.Clear();
        Console.WriteLine("  Размер 22,5 см: 999 руб.");
        Console.WriteLine("  Размер 32 см: 1479 руб.");
        Console.WriteLine("  Размер 40 см: 1999 руб.");

        key = Console.ReadKey();
        Arrow arrow = new Arrow();
        int po = arrow.arrow();

        if (po == 0)
        {
            str = str + "\nРазмер 22,5 см \n\n";
            cost = cost + 999;
            File.AppendAllText(path, str + cost);
        }
        else if (po == 1)
        {
            str = str + "\nРазмер 32 см \n\n";
            cost = cost + 1479;
            File.AppendAllText(path, str + cost);
        }

        else if (po == 2)
        {
            str = str + "\nРазмер 40 см \n\n";
            cost = cost + 1999;
            File.AppendAllText(path, str + cost);
        }
    }
    else if (pos == 3)
    {
        ConsoleKeyInfo key;
        Console.Clear();
        Console.WriteLine("  Ванильный: 149 руб.");
        Console.WriteLine("  Шоколадный: 299 руб.");
        Console.WriteLine("  Персиковый: 449 руб.");
        key = Console.ReadKey();
        Arrow arrow = new Arrow();
        int po = arrow.arrow();

        if (po == 0)
        {
            str = str + "\nВанильный \n\n";
            cost = cost + 149;
            File.AppendAllText(path, str + cost);
        }
        else if (po == 1)
        {
            str = str + "\nШоколадный \n\n";
            cost = cost + 299;
            File.AppendAllText(path, str + cost);
        }

        else if (po == 2)
        {
            str = str + "\nПерсиковый \n\n";
            cost = cost + 449;
            File.AppendAllText(path, str + cost);
        }
    }
    else if (pos == 4)
    {
        ConsoleKeyInfo key;
        Console.Clear();
        Console.WriteLine("  2 коржа: 329 руб.");
        Console.WriteLine("  3 коржа: 449 руб.");
        Console.WriteLine("  4 коржа: 599 руб.");
        key = Console.ReadKey();
        Arrow arrow = new Arrow();
        int po = arrow.arrow();

        if (po == 0)
        {
            str = str + "\n2 коржа \n\n";
            cost = cost + 329;
            File.AppendAllText(path, str + cost);
        }
        else if (po == 1)
        {
            str = str + "\n3 коржа \n\n";
            cost = cost + 449;
            File.AppendAllText(path, str + cost);
        }

        else if (po == 2)
        {
            str = str + "\n4 коржа \n\n";
            cost = cost + 599;
            File.AppendAllText(path, str + cost);
        }
    }
    else if (pos == 5)
    {
        ConsoleKeyInfo key;
        Console.Clear();
        Console.WriteLine("  Клубничная: 449 руб.");
        Console.WriteLine("  Шоколадная: 359 руб.");
        Console.WriteLine("  Ванильная: 129 руб.");
        key = Console.ReadKey();
        Arrow arrow = new Arrow();
        int po = arrow.arrow();
        if (po == 0)
        {
            str = str + "\nКлубничная \n\n";
            cost = cost + 449;
            File.AppendAllText(path, str + cost);
        }
        else if (po == 1)
        {
            str = str + "\nШоколадная \n\n";
            cost = cost + 359;
            File.AppendAllText(path, str + cost);
        }

        else if (po == 2)
        {
            str = str + "\nВанильная \n\n";
            cost = cost + 129;
        }
        File.AppendAllText(path, str + cost);
    }
    else if (pos == 6)
    {
        ConsoleKeyInfo key;
        Console.Clear();
        Console.WriteLine("  Крем-Брюле: 199 руб.");
        Console.WriteLine("  Вишня: 799 руб.");
        Console.WriteLine("  Безе: 389 руб.");
        key = Console.ReadKey();
        Arrow arrow = new Arrow();
        int po = arrow.arrow();
        if (po == 0)
        {
            str = str + "\nКрем-Брюле \n\n";
            cost = cost + 199;
            File.AppendAllText(path, str + cost);
        }
        else if (po == 1)
        {
            str = str + "\nВишня \n\n";
            cost = cost + 799;
            File.AppendAllText(path, str + cost);
        }

        else if (po == 2)
        {
            str = str + "\nБезе \n\n";
            cost = cost + 389;
            File.AppendAllText(path, str + cost);
        }
    }
    else if (pos == 7)
    {
        ConsoleKeyInfo key;

        Console.Clear();

        Console.WriteLine("Ваш заказ оформлен!!!");

        string order_list = "\n\nСписок заказа: " + str;
        string order_cost = "\nСтоимость: " + cost;

        File.WriteAllText("D:\\Vyacheslav\\Study\\Project\\Visual C#\\Pratice 5\\Orders.txt", "\n" + order_list);
        File.WriteAllText("D:\\Vyacheslav\\Study\\Project\\Visual C#\\Pratice 5\\Orders.txt", "\n" + order_cost);

        key = Console.ReadKey();
        Arrow arrow = new Arrow();
        arrow.arrow();

        if (key.Key == ConsoleKey.Escape)
        {
            Console.Clear();
            str = " ";
            cost = 0;
        }
    }
    Select();
}


void Select()
{
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if (key.Key != ConsoleKey.Escape)
    {

        Console.Clear();

        Menu();
        Arrow arrow = new Arrow();
        int pos = arrow.arrow();

        start(pos);
        Menu();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("/tУдачи!");
    }
}
Select();