#language: pt-br

Funcionalidade: Validar login
                Como administrador do sistema
                Eu quero poder validar o login da aplicação
                Para que eu possa acessar o sistema
Esquema do Cenario: Validar login com sucesso
         Dado um usuario "<usuario>" com o perfil de administrado
         Quando  preenche o campo senha com a "<senha>"
         E aciona o envio
         Então o usuario recebe o statusCode "<statusCode>"
         
         Exemplos: 
         | usuario | senha | statusCode |
         | jose    | jose  |    200     |


