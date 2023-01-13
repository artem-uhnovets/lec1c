Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower()=="маша") // если использовать username.ToLower(), то уйдет проблема того как пльзователь введет свое имя
// username.ToLower переводит все символы в нижний регистр
{
    Console.WriteLine("Ура, это же МАША!!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.WriteLine("!");
}