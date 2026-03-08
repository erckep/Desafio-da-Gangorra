# Desafio da Gangorra ⚖️

## 📌 Descrição

Este projeto é uma solução em **C#** para o problema clássico da **Gangorra**, onde precisamos verificar qual lado da gangorra possui maior torque ou se ela está equilibrada.

O programa recebe **quatro valores inteiros**:

* **P1** → Peso do lado esquerdo
* **C1** → Comprimento do lado esquerdo
* **P2** → Peso do lado direito
* **C2** → Comprimento do lado direito

O cálculo é feito usando a fórmula:

Torque = Peso × Comprimento

---

## 🧠 Lógica do Problema

* Se **P1 × C1 > P2 × C2** → A gangorra pende para a esquerda → saída **-1**
* Se **P1 × C1 < P2 × C2** → A gangorra pende para a direita → saída **1**
* Se **P1 × C1 = P2 × C2** → A gangorra está **equilibrada** → saída **0**

---

## 💻 Tecnologias utilizadas

* C#
* .NET
* Visual Studio Code

---

## ▶️ Como executar o projeto

1. Clone o repositório:

```
git clone https://github.com/erckep/Desafio-da-Gangorra.git
```

2. Entre na pasta do projeto

```
cd Desafio-da-Gangorra
```

3. Execute o programa

```
dotnet run
```

---

## 📷 Exemplo de execução

Entrada:

```
10 2 5 3
```

Cálculo:

```
10 × 2 = 20
5 × 3 = 15
```

Saída:

```
-1
```

---

## 📚 Objetivo do projeto

Este projeto foi desenvolvido como prática de **lógica de programação e manipulação de entrada de dados em C#**.

---

## 👨‍💻 Autor

Desenvolvido por **Erick Pereira Damasceno**
