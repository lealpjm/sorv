### Premissas / Fluxo operacional

Considerando que o usuário deverá realizar a retirada numa filial, espera-se que ele conheça a filial no início da operação (através de autenticação ou algum outro método de escolha da Filial ainda a ser definido).

No início da jornada deve-se realizar uma consulta para obter todos os produtos, atualizando sua lista interna com os respectivos estoques da produção.

Ainda na unidade o funcionário deve-se realizar uma operação para informar as quantidades sendo retiradas para rua, afim de atualizar o estoque com itens reservados por funcionário.

Durante o expediente, o funcionário realiza as operações diretamente na solução mobile.

No fim do expediente ele descarrega os dados num endpoint e pode acompanhar a entrega dos produtos

Para o download da solução favor configurar o **SQL Server** no ambiente local ou alterar o appsettings.json


### Trabalhos Futuros

- Definição do processo de autenticação
- Melhoria Testes
- Implantação de algum serviço de mensagens para testes da solução



