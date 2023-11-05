using System;

namespace S_pochinom
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string tmp, name = string.Empty;

            Console.Write("Утречка, путник\n");

            while (true)
            {
                if (name != string.Empty) Console.Write($"Привет, {name}!");
                Console.Write(
                    "\nИспользование программы строго для коммерческих целей, а вот лист доступных тебе команд: ");
                Console.WriteLine("/start, /info, /echo, /exit, /help\n");

                tmp = Console.ReadLine();
                switch (tmp.ToLower())
                {
                    case "/start":
                    case "start":
                        name = Cmd_Start(name);
                        break;
                    case "/info":
                    case "info":
                        Console.WriteLine("Версия программы 1.0, полтора часика в пледике и кружечкой чая прошли замечательно спасибо <3");
                        Console.WriteLine("Создана michel \"adr1enette\": Октябрь 05, 2023");
                        Console.WriteLine(
                            "Использование данной программы допускается в коммерческих и смешных целях. Любое другое использование запрещено.\n\n");
                        break;
                    case "/exit":
                    case "exit":
                        Cmd_Exit();
                        break;
                    case "/help":
                    case "help":
                        Console.WriteLine(
                            "/start — давайте знакомиться!\n/info — версия, дата создания, кому посвящается");
                        Console.WriteLine(
                            "/echo \"комплимент\" — зеркало твоих прекрасных слов <3\n/help — слушай, а ловко ты это придумал");
                        break;
                    default:
                        if ((tmp.StartsWith("/echo ") || tmp.StartsWith("echo ")) && tmp.Length >= 6)
                        {
                            Console.WriteLine(tmp.Substring(5));
                            break;
                        }
                        else
                        {
                            if (name == string.Empty)
                                Console.WriteLine(
                                    "Твои слова услышаны, я поставлю свечку. А пока можешь начать со /start");
                            else
                            {
                                Console.WriteLine(
                                    "Тигр, Тигр, жгучий страх,\nТы горишь в ночных лесах.\nЧей бессмертный взор, любя,\nСоздал страшного тебя?");
                                Console.WriteLine($"          by {name} Повтори-Снова");
                            }

                            break;
                        }
                }
            }
        }

        private static string Cmd_Start(string name)
        {
            if (name == string.Empty)
            {
                Console.Write("Познакомимся? Произнеси на ушко свое имя: ");
                name = Console.ReadLine();
                if (name.ToLower() == "/exit" || name.ToLower() == "exit") Cmd_Exit();
                Console.WriteLine($"Твое имя — {name} (красивое^^)");
                return name;
            }
            else
            {
                Console.WriteLine($"Я правда считаю, что тебе очень идет твое имя, {name}");
                Console.WriteLine("Уверен, что хочешь поменять его? (Y/N)");
                while (true)
                {
                    string check = Console.ReadLine();
                    switch (check.ToLower())
                    {
                        case "y":
                            Console.WriteLine("\nХотя бы фамилию не меняй.. (если не на мою конечно): ");
                            name = string.Empty;
                            Cmd_Start(name);
                            break;
                        case "n":
                            Console.WriteLine($"Я знал, что Вы одумаетесь, Г-н {name}");
                            break;
                        case "/exit":
                        case "exit":
                            Cmd_Exit();
                            break;
                        default:
                            Console.WriteLine("Не пон ( ´･･)ﾉ(._.`), попробуй снова (Y/N)");
                            break;
                    }
                }
            }
        }

        private static void Cmd_Exit()
        {
            Console.WriteLine("Ты же использовал программу только в коммерческих целях? (._.`)");
            Console.WriteLine("p.s. я знаю где ты живешь");
            Environment.Exit(0);
        }
    }
}
