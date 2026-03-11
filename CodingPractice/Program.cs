using System;

// README.md를 읽고 코드를 작성하세요.
Notify notify = SayHello;
notify += SayGoodbye;
notify();

Button button = new Button();
button.Click += HandleClick;
button.Click += HandleClickAgain;

button.Onclick();

Player player = new Player();
HealthBar healthBar = new HealthBar();
SoundManager soundManager = new SoundManager();

player.DamageTaken += healthBar.OnPlayerDamaged;
player.DamageTaken += soundManager.OnPlayerDamaged;

player.TakeDamage(30);

Timer timer = new Timer();
Logger logger = new Logger();

Console.WriteLine("\n=== 구독 상태 ===");
timer.Tick += logger.OnTick;
timer.Start();

Console.WriteLine("\n=== 구독 해제 후 ===");
timer.Tick -= logger.OnTick;
timer.Start();

Sensor sensor = new Sensor();
sensor.Alert += (msg) => Console.WriteLine($"[경보] {msg}");
sensor.Alert += (msg) => Console.WriteLine($"[로그] {DateTime.Now}: {msg}");

Console.WriteLine();
sensor.Detect("움직임 감지됨");
Console.WriteLine();
sensor.Detect("온도 상승");

GameCharacter character = new GameCharacter();
character.OnDeath += () => Console.WriteLine("캐릭터가 사망했습니다");
character.OnDamaged += (health) => Console.WriteLine($"남은 체력: {health}");
character.OnAttack += (damage, name) => Console.WriteLine($"{name}에게 {damage} 데미지!");

character.Attack(50, "슬라임");
character.TakeDamage(30);
character.TakeDamage(80);

Stock msStock = new Stock("MSFT", 100.00m);

msStock.PriceChanged += (sender, e) =>
{
    Stock stock = (Stock)sender;
    Console.WriteLine($"[{stock}]");
    Console.WriteLine($"  이전 가격: {e.OldPrice:C}");
    Console.WriteLine($"  현재 가격: {e.NewPrice:C}");
    Console.WriteLine($"  변동률: {e.ChangePercent:F2}%");
    Console.WriteLine();
};

msStock.Price = 110.00m;
msStock.Price = 105.50m;
msStock.Price = 120.00m;

Car car = new Car(50);
Dashboard dashboard = new Dashboard();

dashboard.Subscribe(car);

for (int i = 0; i < 7; i++)
{
    car.Drive();
    Console.WriteLine();
}

dashboard.Unsubscribe(car);

//SecurePublisher publisher = new SecurePublisher();

//publisher.MyEvent += Handler1;
//publisher.MyEvent += Handler2;

//Console.WriteLine("\n이벤트 발생:");
//publisher.RaiseEvent();

//Console.WriteLine();
//publisher.MyEvent -= Handler1;

//Console.WriteLine("\n이벤트 발생:");
//publisher.RaiseEvent();

//void Handler1(object sender, EventArgs e)
//{
//    Console.WriteLine("Handler1 실행됨");
//}

//void Handler2(object sender, EventArgs e)
//{
//    Console.WriteLine("Handler2 실행됨");
//}

Module1 m1 = new Module1();
Module2 m2 = new Module2();

GlobalNotifier.SendMessage("시스템 시작");
Console.WriteLine();
GlobalNotifier.SendMessage("데이터 로드 완료");

void HandleClick()
{
    Console.WriteLine("버튼이 클릭되었습니다!");
}

void HandleClickAgain()
{
    Console.WriteLine("클릭 처리 완료");
}

void SayHello()
{
    Console.WriteLine("안녕하세요!");
}

void SayGoodbye()
{
    Console.WriteLine("안녕히 가세요!");
}

delegate void Notify();

delegate void EventHandler();