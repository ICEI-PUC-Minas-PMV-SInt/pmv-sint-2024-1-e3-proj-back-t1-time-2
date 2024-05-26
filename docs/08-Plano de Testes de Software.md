# Plano de Testes do Backend

### Estrutura do Documento

Este plano de testes está organizado da seguinte forma:
1. Introdução
2. Objetivo
3. Metodologia de Teste
4. Cronograma de Teste
5. Responsabilidades
6. Riscos e Considerações
7. Casos de Teste

## Introdução

Este documento descreve o plano de testes para o backend do sistema Shape, um aplicativo de treinamento físico personalizado. O objetivo deste plano é garantir que o backend do sistema atenda aos requisitos funcionais e não funcionais, bem como validar sua funcionalidade, desempenho, segurança e confiabilidade.

### Objetivo

O objetivo dos testes do backend é verificar a correta implementação das funcionalidades do sistema, garantir que o sistema esteja operando de acordo com as especificações e identificar e corrigir quaisquer problemas ou falhas que possam surgir durante o teste.

## Metodologia de Teste

### Abordagem Geral:

Para os testes do backend do sistema Shape, adotaremos as seguintes abordagens:
  
- **Teste de Desempenho:** Avaliaremos o desempenho do sistema sob diferentes cargas de trabalho para garantir que ele seja escalável e responsivo.
  
- **Teste de Segurança:** Realizaremos testes de segurança para identificar e corrigir vulnerabilidades que possam comprometer a integridade dos dados do usuário.

### Ferramentas e Tecnologias:

Para realizar os testes, utilizaremos as seguintes ferramentas e tecnologias:

- **Postman:** Faremos uso do Postman para automatizar os testes de API e verificar a integração entre os diferentes serviços do backend.
  
- **JMeter:** Utilizaremos o Apache JMeter para realizar testes de carga e avaliar o desempenho do sistema sob diferentes condições de carga.

Esta metodologia nos permitirá abordar de maneira abrangente os testes do backend do sistema Shape, garantindo sua qualidade, desempenho e segurança.

# Cronograma de Teste

O cronograma de teste do backend do sistema Shape será dividido em várias fases, cada uma dedicada a um conjunto específico de testes. A seguir está o cronograma proposto:

## Fase 1: Preparação

- **Atividades:**
  - Configuração do ambiente de teste.
  - Preparação dos dados de teste.
  - Revisão dos casos de teste e documentação.
  - Treinamento da equipe de teste.

## Fase 2: Testes de Desempenho

- **Atividades:**
  - Execução de testes de carga para avaliar o desempenho do sistema sob diferentes condições de carga.
  - Identificação de gargalos de desempenho e otimização do código, se necessário.

## Fase 3: Testes de Segurança

- **Atividades:**
  - Realização de testes de segurança para identificar e corrigir vulnerabilidades no sistema.
  - Verificação da conformidade com os padrões de segurança e regulamentações aplicáveis.

## Fase 4: Revisão e Relatório

- **Atividades:**
  - Revisão dos resultados dos testes e documentação.
  - Preparação do relatório final de testes, incluindo resumo dos resultados, problemas encontrados e recomendações para melhorias.

## Responsabilidades

As responsabilidades no plano de testes do backend do sistema Shape são distribuídas da seguinte forma:

1. **Equipe de Desenvolvimento:**
   - Responsável por desenvolver o código do backend de acordo com os requisitos especificados.
   - Deve garantir que o código seja testável e fornecer suporte à equipe de teste durante os testes.

2. **Equipe de Teste:**
   - Responsável por planejar, executar e relatar os testes do backend.
   - Deve desenvolver casos de teste abrangentes que abordem todos os requisitos funcionais e não funcionais.
   - Realiza testes de unidade, integração, desempenho e segurança para garantir a qualidade do sistema.
   - Identifica e documenta problemas encontrados durante os testes e colabora com a equipe de desenvolvimento para resolvê-los.

3. **Usuários do Sistema:**
   - Responsáveis por fornecer feedback sobre a usabilidade e a funcionalidade do sistema durante os testes de aceitação.
   - Deve testar o sistema em um ambiente de produção simulado e relatar quaisquer problemas ou preocupações à equipe de desenvolvimento e teste.

# Riscos e Considerações

Ao planejar os testes do backend do sistema Shape, é importante considerar os seguintes riscos e considerações:

1. **Dependência de Terceiros:**
   - Risco: Dependência de serviços externos ou APIs de terceiros pode resultar em falhas de integração ou disponibilidade.
   - Considerações: Testar a integração com serviços de terceiros em ambientes controlados e garantir um plano de contingência para lidar com falhas ou interrupções.

2. **Escalabilidade:**
   - Risco: O sistema pode não escalar conforme o esperado para lidar com um aumento repentino no número de usuários.
   - Considerações: Realizar testes de carga para avaliar o desempenho do sistema sob diferentes volumes de tráfego e garantir que ele seja escalável conforme necessário.

3. **Segurança:**
   - Risco: Vulnerabilidades de segurança no código ou nas configurações do servidor podem comprometer a integridade dos dados do usuário.
   - Considerações: Realizar testes de segurança para identificar e corrigir vulnerabilidades, além de garantir a conformidade com regulamentos de proteção de dados, como LGPD.

4. **Compatibilidade de Plataforma:**
   - Risco: O sistema pode não funcionar corretamente em todas as plataformas ou dispositivos, levando a uma experiência do usuário inconsistente.
   - Considerações: Testar o sistema em diferentes plataformas, navegadores e dispositivos para garantir compatibilidade e consistência.

5. **Manutenibilidade:**
   - Risco: Falta de manutenibilidade do código pode dificultar a identificação e correção de problemas no futuro.
   - Considerações: Escrever testes unitários abrangentes e seguir boas práticas de desenvolvimento de software para garantir a manutenibilidade do código.

# Casos de Testes

### Casos de Teste para RF-001: Permitir que os usuários se cadastrem na aplicação

#### Caso de Teste 1: Registro bem-sucedido de um novo usuário
- **Dado que** o usuário acessa a página de registro
- **Quando** ele preenche todos os campos obrigatórios do formulário de registro com informações válidas
- **E** clica no botão de registro
- **Então** ele deve ser redirecionado para a página inicial

#### Caso de Teste 2: Registro com campos em branco
- **Dado que** o usuário acessa a página de registro
- **Quando** ele deixa um ou mais campos obrigatórios em branco no formulário de registro
- **E** clica no botão de registro
- **Então** a aplicação deve exibir uma mensagem de erro indicando que os campos obrigatórios não podem estar em branco

### Casos de Teste para RF-002: Permitir que os usuários atualizem seus perfis

#### Caso de Teste 1: Atualização bem-sucedida do perfil do usuário
- **Dado que** o usuário acessa a página de perfil
- **Quando** ele edita as informações do perfil com novos dados
- **E** clica no botão de atualizar perfil
- **Então** as informações do perfil devem ser atualizadas corretamente

### Casos de Teste para RNF-001: A aplicação deve ser responsiva e responder às ações do usuário em no máximo 2s

#### Caso de Teste 1: Responsividade da aplicação durante a navegação
- **Dado que** o usuário acessa diferentes páginas da aplicação
- **Quando** ele realiza ações como clicar em botões, preencher formulários ou navegar entre telas
- **Então** a aplicação deve responder às ações do usuário em no máximo 2 segundos

### Casos de Teste para RNF-002: A aplicação deve estar disponível online 99% do tempo

#### Caso de Teste 1: Disponibilidade da aplicação durante o horário de pico
- **Dado que** é um horário de pico de acesso à aplicação
- **Quando** múltiplos usuários tentam acessar a aplicação simultaneamente
- **Então** a aplicação deve estar disponível online para acesso de pelo menos 99% dos usuários durante esse período

### Casos de Teste para RNF-003: A aplicação deve estar em conformidade com os regulamentos de privacidade de dados, como a LGPD

#### Caso de Teste 1: Conformidade com a LGPD durante o armazenamento de dados do usuário
- **Dado que** o usuário fornece informações pessoais durante o registro na aplicação
- **Quando** essas informações são armazenadas no banco de dados da aplicação
- **Então** a aplicação deve garantir que o armazenamento e uso desses dados estejam em conformidade com as diretrizes da LGPD

### Casos de Teste para RNF-004: A aplicação deve ser facilmente mantida e atualizada, com código limpo e modular

#### Caso de Teste 1: Manutenibilidade do código-fonte
- **Dado que** um desenvolvedor precisa realizar uma atualização na aplicação
- **Quando** ele acessa o código-fonte e identifica a parte relevante para a atualização
- **Então** o código-fonte deve ser organizado, legível e modular, facilitando a realização da atualização

### Casos de Teste para RNF-005: A aplicação deve ser capaz de lidar com um aumento no número de usuários e no volume de dados sem comprometer o desempenho

#### Caso de Teste 1: Escalabilidade da aplicação durante picos de tráfego
- **Dado que** a aplicação experimenta um aumento repentino no número de usuários
- **Quando** o tráfego na aplicação aumenta significativamente
- **Então** a aplicação deve continuar a funcionar normalmente e fornecer uma resposta rápida aos usuários, sem comprometer o desempenho
 
## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
