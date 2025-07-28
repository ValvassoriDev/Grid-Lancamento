# 🏁 Projeto Ranking de Pilotos - Blazor Server

Este projeto é um sistema de visualização e filtragem de pilotos de corrida, desenvolvido como desafio proposto, utilizando **Blazor Server**. Ele apresenta os pilotos agrupados e filtráveis por **Categoria, Sexo, Traçado e Peso**, com ordenação pela **melhor volta**.

## ⚙️ Como configurar e rodar o projeto

1. **Pré-requisitos:**
   - Visual Studio 2022 (ou superior)
   - SDK .NET 6 ou superior

2. **Passo a passo:**
   - Clone o repositório:
     ```bash
     git clone [https://github.com/ValvassoriDev/Grid-Lancamento]
     ```
   - Abra o projeto no Visual Studio.
   - Restaure os pacotes (o Visual Studio faz isso automaticamente ao abrir o projeto).
   - Pressione `F5` ou clique em "Iniciar Depuração" para rodar o sistema.

## 📐 Decisões de design e arquitetura

- Optei por usar **Blazor Server**, pois é mais direto para testes e aprendizado.
- Os dados dos pilotos estão em um arquivo local (`wwwroot/Mock.json`), facilitando o uso sem precisar de API.
- A visualização é feita em **cards agrupados**, facilitando a leitura e organização dos dados.
- A ordenação dos pilotos em cada grupo é feita pela **melhor volta (menor tempo primeiro)**.
- Toda a estilização foi centralizada em um arquivo `style.css`, evitando o uso de CSS inline.
- A interface foi inspirada no tema automobilismo, com tons escuros como `#191D26`, `#252A2E`, `#393E45` e destaque em `#DC504E`.

## ✅ Requisitos atendidos

### Requisitos Mínimos:

- [x] Uso do Blazor Server e C#.
- [x] Classe de dados com os seguintes campos:
  - Nome, Equipe, MelhorVolta, Categoria, Peso, Sexo, Nacionalidade, Traçado.
- [x] Lista com 10 pilotos fictícios carregados via JSON local.
- [x] Agrupamento de pilotos em cards por Categoria, Sexo e Traçado.
- [x] Ordenação por melhor volta.
- [x] Cabeçalho identificando cada grupo.
- [x] Interface com visual inspirado em corridas.
- [x] Filtros funcionais por Categoria, Sexo, Peso e Traçado.
- [x] Atualização dinâmica da listagem conforme filtros.
- [x] Código limpo, separado em componentes, com uso adequado de modelos e injeções.

## 💬 Dificuldades enfrentadas

- No início usei muito CSS direto no HTML, o que dificultava a organização. Depois passei para o `style.css`, melhorando bastante.
- Ainda estou aprendendo como organizar melhor os componentes do Blazor, então levei um tempo para entender como dividir bem os arquivos.
- A leitura da melhor volta como string e a ordenação correta exigiram atenção para funcionar bem.
- Tive um pouco de dificuldade para deixar o layout legível e bonito, mas consegui aplicar um tema escuro com contraste claro nas tabelas.

## 📌 Observações finais

Esse projeto me ajudou a entender melhor como funciona o Blazor Server, desde carregar dados locais até trabalhar com componentes e filtros. Aprendi também a importância de manter o CSS separado e o HTML limpo. Foi desafiador, mas fiquei satisfeito com o resultado final. Ainda tenho muito o que aprender, mas esse foi um bom passo!

---
