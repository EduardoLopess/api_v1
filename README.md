# Sistema de Pedidos + PDV/ERP

## Visão Geral
O sistema foi desenvolvido para atender as necessidades de pequenos estabelecimentos (quiosques), oferecendo **gestão completa do fluxo operacional**, desde a criação do pedido até a entrega, passando por **gestão financeira, vendas e controle de estoque**. O foco é **otimizar processos diários, reduzir erros humanos e fornecer dados confiáveis para tomada de decisão**.

---

## Divisão do Sistema

### App Mobile
Principal ferramenta para criação e gestão de pedidos (~90% das vendas), utilizado pelos garçons.  
Funcionalidades:
- Consulta de produtos
- Criação de pedidos
- Edição de pedidos

### Software Desktop
Coração do sistema, utilizado para a **gestão completa do quiosque**.

#### Venda
- Cobrança dos pedidos
- Venda direta (cliente compra sem iniciar pedido)

#### Estoque
- Cadastro de produtos
- Controle da disponibilidade

#### Financeiro
- Relatórios de vendas
- Cadastro de notas fiscais
- Controle de fornecedores

---

## Tecnologias Utilizadas
- **App Mobile**: React Native  
- **Software Desktop**: React (UI) + Tauri (acesso a hardware e backend)  
- **Backend**: .NET  
- **Arquitetura**: DDD + Clean Architecture

---

## Como Executar
1. Instalar dependências do app mobile (`npm install`)  
2. Executar app mobile (`npm run start`)  
3. Instalar dependências do desktop (`npm install`)  
4. Executar software desktop (`npm run tauri dev`)  
5. Backend .NET deve estar rodando para suportar APIs e integração

---

## Conclusão
Este projeto serve como base para **pequenos quiosques ou estabelecimentos que desejam digitalizar pedidos, vendas e controle de estoque**.  
O sistema aplica boas práticas de **DDD, Clean Architecture e UX focado no usuário**, garantindo **manutenção, escalabilidade e confiabilidade**.
