﻿# Proxy Pattern

## Мотивация

 * Междинен клас, който ни дава възможност да комуникираме с основния. Има различни приложения спрямо това кой вид Proxy ползваме - Remote, Virtual, Protection.
 

## Цел

 * Remote Proxy - служи за обработване на данни при прехвърляне(кодира, прави статистика, логва информация).
 * Virtual Proxy - служи за достъпване на допълнителна информация при евентуална нужда от нея и кеширането и.
 * Protection Proxy - служи за добавяне на валидации и както за достъпване на ресурс, ако клиента е оторизиран.

## Приложение

* Пример:

	Virtual Proxy - Навигацонните property-та от Entity Framework(това са полета, които сочат към други таблици - например 'курсове', 'учители') те са дефинират като 'virtual' такива и дават възможност вътрешно 'EF' да създава 'proxy' класове, които представляват основните класове(Student)и доставят данните само, когато имаме нужда от тях или с други думи, когато напишем 'currentStudent.grades' и активираме 'get'-a на полето.
	
    
## Известни употреби
* Remote Proxy - комункация на WPF приложение с WCF service.
* Virtual Proxy - пренаписва виртуалните навигационни property-та в Entity Framework
* Protection Proxy - Proxy server-ите на Китай, които блокират Facebook

## Имплментация 

```c#
using System;
 
namespace DoFactory.GangOfFour.Proxy.RealWorld
{
  /// <summary>
  /// MainApp startup class for Real-World 
  /// Proxy Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Create math proxy
      MathProxy proxy = new MathProxy();
 
      // Do the math
      Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
      Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
      Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
      Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Subject interface
  /// </summary>
  public interface IMath
  {
    double Add(double x, double y);
    double Sub(double x, double y);
    double Mul(double x, double y);
    double Div(double x, double y);
  }
 
  /// <summary>
  /// The 'RealSubject' class
  /// </summary>
  class Math : IMath
  {
    public double Add(double x, double y) { return x + y; }
    public double Sub(double x, double y) { return x - y; }
    public double Mul(double x, double y) { return x * y; }
    public double Div(double x, double y) { return x / y; }
  }
 
  /// <summary>
  /// The 'Proxy Object' class
  /// </summary>
  class MathProxy : IMath
  {
    private Math _math = new Math();
 
    public double Add(double x, double y)
    {
      return _math.Add(x, y);
    }
    public double Sub(double x, double y)
    {
      return _math.Sub(x, y);
    }
    public double Mul(double x, double y)
    {
      return _math.Mul(x, y);
    }
    public double Div(double x, double y)
    {
      return _math.Div(x, y);
    }
  }
}
  ```

## Последствия
* Посредник с определени функции

## Сродни модели
* Facade Pattern


## UML  диаграма

![alt text](https://github.com/shunobaka/TelerikAcademy-Homeworks/blob/master/C%23/High-Quality-Code/14.%20Design%20Patterns/2.%20Structural/images/Proxy.png)
