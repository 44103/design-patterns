Visitor visitorA = new ConcreteVisitorA();
Visitor visitorB = new ConcreteVisitorB();

Acceptor acceptorA = new ConcreteAcceptorA();
Acceptor acceptorB = new ConcreteAcceptorB();

acceptorA.Accept(visitorA);
acceptorB.Accept(visitorA);

acceptorA.Accept(visitorB);
acceptorB.Accept(visitorB);
