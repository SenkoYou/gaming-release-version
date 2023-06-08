using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gaming
{
    internal class Human
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int lvl { get; set; }

        public int op { get; set; }

        public bool isWeapon { get; set; }

        public int damage;
        public int hp;
        public bool stayAlive;
        public string ruWeapon;

        public void getBalance()
        {

            int truehp = lvl * 99;
            hp = truehp;

            int truedamage = lvl * 49;

            if (isWeapon) {
                truedamage += 29;
            }
            
            damage = truedamage;
        }

        public void lvlup(int p = 0)
        {

            lvl++;
            getBalance();
            op = 0;

            if (p != 0)
            {
                op = p;
            }

            Console.WriteLine(" Ваш уровень успешно был повышен, теперь вы намного сильнее!\n");
        }

        public void getInfo()
        {
            if (isWeapon)
            {
                ruWeapon = "Меч";
            }
            else {
                ruWeapon = "Нет";
            }
            Console.WriteLine(" Ваши статы: ");
            Console.WriteLine($" Имя: {Name}\n Описание: {Description}\n Уровень: {lvl}\n Количество опыта: {op}\n Оружие: {ruWeapon}\n Хп: {hp}\n Сила: {damage}\n");
        }

        public Human spawnEnemy(Human gg)
        {

            Human enemy = new Human();
            Random random = new Random();
            string[] FirstNames = new string[50] { "Сергор", "Катернин", "Иган", "Мара", "Зора", "Алиана", "Пронлак", "Бран", "Пенересил", "Урт", "Диль", "Дейман", "Джасмаль", "Зашеир", "Зашеида", "Эхпут-Ки", "Барерис", "Чатхи", "Мадислак", "Кетот", "Имзель", "Фаургар", "Боривик", "Хульмарра", "Марта", "Луиза", "Селизе", "Антон", "Арвин", "Тесселе", "Дорн", "Горстаг", "Аль", "Шуй", "Чао", "Мей", "Фай", "Лей", "Аэл", "Гар", "Триэлия", "Миали", "Бетринна", "Тикаэла", "Цефлай", "Улл", "Диньзее", "Джлкин", "Корза", "Окари" };
            string[] SecondNames = new string[50] { "Марск", "Немецк", "Берск", "Куленов", "'Прядильщик' Тунукалати", "'Твёрдая рука' Кола-Гилеана", "Амастасия (Звёздный Цветок)", "Лиадон (Серебряный Лист)", "Тёмная Тень", "Упавшая Звезда", "Найло (Ночной Бриз)", "Золотое Дерево", "Безрассудство", "'Зоркий глаз' Лагиага", "Чергоба", "Мурнитара", "Уутракт", "Ортегана", "Хун'Халик", "Лар'Ула", "Говорящий Ручей", "Быстрая Стрела", "Ленов", "Дотск", "Натроп", "Хилден", "Серпет", "Карлин Пок", "из клана Лютгер", "из клана Пьянокровь", "'Кривые руки' Като-Олави", "Оскар", "Убийство", "Мозрадиллион", "Галанодель (Лунный Шёпот)", "из клана Камнешлем", "из клана Глубинного рудника", "Фонкин Пивохлёб", "Кель'Рарати", "Прексижандилин", "Беринтолтропал", "Гигаззилишифт", "Вань", "Кунг", "Тань", "Као", "Тай", "'Умелый прыгун' Эланитино", "'Красиво говорящий' Анакалатай", "'Искатель кремня' Эланитино" };
            string[] Descriptions = new string[50] { "Простуженный голос", "Смеётся без причины", "Обожает подтяжки", "Втайне сочиняет стихи", "Боится прикосновений", "Считает людей предсказуемыми", "Жуткая улыбка", "Любит смотреть на небо", "Одевается во всё чёрное", "Безжизненный голос", "Коллекционирует ракушки", "Имеет хроническое заболевание", "Курит электронные сигареты", "Втайне сочиняет песни", "Боится высоты", "Постоянно что-то ест", "Постоянно размышляет вслух", "Вкрадчивый голос", "Всегда странно смотрит на всех", "Дальтоник", "Неко ушки и хвост", "Нервный тик в виде дергающейся улыбки", "Испытывает апатию к женщинам", "Бархатистый голос", "Любит открытую (местами откровенную) одежду", "Недовольный голос", "Крайне недоверчивый", "Любитель чая", "Мечтает о большой семье", "Садист", "Помешан на здоровом питании", "Любит энергетики", "Ломкий голос", "Отличный комик", "Самовлюблён", "Помешан на кофе", "Стесняется разговаривать с противоположным полом", "Прямолинейный", "Всегда нервно бегают глаза", "Обожает рисовать", "Помешан на комиксах и фигурках из аниме", "Всячески избегает фиолетовый цвет", "Коллекционирует фотографии бабочек", "Ненавидит звуки шёпота", "Всегда смотрит в глаза", "Разбирается в ядах", "Боится собак", "Всегда хочет спать", "Звонкий голос", "Ходит в одном и том же" };
            int chooseFN = random.Next(0, 50);
            int chooseSN = random.Next(0, 50);
            int chooseDS = random.Next(0, 50);
            enemy.Name = $"{FirstNames[chooseFN]} {SecondNames[chooseSN]}";
            enemy.Description = Descriptions[chooseDS];
            enemy.lvl = random.Next(1, gg.lvl + 1);
            enemy.op = random.Next(1, 99);
            int choose = random.Next(1, 4);

            if (choose == 1)
            {
                enemy.isWeapon = true;
            }
            else
            {
                enemy.isWeapon = false;
            }

            enemy.getBalance();
            enemy.stayAlive = true;

            return enemy;
        }

        public void successGo()
        {
            int go = 25;
            op = op + go;
            Console.WriteLine($" Вы успешно прошли комнату, прокачались и заработали {go} опыта! Теперь у вас {op} опыта!");
            if (op >= 100)
            {
                lvlup();
            }
        }
        public Human fight(Human gg)
        {
            Human enemy = spawnEnemy(gg);

            Console.WriteLine(" С бешеными глазами на вас нападает враг! \n");
            enemy.getInfo();

            bool finishFight = false;

            while (!finishFight) { 
            Human[] fighthit = fight_hit(gg, enemy);
            gg = fighthit[0];
            enemy = fighthit[1];

            if (gg.stayAlive && enemy.stayAlive)
            {

                Human[] fightdefence = fight_defence(gg, enemy);
                gg = fightdefence[0];
                enemy = fightdefence[1];

                if (!gg.stayAlive || !enemy.stayAlive) {
                        finishFight = true;
                        break;
                }
            }
            else {
                    finishFight = true;
                    break;
            }
            }
            return gg;
        }

        public bool isDeath(Human gg, Human enemy) {

            if (gg.hp <= 0 || enemy.hp <= 0)
            {
                return true;
            }
            else {
                return false;
            }

        }

        public Human[] fight_hit(Human gg, Human enemy)
        {
            Random random = new Random();
            Console.WriteLine("\n Вам приходится бить первым, только вот куда?");
            Console.WriteLine(" (1) В живот! (2) В левую руку! (3) В правую руку! (4) В левую ногу! (5) В правую ногу! \n");
            int hit = Convert.ToInt32(Console.ReadLine());

            if (hit > 5 || hit < 1) {
                Console.WriteLine(" Какой позор, вы промахиваетесь по противнику! \n");
                return getHeroes(gg, enemy);
            }
            Console.WriteLine("");
            int block = random.Next(1, 5);

            if (hit == block)
            {
                gg.hp -= enemy.damage;
                Console.WriteLine($" Противник мастерски парировал ваш удар и нанес контратаку, нанеся вам {enemy.damage} урона! \n");

                if (isDeath(gg, enemy)) {
                    gg.stayAlive = false;
                    return getHeroes(gg, enemy);
                }


                Console.WriteLine($" Вы в шоке, у вас остается {gg.hp} ХП! \n");
                return getHeroes(gg, enemy);
            }
            else
            {
                enemy.hp -= gg.damage;
                Console.WriteLine($" Что за удар? Вы пробиваете защиту противника, нанеся ему {gg.damage} урона.");
                switch (block)
                {
                    case 1:
                        Console.WriteLine(" Противник защищал живот.. Слабак!\n");
                        break;
                    case 2:
                        Console.WriteLine(" Противник защищал в левую руку.. Мда, не видит банальной атаки!\n");
                        break;
                    case 3:
                        Console.WriteLine(" Противник защищал в правую руку.. Боялся остаться безоружным!\n");
                        break;
                    case 4:
                        Console.WriteLine(" Противник защищал в левую ногу.. Как можно быть таким тупым?\n");
                        break;
                    case 5:
                        Console.WriteLine(" Противник защищал правую ногу.. Боится, что не сможет убежать!\n");
                        break;
                }

                if (isDeath(gg, enemy))
                {
                    gg.lvlup(gg.op);
                    gg = pickupWeapon(gg, enemy);
                    gameEnd(gg, 2);
                    enemy.stayAlive = false;
                    return getHeroes(gg, enemy);
                }

            Console.WriteLine($" Осталось всего {enemy.hp} ХП у {enemy.Name} \n");
            return getHeroes(gg, enemy);

            }
        }

        public Human[] getHeroes(Human gg, Human enemy) {

            Human[] heroes = new Human[2];
            heroes[0] = gg;
            heroes[1] = enemy;
            return heroes;
        }

        public Human newGG() {
            Human gg = new Human();
            Console.WriteLine(" Идешь короче по улице и вдруг видишь подземелье!!! Кстати, как тебя зовут? \n");
            Console.Write(" Моё имя: ");
            gg.Name = Console.ReadLine();
            Console.Write("");
            Console.WriteLine(" И ты решаешь зайти в него.. Только зачем? Расскажи о себе, может так станет понятнее! \n");
            Console.Write(" Моё описание: ");
            gg.Description = Console.ReadLine();
            Console.Write("");
            gg.lvl = 1;
            gg.op = 0;
            gg.isWeapon = false;
            gg.stayAlive = true;
            gg.getBalance();
            return gg;
        }

        public void WinOrLoose(Human gg) {

            switch (gg.stayAlive) {
                case true:
                    Console.WriteLine(" Ваш противник умер! Вы победили, но какой ценой?");
                    break;
                case false:
                    Console.WriteLine(" Ваш противник был слишком силен!\n Вы сильно ранены и скоро потеряете сознание. Стоила ли эта пещера того?");
                    Thread.Sleep(5000);
                    Environment.Exit(0);
                    break;
            
            }

        }

        public Human[] fight_defence(Human gg, Human enemy) {

            Random random = new Random();
            Console.WriteLine(" Стоп.. Противник приготовился к ответной атаке! Куда же он ударит? Думай!");
            Console.WriteLine(" (1) В живот! (2) В левую руку! (3) В правую руку! (4) В левую ногу! (5) В правую ногу! \n");
            int hit = random.Next(1, 5);
            int block = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");



            if (hit == block)
            {
                enemy.hp -= gg.damage;
                Console.WriteLine($" Что за мастерство? Вы парировали атаку и нанесли противнику {gg.damage} урона!\n");

                if (isDeath(gg, enemy))
                {
                    gg.lvlup(gg.op);
                    gg = pickupWeapon(gg, enemy);
                    gameEnd(gg,1);
                    enemy.stayAlive = false;
                    return getHeroes(gg, enemy);
                }

                Console.WriteLine($" Вы показываете ваше умение орудовать мечом, оставляя противнику {enemy.hp} ХП!\n");
                return getHeroes(gg, enemy);

            } else
            {
                gg.hp -= enemy.damage;
                Console.WriteLine($" Удар противника был слишком хорош, он пробил вашу защиту и нанес {enemy.damage} урона.");
                switch (hit)
                {
                    case 1:
                        Console.WriteLine(" Противник бил в живот.. Какой очевидный удар!\n");
                        break;
                    case 2:
                        Console.WriteLine(" Противник бил в левую руку.. Хотел вас обезоружить, но вы правша!\n");
                        break;
                    case 3:
                        Console.WriteLine(" Противник бил в правую руку.. Хорошо, что не задел кисть!\n");
                        break;
                    case 4:
                        Console.WriteLine(" Противник бил в левую ногу.. Какой грязный трюк!\n");
                        break;
                    case 5:
                        Console.WriteLine(" Противник попал в правую ногу.. Бил по опорной ноге.. Крыса!\n");
                        break;
                }

                if (isDeath(gg, enemy))
                {
                    gg.stayAlive = false;
                    return getHeroes(gg, enemy);
                }


                Console.WriteLine($" Осталось всего {gg.hp} ХП!\n");
                return getHeroes(gg, enemy);
            }
        }

        public void gameEnd(Human gg, int situation) {

            if (gg.lvl >= 10)
            {
                Random random = new Random();

                switch (situation) {
                    case 1:
                        // После парирования
                        int chanceToRich1 = 200 / (gg.lvl * 4);
                        int money1 = random.Next(1, chanceToRich1);

                        if (money1 == 1)
                        {
                            Console.WriteLine(" После парирования вы замечаете, что за спиной противника было сокровище, взять его? y/n");
                            string input = Console.ReadLine();
                            Console.WriteLine("");
                            if (input == "y")
                            {
                                Console.WriteLine(" Вы забираете сокровище и живете счастливо со своей семьей. Конец.");
                                Thread.Sleep(5000);
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine(" Мда, видимо вы захотели подраться еще..\n Видимо вы любите острые ощущения.");
                            }

                        }

                        break;
                    case 2:
                        // После победы
                        int chanceToRich2 = 200 / (gg.lvl * 2);
                        int money2 = random.Next(1, chanceToRich2);

                        if (money2 == 1)
                        {
                            Console.WriteLine(" После победы над врагом вы заметили сокровище, которое он прятал, взять его? y/n");
                            string input = Console.ReadLine();
                            Console.WriteLine("");
                            if (input == "y")
                            {
                                Console.WriteLine(" Вы забираете сокровище и живете счастливо со своей семьей. Конец.");
                                Thread.Sleep(5000);
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine(" Мда, видимо вы захотели подраться еще..\n Видимо вы слишком самоуверены.");
                            }

                        }

                        break;
                    case 3:
                        // Просто прогулка
                        int chanceToRich3 = 400 / (gg.lvl);
                        int money3 = random.Next(1, chanceToRich3);

                        if (money3 == 1)
                        {
                            Console.WriteLine(" Прогуливаясь по лабиринтам вы приходите к сокровищу! Невероятная удача! Взять его? y/n");
                            string input = Console.ReadLine();
                            Console.WriteLine("");
                            if (input == "y")
                            {
                                Console.WriteLine(" Вы забираете сокровище и живете счастливо со своей семьей. Конец.");
                                Thread.Sleep(5000);
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine(" Мда, видимо вы захотели прогуляться еще..\n Жизнь ничему вас не учит.");
                            }

                        }

                        break;
                }   
            }
        }

        public Human pickupWeapon(Human gg, Human enemy) {

            if (gg.isWeapon == false) {
                if (enemy.isWeapon == true) {

                    Random random = new Random();
                    int chanceToWeapon = 100 / gg.lvl;
                    int pickWeapon = random.Next(1, chanceToWeapon);
                    if (pickWeapon == 1)
                    {
                        Console.WriteLine(" Оружие противника не сломано, заберете? y/n");
                        string input = Console.ReadLine();
                        Console.WriteLine("");
                        if (input == "y")
                        {
                            Console.WriteLine(" Вы забираете оружие противника.\n");
                            gg.isWeapon = true;
                            return gg;
                        }
                        else
                        {
                            Console.WriteLine(" Вы решаете не забираете оружие противника.\n");
                            return gg;
                        }

                    }
                    else {
                        Console.WriteLine(" Оружие противника было сломано, от него не осталось никакой пользы.\n");
                        return gg;
                    }
                }

            }
            return gg;

        }


    }
}
