﻿using System.Collections.Generic;

namespace Mt.Utilities.IO
{
    /// <summary>
    /// Модель zip-файла 
    /// </summary>
    public sealed class ZipFileModel : FileModel
    {
        /// <summary>
        /// Инициализация экземпляра класса <see cref="ZipFileModel"/>.
        /// </summary>
        /// <param name="title">Наименование файла.</param>
        /// <param name="bytes">Данные файла в бинарном формате.</param>
        public ZipFileModel(string title, IEnumerable<byte> bytes) : base($"{title}.zip", bytes)
        {
        }
    }
}