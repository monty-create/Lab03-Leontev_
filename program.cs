Console.WriteLine("Банковский счёт");

double balance = 1000;
Console.WriteLine($"Начальный баланс: {balance}");

balance += 500;
Console.WriteLine($"После пополнения на 500: {balance}");

balance -= 200;
Console.WriteLine($"После покупки на 200: {balance}");

balance *= 1.05;
Console.WriteLine($"После начисления 5%: {balance}");

balance /= 2;
Console.WriteLine($"После деления пополам: {balance}");

Console.WriteLine();
Console.WriteLine("Постфикс vs префикс");

int lessonNumber = 1;
Console.WriteLine($"lessonNumber++ выводит: {lessonNumber++}");
Console.WriteLine($"После этого lessonNumber = {lessonNumber}");

int weekNumber = 1;
Console.WriteLine($"++weekNumber выводит: {++weekNumber}");
Console.WriteLine($"После этого weekNumber = {weekNumber}");

Console.WriteLine();
Console.WriteLine("Практическая ловушка");

int attempts = 0;
Console.WriteLine($"Попытка №{++attempts}");
Console.WriteLine($"Попытка №{++attempts}");
Console.WriteLine($"Всего попыток: {attempts}");

Console.WriteLine();
Console.WriteLine("Операторы сравнения");

double myGrade = 4.6;
double passingGrade = 4.0;
int myAge = 20;
int votingAge = 18;

bool isPassing = myGrade >= passingGrade;
bool isExactAge = myAge == votingAge;
bool canVote = myAge >= votingAge;
bool isNotFailing = myGrade != 2.0;

Console.WriteLine($"Балл {myGrade} >= {passingGrade}: {isPassing}");
Console.WriteLine($"Возраст {myAge} == {votingAge}: {isExactAge}");
Console.WriteLine($"Возраст {myAge} >= {votingAge} (может голосовать): {canVote}");
Console.WriteLine($"Балл {myGrade} != 2.0 (не двойка): {isNotFailing}");

Console.WriteLine();
Console.WriteLine("Логические операторы");

bool hasPassingGrade = true;
bool hasAttendance = false;
bool hasDebt = true;

bool canGetScholarship = hasPassingGrade && hasAttendance;
bool canRetakeExam = hasPassingGrade || hasAttendance;
bool isDebtFree = !hasDebt;

Console.WriteLine($"Может получить стипендию (оценка И посещаемость): {canGetScholarship}");
Console.WriteLine($"Может пересдать (оценка ИЛИ посещаемость): {canRetakeExam}");
Console.WriteLine($"Нет долгов: {isDebtFree}");

Console.WriteLine();
Console.WriteLine("Короткое замыкание");

bool CheckAndPrint(string label, bool value)
{
    Console.WriteLine($"  Вычисляется: {label}");
    return value;
}

Console.WriteLine("Проверяем && (первый операнд false):");
bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
Console.WriteLine($"Результат: {resultAnd}");

Console.WriteLine();
Console.WriteLine("Проверяем || (первый операнд true):");
bool resultOr = CheckAndPrint("C", true) || CheckAndPrint("D", false);
Console.WriteLine($"Результат: {resultOr}");

Console.WriteLine();
Console.WriteLine("Приоритет операций");

int resultNoParens = 2 + 3 * 4;
int resultWithParens = (2 + 3) * 4;
Console.WriteLine($"2 + 3 * 4     = {resultNoParens}");
Console.WriteLine($"(2 + 3) * 4   = {resultWithParens}");

bool logicResult = 5 > 3 && 2 < 4 || false;
bool logicResultParens = (5 > 3 && 2 < 4) || false;
Console.WriteLine($"5>3 && 2<4 || false   = {logicResult}");
Console.WriteLine($"(5>3 && 2<4) || false = {logicResultParens}");

Console.WriteLine();
Console.WriteLine("Приёмная комиссия");

Console.Write("Введите средний балл аттестата: ");
double averageGrade = double.Parse(Console.ReadLine());

Console.Write("Введите баллы за экзамен (0-100): ");
int examScore = int.Parse(Console.ReadLine());

Console.Write("Есть льгота? (1 - да, 0 - нет): ");
int benefitInput = int.Parse(Console.ReadLine());
bool hasBenefit = (benefitInput == 1);

bool hasGoodCertificate = averageGrade >= 4.0;
bool hasGoodExam = examScore >= 60;
bool isEligibleByRules = (hasGoodCertificate && hasGoodExam) || hasBenefit;

double totalScore = averageGrade * 10;
totalScore += examScore;

Console.WriteLine();
Console.WriteLine("Результат");
Console.WriteLine($"Хороший аттестат (>= 4.0): {hasGoodCertificate}");
Console.WriteLine($"Хороший экзамен (>= 60): {hasGoodExam}");
Console.WriteLine($"Льгота: {hasBenefit}");
Console.WriteLine($"Проходит по правилам: {isEligibleByRules}");
Console.WriteLine($"Итоговый балл: {totalScore}");

// Задание 1: проверка числа на чётность
Console.WriteLine();
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
bool isEven = number % 2 == 0;
Console.WriteLine($"Чётное: {isEven}");

// Задание 2: три разных случая для x++ и ++x
Console.WriteLine();
int score1 = 10;
// Сначала берётся старое значение 10 и умножается на 3 (будет 30), потом score1 становится 11
int multPost = score1++ * 3;
Console.WriteLine($"score1++ * 3 = {multPost}, score1 = {score1}");

int score2 = 10;
// Сначала score2 увеличивается до 11, потом прибавляется 5 (будет 16)
int sumPre = ++score2 + 5;
Console.WriteLine($"++score2 + 5 = {sumPre}, score2 = {score2}");

int score3 = 10;
// В saved записывается старое значение 10, а сама переменная score3 становится 11
int saved = score3++;
Console.WriteLine($"saved = score3++ -> saved = {saved}, score3 = {score3}");

// Задание 3: проверка скидки без if
Console.WriteLine();
Console.Write("Введите сумму покупки: ");
double purchaseSum = double.Parse(Console.ReadLine());
Console.Write("Есть карта клиента? (1 - да, 0 - нет): ");
int cardInput = int.Parse(Console.ReadLine());
bool hasCard = (cardInput == 1);
Console.Write("Количество товаров в чеке: ");
int productsCount = int.Parse(Console.ReadLine());

bool hasBigPurchase = purchaseSum >= 3000 && productsCount >= 3;
bool eligibleForDiscount = hasBigPurchase || hasCard;

Console.WriteLine($"Сумма >= 3000 и товаров >= 3: {hasBigPurchase}");
Console.WriteLine($"Есть карта клиента: {hasCard}");
Console.WriteLine($"Скидка положена: {eligibleForDiscount}");
