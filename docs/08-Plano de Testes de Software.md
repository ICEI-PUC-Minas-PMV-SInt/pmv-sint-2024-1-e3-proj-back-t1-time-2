# Plano de Testes do Back-end

### 1- Introdução

**Objetivo**

O objetivo deste plano de testes é garantir a qualidade e a funcionalidade do back-end do Shape App. O back-end é responsável por fornecer listas de exercícios personalizadas, gerenciar e registrar o progresso dos usuários. 

**Escopo**

O escopo deste plano de testes inclui testes unitários, testes de integração, testes de carga e desempenho, e testes de segurança das funcionalidades do back-end do Shape App. 

### 2- Objetivos do Teste

- Verificar a corretude das funcionalidades do back-end. 

- Garantir a integração adequada entre os diferentes módulos do back-end. 

- Avaliar a capacidade do sistema de lidar com cargas elevadas e manter um desempenho aceitável. 

- Testar a segurança do back-end para proteger os dados dos usuários. 

### 3- Escopo do Teste

**Funcionalidades Incluídas:**
- Gerenciamento de perfil do usuário. 
- Geração de listas de exercícios personalizadas. 
- Registro e acompanhamento de progresso do usuário.

### 4- Abordagem de Teste 

- **Testes Unitários**: Verificar a corretude das unidades individuais de código (funções, métodos, classes). 
- **Testes de Integração**: Testar a integração entre diferentes módulos do sistema. 
- **Testes de Carga e Desempenho**: Avaliar o desempenho do sistema sob diferentes condições de cargas. 
- **Testes de Segurança**: Verificar a proteção contra vulnerabilidades comuns.  
- Verificação da conformidade com os padrões de segurança e regulamentações aplicáveis. 

### 5- Ambiente de Teste 

- **Hardware**: Servidores de teste com configurações similares ao ambiente de produção. 
Para realizar os testes, utilizaremos as seguintes ferramentas e tecnologias: 
- **Postman**: Faremos uso do Postman para automatizar os testes de API e verificar a integração entre os diferentes serviços do backend. 
- **JMeter**: Utilizaremos o Apache JMeter para realizar testes de carga e avaliar o desempenho do sistema sob diferentes condições de carga. 

### 6- Critérios de Entrada e Saída

- **Critérios de Entrada**: 
  - Código back-end completo e revisado.
  - Ambiente de teste configurado e disponível. 

- **Critérios de Saída**: 
  - Todos os casos de teste executados com sucesso ou documentados. 
  - Relatório de bugs gerado e analisado.  
  - Feedback dos desenvolvedores coletado e avaliado. 

### 7- Entregas de Teste

- Relatórios de bugs. 
- Métricas de desempenho. 
- Feedback dos desenvolvedores. 
- Relatório final de teste. 

### 8- Recursos e Cronograma 

- **Equipe:** 3 desenvolvedores de testes, 1 líder de teste. 
- **Cronograma:** 3 semanas de testes. 

### 9- Riscos e Mitigações  

- **Riscos:** Atrasos devido a bugs críticos. 
- **Mitigações:** Realizar testes de regressão antecipados e planejar tempo extra no cronograma para correção de bugs. 

### Roteiro de Testes de Funcionalidades do Back-End  

#### Caso de teste 01 
- **1. Permitir que os usuários se cadastrem na aplicação**
  - **Objetivo**: Garantir o registro bem-sucedido de um novo usuário. 
  - **Localização/Passos**:  
  - **Tela** Cadastro de usuário>Tela inicial>Tela Perfil 
  - **Resultado Esperado**: Cadastro bem-sucedido e configuração de seu perfil inicial sem problemas. 

- **2. Permitir que os usuários atualizem seus perfis**
  - **Objetivo**: Testar a criação, atualização e exclusão de perfis de usuário. 
  - **Localização/Passos**: 
  - **Tela** Perfil > Atualizar perfil> Visualizar perfil> Excluir perfil
  - **Resultado Esperado:** Operações de criação, atualização e exclusão realizadas com sucesso. 

#### Caso de teste 02
- **3. Permitir que os usuários personalizem suas próprias rotinas de treinamentos**
  - **Objetivo**: Verificar a integração entre o módulo de perfil do usuário e o módulo de geração de exercícios. 
  - **Localização/Passos**: 
  - **Tela** Perfil com objetivo definido> Tela Lista de Exercícios> Verificar se a lista é adequada ao perfil criado 
  - **Resultado Esperado:** Lista de exercícios gerada corretamente de acordo com o perfil do usuário. 

#### Teste de Carga e Desempenho
- **4. A aplicação deve ser responsiva e responder às ações do usuário em no máximo 2s**
  - **Objetivo**: Avaliar o desempenho do sistema sob diferentes cargas. 
  - **Localização/Passos**: 
  - Navegação das telas> Monitorar tempo de resposta e uso de recursos
- **Resultado Esperado:** O sistema deve manter um desempenho aceitável (tempo de resposta inferior a 2 segundos)
- **A aplicação deve ser capaz de lidar com um aumento no número de usuários e no volume de dados sem comprometer o desempenho**
  - **Objetivo:** Avaliar a capacidade do sistema de lidar com picos de tráfego. 
  - **Localização/Passos:** 
  - Simular aumento súbito de tráfego> Monitorar estabilidade e tempo de resposta. 
  - **Resultado Esperado:** O sistema deve permanecer estável e responder adequadamente sob picos de tráfego.  

#### Teste de Segurança e Privacidade 
- **5. A aplicação deve estar em conformidade com os regulamentos de privacidade de dados, com a LGPD**
  - **Objetivo:** Estar em conformidade com a LGPD durante o armazenamento de dados do usuário. 
  - **Localização/Passos:** 
  - Dados fornecidos durante o registro> Armazenamento seguro em conformidade com as diretrizes LGPD. 
  - **Resultado Esperado:** Dados armazenados com segurança. 
 
## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
