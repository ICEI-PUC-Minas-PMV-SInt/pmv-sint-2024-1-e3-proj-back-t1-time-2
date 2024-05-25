# Metodologia 

A metodologia de trabalho para o desenvolvimento do Shape App iniciou-se com um processo de pesquisa intensiva. Realizamos entrevistas com potenciais usuários e partes interessadas para identificar e analisar as necessidades e problemas específicos no contexto de exercícios físicos e treinamentos personalizados. Essas informações foram fundamentais para estruturar as soluções que o aplicativo deveria oferecer.

Na fase de organização e otimização do ambiente de trabalho, adotamos a metodologia SCRUM. Essa escolha foi feita por sua eficácia em gerenciar e executar trabalhos de forma ágil e dinâmica, especialmente adequada para o desenvolvimento de software. O trabalho foi dividido em pequenos ciclos de atividades, conhecidos como Sprints, permitindo-nos abordar problemas complexos de forma adaptativa e iterativa.

Para o desenvolvimento técnico da Aplicação Web, utilizamos diversas ferramentas especializadas:

1. **Controle de Versão e Hospedagem do Repositório:**
   - Git foi escolhido como nossa ferramenta de controle de versão, e utilizamos o GitHub para hospedar o repositório do projeto. 

2. **Desenvolvimento de Interfaces e Wireframes:**
   - Para o desenho e a prototipagem das interfaces do usuário, a equipe utilizou o Adobe Illustrator. O que ajudou na criação de elementos gráficos refinados.

3. **Ferramentas de Diagramação:**
   - Para a modelagem e a visualização da arquitetura do sistema, o Mermaid foi usado para criar o diagrama de classes, proporcionando uma visão clara da estrutura do nosso aplicativo.
   - Utilizamos o draw.io para elaborar o diagrama de casos de uso, facilitando a compreensão dos diferentes fluxos de interação do usuário com o aplicativo.

4. **Comunicação em Grupo:**
   - Para manter a equipe alinhada e promover uma comunicação eficiente, utilizamos o WhatsApp e o Microsoft Teams. Essas ferramentas permitiram discussões em tempo real, reuniões remotas e atualizações rápidas sobre o progresso do projeto.

Essa metodologia adaptada permitiu que nossa equipe trabalhasse de maneira eficaz e sincronizada, focando na criação de um aplicativo de exercícios personalizados que atende às necessidades específicas de nossos usuários.


## Relação de Ambientes de Trabalho

<table>
 <thead>
  <tr>
   <th>Ambiente</th>
   <th>Plataforma</th>
   <th>Link de Acesso</th>
 </thead>
 <tbody>
  <tr>
   <td>Repositório de Código Fonte</td>
   <td>GitHub</td>
   <td>https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2024-1-e3-proj-back-t1-time-2</td>
  </tr>
  <tr>
   <td>Documentos do projeto</td>
   <td>GitHub</td>
   <td>https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2024-1-e3-proj-back-t1-time-2/tree/main/docs</td>
  </tr>
  <tr>
   <td>Gerenciamento do projeto</td>
   <td>GitHub Projects</td>
   <td>https://github.com/orgs/ICEI-PUC-Minas-PMV-SInt/projects/23</td>
  </tr>
 </tbody>
 </table>

## Controle de Versão do Shape App

Para o desenvolvimento do Shape App, adotamos o [Git](https://git-scm.com/) como nossa ferramenta de controle de versão, com o [GitHub](https://github.com) servindo como a plataforma para hospedagem do repositório. Essa abordagem oferece Confiabilidade e flexibilidade para o gerenciamento do nosso código-fonte.

### Convenções de Branches

Adotamos uma estrutura clara de branches para facilitar o desenvolvimento e manutenção do software:

- `main`: Contém a versão estável do aplicativo, já testada e pronta para produção.
- `unstable`: Usada para versões que passaram por testes, mas ainda podem conter instabilidades.
- `testing`: Destinada à realização de testes intensivos de novas funcionalidades.
- `dev`: A branch de desenvolvimento ativo, onde as novas features são inicialmente implementadas.

### Gerenciamento de Issues

Implementamos uma sistemática eficiente para o gerenciamento de issues, categorizando-as com as seguintes etiquetas:

- `documentation`: Para demandas relacionadas à melhoria ou adição de documentação.
- `bug`: Identifica problemas nas funcionalidades existentes.
- `enhancement`: Quando uma funcionalidade atual necessita de aprimoramento.
- `feature`: Para o desenvolvimento de novas funcionalidades.

### Fluxo de Trabalho e Colaboração

- Cada desenvolvedor trabalha em uma branch dedicada, minimizando interferências no código principal.
- A branch `main` é acessível a toda a equipe, com os desenvolvedores mantendo versões locais nas suas respectivas branches.
- Atualizações são submetidas via commits para o repositório central. Após a conclusão e revisão do trabalho em uma branch, as mudanças são integradas ao projeto principal por meio de pull requests e merges.
- Tags são usadas para marcar diferentes estágios de desenvolvimento de recursos.

Segue uma ilustração que exemplifica nosso fluxo de trabalho de ramificação por recursos:

![Metodologia](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2024-1-e3-proj-back-t1-time-2/blob/main/docs/img/fluxo_ramificacao.svg)  
_Fluxo de trabalho por ramificação de recursos_

Fonte: [Atlassian - Comparing Workflows](https://www.atlassian.com/br/git/tutorials/comparing-workflows/feature-branch-workflow)

## Gerenciamento de Projeto

### Divisão de Papéis

A equipe utiliza metodologias ágeis, tendo escolhido o Scrum como base para definição do processo de desenvolvimento. 

A equipe está organizada da seguinte maneira:
- Scrum Master: Danilo Henrique Pupin de Carvalho;
- Product Owner: Isabella Cristina da Silva Prado;
- Equipe de Desenvolvimento: Alicia Ribeiro Andrade da Silva, Cheyenne Natane Fontes de Souza, Elisabete Romana dos Santos de Paula, Murilo Silva Rezende;


### Processo de Desenvolvimento 

No desenvolvimento do Shape App, serão organizados Sprints focados na implementação e refinamento de funcionalidades essenciais, tais como:

- Cadastro de usuários;
- Perfil do usuário e personalização;
- Monitoramento e atualização de treinos;
- Cálculo do Índice de Massa Corporal (IMC);
- Registro da frequência de exercícios na academia;
- Compartilhamento de conquistas e progresso do usuário.

Reuniões semanais com a equipe de desenvolvedores são agendadas para garantir uma comunicação efetiva e o alinhamento das atividades de desenvolvimento com os objetivos do projeto.

A gestão dos backlogs do produto e o acompanhamento das entregas de cada Sprint serão realizados por meio dos quadros de projeto do GitHub, utilizando o modelo Kanban automatizado. Este modelo apoia a organização dos itens de backlog durante cada Sprint e facilita a distribuição das tarefas entre os membros da equipe.

Abaixo está um exemplo do nosso quadro Kanban no GitHub, demonstrando a distribuição das tarefas pelas diferentes etapas do desenvolvimento: 'A Fazer', 'Em Progresso', 'Em Revisão', e 'Concluído'.

![Metodologia](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2024-1-e3-proj-back-t1-time-2/blob/main/docs/img/quadro_projeto_github.png)
 

### Ferramentas de Desenvolvimento do Shape App

A eficiência no desenvolvimento da Aplicação Web Shape App é alcançada através do uso de ferramentas especializadas para cada aspecto técnico do projeto:

1. **Controle de Versão e Hospedagem do Repositório:**
   - O **Git** foi adotado como a ferramenta de controle de versão devido à sua eficiência e robustez. O repositório do projeto é hospedado no **GitHub**, facilitando o acesso, colaboração e gerenciamento do código fonte entre os membros da equipe.

2. **Desenvolvimento de Interfaces e Wireframes:**
   - O design das interfaces do usuário é criado utilizando o **Adobe Illustrator**, uma ferramenta poderosa que permite a criação de elementos gráficos detalhados e wireframes de alta fidelidade.

3. **Ferramentas de Diagramação:**
   - A estrutura e a arquitetura do aplicativo são visualizadas através de diagramas de classes criados com o **Mermaid**, proporcionando clareza e entendimento da relação entre os componentes do sistema.
   - Para os diagramas de casos de uso, a ferramenta escolhida foi o **draw.io**, que oferece flexibilidade na representação dos fluxos de interação dos usuários com as funcionalidades do aplicativo.

4. **Comunicação em Grupo:**
   - A comunicação contínua e eficaz é mantida com o uso do **WhatsApp** para troca de informações rápidas e resolução de dúvidas. Para reuniões de alinhamento e discussões mais aprofundadas, utilizamos o **Microsoft Teams**, que também suporta chamadas de vídeo e compartilhamento de tela para colaboração em tempo real.

# Avaliação do Framework ASP.NET Core MVC

O ASP.NET Core MVC é uma estrutura de software livre, de multiplataforma e alto desempenho para criação de aplicativos Web e APIs conectados à internet e baseados em nuvens que oferece várias vantagens significativas para o seu uso. Dentre elas estão:

- **Injeção de dependências**: Injeção de dependência nativa mantêm o baixo acoplamento entre os módulos que torna o código mais organizado, testável e de fácil manutenção.
- **Separação de responsabilidade**: O padrão MVC divide a aplicação em Model, View e Controller, isso facilita a manutenção, o teste e a escalabilidade do código. Também acelera o processo de desenvolvimento, uma vez que permite que o desenvolvedor trabalhe com Front-end e Back-end em paralelo.
- **Flexibilidade**: O framework oferece maior controle sobre o fluxo de dados e a lógica da aplicação, sendo mais flexível para criar aplicativos da WEB simples ou complexos, conforme a necessidade do desenvolvedor.
- **Integração com bibliotecas JavaScript**: permite a integração com bibliotecas JavaScript para melhorar a experiência do usuário.
- **HTML gerado separadamente**: O HTML enviado para o navegador é gerado por um mecanismo separado e substituível facilitando a personalização e a otimização da renderização da página.
  
 Embora o ASP.NET Core MVC seja uma estrutura poderosa, está framework apresenta algumas desvantagens como:

- **Configuração do Controlador**:  a configuração dos controladores é feita nas rotas raiz, podendo tornar o processo frágil e menos eficiente em comparação com outras estruturas MVC, já que o roteamento baseado em texto pode causar problemas e afetar o desempenho.
- **Dificuldades de Compatibilidade e Integração com Bibliotecas JavaScript**: o framework pode ter dificuldades ao integrar com bibliotecas JavaScript, pois a compatibilidade e a integração podem ser mais complexas em comparação com outras estruturas.
- **Aprendizado e Recursos em inglês**: por ser uma estrutura relativamente nova muitos recursos de aprendizado estão disponíveis principalmente em inglês, isso pode ser um desafio para desenvolvedores que não possuem o domínio do idioma.
- **Funcionalidades Limitadas em Comparação com Serviços Web Completos**: por não oferecer todas as funcionalidades de um serviço da web completo, como o IIS, alguns recursos, como compartilhamento de porta, configuração fácil de SSL e reescrita de URL, não estão disponíveis nativamente.

Logo, o ASP.NET Core MVC é uma estrutura leve, modular e altamente testável, que oferece uma maneira baseada em padrões para criar aplicativos da web e APIs com uma separação clara de responsabilidades, todavia apresenta algumas desvantagens que precisam ser consideradas ao escolher a melhor abordagem para um projeto.


