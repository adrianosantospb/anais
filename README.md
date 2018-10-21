# Sistema de Apoio à Decisão Médica Baseado em Anaís

O Sistema de Apoio à Decisão Médica Baseado em Anaís é um sistema de apoio a decisão médica baseado em busca por evidência e conhecimento coletivo que foi desenvolvido com base no modelo ANAIS, proposto como tese de doutorado do Doutor Adriano Araújo Santos.

## Versão
1.0

## Tech

No processo de desenvolvimento do Sistema de Apoio à Decisão Médica Baseado em Anaís foram utilizadas as seguintes tecnologias:

* [.NET Framework 4.5.1](https://www.microsoft.com/net) - Rica biblioteca da Microsoft para desenvolvimento de aplicações
* [ASP.NET MVC 4](http://www.asp.net/mvc/mvc4) - Framework MVC que roda em cima do .NET Framework
* [Entity Framework 4](http://www.asp.net/entity-framework) - Camada de abstração ORM
* [Microsoft SQL Server 2008](https://www.microsoft.com/en-us/server-cloud/products/sql-server/) - Banco de dados
* [Apache Solr 5.1.0](http://lucene.apache.org/solr/) - Motor de indexação de documentos busca textual em cima do Lucene 
* [SolrNet](https://github.com/mausch/SolrNet) - Biblioteca para uso do Solr através de código .NET
* [GoldenTrack 2009 2.1.4](http://lightinfocon.com.br/Golden/Goldentrack) - Sistema de workflow de processos
* [GoldenAccess 1.2.4.0](http://lightinfocon.com.br/Golden/Goldentrack) - Sistema de autenticação e autorização de usuários
* [PubMed-API](https://github.com/RichardBosworth/PubMed-API) - Biblioteca para acesso à API do PubMed usando .NET *(**versão modificada**)*
* [NuGet](https://www.nuget.org/) - Mecanismo de resolução de dependências de projeto
* [Twitter Bootstrap](http://getbootstrap.com/) - Framework de UI
* [jQuery](https://jquery.com/) - duh

## Versões
A maioria das dependências é automaticamente gerenciada pelo NuGet (ou seja, ao compilar o projeto, o NuGet cuidará de baixar, configurar e instalar as versões corretas das bibliotecas). As dependências acima que contém uma versão especificada são as únicas que não são gerenciadas pelo NuGet.

## Instalação e configuração
###Passos gerais
1. Instalar .NET Framework, ASP.NET MVC 4, Microsoft SQL Server
2. Instalar e configurar o GoldenAccess
3. Instalar e configurar o GoldenTrack
4. Baixar o código do repositório e realizar o build para instalação de dependências
5. Instalar e configurar o Solr
6. Rodar o Solr
7. Rodar o sistema

####Versão curta:

O diretório /resources/solr contém um *core* a ser instalado no Solr.

####Passo a passo:

1. Instale o Solr na sua máquina. A versão utilizada como referência é a 5.1.0
2. Copie o diretório /resources/solr do repositório sobre o diretório de instalação do Solr. Este processo irá apenas acrescentar o core diagnostico_web no local apropriado dos diretórios do Solr.
3. Execute o Solr (no Windows: /path/to/Solr/bin/cmd.exe start).
4. Acesse http://localhost:8983/solr/#/diagnostico_web e verifique se o core está listado na opcão Core Admin (o processo de *core auto-discovery* deve ter encontrado o core do sistema). Caso ele não esteja carregado, selecione o botão Load.

### Autor

Sistema idealizado pelo MSc. Adriano Araújo Santos para sua tese de doutorado.

* SANTOS, A. A. A conceptual framework for helping in decision-making mitigating uncertainty and risks faced by specialist physicians in the analysis of rare clinical cases. In: HEALTHCON, 2014, Orlando.

Software desenvolvido por Lucas Azevedo e Adriano Santos.

### Licença

Necessita de permissão do proprietário para uso do produto desenvolvido. 