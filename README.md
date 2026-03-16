# 🚀 CryptoAdvisor AI — Gestão de Ativos e Consultoria com IA (.NET 8, Angular & Gemini)

---

## 🧭 Visão Geral

O **CryptoAdvisor AI** é uma plataforma Full Stack completa para gestão de portfólio de criptoativos. Desenvolvida com **.NET 8** no back-end e **Angular 19** no front-end, a aplicação vai além do simples rastreamento de saldo: ela utiliza a **IA do Google (Gemini)** para analisar a saúde financeira do usuário e fornecer conselhos estratégicos personalizados.

O projeto adota os princípios de **Clean Architecture** e **DDD**, garantindo um sistema escalável, com separação clara de responsabilidades e uma interface moderna e responsiva.

---

## ⚙️ Funcionalidades e Arquitetura

### 🏗️ 1. Arquitetura Full Stack & DDD
* **Back-end:** Estrutura modular em camadas utilizando .NET 8, focada na lógica de domínio e segurança.
* **Front-end:** SPA (Single Page Application) desenvolvida com Angular, utilizando componentes reativos e SSR (Server-Side Rendering) para performance otimizada.
* **Comunicação:** Integração robusta via REST API com políticas de CORS configuradas.

---

### 🤖 2. Inteligência Artificial (Gemini API)
* Integração com o modelo **Gemini 1.5 Flash** do Google.
* Análise em tempo real do patrimônio líquido e saldo em caixa.
* Geração de conselhos financeiros dinâmicos baseados na composição atual do portfólio do usuário.

---

### 📊 3. Dashboard Financeiro Real-time
* Visualização clara de **Saldo em Dinheiro** vs **Patrimônio Total**.
* Tabela dinâmica de ativos com cálculo automático de **Preço Médio** e **Total Investido**.
* Interface limpa e intuitiva focada na experiência do usuário (UX).

---

### 🛠️ 4. Persistência e Tecnologia de Ponta
* **Entity Framework Core:** Gerenciamento de banco de dados relacional com suporte a Migrations.
* **PostgreSQL / SQL Server:** Flexibilidade para persistência de dados de transações.
* **HttpClient & Fetch API:** Consumo de dados otimizado no front-end para garantir fluidez na navegação.
* **Dependency Injection:** Uso extensivo de injeção de dependência para desacoplamento de serviços.

---

### 🌐 5. Documentação e Segurança
* **Swagger UI:** Documentação interativa da API para testes rápidos de endpoints.
* **SSL/HTTPS:** Configuração de comunicação segura entre cliente e servidor.
* **Políticas de CORS:** Controle rigoroso de acesso à API.

---

## 🧰 Tecnologias Utilizadas

### **Back-end**
* **C# / .NET 8**
* **Entity Framework Core** (ORM)
* **Google Gemini SDK / REST** (Inteligência Artificial)
* **Domain-Driven Design (DDD)**
* **Swagger / UI** (Documentação)

### **Front-end**
* **Angular 19**
* **TypeScript**
* **RxJS** (Programação Reativa)
* **CSS3 Moderno** (Dashboard responsivo)
* **Zone.js** (Gerenciamento de ciclos de renderização)

---

## 🧠 Conceitos Principais Dominados

* Desenvolvimento **Full Stack** integrado (Back-end + Front-end).
* Integração de **IA Generativa** em aplicações corporativas.
* Arquitetura de software baseada em camadas e separação de interesses.
* Gerenciamento de estado e ciclo de vida de componentes no Angular.
* Implementação de lógica de negócios complexa para cálculo de preço médio de ativos.
* Configuração e otimização de ambientes com **SSR (Server-Side Rendering)**.

---

## 🏁 Conclusão

O **CryptoAdvisor AI** reflete o domínio de tecnologias modernas e a capacidade de unir o poder do processamento de dados do .NET com a agilidade do Angular. A inclusão da Inteligência Artificial eleva o projeto de uma simples ferramenta de gestão para um assistente financeiro inteligente, demonstrando prontidão para as demandas atuais do mercado de tecnologia.
