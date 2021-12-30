# Padroes de projeto - APS
Atividade Prática realizada para a Disciplina de Análise e Projeto de Software

#### Grupo:

#### Carlos Rogner de Oliveira Junior

#### Diego Araújo Silva

#### Régisson César Pereira de Aguiar



# Factory Method

O factory method é um padrão de projetos que fornece uma interface para criar objetos em uma superclasse, mas também perrmite que as subclasses altere os tipos de objetos que são criados. Isso é feito através da criação de objetos que chamam o método fábrica especificando numa interface e implementando por uma classe filha, ou em uma classe abstrata.

Este padrão é muito utilizado em frameworks para definir e manter relacionamentos entre objetos, o Spring, por exemplo, pode utilizar um factory method para criar os seus beans.

#### Pontos positivos

- Baixo acoplamento e maior flexibilidade
- remove a necessidade de acoplar classes específicas para aplicação em nível de código.
- retornar uma subclasse ao invés de um objeto daquele tipo exato.

#### Pontos Negativos

- alto numero de classes que podem sobrecarregar o sistema.



# Proxy

O Proxy tem como o seu objetivo principal é encapsular um objeto através de outro objeto que possui a mesma interface, de forma que o objeto proxy (o segundo objeto) controle o acesso do primeiro, que é o objeto real.  Os proxies foram inventados para adicionar estrutura e encapsulamento aos sistemas distribuídos. Alguns dos seus usos podem estar relacionados a: filtrar conteúdo, providenciar anonimato, e entre outros, atualmente um dos maiores proxies é o Proxy Web. Ele também pode ser encontrado em aplicações J2EE e por alguns frameworks. 



#### Pontos Positivos

- Você pode gerenciar o ciclo de vida do objeto de serviço quando os clientes não se importam com isso.
- Princípio aberto/fechado. Você pode introduzir novos proxies sem alterar o serviço ou os clientes.
- O proxy funciona mesmo se o objeto de serviço não estiver pronto.

#### Pontos Negativos

- A resposta do serviço pode demorar.
- O código pode se tornar mais complicado, pois você precisa introduzir várias novas classes.
