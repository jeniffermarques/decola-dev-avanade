# Internet das coisas

## Por que conectar as coisas?

- Embutir sensores em objetos do dia-a-dia
- Coletar dados do sensores
- Usar o dado para tomar decisão

## Computação Ubíqua

>  A computação ubíqua é a terceira onda da computação que está apenas começando. Primeiro tivemos os mainframes compartilhados por vários pessoas. Estamos na era da computação pessoal com pessoas e máquinas estranhando umas as outras. A seguir vem a computação ubíqua a era da tecnologia "calma", quando a tecnoligia recua para o pano de fundo de nossas vidas.
>
> As tecnologias mais importantes são aquelas que desaparecem. Elas se integram à vida do dia a dia ao nosso cotidiano, até serem idistinguíveis dele.



## Desafios da Internet das Coisas

1. Privacidade e Segurança
2. Quantidade exponencial de dispositivos conectadas na rede
3. Ser capaz de processar e armazenar uma enorme quantidade de informações
4. Gerar valor a partir dos dados coletados



## Arquitetura da Internet das coisas



Considere esses atributos na escolha:

- Baixo consumo de energia
- Rede de dados limitidado
- Resiliência
- Segurança
- Customização
- Baixo Custo



## Exemplos de plataformas para utilizar

### Arduino 

- Plataforma de Prototipagem 

- Com entradas / saídas

- Desenvolvedor escreve em C/C++

- Interface serial ou USB

- Shieds

  

### Embarcados

**MCUs**

- Microcontrolador de chip único
- Sistema operacional real time
- Embarcado
- Uso industrial, médico, militar, transporte



### Minicomputadores 

**Raspberry Pi**

- Computador completo
- Hardware integrado em uma única placa
- Roda SO Linux ou Windows
- Uso doméstico e comercial



## Protocolo MQTT 

- Base na pilha do TCP/IP
- Protocolo de mensagem assíncrona (M2M)
- Criado pela IMB para conectar sensores de pipelines fr petróleo a satélites
- Padrão OASIS suportado pelas linguagens de programação mais populares



## Níveis de qualidade de comunicação 

### QoS 0

- Nível mínimo de menor esforço

- Sem garantia de entrega

- Mensagem não é retransmitida

  

### QoS 1

- Garante que a mensagem foi entregue no mínimo uma vez ao recebedor

- Mensagem pode ser retransmitida se não houver confirmação de entrega

  

### QoS 2

- Garante que a mensagem foi entregue no mínimo uma vez ao recebedor
- Mensagem pode ser retransmitida se não houver confirmação de entrega



## Cloud 

- Grande e cada vez maior número de devices conectados
- TBs ou PBs de informações
- Potencial de escala global



## Estudo de caso

- Arquitetura é escolha
- Prova de conceito
- Mínimo Produto Viável
- Iot na prática 