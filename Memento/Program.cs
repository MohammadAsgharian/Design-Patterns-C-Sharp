// See https://aka.ms/new-console-template for more information
using Memento;

Originator originator = new Originator();
originator.State = "Blue";
CareTaker careTaker = new CareTaker();
careTaker.Memento = originator.CreateMemento();
originator.State = "Green";
originator.State = "White";
originator.SetMemento(careTaker.Memento);
