using Mt.Utilities.Exceptions;
using Mt.Utilities.Extensions;

namespace Mt.Utilities.Test;

/// <summary>
/// Набор тестов для <see cref="ErrorCodeExtensions"/>.
/// </summary>
[TestFixture]
public sealed class ErrorCodeTest
{
    /// <summary>
    /// Положительный тест для <see cref="ErrorCodeExtensions.Title(ErrorCode)"/>.
    /// </summary>
    /// <param name="code">Код ошибки.</param>
    /// <param name="expected">Ожидаемый результат.</param>
    [TestCase(ErrorCode.InternalServerError, "MT-E0000")]
    [TestCase(ErrorCode.InternalLogicError, "MT-E0001")]
    [TestCase(ErrorCode.InvalidOperation, "MT-E0002")]
    [TestCase(ErrorCode.Unauthorized, "MT-E0003")]
    [TestCase(ErrorCode.EntityValidation, "MT-E0010")]
    [TestCase(ErrorCode.EntityNotFound, "MT-E0011")]
    [TestCase(ErrorCode.EntityAlreadyExists, "MT-E0012")]
    [TestCase(ErrorCode.EntityCannotBeDeleted, "MT-E0013")]
    [TestCase(ErrorCode.EntityCannotBeModified, "MT-E0014")]
    public void TitlePositiveTest(ErrorCode code, string expected)
    {
        // act
        var result = code.Title();

        // assert
        result.Should().Be(expected);
    }

    /// <summary>
    /// Положительный тест для <see cref="ErrorCodeExtensions.Desc(ErrorCode)"/>.
    /// </summary>
    /// <param name="code">Код ошибки.</param>
    /// <param name="expected">Ожидаемый результат.</param>
    [TestCase(ErrorCode.InternalServerError, "Внутренняя ошибка сервера.")]
    [TestCase(ErrorCode.InternalLogicError, "Внутренняя ошибка логики приложения.")]
    [TestCase(ErrorCode.InvalidOperation, "Ошибка выполнения операции.")]
    [TestCase(ErrorCode.Unauthorized, "Несанкционированный доступ к ресурсу.")]
    [TestCase(ErrorCode.EntityValidation, "Ошибка валидации параметров сущности.")]
    [TestCase(ErrorCode.EntityNotFound, "Сущность не найдена в последовательности.")]
    [TestCase(ErrorCode.EntityAlreadyExists, "Сущность уже содержится в последовательности.")]
    [TestCase(ErrorCode.EntityCannotBeDeleted, "Сущность не может быть удалена из последовательности.")]
    [TestCase(ErrorCode.EntityCannotBeModified, "Сущность не может быть модифицирована.")]
    public void DescPositiveTest(ErrorCode code, string expected)
    {
        // act
        var result = code.Desc();

        // assert
        result.Should().Be(expected);
    }

    /// <summary>
    /// Положительный тест для <see cref="ErrorCodeExtensions.HttpStatusCode(ErrorCode)"/>.
    /// </summary>
    /// <param name="code">Код ошибки.</param>
    /// <param name="expected">Ожидаемый результат.</param>
    [TestCase(ErrorCode.InternalServerError, 500)]
    [TestCase(ErrorCode.InternalLogicError, 400)]
    [TestCase(ErrorCode.InvalidOperation, 400)]
    [TestCase(ErrorCode.Unauthorized, 401)]
    [TestCase(ErrorCode.EntityValidation, 400)]
    [TestCase(ErrorCode.EntityNotFound, 400)]
    [TestCase(ErrorCode.EntityAlreadyExists, 400)]
    [TestCase(ErrorCode.EntityCannotBeDeleted, 400)]
    [TestCase(ErrorCode.EntityCannotBeModified, 400)]
    public void HttpStatusCodePositiveTest(ErrorCode code, int expected)
    {
        // act
        var result = code.HttpStatusCode();

        // assert
        result.Should().Be(expected);
    }
}