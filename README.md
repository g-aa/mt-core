# <p><img src="iconMt.png" width="64px" height="64px" align="middle"/> Mt Utilities</p>

Универсальные утилиты используемые в проектах Mt-Relay.

## Перечень технологий

net8.0, SonarAnalyzer.CSharp, NUnit.

## [История изменения](CHANGELOG.md)

## Покрытие кода тестами

Перед первым запуском `.test.bat`, для просмотра покрытия кода тестами проверьте наличие `dotnet-reportgenerator-globaltool` выполнив команду:

`dotnet tool list --global`

в перечне пакетов должен присутствовать необходимый пакет:

```
Идентификатор пакета                   Версия      Команды
------------------------------------------------------------------
dotnet-reportgenerator-globaltool      5.1.19      reportgenerator
```

при его отсутствии необходимо выполнить команду:

`dotnet tool install -g dotnet-reportgenerator-globaltool`

## Основной функционал пакета

| Компонент                               | Описание                                                            |
|-----------------------------------------|---------------------------------------------------------------------|
| Mt.Utilities.Exceptions.ErrorCode       | Перечень кодов ошибок.                                              |
| Mt.Utilities.Exceptions.MtBaseException | Базовое исключение применяемое в логики разрабатываемых приложений. |
| Mt.Utilities.Exceptions.MtException     | Исключение логики приложений использующее коды ошибок.              |
| Mt.Utilities.Extensions.String.Ru2Eng   | Транслитерация: ISO 9:1995, ГОСТ 7.79-2000 (Система Б).             |
| Mt.Utilities.Check                      | Класс для упрощения проверки аргументов функций.                    |
| Mt.Utilities.DefaultString              | Значение строк по умолчанию.                                        |
| Mt.Utilities.StringFormat               | Форматы регулярных выражений основных сущностей.                    |

## Статус коды исключений

| Код ошибки | Описание                                              | Http-статус код |
|------------|-------------------------------------------------------|-----------------|
| MT-E0000   | Внутренняя ошибка сервера.                            | 500             |
| MT-E0001   | Внутренняя ошибка логики приложения.                  | 400             |
| MT-E0002   | Ошибка выполнения операции.                           | 400             |
| MT-E0003   | Несанкционированный доступ к ресурсу.                 | 401             |
| MT-E0010   | Ошибка валидации параметров сущности.                 | 400             |
| MT-E0011   | Сущность не найдена в последовательности.             | 400             |
| MT-E0012   | Сущность уже содержится в последовательности.         | 400             |
| MT-E0013   | Сущность не может быть удалена из последовательности. | 400             |
| MT-E0014   | Сущность не может быть модифицирована.                | 400             |