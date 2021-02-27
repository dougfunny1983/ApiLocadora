Essa solu��o feita totalmente feita em DDD/Onion � uma API, documentada pelo Swagger, com a camada de persist�ncia de dados no banco n�o relacional Mongo DB com alguns designer patterns.
**Arquitetura:
- O designer arquitetural que eu escolhi foi o Onion. Trata-se de uma arquitetura que segue os princ�pios SOLID:
S.O.L.I.D stands for:
S - Single-responsiblity principle
O - Open-closed principle
L - Liskov substitution principle
I - Interface segregation principle
D - Dependency Inversion Principle), 
Al�m disso, tem como base o padr�o DDD. Al�m das camadas tradicionais que seguem algumas arquiteturas, ele tem a camada que pode conversar com outras camadas, tornando assim flex�vel. Para essa camada, usei um conceito chamado Invers�o de controle (uso da biblioteca IOC), que permite que o controle das instancias dos objetos sejam gerenciados automaticamente, sem precisar que eu instancie manualmente. Al�m disso, foi feito a Inje��o e Invers�o de depend�ncia, para evitar o auto acoplamento comum quando damos mais de uma responsabilidade para uma classe, principalmente quando essa classe erroneamente instancia uma outra classe.
Onion�s
- Aqui vou listar as camadas e explicar uma abstra��o de cada uma:
1.	
**MongoDB
- Como banco de dados, foi escolhido o MongoDB. Ele foi Conterinizado com apoio do Docker, deployado na cloud do Azure, e gerenciado com o Atlas. Foi colocado em 3 pod, para a testar a redund�ncia e ver como que configura o Atlas para isso, mas infelizmente n�o consigo configurar a mem�ria e nem a millicore para estopurar a memoria com um teste de carga para ver ele startando as outras pod�s, pois � uma conta demo.
**Designer Patterns
-Foi usado em todo o projeto o designer patterns Interfaces, com apoio do Adapter, do Factory e do Abstract. 
**Deploy
-A solu��o foi Conterinizado com apoio do Docker, deployada no Cloud do Google e gerenciada pelo Kubernetes(K8S) em uma �nica pod.

Abaixo est� relacionado as fontes de pesquisa para estudos futuros:
1.	Api: A camada de apresenta��o que � respons�vel por abranger tudo o que diz respeito as intera��es com o cliente.
2.	Aplica��o: A camada de aplica��o que � respons�vel por realizar a(s) aplica��o(s) se comunicar diretamente com o Dom�nio.
3.	Dom�nio: A camada de dom�nio que � respons�vel por ter um uma modelagem s�lida e aqui que a m�gica do DDD(Domain Drive Design) acontece.
4.	Infraestrutura: A camada de infraestrutura � respons�vel por manter os dados e persistir no banco dados.
5.	CrossCutting: A camada CrossCutting pode realizar a invers�o de controle e inje��o de depend�ncias. � aqui que faz a m�gica dos instanciamentos dos objetos.

*DDD: 
�	https://www.youtube.com/watch?v=eUf5rhBGLAk
�	https://imasters.com.br/apis-microsservicos/domain-driven-design-ddd-em-uma-arquitetura-microsservicos
�	https://www.eduardopires.net.br/2016/08/ddd-nao-e-arquitetura-em-camadas/
�	https://www.youtube.com/watch?v=plS-rf2UIPI
�	https://djesusnet.medium.com/

Onion�s:
�	portal da arquitetura (link por autentica��o Localiza) https://aws-dev.localiza.dev/portal/index.html
�	http://www.macoratti.net/20/05/net_onion1.htm#:~:text=A%20Onion%20Architecture%20usa%20o,de%20tr%C3%AAs%20e%20n%2Dcamadas.&text=A%20camada%20de%20dom%C3%ADnio%20reside,objetos%20de%20dom%C3%ADnio%20nesse%20n%C3%BAcleo.
�	https://jeffreypalermo.com/2008/07/the-onion-architecture-part-1/
K8S:
�	https://cloud.google.com/solutions/best-practices-for-operating-containers
�	https://cloud.google.com/kubernetes-engine/docs/tutorials/hello-app
�	portal da arquitetura (link por autentica��o Localiza) https://aws-dev.localiza.dev/portal/index.html
Docker:
�	https://www.docker.com/resources/what-container

MongoDB e Atlas:
�	https://docs.mongodb.com/
�	https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-5.0&tabs=visual-studio
Swagger:
�	https://swagger.io/docs/
