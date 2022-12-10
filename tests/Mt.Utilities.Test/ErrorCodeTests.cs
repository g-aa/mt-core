using Mt.Utilities.Exceptions;
using Mt.Utilities.Extensions;
using NUnit.Framework;

namespace Mt.Utilities.Test
{
    /// <summary>
    /// ����� ������ ��� ����� ������.
    /// </summary>
    [TestFixture]
    public sealed class ErrorCodeTests
    {
        /// <summary>
        /// ������������� ����� ��� ���������.
        /// </summary>
        /// <param name="code">��� ������.</param>
        /// <param name="expected">��������� ���������.</param>
        [Test]
        [TestCase(ErrorCode.InternalServerError,    "MT-E0000")]
        [TestCase(ErrorCode.InternalLogicError,     "MT-E0001")]
        [TestCase(ErrorCode.InvalidOperation,       "MT-E0002")]
        [TestCase(ErrorCode.Unauthorized,           "MT-E0003")]
        [TestCase(ErrorCode.EntityValidation,       "MT-E0010")]
        [TestCase(ErrorCode.EntityNotFound,         "MT-E0011")]
        [TestCase(ErrorCode.EntityAlreadyExists,    "MT-E0012")]
        [TestCase(ErrorCode.EntityCannotBeDeleted,  "MT-E0013")]
        [TestCase(ErrorCode.EntityCannotBeModified, "MT-E0014")]
        public void TitlePositiveTest(ErrorCode code, string expected)
        {
            var result = code.Title();
            Assert.That(result, Is.EqualTo(expected));
        }

        /// <summary>
        /// ������������� ����� ��� ��������.
        /// </summary>
        /// <param name="code">��� ������.</param>
        /// <param name="expected">��������� ���������.</param>
        [Test]
        [TestCase(ErrorCode.InternalServerError,    "���������� ������ �������.")]
        [TestCase(ErrorCode.InternalLogicError,     "���������� ������ ������ ����������.")]
        [TestCase(ErrorCode.InvalidOperation,       "������ ���������� ��������.")]
        [TestCase(ErrorCode.Unauthorized,           "������������������� ������ � �������.")]
        [TestCase(ErrorCode.EntityValidation,       "������ ��������� ���������� ��������.")]
        [TestCase(ErrorCode.EntityNotFound,         "�������� �� ������� � ������������������.")]
        [TestCase(ErrorCode.EntityAlreadyExists,    "�������� ��� ���������� � ������������������.")]
        [TestCase(ErrorCode.EntityCannotBeDeleted,  "�������� �� ����� ���� ������� �� ������������������.")]
        [TestCase(ErrorCode.EntityCannotBeModified, "�������� �� ����� ���� ��������������.")]
        public void DescPositiveTest(ErrorCode code, string expected)
        {
            var result = code.Desc();
            Assert.That(result, Is.EqualTo(expected));
        }

        /// <summary>
        /// ������������� ����� ��� http-������ ����.
        /// </summary>
        /// <param name="code">��� ������.</param>
        /// <param name="expected">��������� ���������.</param>
        [Test]
        [TestCase(ErrorCode.InternalServerError,    500)]
        [TestCase(ErrorCode.InternalLogicError,     400)]
        [TestCase(ErrorCode.InvalidOperation,       400)]
        [TestCase(ErrorCode.Unauthorized,           401)]
        [TestCase(ErrorCode.EntityValidation,       400)]
        [TestCase(ErrorCode.EntityNotFound,         400)]
        [TestCase(ErrorCode.EntityAlreadyExists,    400)]
        [TestCase(ErrorCode.EntityCannotBeDeleted,  400)]
        [TestCase(ErrorCode.EntityCannotBeModified, 400)]
        public void HttpStatusCodePositiveTest(ErrorCode code, int expected)
        {
            var result = code.HttpStatusCode();
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}