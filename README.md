# SkillVault

Platforma do dodawania i weryfikacji umiejętności, doświadczeń i certyfikatów. Inne osoby mogą potwierdzać kompetencje użytkownika, a potwierdzenia trafiają na blockchain, dzięki czemu są niezmienne. Zbudowana jako **modularny monolit** w ASP.NET Core.

## Wymagania

- .NET 9 SDK
- Git

## Uruchomienie backendu

```bash
git clone https://github.com/viko4kka/SkillVault.git
cd SkillVault/api
dotnet restore SkillVault.sln
dotnet run --project src/SkillVault-Back/SkillVault-Back.csproj
```

Aplikacja wystartuje pod adresem podanym w konsoli (np. `https://localhost:7xxx`).
Dokumentacja API (Swagger) jest dostępna pod ścieżką `/swagger`.

## Uruchomienie testów

```bash
cd api
dotnet test SkillVault.sln
```
