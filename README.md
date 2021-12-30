# Padroes de projeto - APS
Atividade Prática realizada para a Disciplina de Análise e Projeto de Software

O factory method é um padrão de projetos que fornece uma interface para criar objetos em uma superclasse, mas também perrmite que as subclasses altere os tipos de objetos que são criados. Isso é feito através da criação de objetos que chamam o método fábrica especificando numa interface e implementando por uma classe filha, ou em uma classe abstrata.

Este padrão é muito utilizado em frameworks para definir e manter relacionamentos entre objetos, o Spring, por exemplo, pode utilizar um factory method para criar os seus beans.

#### Pontos positivos

- Baixo acoplamento e maior flexibilidade
- remove a necessidade de acoplar classes específicas para aplicação em nível de código.
- retornar uma subclasse ao invés de um objeto daquele tipo exato.

#### Pontos Negativos

- alto numero de classes que podem sobrecarregar o sistema.
