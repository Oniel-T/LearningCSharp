using System;
using static LearningSOLID.PaymentGateway;

namespace LearningSOLID
{
  //Single Responsibility Principle: A module/class should have a single responsiblity as following email service example
  public class EmailService
  {
    public void SendMail() { /*Sending email*/ }
  }

  //Open Closed Principle: Open for extension but closed for modification
  public class PaymentGateway
  {
    public enum PayType{ AltaPay,PhonePay, GooglePay }
    public bool VoilatingPrinciple_Pay(PayType x)
    {
      switch (x)
      {
        case PayType.AltaPay:
          return true;
        case PayType.PhonePay:
          return true;
        case PayType.GooglePay:
          return true;
        default:
          return false;
      }
    }
  }
  public interface IPaymentGateway
  {
    bool Pay();
  }
  public class AltaPay : IPaymentGateway
  {
    public bool Pay()
    {
      throw new NotImplementedException();
    }
  }
  public class PhonePay : IPaymentGateway
  {
    public bool Pay()
    {
      throw new NotImplementedException();
    }
  }


  //Liskov Substitution Principle: class can be replaced with its subtype without affecting the correctness of program
  //Create a swimmable interface
  public interface Duck
  {
    public void Swim();
  }
  public class LivingDuck
  {
    public void Swim()
    {
      //Perform swim
    }
  }
  public class ToyDuck
  {
    public bool IsTurnedOn { get; set; }
    public void Swim()
    {
      if (IsTurnedOn)
      {
        //Perform swim
      }

    }
  }

  //Interface Segregation Principle: user should not be forced to implement method which it doesnt wants to.
  //split interface to have specific interface

  //Dependency Inversion Principle: 1. Higher level modules should not be dependent of lower level module. Both should depend on abstraction
  //                      2. Abstraction should not depend on Implementation. Implementation should depend on abstraction
  // Dependency injection is a way to have DIP
  public class Service
  {
    IRepository repository;
    public Service()
    {
      repository = new Repository();
    }
    public void DoSomething()
    {

    }
  }
  public interface IRepository
  {
    void DoSomething();
  }
  public class Repository : IRepository
  {
    public void DoSomething()
    {

    }
  }
}
