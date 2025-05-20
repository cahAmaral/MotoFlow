# MotoFlow API - Controle de Pátio de Motos

### Sobre
API em C# (.NET 7) para controlar motos no pátio. Funciona com banco SQLite (dev) e Oracle (produção).

---

### Funcionalidades
- Cadastrar motos (placa, modelo, QR code, status)
- Listar motos
- Atualizar dados da moto
- Remover motos
- Controlar entrada e saída com timestamp

---

### Endpoints principais
| Método | URL               | O que faz                      |
|--------|-------------------|-------------------------------|
| GET    | /api/motos        | Lista todas as motos           |
| GET    | /api/motos/{id}   | Busca moto pelo ID             |
| POST   | /api/motos        | Cria nova moto                 |
| PUT    | /api/motos/{id}   | Atualiza moto                  |
| DELETE | /api/motos/{id}   | Deleta moto                   |

---

### Como usar

1. Clonar repo:  
   `git clone <url-do-repo>`
2. Entrar na pasta:  
   `cd ControlePatioAPI`
3. Restaurar pacotes:  
   `dotnet restore`
4. Criar banco (SQLite dev):  
   `dotnet ef database update`
5. Rodar projeto:  
   `dotnet run`
6. Abrir Swagger para testar:  
   `https://localhost:5001/swagger/index.html`

