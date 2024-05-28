# Como rodar a aplicação com o banco na Azure

Para rodar a aplicação utilizando o banco na Azure basta registrar a connection string no dotnet secrets:

```
cd pmv-sint-2024-1-e3-proj-back-t1-time-2/src/ShapeApp/ShapeApp

dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server={address},1433;Initial Catalog=shapeapp;Persist Security Info=False;User ID=adm;Password={password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
```
