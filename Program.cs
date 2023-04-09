/*

12:10 06.04.2023

https://gb.ru/lessons/326734/homework	https://replit.com/languages/csharp
	Загрузите итоговый проект до 15 июля, 12:00 +03:00 UTC

	Урок 1. Контрольная работа
Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе 
Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в 
отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, 
как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При 
решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] => [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] => [“-2”]
[“Russia”, “Denmark”, “Kazan”] => []

C#	https://replit.com/languages/csharp


*/



using System;

namespace homework326734{


class HomeWork326734 { // string[] arr = new string[] {};
    string[] myStrings = new string[] { };
    string[] myShortStrings = new string[] { };
    int i3 = 3;  // length of short string !! 3

    static void Test() {
        Console.WriteLine("Hello, world! (Test)");
    }

    public void Init1(bool debug) {   // [“Hello”, “2”, “world”, “:-)”] => [“2”, “:-)”]
	myStrings = new string[4] { "Hello", "2", "world", ":-)" };
        
	if (debug){
		for (int i = 0; i < myStrings.GetLength(0); i++ ){
			Console.WriteLine($" {i}  : '{myStrings[i]}'” \n ");
		}		
	}
    }

    public void InitStrings(string[] arrStr, bool debug) {   // [“Hello”, “2”, “world”, “:-)”] => [“2”, “:-)”]
	int len = arrStr.GetLength(0);

	myStrings = new string[len];
  	for (int i = 0; i < len; i++ ){
		myStrings[i] = arrStr[i];  		
  	}	
          
	if (debug){
		for (int i = 0; i < myStrings.GetLength(0); i++ ){
			Console.WriteLine($" {i}  : “{myStrings[i]}” \n ");
		}		
	}
    }
  
    public void GetShortStrings(bool debug) {   // [“Hello”, “2”, “world”, “:-)”] => [“2”, “:-)”]
	int len = myStrings.GetLength(0);
    // string[] myStrings;
    // string[] myShortStrings;
	int count3 = 0;
	int j = 0;

	for (int i=0; i<len; i++) if (myStrings[i].Length <= i3) count3++;
	
	myShortStrings = new string[count3];

	
  	for (int i = 0; i < len; i++ ){
		if (myStrings[i].Length <= i3)
		{
			myShortStrings[j] = myStrings[i]; 
			if (debug) {
			Console.WriteLine($"{j} : “{myShortStrings[j]}” \n ");
			}
			j++;
		}
      	}	
    }


    static void Main(string[] args) {
      HomeWork326734 pr = new HomeWork326734();
      //HomeWork326734 p = HomeWork326734.new();
        Console.WriteLine("Hello, world!");
      Test();
// [“Hello”, “2”, “world”, “:-)”] => [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] => [“-2”]
// [“Russia”, “Denmark”, “Kazan”] => []
      // DoSomething(10, new[] {"One", "Two", "Three"});
	pr.InitStrings(new string[] {"Hello", "2", "world", ":-)"}, true);
		pr.GetShortStrings(true);

	pr.InitStrings(new string[]  { "1234", "1567", "-2", "computer science" } , true);
	pr.GetShortStrings(true);

  pr.InitStrings(new string[]  { "Russia", "Denmark", "Kazan" } , true);
	pr.GetShortStrings(true);
	
    }
  } // class HomeWork326734 

}  // namespace HomeWork326734{
