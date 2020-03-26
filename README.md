# TPUM

### Programming of Mobile Devices - Programowanie urządzeń mobilnych
#### Stetsenko A. 234154

## Goal 

The goal of the task is to learn in practice:

* Web-sockets technology
* the reactive and interactive interaction of applications, including
* client/server architecture
* publisher/subscriber architecture
* the use of standards to represent interoperability models of applications produced by different manufacturers
* Dependency Injection
* unit and integration testing
* use of MOCK technology

## Scope

Develop a program using the .NET technology, which will perform the role of client and server. Using these roles it is necessary to ensure the exchange of selected structural data between the client and server instance. The following data exchange scenarios should be implemented:

* query/response - the client sends a request and the sewer responds with data depending on the received request
* Sending/Filtering spontaneously - the server sends data spontaneously, while the client filters it according to needs
* publication/subscription - the client orders (subscribes) data, and the server sends (publishes) data spontaneously to it as part of the subscription

The client/server communicates with each other using Web-sockets technology.

The transmitted data must be described using a common object model and represent the chosen business model.

## Related work

* [Mocks Aren't Stubs](https://martinfowler.com/articles/mocksArentStubs.html)
* [How to test software, part I: mocking, stubbing, and contract testing](https://circleci.com/blog/how-to-test-software-part-i-mocking-stubbing-and-contract-testing/?gclid=Cj0KCQiAkePyBRCEARIsAMy5ScunlfHQKu8LF1w4pG9d4P10ChGBpIv8YNgJklqj0rOYGb3p7-kNe8saAjZYEALw_wcB)
* [The WebSocket Protocol; Request for Comments: 6455](https://tools.ietf.org/html/rfc6455)
* [Web-sockets implementacja na GitGub w repozytorium mpostol/NBlockchain](https://github.com/mpostol/NBlockchain)
* [Programowanie Reaktywne](https://github.com/mpostol/TP/tree/master/AdaptiveProgramming/ConcurrentProgramming)
* [Repo for managing Moq 4.x](https://github.com/moq/moq4)
* [Moq 4.13.1](https://www.nuget.org/packages/Moq/4.13.1)
* [Przykładowa implementacja repliki procesu - symulator boilerów](https://github.com/mpostol/OPC-UA-OOI/tree/master/Networking/Simulator.Boiler)

## See also

https://ftims.edu.p.lodz.pl/course/view.php?id=1816
