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

1. Clonar repo
2. Entrar na pasta
3. Restaurar pacotes  
4. Criar banco (SQLite dev)
5. Rodar projeto 
  


