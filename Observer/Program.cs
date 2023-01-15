// See https://aka.ms/new-console-template for more information

using Observer;

Subject objectSubject = new Subject();
objectSubject.Attach(new Observer.Observer("observer 1"));
objectSubject.Attach(new Observer.Observer("observer 2"));
objectSubject.Attach(new Observer.Observer("observer 3"));
//
objectSubject.SetSubjectState("test");
Console.Read();
