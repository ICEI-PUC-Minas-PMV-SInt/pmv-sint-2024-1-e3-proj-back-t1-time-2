# Plano de Testes do Backend

### Estrutura do Documento

Este plano de testes está organizado da seguinte forma:
1. Introdução
2. Objetivo
3. Escopo
4. Metodologia de Teste
5. Recursos de Teste
6. Cronograma de Teste
7. Responsabilidades
8. Riscos e Considerações
9. Casos de Teste
10. Relatório de Teste

## Introdução

Este documento descreve o plano de testes para o backend do sistema Shape, um aplicativo de treinamento físico personalizado. O objetivo deste plano é garantir que o backend do sistema atenda aos requisitos funcionais e não funcionais, bem como validar sua funcionalidade, desempenho, segurança e confiabilidade.

### Objetivo

O objetivo dos testes do backend é verificar a correta implementação das funcionalidades do sistema, garantir que o sistema esteja operando de acordo com as especificações e identificar e corrigir quaisquer problemas ou falhas que possam surgir durante o teste.

### Escopo

Os testes abrangerão todas as funcionalidades do backend do sistema Shape, incluindo o cadastro de usuários, gerenciamento de perfis, cálculo de IMC, recomendação de exercícios, personalização de rotinas de treinamento, notificações de treino, compartilhamento de progresso, bem como requisitos não funcionais como desempenho, disponibilidade, segurança, manutenibilidade e escalabilidade.


## Metodologia de Teste

### Abordagem Geral:

Para os testes do backend do sistema Shape, adotaremos as seguintes abordagens:

- **Teste de Unidade:** Cada componente do backend será testado individualmente para garantir que funcione conforme o esperado.
  
- **Teste de Integração:** Verificaremos a integração entre os diferentes componentes do backend para garantir que trabalhem em conjunto de forma eficaz.
  
- **Teste de Desempenho:** Avaliaremos o desempenho do sistema sob diferentes cargas de trabalho para garantir que ele seja escalável e responsivo.
  
- **Teste de Segurança:** Realizaremos testes de segurança para identificar e corrigir vulnerabilidades que possam comprometer a integridade dos dados do usuário.

### Ferramentas e Tecnologias:

Para realizar os testes, utilizaremos as seguintes ferramentas e tecnologias:

- **Jasmine:** Utilizaremos o framework Jasmine para escrever e executar testes unitários em JavaScript.
  
- **Postman:** Faremos uso do Postman para automatizar os testes de API e verificar a integração entre os diferentes serviços do backend.
  
- **JMeter:** Utilizaremos o Apache JMeter para realizar testes de carga e avaliar o desempenho do sistema sob diferentes condições de carga.
  
- **OWASP ZAP:** Faremos uso do OWASP ZAP para identificar e corrigir vulnerabilidades de segurança, garantindo a proteção dos dados do usuário.

Esta metodologia nos permitirá abordar de maneira abrangente os testes do backend do sistema Shape, garantindo sua qualidade, desempenho e segurança.

## Recursos de Teste

Para realizar os testes do backend do sistema Shape, os seguintes recursos serão necessários:

1. **Ambiente de Desenvolvimento:**
   - Um ambiente de desenvolvimento configurado com todas as dependências necessárias para executar o backend do sistema, incluindo banco de dados, servidores de aplicativos e serviços externos.

2. **Ferramentas de Teste:**
   - As ferramentas de teste mencionadas anteriormente, como Jasmine para testes unitários e Postman  para testes de API.
   
3. **Ambiente de Teste:**
   - Um ambiente de teste separado do ambiente de produção, onde os testes podem ser realizados sem afetar os usuários finais.
   
4. **Dados de Teste:**
   - Conjunto de dados de teste representativos para cada funcionalidade do sistema, incluindo dados de usuários, dados de exercícios, dados de treinamento, etc.
   
5. **Equipe de Teste:**
   - Uma equipe dedicada de testes composta por engenheiros de qualidade de software, desenvolvedores e especialistas em segurança, responsáveis por planejar, executar e relatar os testes.

6. **Documentação:**
   - Documentação detalhada dos requisitos do sistema, casos de teste, procedimentos de teste e resultados esperados, para garantir que os testes sejam realizados de acordo com as especificações do sistema.

7. **Tempo:**
   - Tempo suficiente para planejar, executar e revisar os testes, garantindo uma cobertura abrangente e uma análise detalhada dos resultados.

8. **Hardware e Infraestrutura:**
   - Recursos de hardware e infraestrutura adequados para suportar os testes de desempenho e escalabilidade, garantindo que o sistema possa lidar com cargas de trabalho variáveis.

# Cronograma de Teste

O cronograma de teste do backend do sistema Shape será dividido em várias fases, cada uma dedicada a um conjunto específico de testes. A seguir está o cronograma proposto:

## Fase 1: Preparação

- **Atividades:**
  - Configuração do ambiente de teste.
  - Preparação dos dados de teste.
  - Revisão dos casos de teste e documentação.
  - Treinamento da equipe de teste.

## Fase 2: Testes Unitários

- **Atividades:**
  - Desenvolvimento e execução de testes unitários para cada componente do backend.
  - Identificação e correção de falhas de lógica e funcionais.

## Fase 3: Testes de Integração

- **Atividades:**
  - Verificação da integração entre os diferentes componentes do backend.
  - Teste de interações entre os serviços e validação de dados passados entre eles.
  - Identificação e correção de problemas de integração.

## Fase 4: Testes de Desempenho

- **Atividades:**
  - Execução de testes de carga para avaliar o desempenho do sistema sob diferentes condições de carga.
  - Identificação de gargalos de desempenho e otimização do código, se necessário.

## Fase 5: Testes de Segurança

- **Atividades:**
  - Realização de testes de segurança para identificar e corrigir vulnerabilidades no sistema.
  - Verificação da conformidade com os padrões de segurança e regulamentações aplicáveis.

## Fase 6: Revisão e Relatório

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

3. **Gerente de Projeto:**
   - Responsável por coordenar e supervisionar todas as atividades de teste.
   - Deve garantir que os recursos necessários para os testes estejam disponíveis e alocados conforme necessário.
   - Realiza o acompanhamento do progresso dos testes e garante que o cronograma seja cumprido.
   - Revisa e aprova a documentação de teste, incluindo casos de teste e relatórios de teste.

4. **Equipe de Gerenciamento de Qualidade:**
   - Responsável por garantir que os padrões de qualidade sejam mantidos ao longo do processo de desenvolvimento e teste.
   - Deve revisar os casos de teste, relatórios de teste e outras documentações relacionadas para garantir sua integridade e precisão.
   - Auxilia na identificação e implementação de melhores práticas de teste e garantia de qualidade.

5. **Usuários do Sistema:**
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

6. **Comunicação:**
   - Risco: Falta de comunicação eficaz entre as equipes de desenvolvimento e teste pode resultar em lacunas na cobertura de teste ou problemas não detectados.
   - Considerações: Estabelecer canais de comunicação claros e regulares entre as equipes e manter uma documentação atualizada de requisitos, casos de teste e resultados de teste.

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

#### Caso de Teste 3: Registro com email inválido
- **Dado que** o usuário acessa a página de registro
- **Quando** ele insere um email no formato inválido no campo de email do formulário de registro
- **E** preenche os demais campos obrigatórios
- **E** clica no botão de registro
- **Então** a aplicação deve exibir uma mensagem de erro indicando que o email inserido é inválido

### Casos de Teste para RF-002: Permitir que os usuários criem e atualizem seus perfis

#### Caso de Teste 1: Atualização bem-sucedida do perfil do usuário
- **Dado que** o usuário acessa a página de perfil
- **Quando** ele edita as informações do perfil com novos dados
- **E** clica no botão de atualizar perfil
- **Então** as informações do perfil devem ser atualizadas corretamente

### Casos de Teste para RF-003: Calcular o Índice de Massa Corporal (IMC)

#### Caso de Teste 1: Cálculo correto do IMC do usuário
- **Dado que** o usuário insere sua altura e peso nos campos correspondentes
- **Quando** ele solicita o cálculo do IMC
- **Então** o sistema deve calcular o IMC corretamente e exibir o resultado ao usuário

### Casos de Teste para RF-004: Recomendar uma lista de exercícios físicos adaptada às necessidades específicas do usuário

#### Caso de Teste 1: Recomendação correta de exercícios para perda de peso
- **Dado que** o usuário seleciona a opção de "perda de peso" como objetivo
- **Quando** ele solicita a recomendação de exercícios
- **Então** a aplicação deve recomendar uma lista de exercícios apropriada para perda de peso

#### Caso de Teste 2: Recomendação correta de exercícios para ganho de massa
- **Dado que** o usuário seleciona a opção de "ganho de massa" como objetivo
- **Quando** ele solicita a recomendação de exercícios
- **Então** a aplicação deve recomendar uma lista de exercícios apropriada para ganho de massa muscular

#### Caso de Teste 3: Recomendação correta de exercícios para manter a forma
- **Dado que** o usuário seleciona a opção de "manter a forma" como objetivo
- **Quando** ele solicita a recomendação de exercícios
- **Então** a aplicação deve recomendar uma lista de exercícios apropriada para manter a forma física

### Casos de Teste para RF-005: Fornecer link de vídeos, imagens ou instruções passo a passo para demonstrar corretamente como realizar cada exercício recomendado

#### Caso de Teste 1: Disponibilidade de recursos visuais para exercícios
- **Dado que** o usuário acessa a descrição de um exercício recomendado
- **Quando** ele visualiza os detalhes do exercício
- **Então** a aplicação deve fornecer links ou recursos visuais (vídeos, imagens, instruções passo a passo) para demonstrar corretamente como realizar o exercício

### Casos de Teste para RF-006: Permitir que os usuários personalizem suas próprias rotinas de treinamento

#### Caso de Teste 1: Criação bem-sucedida de uma rotina personalizada
- **Dado que** o usuário acessa a página de criação de rotina
- **Quando** ele seleciona exercícios específicos e ajusta a intensidade de acordo com suas preferências
- **E** salva a rotina
- **Então** a aplicação deve salvar a rotina personalizada com sucesso e torná-la disponível para o usuário

### Casos de Teste para RF-007: Enviar notificações aos usuários para lembrá-los de realizar seus treinos e acompanhar seu progresso

#### Caso de Teste 1: Envio bem-sucedido de notificação de lembrete de treino
- **Dado que** é o horário programado para o treino de um usuário
- **Quando** o sistema envia uma notificação de lembrete de treino para o usuário
- **Então** o usuário deve receber a notificação corretamente em seu dispositivo

### Casos de Teste para RF-008: Permitir que os usuários compartilhem seu progresso de condicionamento físico, conquistas e experiências com amigos e seguidores em redes sociais

#### Caso de Teste 1: Compartilhamento bem-sucedido de progresso de condicionamento físico
- **Dado que** o usuário deseja compartilhar seu progresso de condicionamento físico em redes sociais
- **Quando** ele seleciona a opção de compartilhar e preenche os detalhes necessários
- **E** confirma o compartilhamento
- **Então** o progresso de condicionamento físico do usuário deve ser compartilhado com sucesso em suas redes sociais

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

### Casos de Teste para RNF-004: A aplicação deve ser acessível a usuários com deficiências visuais, auditivas ou motoras

#### Caso de Teste 1: Acessibilidade da aplicação para usuários com deficiência visual
- **Dado que** um usuário com deficiência visual acessa a aplicação utilizando um leitor de tela
- **Quando** ele navega pela aplicação e interage com os elementos da interface
- **Então** a aplicação deve ser compatível com o leitor de tela, fornecendo descrições adequadas para todos os elementos visuais

### Casos de Teste para RNF-005: A aplicação deve ser facilmente mantida e atualizada, com código limpo e modular

#### Caso de Teste 1: Manutenibilidade do código-fonte
- **Dado que** um desenvolvedor precisa realizar uma atualização na aplicação
- **Quando** ele acessa o código-fonte e identifica a parte relevante para a atualização
- **Então** o código-fonte deve ser organizado, legível e modular, facilitando a realização da atualização

### Casos de Teste para RNF-006: A aplicação deve ser capaz de lidar com um aumento no número de usuários e no volume de dados sem comprometer o desempenho

#### Caso de Teste 1: Escalabilidade da aplicação durante picos de tráfego
- **Dado que** a aplicação experimenta um aumento repentino no número de usuários
- **Quando** o tráfego na aplicação aumenta significativamente
- **Então** a aplicação deve continuar a funcionar normalmente e fornecer uma resposta rápida aos usuários, sem comprometer o desempenho




> **Links Úteis**:
> - [Teste De Usabilidade: O Que É e Como Fazer Passo a Passo (neilpatel.com)](https://neilpatel.com/br/blog/teste-de-usabilidade/)
> - [Teste de usabilidade: tudo o que você precisa saber! | by Jon Vieira | Aela.io | Medium](https://medium.com/aela/teste-de-usabilidade-o-que-voc%C3%AA-precisa-saber-39a36343d9a6/)
> - [Planejando testes de usabilidade: o que (e o que não) fazer | iMasters](https://imasters.com.br/design-ux/planejando-testes-de-usabilidade-o-que-e-o-que-nao-fazer/)
> - [Ferramentas de Testes de Usabilidade](https://www.usability.gov/how-to-and-tools/resources/templates.html)
