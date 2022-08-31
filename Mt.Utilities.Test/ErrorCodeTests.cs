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
        /// ���������.
        /// </summary>
        [SetUp]
        public void Setup()
        {

        }

        /// <summary>
        /// ������������� ����� ��� ���������.
        /// </summary>
        /// <param name="code">��� ������.</param>
        /// <param name="title">���������.</param>
        [Test]
        [TestCase(ErrorCode.InternalServerError,    "MT-E0000")]
        [TestCase(ErrorCode.InvalidOperationError,  "MT-E0001")]
        [TestCase(ErrorCode.ValidationError,        "MT-E0002")]
        public void ErrorCodeTitlePositiveTest(ErrorCode code, string title)
        {
            var result = code.Title();
            Assert.That(result, Is.EqualTo(title));
        }

        /// <summary>
        /// ������������� ����� ��� ��������.
        /// </summary>
        /// <param name="code">��� ������.</param>
        /// <param name="desc">��������.</param>
        [Test]
        [TestCase(ErrorCode.InvalidOperationError, "������ ���������� ��������.")]
        [TestCase(ErrorCode.InternalServerError, "���������� ������ �������.")]
        [TestCase(ErrorCode.ValidationError, "������ ��������� ����������.")]
        public void ErrorCodeDescPositiveTest(ErrorCode code, string desc)
        {
            var result = code.Desc();
            Assert.That(result, Is.EqualTo(desc));
        }

        /// <summary>
        /// ������������� ����� ��� http-������ ����.
        /// </summary>
        /// <param name="code">��� ������.</param>
        /// <param name="httpStatus">Http-������ ���.</param>
        [Test]
        [TestCase(ErrorCode.InvalidOperationError, 400)]
        [TestCase(ErrorCode.InternalServerError, 500)]
        [TestCase(ErrorCode.ValidationError, 400)]
        public void ErrorCodeHttpStatusCodePositiveTest(ErrorCode code, int httpStatus)
        {
            var result = code.HttpStatusCode();
            Assert.That(result, Is.EqualTo(httpStatus));
        }
    }
}