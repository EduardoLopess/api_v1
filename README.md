stateDiagram-v2
    [*] --> PedidoCriado
    PedidoCriado --> PagamentoAprovado: Validar Cartão
    PedidoCriado --> Cancelado: Timeout
    PagamentoAprovado --> Enviado
    Enviado --> [*]
