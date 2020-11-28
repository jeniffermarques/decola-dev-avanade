## O que são Serviços Web?



- Serviços Web ou Web Services são soluções para aplicações se comunicarem independente de linguagem, softwares e hardwares utilizados.

- Inicialmente Serviços Web foram criados para troca de mensagens utilizando a linguagem XML (Extensible Markup Language) sobre o protocolo HTTP sendo identificado por URI (Uniform Resource Identifier).

- Podemos dizer que Serviços Web são API's que se comunicam por meio de redes sobre o protocolo HTTP.

  

### Vantagens de usar Web Service

- Linguagem comum
- Interação
- Reutilização de implementação
- Segurança
- Custos



### Principais Tecnologias

- SOAP
- REST
- XML
- JSON



### SOAP

- SOAP - Simple Object Acess Protocol
- É um protocolo baseado em XML para acessar serviços web principalmente por HTTP.
- Pode-se dizer que SOAP é uma definição de como serviços web se comunicam.
- Foi desenvolvido para facilitar integrações entre aplicações.



### Vantagens 

- Permite integrações entre aplicações, independente de linguagem, pois usa como linguagem como o XML.
- É independente de plataforma e software.
- Meio de transporte genérico, ou seja, pode ser usado por outros protocolos além do HTTP.



### Estrutura SOAP

- O "SOAP" Message possui uma estrutura única que deve sempre ser seguida 

  

  - **SOAP Envelope**
    - SOAP Envelope é o primeiro elemento do documento e é usado para encapsular toda a mensagem SOAP
  - SOAP Header
    - SOAP Header é o elemento onde possui informações de atributos e metadados da requisição.
  - SOAP Body
    - SOAP Body é o elemento que contém os detalhes da mensagem. 



### XML

- XML - Extensibble Markup Language
- É uma linguagem de marcação criada na década de 90 pela W3C
- Facilita a separação de conteúdo
- Não tem limitação de criação de tags
- Linguagem comum para integrações entre aplicações.



### WSDL

- WSDL - We Swevices Description Language.
- Usado para descrever Web Services, funciona como um contrato do serviço.
- A descrição é feito em um documento XML, onde é descrito o serviço, especificalçies de acesso, operações e métodos.

### XSD

- XSD - XML Schema Definition
- É um schema no formato XML usado para definir a estrutura de dados que será validada no XML
- O XSD funciona como uma documentação de como deve ser montado o SOAP Message (XML) que será enviado através de Web Service.



### 